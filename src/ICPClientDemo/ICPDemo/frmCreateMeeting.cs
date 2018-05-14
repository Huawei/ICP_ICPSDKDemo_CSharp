using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Com.Huawei.Device.ServiceModel;

namespace ICPDemo
{
    public partial class frmCreateMeeting : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public List<DialContent> DialContentList { get; private set; }

        public string accessCode { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public frmCreateMeeting(bool islEx = false)
        {
            InitializeComponent();
            if (islEx)
            {
                labAccessCode.Visible = true;
                txtAccessCode.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                accessCode = this.txtAccessCode.Text.Trim();
                if (this.lvwMembers.Items.Count == 0)
                {
                    MsgBox.Info("Please add member first.");
                    return;
                }

                List<DialContent> list = new List<DialContent>();

                foreach (ListViewItem item in this.lvwMembers.Items)
                {
                    list.Add(item.Tag as DialContent);
                }

                this.DialContentList = list;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItems = this.lvwMembers.SelectedItems;

                if (selectedItems != null && selectedItems.Count > 0)
                {
                    foreach (ListViewItem item in selectedItems)
                    {
                        this.lvwMembers.Items.Remove(item);
                    }
                }
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        private bool IsNumberExist(string number)
        {
            foreach (ListViewItem item in this.lvwMembers.Items)
            {
                var dialContent = item.Tag as DialContent;

                if (dialContent != null)
                {
                    if (dialContent.PhoneNumber == number)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new frmDial();
                dialog.Text = btnAdd.Text;
                if (dialog.ShowDialog(true) == System.Windows.Forms.DialogResult.OK)
                {
                    var dialContent = dialog.DialContent;

                    if (this.IsNumberExist(dialContent.PhoneNumber))
                    {
                        MsgBox.Info(ConfigHelper.GetString("AlreadyExist"), dialContent.PhoneNumber);
                        return;
                    }

                    ListViewItem item = new ListViewItem();
                    item.Text = dialContent.PhoneNumber;
                    item.SubItems.Add(dialContent.PhoneType.ToString());
                    item.SubItems.Add(dialContent.CallType.ToString());
                    item.Tag = dialContent;

                    this.lvwMembers.Items.Add(item);
                }
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        private void frmCreateMeeting_Load(object sender, EventArgs e)
        {
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.btnAdd.Text = ConfigHelper.GetString("Add");
            this.btnRemove.Text = ConfigHelper.GetString("Remove");
            string[] number= ConfigHelper.GetString("PhoneNumber").Split(':');
            if (number != null && number.Length > 0)
            {
                this.colPhoneNumber.Text = number[0];
            }
            number = ConfigHelper.GetString("PhoneType").Split(':');
            if (number != null && number.Length > 0)
            {
                this.colPhoneType.Text = number[0];
            }
            number = ConfigHelper.GetString("CallType").Split(':');
            if (number != null && number.Length > 0)
            {
                this.colCallType.Text = number[0];
            }
            this.labAccessCode.Text = ConfigHelper.GetString("AccessCode");

        }
    }
}
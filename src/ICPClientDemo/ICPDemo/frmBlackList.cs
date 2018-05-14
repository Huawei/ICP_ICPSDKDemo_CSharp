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
    public partial class frmBlackList : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ShowLockTime { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int LockTime { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ShowFilterMode { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public FilterMode FilterMode { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public frmBlackList(bool showLockTime = true,bool showFilterMode = false)
        {
            InitializeComponent(showFilterMode);

            this.ShowLockTime = showLockTime;
            this.lblLockTime.Visible = showLockTime;
            this.textLockTime.Visible = showLockTime;

            this.ShowFilterMode = showFilterMode;
            this.rBtn_LowPriority.Visible = showFilterMode;
            this.rBtn_Reject.Visible = showFilterMode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                var str = this.textPhoneNumber.Text.Trim();

                if (string.IsNullOrEmpty(str))
                {
                    MsgBox.Info("Please input phone number.");
                    this.textPhoneNumber.Focus();

                    return;
                }

                this.PhoneNumber = str;

                if (this.ShowLockTime)
                {
                    int lockTime = 0;

                    str = this.textLockTime.Text.Trim();

                    if (string.IsNullOrEmpty(str))
                    {
                        MsgBox.Info("Please input lock time.");
                        this.textLockTime.Focus();

                        return;
                    }
                    else if (!int.TryParse(str, out lockTime))
                    {
                        MsgBox.Info("Please input a valid number.");
                        this.textLockTime.Focus();

                        return;
                    }
                    else if (lockTime < 0)
                    {
                        MsgBox.Info("Lock time should be greator than 0.");
                        this.textLockTime.Focus();

                        return;
                    }

                    this.LockTime = lockTime;
                }

                if (this.ShowFilterMode)
                {
                    if (this.rBtn_Reject.Checked)
                    {
                        this.FilterMode = FilterMode.Reject;
                    }
                    else if (this.rBtn_LowPriority.Checked)
                    {
                        this.FilterMode = FilterMode.LowPriority;
                    }
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        private void frmBlackList_Load(object sender, EventArgs e)
        {
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblPhoneNumber.Text = ConfigHelper.GetString("PhoneNumber");
            this.lblLockTime.Text = ConfigHelper.GetString("LockTime");
            this.rBtn_LowPriority.Text = ConfigHelper.GetString("LowPriority"); ;
            this.rBtn_Reject.Text = ConfigHelper.GetString("Reject"); ;
        }
    }
}

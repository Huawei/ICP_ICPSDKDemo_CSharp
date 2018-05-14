using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICPDemo
{
    public partial class CommonForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public string MettingId { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string OldMasterNumber { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string NewMasterNumber { get; private set; }
        private bool _showOther;
        private string _meetingID;
        public CommonForm(string meetingID , bool showOther = true)
        {
            InitializeComponent();
            txtNewNumber.Visible = showOther;
            txtOldNumber.Visible = showOther;
            lblOlderNumber.Visible = showOther;
            lblNewNumber.Visible = showOther;
            _showOther = showOther;
            _meetingID = meetingID;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                var str = this.textMettingId.Text.Trim();
                if (string.IsNullOrEmpty(str))
                {
                    MsgBox.Info("Please input metting id.");
                    this.textMettingId.Focus();

                    return;
                }
                MettingId = str;
                if (this._showOther)
                {
                    str = this.txtOldNumber.Text.Trim();
                    OldMasterNumber = str;

                    str = this.txtNewNumber.Text.Trim();
                    if (string.IsNullOrEmpty(str))
                    {
                        MsgBox.Info("Please input new master number.");
                        this.txtNewNumber.Focus();
                        return;
                    }
                    NewMasterNumber = str;
                }

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch 
            {
                MsgBox.Error("occur exception");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void CommonForm_Load(object sender, EventArgs e)
        {
            this.lblMetting.Text = ConfigHelper.GetString("MeetingId");
            this.lblOlderNumber.Text = ConfigHelper.GetString("OldMasterNumber");
            this.lblNewNumber.Text = ConfigHelper.GetString("NewMasterNumber");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.textMettingId.Text = _meetingID;
        }
    }
}

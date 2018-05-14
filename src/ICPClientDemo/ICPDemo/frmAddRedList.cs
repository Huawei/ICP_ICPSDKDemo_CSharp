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
    public partial class frmAddRedList : Form
    {
        public string PhoneNumber { get; set; }
        public string Priority { get; set; }
        public frmAddRedList()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string phoneNumber = this.txtPhonePrefix.Text;
            string priority = this.txtPriority.Text;
            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(priority))
            {
                 MsgBox.Info("Please input value.");
                 return;
            }
            int int_priority=0;
            if(!int.TryParse(priority,out int_priority))
            {
                MsgBox.Info("Please input value.");
                return;
            }
            PhoneNumber = phoneNumber;
            Priority = priority;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void frmAddRedList_Load(object sender, EventArgs e)
        {
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.label16.Text = ConfigHelper.GetString("PhoneNumber");
            this.label22.Text = ConfigHelper.GetString("Priority");
        }
    }
}

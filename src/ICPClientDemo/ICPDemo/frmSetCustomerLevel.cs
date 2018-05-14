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
    public partial class frmSetCustomerLevel : Form
    {
        public string PhoneNumber { get; set; }
        public int CustomerLevel { get; set; }
        public frmSetCustomerLevel()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PhoneNumber = this.textPhoneNumber.Text.Trim();
            string text = this.textCustomerLevel.Text.Trim();
            int level = -1;
            if (!int.TryParse(text, out level))
            {
                MsgBox.Error("input error");
                return;
            }
            CustomerLevel = level;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmSetCustomerLevel_Load(object sender, EventArgs e)
        {
            this.Text = ConfigHelper.GetString("SetCustomerLevel");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblPhoneNumber.Text = ConfigHelper.GetString("PhoneNumber");
            this.lblCustomerLevel.Text = ConfigHelper.GetString("CustomerLevel");
        }
    }
}

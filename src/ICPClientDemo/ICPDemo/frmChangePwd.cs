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
    public partial class frmChangePwd : Form
    {
        public string OldPw5 { get; set; }
        public string NewPw5 { get; set; }
        public frmChangePwd()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OldPw5 = this.txtOldPw5.Text.Trim();
            NewPw5 = this.txtNewPw5.Text.Trim();
            var againPut = txtAgainPut.Text.Trim();
            if (!NewPw5.Equals(againPut))
            {
                MessageBox.Show("The password must be the same.");
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmChangePwd_Load(object sender, EventArgs e)
        {
            this.Text = ConfigHelper.GetString("ChangeAgentPwd");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblOld.Text = ConfigHelper.GetString("OldPwd");
            this.lblNew.Text = ConfigHelper.GetString("NewPwd");
            this.lblPutAgain.Text = ConfigHelper.GetString("PutAgain");
        }
    }
}

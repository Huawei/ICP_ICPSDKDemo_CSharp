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
    public partial class frmTransToIVR : Form
    {
        //技能组ID
        public string AccessCode{ get; set; }

        //转移模式
        public bool IsSuccTransfer { get; set; }

        public frmTransToIVR()
        {
            InitializeComponent();
        }

        //确定按钮
        private void btnOk_Click(object sender, EventArgs e)
        {
            string skill = this.txtSkillID.Text.Trim();
            if (string.IsNullOrEmpty(skill))
            {
                MsgBox.Info("Please input AccessCode .");
                return;
            }
            AccessCode = skill;
            if (rbSuccTransfer.Checked)
            {
                IsSuccTransfer = true;
            }
            else
            {
                IsSuccTransfer = false;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmTransferToSkillGroup_Load(object sender, EventArgs e)
        {
            this.Text = ConfigHelper.GetString("TransToIVR");
            this.btnOk.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblSkillID.Text = ConfigHelper.GetString("AccessCode");
            this.rbSuccTransfer.Text = ConfigHelper.GetString("SuccTransfer");
            this.rbReleaseTransfer.Text = ConfigHelper.GetString("ReleaseTransfer");
        }
    }
}

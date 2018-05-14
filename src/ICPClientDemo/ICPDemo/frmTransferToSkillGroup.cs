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
    public partial class frmTransferToSkillGroup : Form
    {
        //技能组ID
        public string SkillID { get; set; }

        //转移模式
        public bool IsSuccTransfer { get; set; }

        public frmTransferToSkillGroup()
        {
            InitializeComponent();
        }

        //确定按钮
        private void btnOk_Click(object sender, EventArgs e)
        {
            string skill = this.txtSkillID.Text.Trim();
            if (string.IsNullOrEmpty(skill))
            {
                MsgBox.Info("Please input skill id.");
                return;
            }
            SkillID = skill;
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
            this.btnOk.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblSkillID.Text = ConfigHelper.GetString("GroupId");
            this.rbSuccTransfer.Text = ConfigHelper.GetString("SingleStepSuccTransfer");
            this.rbReleaseTransfer.Text = ConfigHelper.GetString("SingleStepTransfer");
        }
    }
}

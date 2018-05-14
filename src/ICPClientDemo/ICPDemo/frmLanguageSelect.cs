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
    public partial class frmLanguageSelect : Form
    {
        public bool _selectCN;
        public frmLanguageSelect()
        {
            InitializeComponent();
        }
       
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        //中文
        private void rbChinese_CheckedChanged(object sender, EventArgs e)
        {
            _selectCN = true;
            ConfigHelper.SetCurrentCulture("zh-CN");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblTip.Text = ConfigHelper.GetString("Tip");
            this.rbChinese.Text = ConfigHelper.GetString("Chinese");
        }

        //英文
        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            _selectCN = false;
            ConfigHelper.SetCurrentCulture("en-US");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblTip.Text = ConfigHelper.GetString("Tip");
            this.rbChinese.Text = ConfigHelper.GetString("Chinese");
        }

        private void frmLanguageSelect_Load(object sender, EventArgs e)
        {
            //this.rbEnglish.Checked = true;
        }

        private void lblTip_Click(object sender, EventArgs e)
        {

        }

        public DialogResult ShowDialog(bool selectCN)
        {
            _selectCN = selectCN;
            if (selectCN)
            {
                this.rbChinese.Checked = true;
            }
            else
            {
                this.rbEnglish.Checked = true;
            }
            return this.ShowDialog();
        }
    }
}

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
    public partial class frmTalkingGroupState : Form
    {
        public frmTalkingGroupState()
        {
            InitializeComponent();
        }

        public string TalkingGroupID
        { 
            get
            {
                return this.textBox_TalkingGroupID.Text.Trim();
            }

            set
            {
                this.textBox_TalkingGroupID.Text = value;
            }
        }

        public int Expire
        {
            get
            {
                Int32 tmp = 0;
                if (int.TryParse(this.textBox_Expire.Text, out tmp))
                {
                    return tmp;
                }
                return 0;
            }
        }

        public bool IsAutoSubscribe
        {
            get
            {
                if (this.radioButton_True.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void frmTalkingGroupState_Load(object sender, EventArgs e)
        {
            this.label_TalkingGroupID.Text = ConfigHelper.GetString("TalkingGroupID");
            this.label_Expire.Text = ConfigHelper.GetString("Expire");
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
            this.label_IsAutoAubscribe.Text = ConfigHelper.GetString("AutoSubscribe");
            this.radioButton_True.Text = ConfigHelper.GetString("True");
            this.radioButton_False.Text = ConfigHelper.GetString("False");
            this.radioButton_defualt.Text = ConfigHelper.GetString("Default");
        }


        public void HideExpire()
        {
            this.label_Expire.Visible = false;
            this.textBox_Expire.Visible = false;
        }

        public void ShowAutoSubscribe()
        {
            this.label_IsAutoAubscribe.Visible = true;
            this.radioButton_False.Visible = true;
            this.radioButton_True.Visible = true;
            this.radioButton_defualt.Visible = true;
            this.radioButton_defualt.Checked = true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

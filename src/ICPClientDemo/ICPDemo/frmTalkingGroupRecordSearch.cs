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
    public partial class frmTalkingGroupRecordSearch : Form
    {
        public frmTalkingGroupRecordSearch()
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

        public string startTime { 
            get
            {
                return this.textBox_StartTime.Text.Trim();
            }

            set
            {
                this.textBox_StartTime.Text = value;
            }
        }
        public string endTime
        {
            get
            {
                return this.textBox_EndTime.Text.Trim();
            }

            set
            {
                this.textBox_EndTime.Text = value;
            }
        }

        public string pageIndex
        {
            get
            {
                return this.textBox_PageIndex.Text.Trim();
            }

            set
            {
                this.textBox_PageIndex.Text = value;
            }
        }

        public string pageSize
        {
            get
            {
                return this.textBox_PageSize.Text.Trim();
            }

            set
            {
                this.textBox_PageSize.Text = value;
            }
        }

        public bool isConfRecord
        {
            get
            {
                if (this.radioBtn_IsConfRecord_True.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool onlyLocalRecord
        {
            get
            {
                if (this.radioBtn_OnlyLocalRecord_True.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void frmTalkingGroupRecordSearch_Load(object sender, EventArgs e)
        {
            this.label_TalkingGroupID.Text = ConfigHelper.GetString("ConfScheduler");
            this.label_radio_IsConfRecord.Text = ConfigHelper.GetString("IsConfRecord");
            this.label_radio_OnlyLocalRecord.Text = ConfigHelper.GetString("OnlyLocalRecord");
            this.label_textBox_EndTime.Text = ConfigHelper.GetString("EndTime");
            this.label_textBox_PageIndex.Text = ConfigHelper.GetString("PageIndex");
            this.label_textBox_PageSize.Text = ConfigHelper.GetString("PageSize");
            this.label_textBox_StartTime.Text = ConfigHelper.GetString("BeginTime");
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioBtn_OnlyLocalRecord_True_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtn_OnlyLocalRecord_False_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtn_IsConfRecord_False_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

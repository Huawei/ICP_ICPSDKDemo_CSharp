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
    public partial class frmQueryTalkingGroupInfo : Form
    {
        public frmQueryTalkingGroupInfo()
        {
            InitializeComponent();
        }

        public string TalkingGroupID
        {
            get
            {
                return this.textBox_TalkingGroupID.Text;
            }

            set
            {
                this.textBox_TalkingGroupID.Text = value;
            }
        }

        public Int32 QueryType
        { 
            get
            {
                Int32 temp = 0;
                if (Int32.TryParse(this.textBox_QueryType.Text, out temp))
                {
                    return temp;
                }

                return 0;
            }
                
        }

        public string PageNumber
        {
            get
            {
                return this.textBox_PageNumber.Text;
            }

            set
            {
                this.textBox_PageNumber.Text = value;
            }
        }

        public Int32 CountPerPage
        {
            get
            { 
                Int32 temp = 0;
                if (Int32.TryParse(this.textBox_CountPerPage.Text, out temp))
                {
                    return temp;
                }

                return 0;
            }
        }

        public void attachMouseClickEvent()
        {
            this.textBox_QueryType.TextChanged += updateLabel;
        }

        public void detachMouseClickEvent()
        {
            this.textBox_QueryType.TextChanged -= updateLabel;
        }

        private void updateLabel(object sender, EventArgs e)
        {
            if (this.QueryType == 1)
            {
                this.label_PageNumber.Text = ConfigHelper.GetString("PageNumber");
            }
            else if (this.QueryType == 2)
            {
                this.label_PageNumber.Text = ConfigHelper.GetString("TalkingGroupID");
            }
        }

        //add bagin by cwx423266
        public void _attachMouseClickEvent()
        {
            this.textBox_QueryType.TextChanged += queryGroupupdateLabel;
        }

        public void _detachMouseClickEvent()
        {
            this.textBox_QueryType.TextChanged -= queryGroupupdateLabel;
        }

        private void queryGroupupdateLabel(object sender, EventArgs e)
        {
            if (this.QueryType == 1 || this.QueryType == 3)
            {
                this.label_PageNumber.Visible = true;
                this.textBox_PageNumber.Visible = true;
                this.label_TalkingGroupID.Visible = false;
                this.textBox_TalkingGroupID.Visible = false;
            }
            else if (this.QueryType == 2)
            {
                this.label_PageNumber.Visible = false;
                this.textBox_PageNumber.Visible = false;
                this.label_TalkingGroupID.Visible = true;
                this.textBox_TalkingGroupID.Visible = true;
            }
        }
       //add end by cwx423266

        public void hideGroupID()
        {
            this.label_TalkingGroupID.Visible = false;
            this.textBox_TalkingGroupID.Visible = false;
        }

        private void frmQueryTalkingGroupInfo_Load(object sender, EventArgs e)
        {
            this.label_CountPerPage.Text = ConfigHelper.GetString("CountPerPage");
            this.label_PageNumber.Text = ConfigHelper.GetString("PageNumber");
            this.label_QueryType.Text = ConfigHelper.GetString("QueryType");
            this.label_TalkingGroupID.Text = ConfigHelper.GetString("TalkingGroupID");
            this.button_OK.Text = ConfigHelper.GetString("Ok");
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

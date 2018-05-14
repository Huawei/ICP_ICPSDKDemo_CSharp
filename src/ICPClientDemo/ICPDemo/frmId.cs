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
    public partial class frmId : Form
    {
        public string Id { get; private set; }
        public frmId()
        {
            InitializeComponent();
        }

        public string RecordID
        {
            get
            {
                return this.textId.Text.Trim();
            }

            set
            {
                this.textId.Text = value;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string id = this.textId.Text.Trim();    
            this.Id = id;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmId_Load(object sender, EventArgs e)
        {
            string title = this.Text;
            if (title.Equals(Helper.OperationToken.QueryAgentStatus.ToString()))
            {
                this.lblId.Text = ConfigHelper.GetString("AgentId");
                this.Text = ConfigHelper.GetString("QueryAgentStatus");
            }
            else if (title.Equals(Helper.OperationToken.ForceLogout.ToString()))
            {
                this.lblId.Text = ConfigHelper.GetString("AgentId");
                this.Text = ConfigHelper.GetString("ForceLogout");
            }
            else if (title.Equals(Helper.OperationToken.QueryCallList.ToString()))
            {
                this.lblId.Text = ConfigHelper.GetString("GroupId");
                this.Text = ConfigHelper.GetString("QueryCallListByGroupId");
            }
            else if (title.Equals(Helper.OperationToken.SelectPickup.ToString()))
            {
                this.lblId.Text = ConfigHelper.GetString("CallId");
                this.Text = ConfigHelper.GetString("SelectPickup");
            }
            else if (title.Equals(Helper.OperationToken.SetCallData.ToString()))
            {
                this.lblId.Text = ConfigHelper.GetString("CallData");
                this.Text = ConfigHelper.GetString("SetCallData");
            }
            else if (title.Equals(ConfigHelper.GetString("QueryAgentIP")))
            {
                this.lblId.Text = ConfigHelper.GetString("AgentId");
            }
            else if (title.Equals(ConfigHelper.GetString("AgentSendDTMF")))
            {
                this.lblId.Text = ConfigHelper.GetString("PhoneNumber");
            }
            else if (title.Equals(Helper.OperationToken.QueryMaliciousCalls.ToString()))
            {
                this.lblId.Text = ConfigHelper.GetString("PhoneNumber");
                this.Text = ConfigHelper.GetString("QueryMaliciousCalls");
            }
            else if (title.Equals(Helper.OperationToken.QuerySkillGroupStatus.ToString()))
            {
                //查询技能队列状态
                this.lblId.Text = ConfigHelper.GetString("GroupId");
                this.Text = ConfigHelper.GetString("QuerySkillGroupStatus");
            }
            else if (title.Equals(Helper.OperationToken.QueryAgentSkillGroups.ToString()))
            {
                //查询座席配置的技能信息
                this.lblId.Text = ConfigHelper.GetString("AgentId");
                this.Text = ConfigHelper.GetString("QueryAgentSkillGroups");
            }
            else if (title.Equals(Helper.OperationToken.QueryCallIdOnAgent.ToString()))
            {
                //查询座席的CallId
                this.lblId.Text = ConfigHelper.GetString("AgentId");
                this.Text = ConfigHelper.GetString("QueryCallIdOnAgent");
            }
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Com.Huawei.Device.ServiceModel;

namespace ICPDemo
{
    public partial class frmAgentId : Form
    {
        string title = "";
        /// <summary>
        /// 
        /// </summary>
        public AgentInfo AgentInfo { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public frmAgentId(string title = "SingleStepSuccTransfer")
        {
            InitializeComponent();
            this.title = title;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string agentId = this.textAgentId.Text.Trim();
                if (string.IsNullOrEmpty(agentId) && null == this.Tag)
                {
                    MsgBox.Info("Please input agent id.");
                    this.textAgentId.Focus();

                    return;
                }
                string phoneNumber = this.textPhoneNumber.Text.Trim();

                this.AgentInfo = new AgentInfo() { AgentId = agentId, PhoneNumber = phoneNumber };
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch
            {
                MsgBox.Error("input error");
            }
        }

        private void frmAgentId_Load(object sender, EventArgs e)
        {
            if (this.title != "TransferSMSToAgent")
            {
                string title = ConfigHelper.GetString("SingleStepSuccTransfer");
                if (this.Text.Equals(title))
                {
                    this.lblNumber.Text = ConfigHelper.GetString("TargetNumber");
                }
                else
                {
                    this.lblNumber.Text = ConfigHelper.GetString("PhoneNumber");
                }
            }
            else
            {
                string title = ConfigHelper.GetString("TransferSMSToAgent");
                this.lblNumber.Text ="CCBIdx";
            }
            lblAgentID.Text = ConfigHelper.GetString("AgentId");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
        }
    }
}

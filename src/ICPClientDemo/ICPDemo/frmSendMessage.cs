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
    public partial class frmSendMessage : Form
    {
        //窗口标题
        string title = "";

        //发送目标座席工号
        public string agentId { get; private set; }

        //发送便签内容
        public string message { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public frmSendMessage(string title = "SendMessage")
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
        /// 确定事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //获取目标座席工号
                string agentId = this.textAgentId.Text.Trim();

                if (string.IsNullOrEmpty(agentId) && null == this.Tag)
                {
                    MsgBox.Info("Please input agent id.");
                    this.textAgentId.Focus();

                    return;
                }

                //获取便签内容
                string message = this.textMessage.Text.Trim();

                if (string.IsNullOrEmpty(message))
                {
                    MsgBox.Info("Please input message.");
                    this.textMessage.Focus();
                    return;
                }

                this.agentId = agentId;
                this.message = message;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch
            {
                MsgBox.Error("input error");
            }
        }

        /// <summary>
        /// 窗体加载处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSendMessage_Load(object sender, EventArgs e)
        {
            string title = ConfigHelper.GetString("SendMessage");
            this.lblMessage.Text = ConfigHelper.GetString("AgentMessage");
            this.lblAgentID.Text = ConfigHelper.GetString("AgentId");

            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
        }

        
    }
}

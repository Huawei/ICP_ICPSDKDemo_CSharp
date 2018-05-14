using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.Huawei.Device.ServiceModel;

namespace ICPDemo
{
    public partial class frmSubscribeEvent : Form
    {
         //窗口标题
        string title = "";

        //目标座席工号
        public string agentId { get; private set; }

        //订阅事件类型
        public string eventType { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public frmSubscribeEvent(string title = "SubscribeEvent")
        {
            InitializeComponent();
            this.title = title;
        }

        public frmSubscribeEvent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

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
                string eventType = this.comboBoxEventType.Text.Trim();

                if (string.IsNullOrEmpty(eventType))
                {
                    MsgBox.Info("Please input Event Type.");
                    this.comboBoxEventType.Focus();
                    return;
                }

                this.agentId = agentId;
                this.eventType = eventType;

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
        private void frmSubscribeEvent_Load(object sender, EventArgs e)
        {
            string title = this.Text;
            if (title.Equals("SubscribeAgentEvent"))
            {
                this.Text = ConfigHelper.GetString("SubscribeAgentEvent");
            }
            else if (title.Equals("StopSubscribeAgentEvent"))
            {
                this.Text = ConfigHelper.GetString("StopSubscribeAgentEvent");
            }

            this.lblAgentId.Text = ConfigHelper.GetString("AgentId");
            this.lblEventType.Text = ConfigHelper.GetString("EventType");

            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");

            comboBoxEventType.Items.Clear();
            foreach (int  myEventType in Enum.GetValues(typeof(EventTypeEnum)))
            {
                string eventTypeName = Enum.GetName(typeof(EventTypeEnum), myEventType);//获取名称
                comboBoxEventType.Items.Add(eventTypeName);
                comboBoxEventType.ValueMember = eventTypeName;
            }
        }
    }
}

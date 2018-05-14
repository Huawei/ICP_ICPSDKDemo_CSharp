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
    public partial class frmEmailConfig : Form
    {
        public string ReceiveServerIP { get; set; }
        public string SendServerIP { get; set; }
        public string AgentReceiveAddress { get; set; }
        public string AgentSendAddress { get; set; }
        public string AgentReceiveUserName { get; set; }
        public string AgentReceivePW5 { get; set; }
        public string PublicMailAddress { get; set; }
        public string UserReceiverAddress { get; set; }

        string _receiveServerIP;
        string _sendServerIP;
        string _agentReceiveAddress;
        string _agentSendAddress;
        string _agentReceiveUserName;
        string _agentReceivePassWord;
        string _publicMailAddress;
        string _userReceiverAddress;

        public frmEmailConfig(string receiveServerIP, string sendServerIP, string agentReceiveAddress
                            , string agentSendAddress, string agentReceiveUserName, string agentReceivePassWord
                            , string publicMailAddress, string userReceiverAddress)
        {
            InitializeComponent();
            _receiveServerIP = receiveServerIP;
            _sendServerIP = sendServerIP;
            _agentReceiveAddress = agentReceiveAddress;
            _agentSendAddress = agentSendAddress;
            _agentReceiveUserName = agentReceiveUserName;
            _agentReceivePassWord = agentReceivePassWord;
            _publicMailAddress = publicMailAddress;
            _userReceiverAddress = userReceiverAddress;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ReceiveServerIP = this.txtReceiveServer.Text.Trim();
            SendServerIP = this.txtSendServer.Text.Trim();
            AgentReceiveAddress = this.txtPrivateReceiveAddress.Text.Trim();
            AgentSendAddress = this.txtPrivateSendAddress.Text.Trim();
            AgentReceiveUserName = this.txtUserName.Text.Trim();
            AgentReceivePW5 = this.txtPW5.Text.Trim();
            PublicMailAddress = this.txtPublicMailAddress.Text.Trim();
            UserReceiverAddress = this.txtReceiverAddress.Text.Trim();
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void frmEmailConfig_Load(object sender, EventArgs e)
        {
             this.txtReceiveServer.Text=_receiveServerIP;
            this.txtSendServer.Text=_sendServerIP;
            this.txtPrivateReceiveAddress.Text=_agentReceiveAddress;
            this.txtPrivateSendAddress.Text=_agentSendAddress;
            this.txtUserName.Text=_agentReceiveUserName;
            this.txtPW5.Text=_agentReceivePassWord;
            this.txtPublicMailAddress.Text=_publicMailAddress;
            this.txtReceiverAddress.Text = _userReceiverAddress;


            this.lblReceive.Text = ConfigHelper.GetString("ReceiveServerIP");
            this.lblSendServer.Text = ConfigHelper.GetString("SendServerIP");
            this.lblReceiveAddress.Text = ConfigHelper.GetString("AgentReceiveAddress");
            this.lblSendAddress.Text = ConfigHelper.GetString("AgentSendAddress");
            this.lblUserName.Text = ConfigHelper.GetString("AgentReceiveUserName");
            this.lblPpwd.Text = ConfigHelper.GetString("AgentReceivePassWord");
            this.lblpublic.Text = ConfigHelper.GetString("PublicMailAddress");
            this.lblUserReceiverAddress.Text = ConfigHelper.GetString("UserReceiverAddress");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
        }
    }
}

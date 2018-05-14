using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.Huawei.Device.Contract;
using Com.Huawei.Device.ServiceModel;

namespace ICPDemo
{
    public partial class frmMultiMediaChatForTest : Form
    {

        private CallInfo m_csCallInfo = new CallInfo();

        private IDevice m_Device = null;

        private string m_strUser = "";

        private AgentInfo m_csAgentInfo;

        private bool m_bSelfRelease = true;

        public frmMultiMediaChatForTest(IDevice device, AgentInfo agentInfo)
        {
            InitializeComponent();
            m_Device = device;
            m_csAgentInfo = agentInfo;
        }

        private void frmMultiMedaChatForTest_Load(object sender, EventArgs e)
        {
            this.btnSendMediaContent.Text = ConfigHelper.GetString("Send");
            this.btnSendFile.Text = ConfigHelper.GetString("SendFile");
            this.btnTransfer.Text = ConfigHelper.GetString("Transfer");
            this.btnReceiveFile.Text = ConfigHelper.GetString("ReceiveFile");
            this.cbxNeedConfirm.Text = ConfigHelper.GetString("NeedConfirm");
            this.lbLocalPath.Text = ConfigHelper.GetString("LocalPath");
            this.lbRemotePath.Text = ConfigHelper.GetString("RemotePath");
            this.lbTargetAgentId.Text = ConfigHelper.GetString("TargetAgentId");
            this.lbFileMediaType.Text = ConfigHelper.GetString("FileMediaType");
        }

        /// <summary>
        /// 多媒体呼叫到达事件
        /// </summary>
        /// <param name="subMediaType">子媒体类型</param>
        /// <param name="uvid">呼叫访问标志</param>
        /// <param name="isInnerCall">是否是内部呼叫</param>
        /// <param name="callId">呼叫标志</param>
        /// <param name="caller">主叫号码</param>
        /// <param name="called">被叫号码</param>
        /// <param name="realCaller">实际主叫信息</param>
        /// <param name="displayName">用户显示名称</param>
        /// <param name="userInfo">其他用户信息</param>
        /// <param name="attachData">随路数据</param>
        public void OnReceiveMediaCallConnectEvent(int subMediaType, int uvid, bool isInnerCall, string callId, string caller,
                                                            string called, string realCaller, string displayName, string userInfo, string attachData)
        {
            m_csCallInfo.SetState(true);
            m_csCallInfo.m_iChatId = 0;
            m_csCallInfo.m_iUvid = uvid;
            m_csCallInfo.m_strCallId = callId;
            m_csCallInfo.m_strCaller = caller;
            m_csCallInfo.m_strCalled = called;
            m_csCallInfo.m_strRealCaller = realCaller;
            m_csCallInfo.m_strDisplayName = displayName;
            m_csCallInfo.m_strUserInfo = userInfo;
            m_strUser = " (" + caller + " )";
            this.Text = callId + m_strUser;
            tbCallId.AppendText(callId);
        }

        /// <summary>
        /// 接收到多媒体呼叫内容事件
        /// </summary>
        /// <param name="subMediaType">子媒体类型</param>
        /// <param name="callId">呼叫标志</param>
        /// <param name="seqno">序列编号</param>
        /// <param name="content">内容</param>
        public void OnReceiveMediaCallContent(int subMediaType, string callId, int chatId, int chatContentType, string content)
        {

            var _time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            string _strTitle = string.Format("User({0}) {1}", m_strUser, _time);
            appendInfoToChatContent(_strTitle, HorizontalAlignment.Left, Color.Gray, 8, Color.White);

            // 打印文本内容
            if (0 == chatContentType)
            {
                appendInfoToChatContent(content, HorizontalAlignment.Left, Color.Black, 9, Color.White);
            }
            else
            {
                appendInfoToChatContent(content, HorizontalAlignment.Left, Color.Black, 9, Color.LightGray);
            }

            rtbEventContent.AppendText(_time + " " + "OnReceiveMediaCallContent.\n");
            
        }

        /// <summary>
        /// 多媒体呼叫转移结果
        /// </summary>
        /// <param name="callId">呼叫标志</param>
        /// <param name="flag">转移成功/失败标志</param>
        /// <param name="errorCode">转移失败原因码</param>
        public void OnTransferMediaCallToAgentResult(string callId, bool flag, int errorCode)
        {
            var _time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string _strEvent = string.Format("OnTransferMediaCallToAgentResult, flag = {0}, errorCode = {1}\n", flag, errorCode);
            rtbEventContent.AppendText(_time + " " + _strEvent);
        }

        /// <summary>
        /// 多媒体文本内容发送结果
        /// </summary>
        /// <param name="callId">呼叫标志</param>
        /// <param name="chatId">序列编号</param>
        /// <param name="flag">发送成功/失败标志</param>
        /// <param name="errorCode">发送失败原因码</param>
        public void OnSendMediaContentResult(string callId, int chatId, bool flag, int errorCode)
        {
            var _time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string _strEvent = string.Format("OnSendMediaContentResult, chatid = {0}, flag = {1}, errorCode = {2}\n", chatId, flag, errorCode);
            rtbEventContent.AppendText(_time + " " + _strEvent);
        }

        /// <summary>
        /// 多媒体文件发送结果
        /// </summary>
        /// <param name="callId">呼叫标志</param>
        /// <param name="chatId">序列编号</param>
        /// <param name="flag">发送成功/失败标志</param>
        /// <param name="errorCode">发送失败原因码</param>
        public void OnSendMediaFileResult(string callId, int chatId, bool flag, int errorCode)
        {
            var _time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string _strEvent = string.Format("OnSendMediaFileResult, chatid = {0}, flag = {1}, errorCode = {2}.\n", chatId, flag, errorCode);
            rtbEventContent.AppendText(_time + " " + _strEvent);
        }

        /// <summary>
        /// 多媒体文件发送结果
        /// </summary>
        /// <param name="callId">呼叫标志</param>
        /// <param name="flag">发送成功/失败标志</param>
        /// <param name="errorCode">发送失败原因码</param>
        public void OnReceiveMediaFileResult(string callId, bool flag, int errorCode)
        {
            var _time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string _strEvent = string.Format("OnReceiveMediaFileResult, flag = {0}, errorCode = {1}.\n", flag, errorCode);
            rtbEventContent.AppendText(_time + " " + _strEvent);
        }

        public void OnReceiveMediaCallReleaseEvent(string callId)
        {
            m_bSelfRelease = false;
        }

        private void btnSendMediaContent_Click(object sender, EventArgs e)
        {
            var _sendContent = this.rtbSendContent.Text;
            this.rtbSendContent.Clear();
            string _strCallId = this.tbCallId.Text.ToString();

            bool _bNeedCheck = false;
            if (CheckState.Checked == this.cbxNeedConfirm.CheckState)
            {
                _bNeedCheck = true;
            }

            try
            {
                if (m_Device != null)
                {
                    // 聊天内容框打印发送者及发送时间
                    var _time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                    // 打印文本发送方
                    string _strTitle = string.Format("Agent({0}) {1}", m_csAgentInfo.AgentId, _time);
                    appendInfoToChatContent(_strTitle, HorizontalAlignment.Right, Color.Gray, 8, Color.White);
                    
                    // 打印文本内容
                    if (string.IsNullOrEmpty(_sendContent))
                    {
                        appendInfoToChatContent("{Input Content is empty!}", HorizontalAlignment.Right, Color.Black, 9, Color.LightYellow);
                    }
                    else
                    {
                        appendInfoToChatContent(_sendContent, HorizontalAlignment.Right, Color.Black, 9, Color.White);
                    }

                    int _iChatId = m_Device.SendMediaContent(_strCallId, _bNeedCheck, _sendContent);
                    string _strEventContent = string.Format("SendMediaContent, chatid = {0}, needConfirm = {1}.\n", _iChatId, _bNeedCheck);
                    rtbEventContent.AppendText(_time + " " + _strEventContent);
                }
            }
            catch (System.Exception ex)
            {
                MsgBox.Error("Error {0}", ex.Message);
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            string _strLocalPath = this.tbLocalPath.Text.ToString();
            string _strFileMediaType = this.tbFileMediaType.Text.ToString();
            bool _bNeedCheck = false;
            if (CheckState.Checked == this.cbxNeedConfirm.CheckState)
            {
                _bNeedCheck = true;
            }
            string _strCallId = this.tbCallId.Text.ToString();

            try
            {
                if (m_Device != null)
                {
                    // 聊天内容框打印发送者及发送时间
                    var _time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                    int _iChatId = m_Device.SendMediaFile(_strCallId, _bNeedCheck, _strFileMediaType, _strLocalPath);
                    string _strEventContent = string.Format("SendMediaFile, chatid = {0}, needConfirm = {1}, fileMediaType = {2}, localPath = {3}.\n", 
                        _iChatId, _bNeedCheck, _strFileMediaType, _strLocalPath);
                    rtbEventContent.AppendText(_time + " " + _strEventContent);
                    
                    // 聊天内容框打印发送者及发送时间
                    string _strTitle = string.Format("Agent({0}) {1}", m_csAgentInfo.AgentId, _time);
                    appendInfoToChatContent(_strTitle, HorizontalAlignment.Right, Color.Gray, 8, Color.White);
                    appendInfoToChatContent(_strEventContent, HorizontalAlignment.Right, Color.Black, 9, Color.LightGray);
                }
            }
            catch (System.Exception ex)
            {
                MsgBox.Error("Error {0}", ex.Message);
            }
        }

        private void btnReceiveFile_Click(object sender, EventArgs e)
        {
            string _strLocalPath = this.tbLocalPath.Text.ToString();
            string _strRemotePath = this.tbRemotePath.Text.ToString();
            string _strCallId = this.tbCallId.Text.ToString();

            try
            {
                if (m_Device != null)
                {
                    // 聊天内容框打印发送者及发送时间
                    var _time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                    m_Device.ReceiveMediaFile(_strCallId, _strRemotePath, _strLocalPath);
                    string _strEventContent = string.Format("ReceiveMediaFile, remotePath = {0}, localPath = {1}.\n", _strRemotePath, _strLocalPath);
                    rtbEventContent.AppendText(_time + " " + _strEventContent);
                }
            }
            catch (System.Exception ex)
            {
                MsgBox.Error("Error {0}", ex.Message);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string _strTargetAgentId = this.tbTargetAgentId.Text.ToString();
            string _strCallId = this.tbCallId.Text.ToString();

            try
            {
                if (m_Device != null)
                {
                    // 聊天内容框打印发送者及发送时间
                    var _time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                    m_Device.TransferMediaCallToAgent(_strCallId, _strTargetAgentId);
                    string _strEventContent = string.Format("SendMediaContent, destAgentId = {0}.\n", _strTargetAgentId);
                    rtbEventContent.AppendText(_time + " " + _strEventContent);
                }
            }
            catch (System.Exception ex)
            {
                MsgBox.Error("Error {0}", ex.Message);
            }
        }

        private void rtbEventContent_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            rtbEventContent.SelectionStart = rtbEventContent.TextLength;
            rtbEventContent.ScrollToCaret();
            //rtbEventContent.SelectionLength = 0;
            //rtbEventContent.Focus();
        }

        private void rtbChatContent_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            rtbChatContent.Focus();
            rtbChatContent.SelectionStart = rtbChatContent.TextLength;
            rtbChatContent.ScrollToCaret();
            //rtbChatContent.SelectionLength = 0;
            //rtbChatContent.Focus();
        }

        private void frmMultiMediaChatForTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (m_Device != null && m_bSelfRelease)
                {
                    m_Device.ReleaseMediaCall(m_csCallInfo.m_strCallId);
                }
            }
            catch (System.Exception ex)
            {
                MsgBox.Error("Error {0}", ex.Message);
            }
        }

        private void appendInfoToChatContent(string content, HorizontalAlignment contentAlignment, Color fontColor, int fontSize, Color backColor)
        {
            // 选中文本末尾
            rtbChatContent.SelectionStart = rtbChatContent.TextLength;
            rtbChatContent.ScrollToCaret();

            // 设置该行文本颜色、字体、大小、背景色
            rtbChatContent.SelectionAlignment = contentAlignment;
            rtbChatContent.SelectionColor = fontColor;
            rtbChatContent.SelectionFont = new Font("微软雅黑", fontSize);
            rtbChatContent.SelectionBackColor = backColor;

            rtbChatContent.AppendText(content + "\n");
            //rtbChatContent.Font.Dispose();
            rtbChatContent.Focus();
        }
    }
}

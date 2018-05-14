using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;

using Com.Huawei.Device;
using Com.Huawei.Device.Contract;
using Com.Huawei.Device.ServiceModel;
using ICPDemo.src.model;
using AD;


namespace ICPDemo
{
    public partial class frmMain : Form
    {
        private const int SIZE_PANEL_CFG = 45;
        private const int SIZE_PANEL_STATE = 70;
        private const int SIZE_PANEL_ECC = 402;
        private const int SIZE_PANEL_AD = 192;

        private bool lblStateDsp = true;
        private bool lblFucDsp = true;
        private bool lblADDsp = true;

        private readonly object syncRoot = new object();

        public AgentInfo _agentInfo = null;
        public Dictionary<string, string> _settings = null;

        private IDevice _device = null;
        public OpStatus _agentStatus = OpStatus.Closed;
        private string _meetingId;
        private frmMeeting _meetingForm = null;

        private Rest _restForm = null;
        //技能队列窗体对象
        private frmSkills _frmskill = null;

        [Serializable]
        public delegate void WriteLogDelegate(string message, params object[] args);

        public string callSessionID = String.Empty;

        public string otherCall = String.Empty;

        public string holdedCallSessionID = String.Empty;

        public bool demoHold = false;

        public bool demoRelease = false;

        public string MonitorTalkingGroupId { get; set; }

        public string CallSessionIDOnAidDevice { get; set; }

        //是否有通话在辅助设备上
        public bool IsTalkingOnAidDevice { get; set; }

        //是否已经有被select的groupTalking
        public bool HasSelectedGroupTalking { get; set;}

        //是否是音频呼出
        public bool IsAudioCallout = true;

        //是否启动了辅助设备
        public bool IsEnableAidDevice
        {
            get { return this._isEnableAidDevice; }
        }

        public string LastCallInPrivateQueue;

        //将要做Select操作的GroupTalkingSelectId
        public String GoingToGroupTalkingSelectId { get; set; }

        //public ToBeSwitchedCallInfo m_ToBeSwitchedCallInfo = new ToBeSwitchedCallInfo();

        public CallInfoOnAidDevice m_CallInfoOnAidDevice = new CallInfoOnAidDevice();

        private Dictionary<string, string> _phoneConfig = null;

        private bool _isEnableAidDevice = false;

        private Dictionary<string, string> _CDSsettings = null;

        public string UportalPassword;
        public Dictionary<string, string> _uportalConfig = null;

        private frmConfig _cfgForm = null;
        public List<SoundDeviceInfo> _inPutDev = null;
        public List<SoundDeviceInfo> _outPutDev = null;
        public List<SoundDeviceInfo> _videoDev = null;
        public string groupID;
        public TalkingGroup talkingGroup;

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        public frmLocalVideo localVideoForm = null;
        public frmRemoteVideo remoteVideoForm = null;

        public frmMain()
        {
            talkingGroup = new TalkingGroup();

            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                this.WriteLog("InitializeComponent.failed" + ex.Message);
            }

            try
            {
                this._device = IDeviceProvider.GetIDevice(frmMainDeviceCallback.GetMainDeviceCallback(this)) as IDevice;
            }
            catch (Exception ex)
            {
                this.WriteLog("GetIDevice.failed" + ex.Message);
            }

            var version = Assembly.GetExecutingAssembly().GetName().Version;
  
            this.WriteLog("ICPDemo Start Success!(Version:{0}, BuildTime:{1})", version.ToString(), System.IO.File.GetLastWriteTime(this.GetType().Assembly.Location).ToString());

            try
            {

                this.axActiveMailReply.SetActiveXShowType(0);

                this.axActiveMailReply.ShowMailDialog();
                this.axActiveMailReply.DialogStyle = 0;
                this.axActiveMailReply.AfterSendMail += new AxACTIVEMAILLib._DActiveMailEvents_AfterSendMailEventHandler(axActiveMail1_AfterSendMail);
                this.axActiveMailReply.BeforeSendMail += new AxACTIVEMAILLib._DActiveMailEvents_BeforeSendMailEventHandler(axActiveMail1_BeforeSendMail);
                this.axActiveMailReply.OnReceived += new AxACTIVEMAILLib._DActiveMailEvents_OnReceivedEventHandler(axActiveMailReply_OnReceived);

                this.axActiveMailSend.ShowMailDialog();
                this.axActiveMailSend.DialogStyle = 5;
                this.axActiveMailSend.AfterSendMail += new AxACTIVEMAILLib._DActiveMailEvents_AfterSendMailEventHandler(axActiveMail1_AfterSendMail);
                this.axActiveMailSend.BeforeSendMail += new AxACTIVEMAILLib._DActiveMailEvents_BeforeSendMailEventHandler(axActiveMail1_BeforeSendMail);
            }
            catch
            {
                //this.WriteLog("frmMain.failed");
            }
            
        }

        void axActiveMailReply_OnReceived(object sender, AxACTIVEMAILLib._DActiveMailEvents_OnReceivedEvent e)
        {
            this.WriteLog("axActiveMail_OnReceived,IsFinishReceMail = {0}", axActiveMailReply.IsFinishReceMail());
            this.WriteLog("axActiveMail_OnReceived.OrgCaller = {0},ReceivDateTime = {1},Subject ={2},ContentHTML = {3}",
                axActiveMailReply.GetOrgCaller(), axActiveMailReply.GetReceivDateTime(), axActiveMailReply.GetSubject(), axActiveMailReply.GetContentHTML());
            this.axActiveMailReply.ShowMailDialog();
        }

        void axActiveMail1_BeforeSendMail(object sender, AxACTIVEMAILLib._DActiveMailEvents_BeforeSendMailEvent e)
        {
            this.WriteLog("axActiveMail_BeforeSendMail,ucHandle = {0},ulTime = {1},usDsn = {2}", e.ucHandle, e.ulTime, e.usDsn);
        }

        void axActiveMail1_AfterSendMail(object sender, AxACTIVEMAILLib._DActiveMailEvents_AfterSendMailEvent e)
        {
            this.WriteLog("axActiveMail_AfterSendMail,ucHandle = {0},ulTime = {1},usDsn = {2}", e.ucHandle, e.ulTime, e.usDsn);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        frmMainDeviceCallback frmMainDeviceCallback = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                var config = ConfigHelper.Load();

                if (config != null && config.Settings.ContainsKey("Language"))
                {
                    if (config.Settings["Language"] == "CN")
                    {
                        ConfigHelper.SetCurrentCulture("zh-CN");
                    }
                    else
                    {
                        ConfigHelper.SetCurrentCulture("en-US");
                    }                    
                }
                else
                {
                    var lanSelect = new frmLanguageSelect();
                    if (lanSelect.ShowDialog(false) == DialogResult.OK)
                    {
                        config.Settings.Add("Language", lanSelect._selectCN ? "CN" : "US");
                        config.Save();
                    }
                }


                if (config != null)
                {
                    this._agentInfo = config.AgentInfo;
                    this._settings = config.Settings;
                    this._phoneConfig = config.PhoneSettings;
                    this._uportalConfig = config.UportalSettings;
                }

                frmMainDeviceCallback = frmMainDeviceCallback.GetMainDeviceCallback(this);
                this.UpdateControlStatus(OpStatus.Closed);
                this.SetResourcePos();
                //界面显示
                this.SetResourceCulture();
            }
            catch (Exception ex)
            {
                MsgBox.Error("occur exception: " + ex.Message);
            }
        }

        private void SetResourcePos()
        {
            int posY;
            posY = panelCfg.Location.Y;
            panelCfg.Size = new Size(1164, SIZE_PANEL_CFG);
            posY += SIZE_PANEL_CFG + 5;

           lblState.Location = new Point(lblState.Location.X, posY); ;
            posY += 15;
            if (lblStateDsp)
            {
                panelState.Location = new Point(panelState.Location.X, posY);
                panelState.Size = new Size(1164, SIZE_PANEL_STATE);
                posY += SIZE_PANEL_STATE + 5;
            }

            lblFunction.Location = new Point(lblFunction.Location.X, posY);
            posY += 15;
            if (lblFucDsp)
            {
                panelECC.Location = new Point(panelECC.Location.X, posY);
                panelECC.Size = new Size(1164, SIZE_PANEL_ECC);
                posY += SIZE_PANEL_ECC + 5;
            }

            label_AD.Location = new Point(label_AD.Location.X, posY);
            posY += 15;
            if (lblADDsp)
            {
                panelAD.Location = new Point(panelAD.Location.X, posY);
                panelAD.Size = new Size(1164, SIZE_PANEL_AD);
                posY += SIZE_PANEL_AD + 5;
            }

            txtEvents.Location = new Point(txtEvents.Location.X, posY);
            
            int txtSize = this.Size.Height - 70 - posY;
            if (txtSize < 155)
            {
                txtSize = 155;
            }
            else
            {
                if (this.HorizontalScroll.Visible || this.VerticalScroll.Visible)
                {
                    txtSize -= 20;
                }
                this.VerticalScroll.Visible = false;
            }

            
            txtEvents.Size = new Size(1164, txtSize);
            posY += txtSize + 5;

            btnClearLog.Location = new Point(8, posY);
        }

        private void SetResourceCulture()
        {            
            this.btnConfig.Text = ConfigHelper.GetString("Config");
            this.btnUnifiedLogin.Text = ConfigHelper.GetString("UnifiedLogin");
            this.btnUnifiedLogout.Text = ConfigHelper.GetString("UnifiedLogout");
            this.btnInitial.Text = ConfigHelper.GetString("Initialize");
            this.btnUnInitial.Text = ConfigHelper.GetString("UnInitialize");
            this.btn_UninitialAll.Text = ConfigHelper.GetString("UninitialAll");
            this.btnChangeAgentPwd.Text = ConfigHelper.GetString("ChangeAgentPwd");
            this.btnGetSysVersion.Text = ConfigHelper.GetString("GetSysVersion");
            //状态管理
            this.lblState.Text = ConfigHelper.GetString("lblState") + " [-]";
            this.btnSetIdle.Text = ConfigHelper.GetString("SetIdle");
            this.btnSetBusy.Text = ConfigHelper.GetString("SetBusy");
            this.BtnRest.Text = ConfigHelper.GetString("Rest");
            this.BtnCancelRest.Text = ConfigHelper.GetString("CancelRest");
            this.btnWork.Text = ConfigHelper.GetString("SetWork");
            this.btnWorkStop.Text = ConfigHelper.GetString("SetWorkStop");
            this.btnAutoEnterIdle.Text = ConfigHelper.GetString("SetAutoEnterIdle");
            this.btnClearAutoEnterIdle.Text = ConfigHelper.GetString("CancelAutoEnterIdle");
            this.btnExitACW.Text = ConfigHelper.GetString("ExitACW");
            //呼叫控制
            this.btnPickup.Text = ConfigHelper.GetString("Pickup");
            this.btnHangup.Text = ConfigHelper.GetString("Hangup");
            this.btnHoldCall.Text = ConfigHelper.GetString("Hold");
            this.btnRetrieveCall.Text = ConfigHelper.GetString("HoldCancel");
            this.btnConsult.Text = ConfigHelper.GetString("ConsultCall");
            this.btnEndConsultCall.Text = ConfigHelper.GetString("EndConsultCall");
            this.btnTransToAgent.Text = ConfigHelper.GetString("TransferToAgent");
            this.btnBlindTransfer.Text = ConfigHelper.GetString("SingleStepTransfer");
            this.btnSingleStepSuccTransfer.Text = ConfigHelper.GetString("SingleStepSuccTransfer");
            this.btnSingleStepSuccTransferEx.Text = ConfigHelper.GetString("SingleStepSuccTransferEx");
            this.btnDial.Text = ConfigHelper.GetString("Dial");
            this.btnPollingCall.Text = ConfigHelper.GetString("PollingCall");
            this.btnTransferToSkillGroup.Text = ConfigHelper.GetString("TransferToSkillGroup");
            this.btnDialEx.Text = ConfigHelper.GetString("DialEx");
            this.btnPollingCallEx.Text = ConfigHelper.GetString("PollingCallEx");
            this.btnAgentSendDTMF.Text = ConfigHelper.GetString("AgentSendDTMF");
            this.btnTransToIVR.Text = ConfigHelper.GetString("TransToIVR");
            this.btnSmsToAgent.Text = ConfigHelper.GetString("TransferSMSToAgent");
            this.btn_TransferConsulting.Text = ConfigHelper.GetString("TransferConsulting");

            //会议控制
            this.btnCreateMeeting.Text = ConfigHelper.GetString("CreateMeeting");
            this.btnMakeMeeting.Text = ConfigHelper.GetString("MakeMeeting");
            this.BtnSingleStepMeeting.Text = ConfigHelper.GetString("SingleStepMeeting");
            this.btnExitMeeting.Text = ConfigHelper.GetString("ExitMeeting");
            this.btnQueryMeetingMembers.Text = ConfigHelper.GetString("QueryMeetingMembers");
            this.btnTransferMeetingMaster.Text = ConfigHelper.GetString("TransferMeetingMaster");

            this.btnCreateMeetingEx.Text = ConfigHelper.GetString("CreateMeetingEx");

            //查询
            this.btnQueryAgentStatus.Text = ConfigHelper.GetString("QueryAgentStatus");
            this.btnQueryAllByGroupId.Text = ConfigHelper.GetString("QueryAllAgentStatus");
            this.btnQuerySkillGroups.Text = ConfigHelper.GetString("QuerySkillGroups");
            this.btnQueryCallListByGroup.Text = ConfigHelper.GetString("QueryCallListByGroupId");
            this.btnQueryCurrentCallingScope.Text = ConfigHelper.GetString("QueryCurrentCallingScope");
            this.btnQueryLostCalls.Text = ConfigHelper.GetString("QueryLostCalls");
            this.btnQueryTotalSysInno.Text = ConfigHelper.GetString("QueryAccessCode");
            this.btnQueryIVRInfo.Text = ConfigHelper.GetString("QueryIVRInfo");
            this.btn_SubscriberCallListChange.Text = ConfigHelper.GetString("SubscriberCallList");
            this.btn_StopSubscriberCallListChange.Text = ConfigHelper.GetString("StopSubscriberCallList");

            //无线
            this.btnPTTOn.Text = ConfigHelper.GetString("PTTOn");
            this.btnPTTOff.Text = ConfigHelper.GetString("PTTOff");
            this.btnQueryWirelessInfo.Text = ConfigHelper.GetString("QueryWirelessInfo");
            this.btnQueryAllWireless.Text = ConfigHelper.GetString("QueryAllWirelessDevice");
            this.bntQueryUsingWirelessDevice.Text = ConfigHelper.GetString("QueryUsingWirelessDevice");
            //黑名单
            this.btnAddBlackList.Text = ConfigHelper.GetString("AddToBlackList");
            this.btnRemoveBlackList.Text = ConfigHelper.GetString("RemoveFromBlackList");
            this.btnClearBlackList.Text = ConfigHelper.GetString("RemoveAllBlackList");
            this.btnQueryBlackList.Text = ConfigHelper.GetString("QueryBlackList");
            this.btnQueryAllBlackList.Text = ConfigHelper.GetString("QueryAllBlackList");

            this.btnAddBlackListEx.Text = ConfigHelper.GetString("AddToBlackListEx");
            this.btnQueryBlackListEx.Text = ConfigHelper.GetString("QueryBlackListEx");
            this.btnQueryAllBlackListEx.Text = ConfigHelper.GetString("QueryAllBlackListEx");

            //红名单
            this.btnAddToRedList.Text = ConfigHelper.GetString("AddToRedList");
            this.btnQueryRedList.Text = ConfigHelper.GetString("QueryRedList");
            this.btnRemoveFromRedList.Text = ConfigHelper.GetString("RemoveFromRedList");
            this.btnRemoveAllRedList.Text = ConfigHelper.GetString("RemoveAllRedList");
            this.btnQueryAllRedList.Text = ConfigHelper.GetString("QueryAllRedList");

            //质检
            this.btnMonitor.Text = ConfigHelper.GetString("Monitor");
            this.btnMonitorToBarge.Text = ConfigHelper.GetString("MonitorToBarge");
            this.btnMonitorToSnatch.Text = ConfigHelper.GetString("MonitorToForceRelease");
            this.btnBarge.Text = ConfigHelper.GetString("Barge");
            this.btnSnatch.Text = ConfigHelper.GetString("ForceRelease");
            this.btnSnatchPickup.Text = ConfigHelper.GetString("SnatchPickup");
            this.btnSelectPickup.Text = ConfigHelper.GetString("SelectPickup");
            this.btnForceLogout.Text = ConfigHelper.GetString("ForceLogout");


            this.btnWhisper.Text = ConfigHelper.GetString("Whisper");
            this.btnStopWhisper.Text = ConfigHelper.GetString("SuperviseStop");
            this.btnSuperviseSwitch.Text = ConfigHelper.GetString("SuperviseSwitch");



            //录音管理
            this.btnGetRecordLength.Text = ConfigHelper.GetString("GetRecordLength");
            this.btnPlayRecord.Text = ConfigHelper.GetString("PlayRecord");
            this.btnPlayRecordSeekTo.Text = ConfigHelper.GetString("PlayRecordSeekTo");
            this.btnPausePlayRecord.Text = ConfigHelper.GetString("PlayRecordPause");
            this.btnResumePlayRecord.Text = ConfigHelper.GetString("PlayRecordResume");
            this.btnStopPlayRecord.Text = ConfigHelper.GetString("PlayRecordStop");
            //邮件
            this.btnUpdateMailConfig.Text = ConfigHelper.GetString("UpdateMailConfig");
            this.btnQueryAgentCfgInfo.Text = ConfigHelper.GetString("QueryAgentEmailCfgInfo");
            this.btnReceiveMail.Text = ConfigHelper.GetString("ReceiveMail");
            this.btnReplyEmail.Text = ConfigHelper.GetString("ReplyEmail");
            this.btnGetCallOutNo.Text = ConfigHelper.GetString("GetCallOutNo");
            this.btnSendEmail.Text = ConfigHelper.GetString("SendEmail");
            this.btnReleaseCallEx.Text = ConfigHelper.GetString("ReleaseMailCall");
            //短信
            this.btnSMS.Text = ConfigHelper.GetString("SendSMS");
            this.lblSepNo.Text = ConfigHelper.GetString("SeqNo");
            this.btnQueryAgentIP.Text = ConfigHelper.GetString("QueryAgentIP");

            this.lblFunction.Text = ConfigHelper.GetString("lblFunction") + " [-]";
            this.lblCall.Text = ConfigHelper.GetString("label27");
            this.lblMeeting.Text = ConfigHelper.GetString("lblMeeting");
            this.lblQuery.Text = ConfigHelper.GetString("lblQuery");
            this.lblBlack.Text = ConfigHelper.GetString("lblBlack");
            this.lblRed.Text = ConfigHelper.GetString("lblRed");
            this.lblRecordId.Text = ConfigHelper.GetString("lblRecordId");
            this.lblSeekToTime.Text = ConfigHelper.GetString("lblSeekToTime");
            this.lblSkillID.Text = ConfigHelper.GetString("lblSkillID");
            this.lblSMSSkillId.Text = ConfigHelper.GetString("lblSkillID");
            this.lblUser.Text = ConfigHelper.GetString("Number");
            this.lblNote.Text = ConfigHelper.GetString("lblNote");

            //tab
            this.tab.Text = ConfigHelper.GetString("Phonology");
            this.tabEmail.Text = ConfigHelper.GetString("Email");
            this.tabList.Text = ConfigHelper.GetString("List");
            this.tabNote.Text = ConfigHelper.GetString("Message");
            this.tabM.Text = ConfigHelper.GetString("MonitorFunction");
            this.tabRecord.Text = ConfigHelper.GetString("Record");
            this.tabWirelesss.Text = ConfigHelper.GetString("Wireless");
            this.tabVRC.Text = ConfigHelper.GetString("VRC");

            //C60新增设置
            this.btnSetAutoAnswer.Text = ConfigHelper.GetString("SetAutoAnswer");
            this.btnCancelAutoAnswer.Text = ConfigHelper.GetString("CancelAutoAnswer");
            this.btnSetCallData.Text = ConfigHelper.GetString("SetCallData");
            this.btnQueryCallData.Text = ConfigHelper.GetString("QueryCallData");
            this.btnSetCustomerLevel.Text = ConfigHelper.GetString("SetCustomerLevel");
            this.btnQueryMaliciousCalls.Text = ConfigHelper.GetString("QueryMaliciousCalls");
            // add by xiezhengquan for AR. eSDK.001.001.001
            this.btnSetCustomizedRecordInfo.Text = ConfigHelper.GetString("SetCustomizedRecordInfo");

            this.btnSendMessage.Text = ConfigHelper.GetString("SendMessage");
            this.btnQueryAgentSkillGroups.Text = ConfigHelper.GetString("QueryAgentSkillGroups");
            this.btnQuerySkillGroupStatus.Text = ConfigHelper.GetString("QuerySkillGroupStatus");

            this.btnMute.Text = ConfigHelper.GetString("Mute");
            this.btUnMute.Text = ConfigHelper.GetString("UnMute");
            this.btnQueryCallInfo.Text = ConfigHelper.GetString("QueryCallInfo");
            this.btnQueryCallIdOnAgent.Text = ConfigHelper.GetString("QueryCallIdOnAgent");

            this.btnResetAgentSkill.Text = ConfigHelper.GetString("ResetAgentSkill");


            //VC Call
            this.btnSubscribeAgentEvent.Text = ConfigHelper.GetString("SubscribeAgentEvent");
            this.btnStopSubscribeAgentEvent.Text = ConfigHelper.GetString("StopSubscribeAgentEvent");
            this.btnPickupVCCall.Text = ConfigHelper.GetString("PickupVCCall");
            this.btnHangupVCCall.Text = ConfigHelper.GetString("HangupVCCall");

            this.tabVCC.Text = ConfigHelper.GetString("Video");

            this.lblRecordPath.Text = ConfigHelper.GetString("RecordPath");
            this.lblStorePath.Text = ConfigHelper.GetString("StorePath");
            this.lblDownloadFormat.Text = ConfigHelper.GetString("DownloadFormat");
            this.btnDownloadRecord.Text = ConfigHelper.GetString("DownloadRecord");

            this.btn_Init.Text = ConfigHelper.GetString("PhoneInitialize");
            this.btn_PhoneUninit.Text = ConfigHelper.GetString("PhoneUnInitialize");
            this.btn_PhoneAnswer.Text = ConfigHelper.GetString("PhoneAnswer");
            this.btn_PhoneHangup.Text = ConfigHelper.GetString("PhoneRelease");
            this.btn_PhoneMute.Text = ConfigHelper.GetString("PhoneMute");
            this.btn_PhoneUnmute.Text = ConfigHelper.GetString("PhoneUnmute");
            this.btn_AddTalking.Text = ConfigHelper.GetString("TalkingGroupAdd");
            this.btn_DeleteTakling.Text = ConfigHelper.GetString("TalkingGroupDelete");
            this.btn_GetDeviceVolume.Text = ConfigHelper.GetString("PhoneGetDeviceVolume");
            this.btn_GetSoundDevice.Text = ConfigHelper.GetString("PhoneGetSoundDevice");
            this.btn_GetVolume.Text = ConfigHelper.GetString("PhoneGetVolume");
            this.btn_GetVolumeGain.Text = ConfigHelper.GetString("PhoneGetVolumeGainByCall");
            this.btn_GroupMonitor.Text = ConfigHelper.GetString("TalkingGroupMonitor");
            this.btn_GroupDemonitor.Text = ConfigHelper.GetString("TalkingGroupDemonitor");
            this.btn_GroupPTT.Text = ConfigHelper.GetString("TalkingGroupPTT");
            this.btn_GroupDePTT.Text = ConfigHelper.GetString("GroupDePTT");
            this.btn_GroupSelect.Text = ConfigHelper.GetString("TalkingGroupSelect");
            this.btn_GroupDeselect.Text = ConfigHelper.GetString("TalkingGroupDeselect");
            this.btn_QueryGrupState.Text = ConfigHelper.GetString("TalkingGroupQueryState");
            this.btn_LogoutUportal.Text = ConfigHelper.GetString("LogoutFromUPortal");
            this.btn_UportalLogin.Text = ConfigHelper.GetString("LoginToUPortal");
            this.btn_MixedGroupCallEnd.Text = ConfigHelper.GetString("MixedGroupCallEnd");
            this.btn_MixedGroupCallStart.Text = ConfigHelper.GetString("MixedGroupCallStart");
            this.btn_mixedAndTempGroupStart.Text = ConfigHelper.GetString("MixedAndTempGroupCallStart");
            this.btn_MixedGroupChangeUserState.Text = ConfigHelper.GetString("MixedGroupChangeUserState");
            this.btn_ModifyGroup.Text = ConfigHelper.GetString("TalkingGroupModify");
            this.btn_RadioGroupQuery.Text = ConfigHelper.GetString("RadioGroupQuery");
            this.btn_SetDeviceVolume.Text = ConfigHelper.GetString("PhoneSetDeviceVolume");
            this.btn_SetSoundDevice.Text = ConfigHelper.GetString("PhoneSetSoundDevice");
            this.btn_SetVolume.Text = ConfigHelper.GetString("PhoneSetVolume");
            this.btn_SetVolumeGain.Text = ConfigHelper.GetString("PhoneSetVolumeGainByCall");
            this.btn_SwitchAidDevice.Text = ConfigHelper.GetString("PhoneSwitchToAidDevice");
            this.btn_SwitchMainDevice.Text = ConfigHelper.GetString("PhoneSwitchToMainDevice");
            this.btn_TalkingGroupSubscribe.Text = ConfigHelper.GetString("TalkingGroupSubscribe");
            this.btn_TalkingGroupQuery.Text = ConfigHelper.GetString("TalkingGroupQuery");
            this.btn_TalkingGroupGetCallInfo.Text = ConfigHelper.GetString("TalkingGroupGetCallInfo");
            this.btn_GroupDesubscribe.Text = ConfigHelper.GetString("TalkingGroupDesubscribe");
            this.btn_GetConfig.Text = ConfigHelper.GetString("GetConfig");
            this.btn_SetConfig.Text = ConfigHelper.GetString("SetConfig");
            this.btn_QueryRleaseAuthority.Text = ConfigHelper.GetString("QueryRleaseAuthority");
            this.btn_Record.Text = ConfigHelper.GetString("RecordList");
            this.btn_GetNonce.Text = ConfigHelper.GetString("GetNonce");
            this.btn_Record_Backplay.Text = ConfigHelper.GetString("RecordBackplay");
            this.btn_stop_emergency_note.Text = ConfigHelper.GetString("StopPlayEmergencyNote");
            this.btn_get_pubParamters.Text = ConfigHelper.GetString("ServiceParamters");
            this.btn_emergency_answer.Text = ConfigHelper.GetString("EmergencyAnswer");
            this.bt_previewVideo.Text = ConfigHelper.GetString("PreviewVideo");
            this.bt_GetVideoDevice.Text = ConfigHelper.GetString("GetVideoDevice");
            this.btn_emergency_exit.Text = ConfigHelper.GetString("EmergencyExit");
            this.btn_releaseCurUserGroupCall.Text = ConfigHelper.GetString("ReleaseAll");

            //VRC
            this.btn_initializeVRCAgent.Text = ConfigHelper.GetString("InitAgentVRC");
            this.btn_StartRecordScreen.Text = ConfigHelper.GetString("startRecordScreen");
            this.btn_StopRecordScreen.Text = ConfigHelper.GetString("stopRecordScreen");
            this.Uninitialize_VRC.Text = ConfigHelper.GetString("Uninitialize_VRC");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        private void PerformAction(Action action, bool cursorBusy = true)
        {
            if (action != null)
            {
                bool cursorSet = false;

                try
                {
                    if (cursorBusy)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        cursorSet = true;
                    }

                    action();

                    if (cursorSet)
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
                catch (TypeInitializationException ex)
                {
                    if (cursorSet)
                    {
                        Cursor.Current = Cursors.Default;
                    }
                    MsgBox.Error(ex.Message);
                }
                catch (Exception ex)
                {
                    if (cursorSet)
                    {
                        Cursor.Current = Cursors.Default;
                    }

                    MsgBox.Error("occur exception " + ex.Message);
                }
            }
        }

        /// <summary>  
        /// 
        /// </summary>
        /// <param name="action"></param>
        public void PerformDeviceAction(Action<IDevice> action)
        {
            var device = this._device;

            if (device == null)
            {
                MsgBox.Error(ConfigHelper.GetString("NotInitialized"));

                return;
            }

            try
            {
                action(device);
            }
            catch (Exception ex)
            {
                this.WriteLog("PerformDeviceAction:{0}.failed! message: {1}", action.Method.Name, ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public void WriteLog(string message, params object[] args)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new WriteLogDelegate(this.WriteLog), message, args);
                return;
            }

            try
            {
                var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff");

                if (args != null && args.Length > 0)
                {
                    this.txtEvents.AppendText(date + " " + string.Format(message, args) + Environment.NewLine);
                }
                else
                {
                    this.txtEvents.AppendText(date + " " + message + Environment.NewLine);
                }

                this.txtEvents.SelectionStart = int.MaxValue;
            }
            catch
            {
                this.WriteLog("WriteLog.Exception");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentStatus"></param>
        public void UpdateAgentStatus(OpStatus agentStatus)
        {
            lock (syncRoot)
            {
                if (this._agentStatus != agentStatus)
                {
                    this._agentStatus = agentStatus;

                    this.UpdateControlStatus(agentStatus);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateControlStatus(OpStatus agentStatus)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmConfig(_device, _inPutDev, _outPutDev, _videoDev);
                _cfgForm = dialog;
                if (dialog.ShowDialog(this._agentInfo, this._settings, this._phoneConfig) == DialogResult.OK)
                {
                    if (this._settings.ContainsKey("Language") && dialog.Settings.ContainsKey("Language")
                        && this._settings["Language"] != dialog.Settings["Language"])
                    {
                        this.SetResourceCulture();
                    }
                    this._agentInfo = dialog.AgentInfo;
                    this._settings = dialog.Settings;
                    this._phoneConfig = dialog.PhoneSettings;

                    ConfigHelper config = new ConfigHelper();
                    config.AgentInfo = this._agentInfo;
                    config.Settings = this._settings;
                    config.PhoneSettings = this._phoneConfig;
                    config.Save();
                }
                _cfgForm = null;
            });
        }
        public void SetInputDeviceInfo(List<SoundDeviceInfo> deviceList)
        {
            _inPutDev = deviceList;
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<List<SoundDeviceInfo>>(SetInputDeviceInfo), deviceList);
                return;
            }
            if (this._cfgForm != null)
            {
                this._cfgForm.SetDeviceInfo(deviceList, MediaDeviceType.AudioInput);
            }
        }

        public void SetOutputDeviceInfo(List<SoundDeviceInfo> deviceList)
        {
            _outPutDev = deviceList;
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<List<SoundDeviceInfo>>(SetOutputDeviceInfo), deviceList);
                return;
            }
            if (this._cfgForm != null)
            {
                this._cfgForm.SetDeviceInfo(deviceList, MediaDeviceType.AudioOutput);
            }
        }

        public void SetVideoDeviceInfo(List<SoundDeviceInfo> deviceList)
        {
            _videoDev = deviceList;
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<List<SoundDeviceInfo>>(SetVideoDeviceInfo), deviceList);
                return;
            }
            if (this._cfgForm != null)
            {
                this._cfgForm.SetDeviceInfo(deviceList, MediaDeviceType.Video);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInitial_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var agentInfo = this._agentInfo;
                var settings = this._settings;

                if (agentInfo == null)
                {
                    throw new InvalidOperationException("Config error: Invalid agent info.");
                }

                if (settings == null || settings.Count == 0)
                {
                    throw new InvalidOperationException("Config error: Invalid settings.");
                }

                string HuaweiCTIServerIP = string.Empty;
                settings.TryGetValue("HuaweiCTIServerIP", out HuaweiCTIServerIP);
                if (!string.IsNullOrEmpty(HuaweiCTIServerIP) && !HuaweiCTIServerIP.StartsWith("https"))
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;

                    //默认情况下，如MessageBox.Show("确定要退出吗？")只显示一个“确定”按钮。
                    DialogResult dr = MessageBox.Show(ConfigHelper.GetString("HttpAlarm"), "Message", messButton);

                    if (dr != DialogResult.OK)//如果点击“确定”按钮
                    {
                        return;
                    }

                }

                bool canlogin = true;
                

                if (canlogin)
                {
                    lock (this.syncRoot)
                    {
                        if (this._device == null)
                        {
                            var device = IDeviceProvider.GetIDevice(frmMainDeviceCallback.GetMainDeviceCallback(this)) as IDevice;
                            if (device == null)
                            {
                                throw new Exception("Create device failed.");
                            }

                            this._device = device;
                        }
                    }

                    this.PerformDeviceAction((device) =>
                    {
                        device.Initialize(agentInfo, settings);
                        this.WriteLog("version:"+device.GetVersion() );
                    });
                }

            });
        }

       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnInitial_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.UnInitialize());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetIdle_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.SetIdle());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetBusy_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.SetBusy());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBlackList_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmBlackList();
                dialog.Text = btnAddBlackList.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.AddToBlackList(dialog.PhoneNumber, dialog.LockTime));
                }
            }, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveBlackList_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmBlackList(false);
                dialog.Text = btnRemoveBlackList.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.RemoveFromBlackList(dialog.PhoneNumber));
                }
            }, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearBlackList_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.RemoveAllBlackList());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPickup_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.Pickup());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDial_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmDial(false, true);
                dialog.Text = btnDial.Text;

                if (dialog.ShowDialog(true) == System.Windows.Forms.DialogResult.OK)
                {
                    var dialContent = dialog.DialContent;
                    this.PerformDeviceAction((device) => device.Dial(dialContent));                        
                }

            }, false);
        }

        public void Dial(string callNo)
        {
            DialContent dialcontent = new DialContent();
            dialcontent.PhoneNumber = callNo;
            dialcontent.PhoneType = DeviceType.Phone;
            dialcontent.CallType = DeviceCallType.ConventionCall;
            this.PerformDeviceAction((device) => device.Dial(dialcontent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHoldCall_Click(object sender, EventArgs e)
        {
            FrmHold frm = new FrmHold();
            frm.Text = this.btnHoldCall.Text;
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(frm.CallId))
                {
                    this.PerformDeviceAction((device) => device.Hold(HoldMode.Hold));
                }
                else
                {
                    this.PerformDeviceAction((device) => device.HoldByCallId(HoldMode.Hold, frm.CallId));
                }
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetrieveCall_Click(object sender, EventArgs e)
        {
            FrmHold frm = new FrmHold();
            frm.Text = this.btnRetrieveCall.Text;
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(frm.CallId))
                {
                    this.PerformDeviceAction((device) => device.Hold(HoldMode.HoldCancel));
                }
                else
                {
                    this.PerformDeviceAction((device) => device.HoldByCallId((HoldMode.HoldCancel), frm.CallId));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHangup_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.Hangup());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsult_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmDial(false, true);
                dialog.Text = btnConsult.Text;

                if (dialog.ShowDialog(false) == System.Windows.Forms.DialogResult.OK)
                {
                    var dialContent = dialog.DialContent;

                    this.PerformDeviceAction((device) => device.ConsultCall(dialContent));
                }
            }, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransToAgent_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.TransferToAgent());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlindTransfer_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmDial();
                dialog.Text = btnBlindTransfer.Text;

                if (dialog.ShowDialog(false) == System.Windows.Forms.DialogResult.OK)
                {
                    var dialContent = dialog.DialContent;

                    this.PerformDeviceAction((device) => device.SingleStepTransfer(this._agentInfo.AgentId, dialContent.PhoneNumber));
                }
            }, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeMeeting_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.MakeMeeting());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryWirelessInfo_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmDeviceId();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.QueryWirelessInfo(dialog.WirelessDeviceId));
                }
            }, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryAllWireless_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryAllWirelessDevice());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPTTOn_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmDeviceId(true);

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.PTT(PTTOperate.PutDown, dialog.WirelessDeviceId));
                }
            }, false);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPTTOff_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.PTT(PTTOperate.PutUp, "7"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.PerformAction(() => this.txtEvents.Clear());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayRecord_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                string number = this.txtRecordId.Text.Trim();
                if (string.IsNullOrEmpty(number))
                {
                    MsgBox.Info("Please input record id.");
                    this.txtRecordId.Focus();
                    return;
                }
                this.PerformDeviceAction((device) => device.PlayRecord(number));
            }, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopPlayRecord_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.PlayRecordStop());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPausePlayRecord_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.PlayRecordPause());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResumePlayRecord_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.PlayRecordResume());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateMeeting_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmCreateMeeting();
                dialog.Text = btnCreateMeeting.Text;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.CreateMeeting(dialog.DialContentList));
                }
            }, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="meetingId"></param>
        public void OnStartMeeting(string meetingId)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(OnStartMeeting), meetingId);
                return;
            }
            if (this._meetingForm != null && meetingId.Equals(this._meetingForm.MeetingId))
            {
                return;
            }
            var meetingForm = new frmMeeting(this._device, this._agentInfo);
            meetingForm.MeetingId = meetingId;

            this._meetingForm = meetingForm;
            this._meetingId = meetingId;
            meetingForm.Show(this);
        }

        private void OnMeetingHangup(DialContent dialContent)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<DialContent>(OnMeetingHangup), dialContent);
                return;
            }

            var meetingForm = this._meetingForm;

            if (meetingForm != null)
            {
                meetingForm.RemoveDialContent(dialContent);
            }
        }

        /// <summary>
        /// 查询会议成员
        /// </summary>
        /// <param name="mettingId"></param>
        public void QueryMeetingMembers(string mettingId)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(QueryMeetingMembers), mettingId);
                return;
            }
            this.PerformDeviceAction((device) => device.QueryMeetingMembers(mettingId));
        }

        /// <summary>
        /// 界面数据更新
        /// </summary>
        /// <param name="dialContent"></param>
        public void OnAddMeetingDialContent(DialContent dialContent)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<DialContent>(OnAddMeetingDialContent), dialContent);
                return;
            }

            var meetingForm = this._meetingForm;

            if (meetingForm != null)
            {
                meetingForm.AddDialContent(dialContent);
            }
        }

        /// <summary>
        /// 清空会议列表
        /// </summary>
        public void OnClearList()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(OnClearList));
                return;
            }

            var meetingForm = this._meetingForm;

            if (meetingForm != null)
            {
                meetingForm.ClearList();
                if (null != meetingForm.DialContentList)
                {
                    meetingForm.DialContentList.Clear();
                }
            }
        }
        public void OnRemoveMeetingMember(DialContent dialContent)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<DialContent>(OnRemoveMeetingMember), dialContent);
                return;
            }

            var meetingForm = this._meetingForm;

            if (meetingForm != null)
            {
                meetingForm.RemoveDialContent(dialContent);
            }
        }

        public void OnEndMeeting()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(OnEndMeeting));
                return;
            }

            var meetingForm = this._meetingForm;
            this._meetingForm = null;
            this._meetingId = "";
            if (meetingForm != null)
            {
                meetingForm.Close();
            }
        }

        public void OnSetVideoWindow()
        {
            localVideoForm = new frmLocalVideo();
            localVideoForm.Show();
            remoteVideoForm = new frmRemoteVideo();
            remoteVideoForm.Show();
            IntPtr localwdHandle = FindWindow(null, localVideoForm.Text);
            IntPtr remotewdHandle = FindWindow(null, remoteVideoForm.Text);
            localVideoForm.Hide();
            remoteVideoForm.Hide();
            this.PerformDeviceAction((device) => device.PhoneSetVideoWindow(SerializeHelper.Serialize(new sWindowInfo() { localVideoWindow = localwdHandle.ToString(), remoteVideoWindow = remotewdHandle.ToString() })));
        }

        /// <summary>
        /// 监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmAgentId();
                dialog.Text = btnMonitor.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.Monitor(dialog.AgentInfo));
                }
            });
        }

        /// <summary>
        /// 强插
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBarge_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmAgentId();
                dialog.Text = btnBarge.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.Barge(dialog.AgentInfo));
                }
            });
        }

        /// <summary>
        /// 监听转强插
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMonitorToBarge_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmAgentId();
                dialog.Text = btnMonitorToBarge.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.MonitorToBarge(dialog.AgentInfo));
                }
            });
        }

        /// <summary>
        /// 监听转强拆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMonitorToSnatch_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmAgentId();
                dialog.Text = btnMonitorToSnatch.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.MonitorToForceRelease(dialog.AgentInfo));
                }
            });
        }

        private void btnSnatch_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmAgentId();
                dialog.Text = btnSnatch.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.ForceRelease(dialog.AgentInfo));
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSnatchPickup_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmAgentId();
                dialog.Text = btnSnatchPickup.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.SnatchPickup(dialog.AgentInfo));
                }
            });
        }

        private void btnQueryCallList_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new FrmQueryCallList(frmMainDeviceCallback, this);
                dialog.Show();
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPickup_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmId();
                dialog.Text = Helper.OperationToken.SelectPickup.ToString();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(dialog.Id))
                    {
                        this.PerformDeviceAction((device) => device.SelectPickup(new DialContent() { CallId = LastCallInPrivateQueue}));
                    }
                    else
                    {
                        this.PerformDeviceAction((device) => device.SelectPickup(new DialContent() { CallId = dialog.Id }));
                    }                    
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndConsultCall_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.EndConsultCall());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayRecordSeekTo_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                int nStep;
                string txtSeekTo = txtPlayRecordSeekTo.Text.Trim();
                if (string.IsNullOrEmpty(txtSeekTo))
                {
                    MsgBox.Info("Please input value");
                    return;
                }
                if (!int.TryParse(txtSeekTo, out nStep) || int.Parse(txtSeekTo) <= 0)
                {
                    MsgBox.Info("Please input positive number");
                    return;
                }
                this.PerformDeviceAction((device) => device.PlayRecordSeekTo(nStep));
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryAgentStatus_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmId();
                dialog.Text = Helper.OperationToken.QueryAgentStatus.ToString();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AgentInfo agentInfo = new AgentInfo();
                    agentInfo.AgentId = dialog.Id;
                    this.PerformDeviceAction((device) => device.QueryAgentStatus(agentInfo));
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryAllByGroupId_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                this.PerformDeviceAction((device) => device.QueryAllAgentStatus());
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryCurrentCallingScope_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryCurrentCallingScope());
        }

        /// <summary>
        /// 查询正在使用的无线设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntQueryUsingWirelessDevice_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryUsingWirelessDevice());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForceLogout_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmId();
                dialog.Text = Helper.OperationToken.ForceLogout.ToString();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AgentInfo agentInfo = new AgentInfo();
                    agentInfo.AgentId = dialog.Id;
                    this.PerformDeviceAction((device) => device.ForceLogout(agentInfo));
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitMeeting_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new CommonForm(this._meetingId, false);
                dialog.Text = btnExitMeeting.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.ExitMeeting(dialog.MettingId));
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransferMeetingMaster_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new CommonForm(this._meetingId, true);
                dialog.Text = btnTransferMeetingMaster.Text;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.TransferMeetingMaster(dialog.MettingId, dialog.OldMasterNumber, dialog.NewMasterNumber));
                }
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetRecordLength_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                string number = this.txtRecordId.Text.Trim();
                if (string.IsNullOrEmpty(number))
                {
                    MsgBox.Info("Please input record id.");
                    this.txtRecordId.Focus();
                    return;
                }
                this.PerformDeviceAction((device) => device.GetRecordLength(number));
            }, false);
        }

        /// <summary>
        /// 休息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRest_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new Rest(_device);
                this._restForm = dialog;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.Rest(dialog.RestTime, dialog.RestCode));
                }
                this._restForm = null;
            }, false);
        }

        //把查询的休息原因绑定到界面
        public void GetRestReasons(List<RestReason> listRestReason)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<List<RestReason>>(GetRestReasons), listRestReason);
                return;
            }
            if (this._restForm != null)
            {
                this._restForm.GetRestReasons(listRestReason);
            }
        }

        /// <summary>
        /// 取消休息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelRest_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.CancelRest());
        }

        /// <summary>
        /// 系统支持轮询呼叫多个人，第一个呼不通时，自动呼叫第二个，直至呼通其中的一个进入通话或全部呼不通为止。 支持10个用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPollingCall_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmPollingCall(true);
                dialog.Text = btnPollingCall.Text;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.PollingCall(dialog.dialContents, dialog.timeout));
                }
            });

        }

        /// <summary>
        /// 系统支持查询被屏蔽的电话黑名单数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryBlackList_Click(object sender, EventArgs e)
        {
            var dialog = new frmBlackList(false);
            dialog.Text = btnQueryBlackList.Text;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.QueryBlackList(dialog.PhoneNumber));
            }
        }

        /// <summary>
        /// 系统支持查询所有被屏蔽的电话黑名单数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryAllBlackList_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryAllBlackList());
        }

        /// <summary>
        /// 单步会议
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSingleStepMeeting_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmDial(true);
                dialog.Text = BtnSingleStepMeeting.Text;
                if (dialog.ShowDialog(true) == System.Windows.Forms.DialogResult.OK)
                {
                    var dialContent = dialog.DialContent;

                    this.PerformDeviceAction((device) => device.SingleStepMeeting(dialContent));
                }

            }, false);
        }

        /// <summary>
        /// 查询某个会议中所有会议成员
        /// </summary>
        /// <param name="meetingId">会议编号</param>
        private void btnQueryMeetingMembers_Click(object sender, EventArgs e)
        {
            var dialog = new CommonForm(this._meetingId, false);
            dialog.Text = btnQueryMeetingMembers.Text;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.QueryMeetingMembers(dialog.MettingId));
            }
        }

        /// <summary>
        /// 呼叫成功转移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSingleStepSuccTransfer_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmAgentId();
                dialog.Text = btnSingleStepSuccTransfer.Text;
                dialog.Tag = "SingleStepSuccTransfer";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.SingleStepSuccTransfer(dialog.AgentInfo.AgentId, dialog.AgentInfo.PhoneNumber));
                }
            });
        }

        //呼叫转技能队列
        private void btnTransferToSkillGroup_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmTransferToSkillGroup();
                dialog.Text = btnTransferToSkillGroup.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.TransferToSkillGroup(dialog.IsSuccTransfer, dialog.SkillID));
                }
            });
        }

        /// <summary>
        /// 改变座席密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeAgentPwd_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmChangePwd();
                dialog.Text = "Change Agent Pwd";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.ChangeAgentPwd(dialog.OldPw5, dialog.NewPw5));
                }
            }, false);
        }

        private void btnAddToRedList_Click(object sender, EventArgs e)
        {
            try
            {
                this.PerformAction(() =>
                {
                    var dialog = new frmAddRedList();
                    dialog.Text = btnAddToRedList.Text;
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.PerformDeviceAction((device) => device.AddToRedList(dialog.PhoneNumber, Convert.ToInt32(dialog.Priority)));
                    }
                }, false);
            }
            catch
            {
                this.WriteLog("AddToRedList.Exception");
            }

        }

        private void btnGetSendEmailIndex_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.GetSendEmailIndex());
        }

        //取消红名单
        private void btnRemoveFromRedList_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmBlackList(false);
                dialog.Text = btnRemoveFromRedList.Text;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.RemoveFromRedList(dialog.PhoneNumber));
                }
            }, false);
        }

        //移除所有红名单
        private void btnRemoveAllRedList_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.RemoveAllRedList());
        }

        //查询是否是优先级名单
        private void btnQueryRedList_Click(object sender, EventArgs e)
        {
            var dialog = new frmBlackList(false);
            dialog.Text = btnQueryRedList.Text;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.QueryRedList(dialog.PhoneNumber));
            }
        }

        //查询所有红名单
        private void btnQueryAllRedList_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryAllRedList());
        }

        /// <summary>
        /// 座席主动对外发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                this.PerformDeviceAction((device) => device.SendEmail(_userReceiverAddress, txtSkillID.Text.Trim(), txtIndex.Text.Trim() != "" ? Convert.ToInt32(txtIndex.Text.Trim()) : 0));

            }
            catch
            {
                this.WriteLog("SendEmail.Exception");
            }
            finally
            {
                txtIndex.Invoke(new Action(() => { txtIndex.Text = ""; }));
            }
        }

        /// <summary>
        /// 查询当前座席的Email配置参数信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryAgentCfgInfo_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryAgentEmailCfgInfo());
        }

        /// <summary>
        /// 接收邮件,在CccCtrl接续控件（VCL版）的事件OnEmailArrived(dwTime : DWORD; wDsn : WORD; bHandle : byte)中即可使用此方法接收相应的邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceiveMail_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = axActiveMailReply.ReceiveMail(Convert.ToInt32(txtulTime.Text.Trim()), Convert.ToInt32(txtusDsn.Text.Trim()), Convert.ToInt16(txtucHandle.Text.Trim()));
                this.WriteLog("ReceiveMail.result = {0}", result);
            }
            catch
            {
                this.WriteLog("ReceiveMail.Exception");
            }

        }

        /// <summary>
        /// 座席对收到的邮件呼叫进行回复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplyEmail_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.ReplyEmail());
        }

        /// <summary>
        /// 主动呼出后，Email控件会生成一个呼出序列号。此函数返回本次呼出的序列号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetCallOutNo_Click(object sender, EventArgs e)
        {
            this.txtIndex.Text = this.axActiveMailSend.GetCallOutNo().ToString();
            this.WriteLog("GetCallOutNo.CallOutNo = {0}", this.txtIndex.Text);
        }

        //发送短信
        private void btnSMS_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                string deviceId = txtDeviceId.Text.Trim();
                string phoneNumber = txtPhoneNumber.Text.Trim();
                string note = txtNote.Text.Trim();
                string mciIp = txtMciIp.Text.Trim();
                string mciPort = txtMciPort.Text.Trim();
                //判空
                if (string.IsNullOrEmpty(note) || string.IsNullOrEmpty(mciPort))
                {
                    MsgBox.Info("Please input values.");
                    return;
                }
                int ulSeqNo = 0;
                string txtUlSeqNo = txtulSeqNo.Text.Trim();
                if (!string.IsNullOrEmpty(txtUlSeqNo) && !int.TryParse(txtUlSeqNo, out ulSeqNo))
                {
                    ulSeqNo = -1;
                }
                this.PerformDeviceAction((device) => device.SendSMS(deviceId, phoneNumber, note, mciIp, mciPort, ulSeqNo));
            }, false);
        }

        List<frmReplySMS> listSMS = new List<frmReplySMS>();
        //新增短信、更新短信
        public void OnAddSMS(int mediaType, int CCBIdx, string callNumber, string receiveTime, string note)
        {
            lock (listSMS)
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new Action<int, int, string, string, string>(OnAddSMS), mediaType, CCBIdx, callNumber, receiveTime, note);
                    return;
                }

                bool isFind = false;
                foreach (frmReplySMS frmInfo in listSMS)
                {
                    if (frmInfo.callNumber.Equals(callNumber))
                    {
                        isFind = true;
                        frmInfo.UpdateSMS(receiveTime, mediaType, CCBIdx, callNumber, note);
                        break;
                    }
                }
                if (!isFind)
                {
                    frmReplySMS frm = new frmReplySMS(_device, mediaType, CCBIdx, receiveTime, callNumber, note);
                    frm.Show();
                    listSMS.Add(frm);
                }
            }
        }
        //关闭短息窗口
        public void OnCloseSMS(int mediaType, int CCBIdx)
        {
            lock (listSMS)
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new Action<int, int>(OnCloseSMS), mediaType, CCBIdx);
                    return;
                }
                foreach (frmReplySMS frmInfo in listSMS)
                {
                    if (frmInfo.mediaType.Equals(mediaType) && frmInfo.CCBIdx.Equals(CCBIdx))
                    {
                        frmInfo.Close();
                        listSMS.Remove(frmInfo);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 停止mail呼叫
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReleaseCallEx_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.ReleaseMailCall());
        }

        string _userReceiverAddress = "";
        private void btnUpdateMailConfig_Click(object sender, EventArgs e)
        {
            try
            {

                var dialog = new frmEmailConfig(this.axActiveMailReply.EMailPop3Server, this.axActiveMailReply.EMailSmtpServer, this.axActiveMailReply.EMailAddress
                    , this.axActiveMailReply.SendEMailAddress, this.axActiveMailReply.EMailUserName, this.axActiveMailSend.EMailPassWord, this.axActiveMailReply.PublicEMailAddress
                    , _userReceiverAddress);
                dialog.Text = btnUpdateMailConfig.Text;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.axActiveMailReply.EMailAddress = dialog.AgentReceiveAddress;
                    this.axActiveMailReply.EMailPassWord = dialog.AgentReceivePW5;
                    this.axActiveMailReply.EMailPop3Server = dialog.ReceiveServerIP;
                    this.axActiveMailReply.EMailSmtpServer = dialog.SendServerIP;
                    this.axActiveMailReply.EMailUserName = dialog.AgentReceiveUserName;
                    this.axActiveMailReply.PublicEMailAddress = dialog.PublicMailAddress;
                    this.axActiveMailReply.SendEMailAddress = dialog.AgentSendAddress;

                    this.axActiveMailSend.EMailAddress = dialog.AgentReceiveAddress;
                    this.axActiveMailSend.EMailPassWord = dialog.AgentReceivePW5;
                    this.axActiveMailSend.EMailPop3Server = dialog.ReceiveServerIP;
                    this.axActiveMailSend.EMailSmtpServer = dialog.SendServerIP;
                    this.axActiveMailSend.EMailUserName = dialog.AgentReceiveUserName;
                    this.axActiveMailSend.PublicEMailAddress = dialog.PublicMailAddress;
                    this.axActiveMailSend.SendEMailAddress = dialog.AgentSendAddress;

                    _userReceiverAddress = dialog.UserReceiverAddress;
                }
            }
            catch
            {
                MsgBox.Error("occur exception");
            }

            if (sender != null)
            {
                this.WriteLog("UpdateMailConfig");
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._device != null)
            {
                this.PerformDeviceAction((device) => device.UnInitializeAll());
            }
        }

        /// <summary>
        /// 设置通话后是否进入空闲状态属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutoEnterIdle_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.SetAutoEnterIdle(true));
        }
        //取消通话后自动进入空闲态
        private void btnClearAutoEnterIdle_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.SetAutoEnterIdle(false));
        }

        //停止工作态
        private void btnWorkStop_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.SetWorkStop(false));
        }
        //进入工作态
        private void btnWork_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.SetWorkStop(true));
        }
        /// <summary>
        /// 查询系统的技能队列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuerySkillGroups_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QuerySkillGroups());
        }

        //查询丢失的通话
        private void btnQueryLostCalls_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmQueryLostCalls(_device);
                dialog.Text = btnQueryLostCalls.Text;
                dialog.ShowDialog();
            }, false);
        }

        /// <summary>
        /// 查询所有系统接入码配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryTotalSysInno_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryAccessCodeList());
        }

        /// <summary>
        /// 外呼扩展
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDialEx_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmDial(true,true);
                dialog.Text = btnDialEx.Text;

                if (dialog.ShowDialog(true) == System.Windows.Forms.DialogResult.OK)
                {
                    var dialContent = dialog.DialContent;

                    this.PerformDeviceAction((device) => device.DialEx(dialContent, dialog.accessCode));
                }

            }, false);
        }

        /// <summary>
        /// 创建会议拓展
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateMeetingEx_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmCreateMeeting(true);
                dialog.Text = btnCreateMeetingEx.Text;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.CreateMeetingEx(dialog.DialContentList, dialog.accessCode));
                }
            }, false);
        }

        /// <summary>
        /// 轮询呼拓展
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPollingCallEx_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmPollingCall(true, true);
                dialog.Text = btnPollingCallEx.Text;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.PollingCallEx(dialog.dialContents, dialog.timeout, dialog.accessCode));
                }
            });
        }

        /// <summary>
        /// 接收邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReceiveEmail(string callId, string emailCallId, string receiveTime)
        {
            this.txtIndex.Invoke(new Action(() => { this.txtucHandle.Text = callId.ToString(); this.txtulTime.Text = receiveTime; this.txtusDsn.Text = emailCallId; }));
        }

        /// <summary>
        /// 获取发送的邮件索引号结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GetSendEmailIndexResult(string callId, int emailIndex, bool flag, int errorCode)
        {
            this.txtIndex.Invoke(new Action(() => { this.txtIndex.Text = emailIndex.ToString(); }));
        }

        private void btnAgentSendDTMF_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmId();
                dialog.Text = ConfigHelper.GetString("AgentSendDTMF");
                dialog.RecordID = "123|456|789";

                string[] recordIDs = null;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    if (String.IsNullOrEmpty(dialog.RecordID))
                    {
                        MessageBox.Show("Record ID is empty.", dialog.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    recordIDs = dialog.RecordID.Split('|');

                    foreach (var temp in recordIDs)
                    {
                        this.PerformDeviceAction((device) => device.AgentSendDTMF(temp));
                        Thread.Sleep(1000);
                    }
                }
            });
        }

        /// <summary>
        /// 设置自动应答
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetAutoAnswer_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.SetAutoAnswer(true));
        }

        /// <summary>
        /// 取消自动应答
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAutoAnswer_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.SetAutoAnswer(false));
        }

        /// <summary>
        /// 设置呼叫数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetCallData_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmId();
                dialog.Text = Helper.OperationToken.SetCallData.ToString();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var callData = dialog.Id;
                    this.PerformDeviceAction((device) => device.SetCallData(callData));
                }
            });
        }

        /// <summary>
        /// 查询呼叫数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryCallData_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryCallData());
        }

        /// <summary>
        /// 设置客户级别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetCustomerLevel_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmSetCustomerLevel();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.SetCustomerLevel(dialog.PhoneNumber, dialog.CustomerLevel));
                }
            });
        }

        /// <summary>
        /// 设置录音关联业务信息 add by xiezhengquan for AR. eSDK.001.001.001
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetCustomizedRecordInfo_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmSetCustomizedRecordInfo();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.SetCustomizedRecordInfo(dialog.RecordId, dialog.Data));
                }
            });
        }

        /// <summary>
        /// 查询IVR流程信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryIVRInfo_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryIVRInfo());
        }

        /// <summary>
        /// TransToIVR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransToIVR_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmTransToIVR();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.TransferToIVR(dialog.IsSuccTransfer, dialog.AccessCode));
                }
            });
        }

        /// <summary>
        /// QueryAgentIP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryAgentIP_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmId();
                dialog.Text = ConfigHelper.GetString("QueryAgentIP");
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AgentInfo agentInfo = new AgentInfo();
                    agentInfo.AgentId = dialog.Id;
                    this.PerformDeviceAction((device) => device.QueryAgentIP(agentInfo));
                }
            });
        }

        public int iCCBIdx = 0;
        /// <summary>
        /// TransferSMSToAgent 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmAgentId("TransferSMSToAgent");
                dialog.Text = ConfigHelper.GetString("TransferSMSToAgent");
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    iCCBIdx = Convert.ToInt32(dialog.AgentInfo.PhoneNumber);
                    this.PerformDeviceAction((device) => device.TransferSMSToAgent(Convert.ToInt32(dialog.AgentInfo.PhoneNumber), dialog.AgentInfo.AgentId));
                }
            });
        }

        /// <summary>
        /// 请求耳语
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWhisper_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmAgentId();
                dialog.Text = btnWhisper.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.Whisper(dialog.AgentInfo));
                }
            });
        }

        /// <summary>
        /// 停止质检
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopWhisper_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.SuperviseStop());
        }

        //质检切换
        private void btnSuperviseSwitch_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmSuperviseSwitch();
                dialog.Text = btnSuperviseSwitch.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.SuperviseSwitch(dialog.Type));
                }
            });
        }

        /// <summary>
        /// 查询骚扰电话记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryMaliciousCalls_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmId();
                dialog.Text = Helper.OperationToken.QueryMaliciousCalls.ToString();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var phoneNumber = dialog.Id;
                    this.PerformDeviceAction((device) => device.QueryMaliciousCalls(phoneNumber));
                }
            });
        }

        /// <summary>
        /// 查询队列状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuerySkillGroupStatus_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmId();
                dialog.Text = Helper.OperationToken.QuerySkillGroupStatus.ToString();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var groupId = dialog.Id;
                    this.PerformDeviceAction((device) => device.QuerySkillGroupStatus(groupId));
                }
            });
        }

        /// <summary>
        /// 查询座席技能配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryAgentSkillGroups_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmId();
                dialog.Text = Helper.OperationToken.QueryAgentSkillGroups.ToString();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var agentId = dialog.Id;
                    this.PerformDeviceAction((device) => device.QueryAgentSkillGroups(agentId));
                }
            });
        }

        /// <summary>
        /// 座席发送便签消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                //新建窗体
                var dialog = new frmSendMessage();
                dialog.Text = btnSendMessage.Text;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //目标工号
                    string agentId = dialog.agentId;
                    //便签消息
                    string message = dialog.message;
                    //调用SDK接口发送便签
                    this.PerformDeviceAction((device) => device.SendMessage(agentId, message));
                }
            });
        }

        //静音
        private void btnMute_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.Mute(true));
        }

        //取消静音
        private void btUnMute_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.Mute(false));
        }

        //查询当前非保持通话
        private void btnQueryCallInfo_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryCallInfo());
        }

        //查询座席CallId
        private void btnQueryCallIdOnAgent_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmId();
                dialog.Text = Helper.OperationToken.QueryCallIdOnAgent.ToString();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var agentId = dialog.Id;
                    this.PerformDeviceAction((device) => device.QueryCallIDOnAgent(agentId));
                }
            });
        }

        //把查询的技能队列绑定到界面
        public void GetAgentSkill(List<SkillGroup> listSkill)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<List<SkillGroup>>(GetAgentSkill), listSkill);
                return;
            }
            if (this._frmskill != null && null != listSkill && listSkill.Count > 0)
            {
                this._frmskill.ResetAgentSkill(listSkill);
            }
        }

        //重置技能队列
        private void btnResetAgentSkill_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmSkills(_device);
                this._frmskill = dialog;
                dialog.Text = btnResetAgentSkill.Text;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.ResetAgentSkillGroups(dialog.AgentID, dialog.Groups));
                }
                this._frmskill = null;
            }, false);
        }

        private void btnExitACW_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.ExitACW());
        }

        private void btnSubscribeAgentEvent_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                //新建窗体
                var dialog = new frmSubscribeEvent();
                dialog.Text = "SubscribeAgentEvent";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //目标工号
                    string agentId = dialog.agentId;
                    //事件类型
                    string eventType = dialog.eventType;
                    //调用SDK接口订阅事件
                    this.PerformDeviceAction((device) => device.SubscribeAgentEvent(agentId, eventType));
                }
            });
        }

        private void btnStopSubscribeAgentEvent_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                //新建窗体
                var dialog = new frmSubscribeEvent();
                dialog.Text = "StopSubscribeAgentEvent";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //目标工号
                    string agentId = dialog.agentId;
                    //事件类型
                    string eventType = dialog.eventType;
                    //调用SDK接口停止订阅事件
                    this.PerformDeviceAction((device) => device.StopSubscribeAgentEvent(agentId, eventType));
                }
            });
        }

        private void btnPickupVCCall_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.PickupVCCall());
        }

        private void btnHangupVCCall_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.HangupVCCall());
        }

        private void btnAddBlackListEx_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmBlackList(true, true);
                dialog.Text = btnAddBlackListEx.Text;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.AddToBlackListEx(dialog.PhoneNumber, dialog.LockTime, dialog.FilterMode));
                }
            }, false);
        }

        private void btnQueryBlackListEx_Click(object sender, EventArgs e)
        {
            var dialog = new frmBlackList(false);
            dialog.Text = btnQueryBlackListEx.Text;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.QueryBlackListEx(dialog.PhoneNumber));
            }
        }

        private void btnQueryAllBlackListEx_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.QueryAllBlackListEx());
        }

        private void btnDownloadRecord_Click(object sender, EventArgs e)
        {
            string fileStorePos = txtStorePath.Text;
            string fileDownloadPos = txtRecordPath.Text;
            this.PerformDeviceAction((device) =>
            {
                device.DownloadRecordFile(fileDownloadPos, fileStorePos, int.Parse(txtDownloadFormat.Text));
            });
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_PhoneAnswer_Click(object sender, EventArgs e)
        {
            frmAnswer frm = new frmAnswer();
            if (true == this.IsAudioCallout)
            {
                frm.lblCallType.Visible = false;
                frm.isVideo.Visible = false;
            }
            else
            {
                frm.isVideo.SelectedIndex = 0;
            }
            frm.Text = this.btn_PhoneAnswer.Text;
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            if (true == frm._isVideo)
            {
                if (string.IsNullOrEmpty(frm.CallId))
                {
                    this.PerformDeviceAction((device) => device.PhoneAnswerEx(SerializeHelper.Serialize(new PhoneAnswerParam() { callSessionId = this.callSessionID, isVideo = frm._isVideo })));
                }
                else
                {
                    this.PerformDeviceAction((device) => device.PhoneAnswerEx(SerializeHelper.Serialize(new PhoneAnswerParam() { callSessionId = frm.CallId, isVideo = frm._isVideo })));
                }
            }
            else
            {
                if (string.IsNullOrEmpty(frm.CallId))
                {
                    this.PerformDeviceAction((device) => device.PhoneAnswer(this.callSessionID));
                }
                else
                {
                    this.PerformDeviceAction((device) => device.PhoneAnswer(frm.CallId));
                }
            }
            
        }

        private void btn_PhoneHangup_Click(object sender, EventArgs e)
        {
            demoRelease = true;
            if (!string.IsNullOrEmpty(otherCall))
            {
                callSessionID = otherCall;
            }

            FrmHold frm = new FrmHold();
            frm.Text = this.btn_PhoneHangup.Text;
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            if (String.IsNullOrEmpty(frm.CallId))
            {
                this.PerformDeviceAction((device) => device.PhoneRelease(this.callSessionID));
            }
            else
            {
                this.PerformDeviceAction((device) => device.PhoneRelease(frm.CallId));
            }
        }

        private void btn_PhoneMute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(otherCall))
            {
                callSessionID = otherCall;
            }

            FrmHold frm = new FrmHold();
            frm.Text = this.btn_PhoneMute.Text;
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            
            if (String.IsNullOrEmpty(frm.CallId))
            {
                this.PerformDeviceAction((device) => device.PhoneMute(this.callSessionID, true));
            }
            else
            {
                this.PerformDeviceAction((device) => device.PhoneMute(frm.CallId, true));
            }
            
        }

        private void btn_PhoneUnmute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(otherCall))
            {
                callSessionID = otherCall;
            }

            FrmHold frm = new FrmHold();
            frm.Text = this.btn_PhoneMute.Text;
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            if (String.IsNullOrEmpty(frm.CallId))
            {
                this.PerformDeviceAction((device) => device.PhoneMute(this.callSessionID, false));
            }
            else
            {
                this.PerformDeviceAction((device) => device.PhoneMute(frm.CallId, false));
            }
        }

        private void btn_SwitchAidDevice_Click(object sender, EventArgs e)
        {
            FrmHold frm = new FrmHold();
            frm.Text = btn_SwitchAidDevice.Text;
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(frm.CallId))
                {
                    //若辅助声卡有通话则先将辅助声卡的通话切换到主声卡
                    if (this.IsTalkingOnAidDevice)
                    {
                        this.PerformDeviceAction((device) => device.PhoneSwitchSoundDevice(this.CallSessionIDOnAidDevice, false));
                        //this.m_ToBeSwitchedCallInfo.UpdateToBeSwitchedCallInfo(frm.CallId, true);
                    }
                    else
                    {
                        this.PerformDeviceAction((device) => device.PhoneSwitchSoundDevice(frm.CallId, true));
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(otherCall))
                    {
                        callSessionID = otherCall;
                    }

                    //若辅助声卡有通话则先将辅助声卡的通话切换到主声卡
                    if (this.IsTalkingOnAidDevice)
                    {
                        this.PerformDeviceAction((device) => device.PhoneSwitchSoundDevice(this.CallSessionIDOnAidDevice, false));
                        //this.m_ToBeSwitchedCallInfo.UpdateToBeSwitchedCallInfo(this.callSessionID, true);
                    }
                    else
                    {
                        this.PerformDeviceAction((device) => device.PhoneSwitchSoundDevice(this.callSessionID, true));

                    }  
                }
            }            
        }

        private void btn_SwitchMainDevice_Click(object sender, EventArgs e)
        {
            FrmHold frm = new FrmHold();
            frm.Text = btn_SwitchMainDevice.Text;
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(frm.CallId))
                {
                    this.PerformDeviceAction((device) => device.PhoneSwitchSoundDevice(frm.CallId, false));
                }
                else
                {
                    if (!string.IsNullOrEmpty(otherCall))
                    {
                        callSessionID = otherCall;
                    }

                    this.PerformDeviceAction((device) => device.PhoneSwitchSoundDevice(this.callSessionID, false));
                }
            }
        }

        private void btn_GetSoundDevice_Click(object sender, EventArgs e)
        {
            try
            {
                frmGetSoundDevice soundDevice = new frmGetSoundDevice();

                soundDevice.StartPosition = FormStartPosition.CenterParent;
                soundDevice.Text = this.btn_GetSoundDevice.Text;

                if (soundDevice.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.PhoneGetSoundDevice(soundDevice.radioButton_Input.Checked));
                }
            }
            catch
            {
                WriteLog("Occur Exception.");
            }
        }

        private void btn_SetSoundDevice_Click(object sender, EventArgs e)
        {
            try
            {
                frmSetSoundDevice soundDevice = new frmSetSoundDevice();

                soundDevice.StartPosition = FormStartPosition.CenterParent;
                soundDevice.Text = this.btn_SetSoundDevice.Text;

                if (soundDevice.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.PhoneSetSoundDevice(soundDevice.radioButton_Input.Checked, soundDevice.textBox_DeviceIndex.Text.Trim()));
                }
            }
            catch
            {
                WriteLog("Occur exception.");
            }
        }

        private void btn_GetVolume_Click(object sender, EventArgs e)
        {
            frmGetSoundDevice soundDevice = new frmGetSoundDevice();

            soundDevice.StartPosition = FormStartPosition.CenterParent;
            soundDevice.Text = this.btn_GetVolume.Text;

            if (soundDevice.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.PhoneGetVolume(soundDevice.IsInput));
            }
        }

        private void btn_SetVolume_Click(object sender, EventArgs e)
        {
            try
            {
                frmVolume setVolume = new frmVolume();

                setVolume.StartPosition = FormStartPosition.CenterParent;
                setVolume.Text = this.btn_SetVolume.Text;

                if (setVolume.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.PhoneSetVolume(setVolume.IsInput, setVolume.VolumeValue));
                }
            }
            catch
            {
                WriteLog("Occur exception.");
            }
        }

        private void btn_PhoneUninit_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.PhoneUnInitialize());

            callSessionID = string.Empty;
            holdedCallSessionID = string.Empty;
        }

        private void btn_Init_Click(object sender, EventArgs e)
        {
            var phoneSettings = this._phoneConfig;
            var localInfo = new LocalInfo();
            Int32 temp = 0;
            string phoneNumber = string.Empty;
            string phonePassword = string.Empty;
            string phoneSipserverInfo = string.Empty;

            if (phoneSettings.ContainsKey("LocalAudioPort"))
            {
                if (Int32.TryParse(phoneSettings["LocalAudioPort"], out temp))
                {
                    localInfo.LocalAudioPort = temp;
                }

            }

            if (phoneSettings.ContainsKey("LocalSipPort"))
            {
                if (Int32.TryParse(phoneSettings["LocalSipPort"], out temp))
                {
                    localInfo.LocalSipPort = temp;
                }

            }

            if (phoneSettings.ContainsKey("LocalIP"))
            {
                if (phoneSettings["LocalIP"] != null)
                {
                    localInfo.LocalIp = phoneSettings["LocalIP"];
                }

            }

            DeviceInfo deviceInfo = new DeviceInfo();
            string tempDictionaryValue = null;

            if (phoneSettings.TryGetValue("IsAidEnable", out tempDictionaryValue))
            {
                deviceInfo.isAidEnable = (tempDictionaryValue == "true") ? true : false;

                this._isEnableAidDevice = (tempDictionaryValue == "true") ? true : false;
            }

            if (phoneSettings.TryGetValue("MainSpeaker", out tempDictionaryValue))
            {
                deviceInfo.mainSpeakerDeviceName = tempDictionaryValue;
            }

            if (phoneSettings.TryGetValue("MainMic", out tempDictionaryValue))
            {
                deviceInfo.mainMicrophoneDeviceName = tempDictionaryValue;
            }

            if (phoneSettings.TryGetValue("AidSpeaker", out tempDictionaryValue))
            {
                deviceInfo.aidSpeakerDeviceName = tempDictionaryValue;
            }

            if (phoneSettings.TryGetValue("AidMic", out tempDictionaryValue))
            {
                deviceInfo.aidMicrophoneDeviceName = tempDictionaryValue;
            }

            if (phoneSettings.TryGetValue("VideoDevice", out tempDictionaryValue))
            {
                deviceInfo.videoDeviceName = tempDictionaryValue;
            }

            if (phoneSettings.TryGetValue("AidPolicy", out tempDictionaryValue))
            {
                if ("default" == tempDictionaryValue)
                {
                    deviceInfo.newCallToAidPolicy = string.Empty;
                }
                else
                {
                    deviceInfo.newCallToAidPolicy = tempDictionaryValue;
                } 
            }

            SettingsInfo settingsInfo = new SettingsInfo();
            if (phoneSettings.TryGetValue("IsAutoAnswerIPCC", out tempDictionaryValue))
            {
                settingsInfo.isAutoAnswerIPCC = (tempDictionaryValue == "true") ? true : false;
            }
            if (phoneSettings.TryGetValue("IsAutoAnswerIPT", out tempDictionaryValue))
            {
                settingsInfo.isAutoAnswerIPT = (tempDictionaryValue == "true") ? true : false;
            }

            if (phoneSettings.TryGetValue("SipRealName", out tempDictionaryValue))
            {
                settingsInfo.sipDomain = tempDictionaryValue;
            }

            if (phoneSettings.TryGetValue("DispatchNumber", out tempDictionaryValue))
            {
                settingsInfo.phoneNum = tempDictionaryValue;
            }

            if (phoneSettings.TryGetValue("IsRejectCallAgentNotIdle", out tempDictionaryValue))
            {
                settingsInfo.isRejectCallAgentNotIdle = (tempDictionaryValue == "true") ? true : false;
            }
            var phoneUsedMode = PhoneUsedMode.PhoneEmbeddedMode;
            if (phoneSettings.TryGetValue("PhoneUsedMode", out tempDictionaryValue))
            {
                phoneUsedMode = (tempDictionaryValue == "PhoneEmbeddedMode") ? PhoneUsedMode.PhoneEmbeddedMode : PhoneUsedMode.PhoneLinkedMode;
            }

            if (phoneSettings.TryGetValue("PhoneNumber", out tempDictionaryValue))
            {
                phoneNumber = tempDictionaryValue;
            }

            if (phoneSettings.TryGetValue("PhonePassword", out tempDictionaryValue))
            {
                phonePassword = tempDictionaryValue;
            }

            if (phoneSettings.TryGetValue("SipServerInfo", out tempDictionaryValue))
            {
                phoneSipserverInfo = tempDictionaryValue;
            }

            this.OnSetVideoWindow();

            this.PerformDeviceAction((device) => device.PhoneInitialize(phoneUsedMode, phoneNumber, phonePassword, phoneSipserverInfo, frmMainDeviceCallback.Serialize(deviceInfo), localInfo, frmMainDeviceCallback.Serialize(settingsInfo)));
        }

        private void btn_GetVolumeGain_Click(object sender, EventArgs e)
        {
            frmGetSoundDevice soundDeivce = new frmGetSoundDevice();

            soundDeivce.StartPosition = FormStartPosition.CenterParent;
            soundDeivce.Text = this.btn_GetVolumeGain.Text;

            if (soundDeivce.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.PhoneGetVolumeGainByCall(this.callSessionID, soundDeivce.IsInput));
            }
        }

        private void btn_SetVolumeGain_Click(object sender, EventArgs e)
        {
            frmVolume soundDevice = new frmVolume();

            soundDevice.StartPosition = FormStartPosition.CenterParent;
            soundDevice.Text = this.btn_SetVolumeGain.Text;
            soundDevice.numericUpDown_Volume.Maximum = 10;

            if (soundDevice.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.PhoneSetVolumeGainByCall(this.callSessionID, soundDevice.IsInput, soundDevice.VolumeValue));
            }
        }

        private void btn_GetDeviceVolume_Click(object sender, EventArgs e)
        {
            FrmGetVolume soundDevice = new FrmGetVolume();

            soundDevice.StartPosition = FormStartPosition.CenterParent;
            soundDevice.Text = this.btn_GetDeviceVolume.Text;
            if (soundDevice.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.PhoneGetDeviceVolume(soundDevice.IsInput, soundDevice.IsAidDvice ? AudioDeviceType.AidDevice : AudioDeviceType.MainDevice));
            }
        }

        private void btn_SetDeviceVolume_Click(object sender, EventArgs e)
        {
            FrmSetVolume soundDevice = new FrmSetVolume();

            soundDevice.StartPosition = FormStartPosition.CenterParent;
            soundDevice.Text = this.btn_SetDeviceVolume.Text;
            if (soundDevice.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.PhoneSetDeviceVolume(soundDevice.IsInput, soundDevice.VolumeValue, soundDevice.IsAidDevice ? AudioDeviceType.AidDevice : AudioDeviceType.MainDevice));
            }
        }

        private void btn_LogoutUportal_Click(object sender, EventArgs e)
        {
            new Task(() =>
            {
                this.PerformDeviceAction((device) => device.LogoutFromUPortal());
            }).Start(); 
        }

        private void btn_TalkingGroupQuery_Click(object sender, EventArgs e)
        {
            frmQueryTalkingGroupInfo groupInfo = new frmQueryTalkingGroupInfo();

            groupInfo.StartPosition = FormStartPosition.CenterParent;
            groupInfo.Text = this.btn_TalkingGroupQuery.Text;
            groupInfo.TalkingGroupID = "123|456|789";
            groupInfo.PageNumber = "123|456|789";
            groupInfo.hideGroupID();
            groupInfo._attachMouseClickEvent();
  
            //如果未点击确定，则直接返回。
            if (groupInfo.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            //查询类型判断
            if((groupInfo.QueryType !=1) && (groupInfo.QueryType != 2) && (groupInfo.QueryType!=3))
            {
                MessageBox.Show("Error Querytype.", this.btn_TalkingGroupQuery.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //若device为空，则直接返回
            if (this._device == null)
            {
                return;
            }

            string _taskId = string.Empty;

            if (groupInfo.QueryType == 2)
            {
                //如果传的GroupId为空，则直接调用接口，然后返回。
                if (string.IsNullOrWhiteSpace(groupInfo.TalkingGroupID))
                {
                    _taskId = this._device.TalkingGroupQuery(groupInfo.QueryType, 1, groupInfo.TalkingGroupID);
                    WriteLog("TalkingGroupQuery taskId={0}", _taskId);

                    return;
                }

                //该接口支持并发调用，若输入超过一个群组号，则多次调用。
                foreach (string _tempId in groupInfo.TalkingGroupID.Trim().Split('|'))
                {
                    _taskId = this._device.TalkingGroupQuery(groupInfo.QueryType, 1, _tempId.Trim());
                    WriteLog("TalkingGroupQuery taskId={0}", _taskId);
                }
            }
            else
            {
                //如果传的GroupId为空，则直接调用接口，然后返回。
                if (string.IsNullOrWhiteSpace(groupInfo.PageNumber))
                {
                    _taskId = this._device.TalkingGroupQuery(groupInfo.QueryType, groupInfo.CountPerPage, groupInfo.PageNumber);
                    WriteLog("TalkingGroupQuery taskId={0}", _taskId);

                    return;
                }

                //该接口支持并发调用，若输入超过一个群组号，则多次调用。
                foreach (string _tempId in groupInfo.PageNumber.Trim().Split('|'))
                {
                    _taskId = this._device.TalkingGroupQuery(groupInfo.QueryType, groupInfo.CountPerPage, _tempId.Trim());
                    WriteLog("TalkingGroupQuery taskId={0}", _taskId);
                }
            }     
        }

        private void btn_UportalLogin_Click(object sender, EventArgs e)
        {
            frmUportalLogin uportalLogin = new frmUportalLogin(this);

            uportalLogin.StartPosition = FormStartPosition.CenterParent;
            uportalLogin.Text = this.btn_UportalLogin.Text;
            if (uportalLogin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!uportalLogin.ServerIP.StartsWith("https"))
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;

                    //默认情况下，如MessageBox.Show("确定要退出吗？")只显示一个“确定”按钮。
                    DialogResult dr = MessageBox.Show(ConfigHelper.GetString("HttpAlarm"), "Message", messButton);

                    if (dr != DialogResult.OK)//如果点击“确定”按钮
                    {
                        return;
                    }

                }
                ConfigHelper config = new ConfigHelper();
                config.AgentInfo = this._agentInfo;
                config.Settings = this._settings;
                config.PhoneSettings = this._phoneConfig;
                config.UportalSettings = this._uportalConfig;
                config.Save();

                this.PerformDeviceAction((device) => device.LoginToUPortal(uportalLogin.ServerIP, uportalLogin.Account, uportalLogin.Password, uportalLogin.PhoneNumber));
            }
        }

        private void btn_QueryGrupState_Click(object sender, EventArgs e)
        {
            frmTalkingGroupState groupState = new frmTalkingGroupState();
            groupState.TalkingGroupID = "123|456|789";
            groupState.HideExpire();
            groupState.StartPosition = FormStartPosition.CenterParent;
            groupState.Text = this.btn_QueryGrupState.Text;


            if (groupState.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string _taskId = string.Empty;
                /*if (this._device != null)
                {
                    _taskId = this._device.TalkingGroupQueryState(groupState.TalkingGroupID);                
                }*/
                if (this._device != null)
                {
                    foreach (string _tempId in groupState.TalkingGroupID.Trim().Split('|'))
                    {
                        _taskId = this._device.TalkingGroupQueryState(_tempId.Trim());
                        WriteLog("TalkingGroupQueryState taskId={0}", _taskId);
                    }
                }
            }
        }

        private void btn_AddTalking_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupConfig frm = new frmTalkingGroupConfig(talkingGroup);
                frm.Text = this.btn_AddTalking.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {                    
                    talkingGroup.talkGroupName = frm.TalkGroupName;
                    talkingGroup.talkGroupNumber = frm.TalkGroupNumber;
                    talkingGroup.talkGroupType = frm.TalkGroupType;
                    if (frm.RadioNumber == null)
                    {
                        talkingGroup.radioGroupNumber = new List<string>();
                    }
                    else
                    {
                        talkingGroup.radioGroupNumber = frm.RadioNumber;
                    }
                    if (frm.DispatchNumber == null)
                    {
                        talkingGroup.dispatchNumber = new List<string>();
                    }
                    else
                    {
                        talkingGroup.dispatchNumber = frm.DispatchNumber;
                    }
                    if (frm.OtherUserNumber == null)
                    {
                        talkingGroup.otherUserNumber = new List<string>();
                    }
                    else
                    {
                        talkingGroup.otherUserNumber = frm.OtherUserNumber;
                    }
                    
                    talkingGroup.talkGroupDesc = frm.TalkGroupDesc;
                    talkingGroup.receiveOnly = frm.ReceiveOnly.ToString().ToLower();
                    talkingGroup.pttTimeoutInterval = Int16.Parse(frm.pttTimeoutInterval);
                    talkingGroup.noPttTimeoutInterval = Int16.Parse(frm.noPttTimeoutInterval);
                    talkingGroup.radioToRadio = frm.RadioToRadio.ToString().ToLower();
                    talkingGroup.configureUser = frm.isConfigUser.ToString().ToLower();

                    string _taskId = string.Empty;
                    if (this._device != null)
                    {
                        _taskId = this._device.TalkingGroupAdd(talkingGroup);
                    }
                    WriteLog("TalkingGroupAdd taskId={0}", _taskId);
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_ModifyGroup_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupConfig frm = new frmTalkingGroupConfig(talkingGroup);
                frm.Text = this.btn_ModifyGroup.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    talkingGroup.talkGroupName = frm.TalkGroupName;
                    talkingGroup.talkGroupNumber = frm.TalkGroupNumber;
                    talkingGroup.talkGroupType = frm.TalkGroupType;
                    if (frm.RadioNumber == null)
                    {
                        talkingGroup.radioGroupNumber = new List<string>();
                    }
                    else
                    {
                        talkingGroup.radioGroupNumber = frm.RadioNumber;
                    }
                    if (frm.DispatchNumber == null)
                    {
                        talkingGroup.dispatchNumber = new List<string>();
                    }
                    else
                    {
                        talkingGroup.dispatchNumber = frm.DispatchNumber;
                    }
                    if (frm.OtherUserNumber == null)
                    {
                        talkingGroup.otherUserNumber = new List<string>();
                    }
                    else
                    {
                        talkingGroup.otherUserNumber = frm.OtherUserNumber;
                    }
                    talkingGroup.talkGroupDesc = frm.TalkGroupDesc;
                    talkingGroup.receiveOnly = frm.ReceiveOnly.ToString().ToLower();
                    talkingGroup.pttTimeoutInterval = Int16.Parse(frm.pttTimeoutInterval);
                    talkingGroup.noPttTimeoutInterval = Int16.Parse(frm.noPttTimeoutInterval);
                    talkingGroup.radioToRadio = frm.RadioToRadio.ToString().ToLower();
                    talkingGroup.configureUser = frm.isConfigUser.ToString().ToLower();

                    string _taskId = string.Empty;
                    if (this._device != null)
                    {
                        _taskId = this._device.TalkingGroupModify(talkingGroup);
                    }
                    WriteLog("TalkingGroupModify taskId={0}", _taskId);
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_DeleteTakling_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();
                frm.HideExpire();
                frm.Text = this.btn_DeleteTakling.Text;
                frm.TalkingGroupID = "123|456|789";
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string _taksId = string.Empty;
                    if (this._device != null)
                    {
                        //_taksId = this._device.TalkingGroupDelete(frm.TalkingGroupID);
                        foreach (string _tempId in frm.TalkingGroupID.Trim().Split('|'))
                        {
                            _taksId = this._device.TalkingGroupDelete(_tempId.Trim());
                            WriteLog("TalkingGroupDelete taskId={0}", _taksId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_RadioGroupQuery_Click(object sender, EventArgs e)
        {
            try
            {
                frmQueryTalkingGroupInfo frm = new frmQueryTalkingGroupInfo();
                frm.Text = this.btn_RadioGroupQuery.Text;
                frm.PageNumber = "123|456|789";
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.hideGroupID();
                frm.attachMouseClickEvent();

                //如果未点击确定，则直接返回。
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                if ((frm.QueryType != 1) && (frm.QueryType != 2))
                {
                    MessageBox.Show("Error Querytype.", this.btn_RadioGroupQuery.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //若device为空，则直接返回
                if (this._device == null)
                {
                    return;
                }

                string _taskId = string.Empty;
                //如果传的GroupId为空，则直接调用接口，然后返回。
                if (String.IsNullOrWhiteSpace(frm.PageNumber))
                {
                    _taskId = this._device.RadioGroupQuery(frm.QueryType, frm.CountPerPage, frm.PageNumber);
                    WriteLog("RadioGroupQuery taskId={0}", _taskId);

                    return;
                }

                //该接口支持并发调用，若输入超过一个群组号，则多次调用。
                foreach (string _tempId in frm.PageNumber.Trim().Split('|'))
                {
                    _taskId = this._device.RadioGroupQuery(frm.QueryType, frm.CountPerPage, _tempId.Trim());
                    WriteLog("RadioGroupQuery taskId={0}", _taskId);
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_TalkingGroupSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();

                frm.Text = this.btn_TalkingGroupSubscribe.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.TalkingGroupID = "123|456|789";

                //如果未点击确定，则直接返回。
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                //若device为空，则直接返回
                if (this._device == null)
                {
                    return;
                }

                string _taskId = string.Empty;
                //如果传的GroupId为空，则直接调用接口，然后返回。
                if (String.IsNullOrWhiteSpace(frm.TalkingGroupID))
                {
                    _taskId = this._device.TalkingGroupSubscribe(frm.Expire, frm.TalkingGroupID);
                    WriteLog("TalkingGroupSubscribe taskId={0}", _taskId);

                    return;
                }

                //该接口支持并发调用，若输入超过一个群组号，则多次调用。
                foreach (string _tempId in frm.TalkingGroupID.Split('|'))
                {
                    _taskId = this._device.TalkingGroupSubscribe(frm.Expire, _tempId.Trim());
                    WriteLog("TalkingGroupSubscribe taskId={0}", _taskId);
                }
                
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_GroupMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();

                frm.HideExpire();
                frm.ShowAutoSubscribe();
                frm.Text = this.btn_GroupMonitor.Text;
                //frm.TalkingGroupID = "123|456|789";
                frm.StartPosition = FormStartPosition.CenterParent;

                //如果未点击确定，则直接返回。
                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                if (!string.IsNullOrEmpty(callSessionID) && callSessionID != "0" && string.IsNullOrEmpty(otherCall))
                {
                    otherCall = callSessionID;
                }

                //若device为空，则直接返回
                if (this._device == null)
                {
                    return;
                }

                string _taskId = string.Empty;
                //如果传的GroupId为空，则直接调用接口，然后返回。
                if (string.IsNullOrWhiteSpace(frm.TalkingGroupID))
                {
                    if (frm.radioButton_defualt.Checked)
                    {
                        _taskId = this._device.TalkingGroupMonitor(frm.TalkingGroupID, true);
                    }
                    else
                    {
                        _taskId = this._device.TalkingGroupMonitor(frm.TalkingGroupID, true, frm.IsAutoSubscribe);
                    }
                    
                    WriteLog("TalkingGroupMonitor taskId={0}", _taskId);

                    return;
                }

                //如果自动订阅为默认值，则接传入默认值
                if (frm.radioButton_defualt.Checked)
                {
                    //该接口支持并发调用，若输入超过一个群组号，则多次调用。
                    foreach (string _tempId in frm.TalkingGroupID.Split('|'))
                    {
                        _taskId = this._device.TalkingGroupMonitor(_tempId.Trim(), true);
                        WriteLog("TalkingGroupMonitor taskId={0}", _taskId);
                    }
                }
                else
                {
                    //该接口支持并发调用，若输入超过一个群组号，则多次调用。
                    foreach (string _tempId in frm.TalkingGroupID.Split('|'))
                    {
                        _taskId = this._device.TalkingGroupMonitor(_tempId.Trim(), true, frm.radioButton_True.Checked);
                        WriteLog("TalkingGroupMonitor taskId={0}", _taskId);
                    }
                }

                this.MonitorTalkingGroupId = frm.TalkingGroupID;
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_GroupSelect_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();
                frm.HideExpire();
                frm.Text = this.btn_GroupSelect.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //在进行select之前，若辅助声卡上通话则把通话切换到主声卡
                    if (this.IsTalkingOnAidDevice && this.IsEnableAidDevice && (!this.HasSelectedGroupTalking))
                    {
                        this.PerformDeviceAction((device) => device.PhoneSwitchSoundDevice(this.CallSessionIDOnAidDevice, false));

                        this.GoingToGroupTalkingSelectId = frm.TalkingGroupID;
                    }
                    else
                    {
                        string _taskId = string.Empty;
                        if (this._device != null)
                        {
                            _taskId = this._device.TalkingGroupSelect(frm.TalkingGroupID, true);
                        }

                        this.GoingToGroupTalkingSelectId = string.Empty;
                    }                   
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_GroupPTT_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();
                frm.HideExpire();
                frm.Text = this.btn_GroupPTT.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string _taskId = string.Empty;
                    if (this._device != null)
                    {
                        _taskId = this._device.TalkingGroupPTT(frm.TalkingGroupID, true);
                    }
                    WriteLog("TalkingGroupPTT taskId={0}", _taskId);
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_TalkingGroupGetCallInfo_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();
                frm.HideExpire();
                frm.Text = this.btn_TalkingGroupGetCallInfo.Text;
                frm.TalkingGroupID = "123|456|789";
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string _taskId = string.Empty;
                    if (this._device != null)
                    {
                        foreach (string _tempId in frm.TalkingGroupID.Split('|'))
                        {
                            _taskId = this._device.TalkingGroupGetCallInfo(_tempId.Trim());
                            WriteLog("TalkingGroupGetCallInfo taskId={0}", _taskId);
                        }
                      // _taskId = this._device.TalkingGroupGetCallInfo(frm.TalkingGroupID);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_MixedGroupCallStart_Click(object sender, EventArgs e)
        {
            try
            {
                frmMixedGroupConfig frm = new frmMixedGroupConfig();
                frm.Text = this.btn_MixedGroupCallStart.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.HideMute();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MixedGroupUserInfoList usersList = new MixedGroupUserInfoList();
                    string userStr = string.IsNullOrWhiteSpace(frm.Users) ? "{\"users\":[]}" : frm.Users;
                    usersList = BaseServiceHelper.Deserialize<MixedGroupUserInfoList>(userStr);
                    if (!string.IsNullOrEmpty(callSessionID) && callSessionID != "0" && string.IsNullOrEmpty(otherCall))
                    {
                        otherCall = callSessionID;
                    }
                    string _taskId = string.Empty;
					if (this._device != null)
					{
	                    foreach (string _tempId in frm.GroupId.Split('|'))
	                    {
	                        _taskId = this._device.MixedGroupCallStart(_tempId.Trim(), usersList.users);
	                        WriteLog("MixedGroupCallStart taskId={0}", _taskId);
	                    }
					}
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_MixedGroupCallEnd_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();
                frm.HideExpire();
                frm.Text = this.btn_MixedGroupCallEnd.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string _taskId = string.Empty;
                    if (this._device != null) 
                    {
                        foreach (string _tempId in frm.TalkingGroupID.Split('|'))
                        {
                            _taskId = this._device.MixedGroupCallEnd(_tempId.Trim());
                            WriteLog("MixedGroupCallEnd taskId={0}", _taskId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_MixedGroupChangeUserState_Click(object sender, EventArgs e)
        {
            try
            {
                frmMixedGroupUserStateConfig frm = new frmMixedGroupUserStateConfig();
                frm.Text = this.btn_MixedGroupChangeUserState.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MixedGroupUserInfoList usersList = new MixedGroupUserInfoList();
                    if (frm.IsSingleUser)
                    {
                        MixedGroupUserState userState = new MixedGroupUserState();
                        userState = frmMainDeviceCallback.Deserialize<MixedGroupUserState>(frm.SingleUser);
                        //usersList = AD.BaseServiceHelper.Deserialize<MixedGroupUserInfoList>(frm.SingleUser);
                        usersList.users = new List<MixedGroupUserState>();
                        usersList.users.Add(userState);
                    }
                    else
                    {
                        usersList = frmMainDeviceCallback.Deserialize<MixedGroupUserInfoList>(frm.MuiltUsers);
                    }

                    string _taskId = string.Empty;
                    if (this._device != null)
                    {
                        _taskId = this._device.MixedGroupChangeUserState(frm.GroupId, usersList.users);
                    }
                    WriteLog("MixedGroupChangeUserState taskId={0}", _taskId);
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void button_GroupDesubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();

                frm.HideExpire();
                frm.Text = this.btn_TalkingGroupSubscribe.Text;
                frm.TalkingGroupID = "123|456|789";
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                if (this._device == null)
                {
                    return;
                }

                string _taskId = string.Empty;
                if (string.IsNullOrWhiteSpace(frm.TalkingGroupID))
                {
                    _taskId = this._device.TalkingGroupSubscribe(0, frm.TalkingGroupID);
                    WriteLog("TalkingGroupSubscribe taskId={0}", _taskId);

                    return;
                }

                foreach (string _tempId in frm.TalkingGroupID.Split('|'))
                {
                    _taskId = this._device.TalkingGroupSubscribe(0, _tempId.Trim());
                    WriteLog("TalkingGroupSubscribe taskId={0}", _taskId);
                }
                
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void buttonGroupDemonitor_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();

                frm.HideExpire();
                frm.ShowAutoSubscribe();
                frm.Text = this.btn_GroupMonitor.Text;
                //frm.TalkingGroupID = "123|456|789";
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                if (!string.IsNullOrEmpty(callSessionID) && callSessionID != "0" && string.IsNullOrEmpty(otherCall))
                {
                    otherCall = callSessionID;
                }

                if (this._device == null)
                {
                    return;
                }

                string _taskId = string.Empty;

                if (string.IsNullOrWhiteSpace(frm.TalkingGroupID))
                {
                    //如果自动订阅为默认值，则使用接口默认参数
                    if (frm.radioButton_defualt.Checked)
                    {
                        _taskId = this._device.TalkingGroupMonitor(frm.TalkingGroupID, false);
                    }
                    else
                    {
                        _taskId = this._device.TalkingGroupMonitor(frm.TalkingGroupID, false, frm.IsAutoSubscribe);
                    }
                    
                    WriteLog("TalkingGroupMonitor taskId={0}", _taskId);

                    return;
                }

                //如果自动订阅为默认值，则使用接口默认参数
                if (frm.radioButton_defualt.Checked)
                {
                    foreach (string _tempId in frm.TalkingGroupID.Split('|'))
                    {
                        _taskId = this._device.TalkingGroupMonitor(_tempId.Trim(), false);
                        WriteLog("TalkingGroupMonitor taskId={0}", _taskId);
                    }
                }
                else
                {
                    foreach (string _tempId in frm.TalkingGroupID.Split('|'))
                    {
                        _taskId = this._device.TalkingGroupMonitor(_tempId.Trim(), false, frm.radioButton_True.Checked);
                        WriteLog("TalkingGroupMonitor taskId={0}", _taskId);
                    }
                }
                
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void button_GroupDeselect_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();
                frm.HideExpire();
                frm.Text = this.btn_GroupSelect.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string _taskId = string.Empty;
                    if (this._device != null)
                    {
                        _taskId = this._device.TalkingGroupSelect(frm.TalkingGroupID, false);
                    }
                    WriteLog("TalkingGroupSelect taskId={0}", _taskId);
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_GroupDePTT_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupState frm = new frmTalkingGroupState();
                frm.HideExpire();
                frm.Text = this.btn_GroupDePTT.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string _taskId = string.Empty;
                    if (this._device != null)
                    {
                        _taskId = this._device.TalkingGroupPTT(frm.TalkingGroupID, false);
                    }
                    WriteLog("TalkingGroupPTT taskId={0}", _taskId);
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_GetConfig_Click(object sender, EventArgs e)
        {
            Form_Config frm = new Form_Config();
            frm.Text = this.btn_GetConfig.Text;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.HideConfigValue();

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.GetConfig(frm.ConfigKey));
            }
        }

        private void btn_SetConfig_Click(object sender, EventArgs e)
        {
            Form_Config frm = new Form_Config();
            frm.Text = this.btn_SetConfig.Text;
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.PerformDeviceAction((device) => device.SetConfig(frm.ConfigKey, frm.ConfigValue));
            }
        }

        private void btn_UninitialAll_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.UnInitializeAll());
        }

        private void btn_SubscriberCallListChange_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) =>
            {
                device.SubscriberCallListChange();
            });
        }

        private void btn_StopSubscriberCallListChange_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) =>
            {
                device.StopSubscriberCallListChange();
            });
        }

        private void btn_TransferConsulting_Click(object sender, EventArgs e)
        {
            FrmHold frm = new FrmHold();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = this.btn_TransferConsulting.Text;

            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            this.PerformDeviceAction((device) =>
            {
                device.TransferConsulting(frm.CallId);
            });
        }
        
        private void btn_Record_Click(object sender, EventArgs e)
        {
            try
            {
                frmTalkingGroupRecordSearch frm = new frmTalkingGroupRecordSearch();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.TalkingGroupID = "123|456|789";
                frm.Text = this.btn_Record.Text;

                //若device为空，则直接返回
                if (this._device == null)
                {
                    return;
                }

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string _taskId = string.Empty;

                    foreach (string _tempId in frm.TalkingGroupID.Trim().Split('|'))
                    {
                        QueryRecordData data = new QueryRecordData();
                        data.corpId = "default";
                        data.pageIndex = Int16.Parse(frm.pageIndex);
                        data.pageSize = Int16.Parse(frm.pageSize);
                        data.startTime = frm.startTime;
                        data.endTime = frm.endTime;
                        data.isConfRecord = frm.isConfRecord;
                        data.onlyLocalRecord = frm.onlyLocalRecord;
                        data.searchKey = _tempId.Trim();
                        _taskId = this._device.RecordQuery(data);
                        WriteLog("RecordQuery. taskId={0}", _taskId);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        //获取Nonce
        private void btn_GetNonce_Click (object sender, EventArgs e)
        {
            try
            {
                string _taskId = string.Empty;
                _taskId = this._device.GetNonce();

                WriteLog("GetNonce. taskId={0}", _taskId);
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_RecordBackplay_Click(object sender, EventArgs e)
        {
            try
            {
                frmRecordBackplay frm = new frmRecordBackplay();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Text = this.btn_Record_Backplay.Text;

                //若device为空，则直接返回
                if (this._device == null)
                {
                    return;
                }

                if (null == this._CDSsettings)
                {
                    this._CDSsettings = new Dictionary<string, string>();
                }

                if (this._CDSsettings.ContainsKey("frmRecordBackplay_addr"))
                {
                    frm.address = this._CDSsettings["frmRecordBackplay_addr"];
                }
                if (this._CDSsettings.ContainsKey("frmRecordBackplay_filefolder"))
                {
                    frm.fileFolder = this._CDSsettings["frmRecordBackplay_filefolder"];
                }

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string _taskId = string.Empty;
                    if (string.IsNullOrEmpty(frm.fileFolder) || string.IsNullOrEmpty(frm.recordFile) || string.IsNullOrEmpty(frm.nonce) || string.IsNullOrEmpty(frm.address))
                    {
                        WriteLog("Empty Parameters:fileFolder={0}, recordFile={1}, nonce={2}, service ip={3}", frm.fileFolder, frm.recordFile, frm.nonce, frm.address);
                        return;
                    }
                    
                    if (this._CDSsettings.ContainsKey("frmRecordBackplay_filefolder"))
                    {
                        this._CDSsettings["frmRecordBackplay_filefolder"] = frm.fileFolder;
                    }
                    else
                    {
                        this._CDSsettings.Add("frmRecordBackplay_filefolder", frm.fileFolder);
                    }

                    if (this._CDSsettings.ContainsKey("frmRecordBackplay_addr"))
                    {
                        this._CDSsettings["frmRecordBackplay_addr"] = frm.address;
                    }
                    else
                    {
                        this._CDSsettings.Add("frmRecordBackplay_addr", frm.address);
                    }

                    string url = string.Format("{0}/portal/playRecordFile.sraction?nonce={1}&filefolder={2}&recordfile={3}", frm.address, frm.nonce, frm.fileFolder, frm.recordFile);
                                        
                    if (url.Contains("<")
                        || url.Contains(">")
                        || url.Contains("&")
                        || url.Contains("\"")
                        || url.Contains("'")
                        || url.Contains("(")
                        || url.Contains(")")
                        )
                    {
                        return;
                    }

                    System.Diagnostics.Process.Start(url);
                    WriteLog("Open the url: " + url);
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_QueryRleaseAuthority_Click(object sender, EventArgs e)
        {
            FrmHold frm = new FrmHold();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = this.btn_QueryRleaseAuthority.Text;

            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            this.PerformDeviceAction((device) =>
            {
                device.QueryReleaseAuthorityByCallId(frm.CallId);
            });
        }

        private void btn_stop_emergency_note_Click(object sender, EventArgs e)
        {
            try
            {
                frmStopEmergencyNote frm = new frmStopEmergencyNote();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Text = this.btn_stop_emergency_note.Text;

                //若device为空，则直接返回
                if (this._device == null)
                {
                    return;
                }

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string _taskId = string.Empty;

                    _taskId = this._device.StopPlayEmergencyNote(frm.TalkingGroupID);
                    WriteLog("StopPlayEmergencyNote. taskId={0}", _taskId);
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_get_pubParamters_Click(object sender, EventArgs e)
        {
            try
            {
                //若device为空，则直接返回
                if (this._device == null)
                {
                    return;
                }

                string _taskId = string.Empty;
                _taskId = this._device.QueryServiceParameters();
                WriteLog("QueryServiceParameters. taskId={0}", _taskId);
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_emergency_answer_Click(object sender, EventArgs e)
        {
            //紧急呼叫应答按钮
            frmTalkingGroupState frm = new frmTalkingGroupState();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.HideExpire();
            frm.Text = this.btn_emergency_answer.Text;

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TODO 调用紧急呼叫
                string _taskId = string.Empty;
                if (this._device != null)
                {
                    foreach (string _tempId in frm.TalkingGroupID.Split('|'))
                    {
                        _taskId = this._device.AnswerEmergencyCall(_tempId.Trim());
                        WriteLog("AnswerEmergencyCall taskId={0}", _taskId);
                    }
                }
            }
        }

        private void btn_emergency_exit_Click(object sender, EventArgs e)
        {
            //调度席退出紧急呼叫
            frmTalkingGroupState frm = new frmTalkingGroupState();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.HideExpire();
            frm.Text = this.btn_emergency_exit.Text;

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //TODO 调用紧急呼叫
                string _taskId = string.Empty;
                if (this._device != null)
                {
                    _taskId = this._device.EmergencyExit(frm.TalkingGroupID);
                }
                WriteLog("TalkingGroupQueryState taskId={0}", _taskId);
            }
        }

        private void button_GetSysVersion_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => WriteLog("GetSysVersion " + device.GetSysVersion()));
        }

        private void lblState_Click(object sender, EventArgs e)
        {
            lblStateDsp = !lblStateDsp;

            if (lblStateDsp)
            {
                lblState.Text = ConfigHelper.GetString("lblState") + " [-]";
            }
            else
            {
                lblState.Text = ConfigHelper.GetString("lblState") + " [+]";
            }                       
            panelState.Visible = lblStateDsp;
            panelState.Location = new Point(panelState.Location.X, Location.Y);
            SetResourcePos();
            this.Refresh();
        }

        private void lblFunction_Click(object sender, EventArgs e)
        {
            lblFucDsp = !lblFucDsp;

            if (lblFucDsp)
            {
                lblFunction.Text = ConfigHelper.GetString("lblFunction") + " [-]";
            }
            else
            {
                lblFunction.Text = ConfigHelper.GetString("lblFunction") + " [+]";
            }
            panelECC.Visible = lblFucDsp;
            SetResourcePos();
            
            this.Refresh();
        }

        private void label_AD_Click(object sender, EventArgs e)
        {
            lblADDsp = !lblADDsp;

            if (lblADDsp)
            {
                label_AD.Text = "AD [-]";
             }
            else
            {
                label_AD.Text = "AD [+]";
            }            
            panelAD.Visible = lblADDsp;
            SetResourcePos();
            this.Refresh();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            SetResourcePos();
            this.Refresh();
        }

        private void frmMain_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll && e.NewValue != e.OldValue)
            {                
                SetResourcePos();
                this.Refresh();
            }
        }

        private void bt_previewVideo_Click(object sender, EventArgs e)
        {
            try
            {
                frmDeviceIndex deviceIndex = new frmDeviceIndex();

                deviceIndex.StartPosition = FormStartPosition.CenterParent;
                deviceIndex.Text = this.bt_previewVideo.Text;

                if (deviceIndex.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var dialog = new frmVideo(this);
                    dialog.Text = this.bt_previewVideo.Text;
                    dialog.Show();
                    IntPtr wdHandle = FindWindow(null, dialog.Text);
                    this.PerformDeviceAction((device) => device.PreviewVideo(wdHandle.ToString(), deviceIndex.textBox_DeviceIndex.Text.Trim()));
                }
            }
            catch
            {
                WriteLog("Occur exception.");
            }
        }

        private void bt_GetVideoDevice_Click(object sender, EventArgs e)
        {
            try
            {
                this.PerformDeviceAction((device) => device.PhoneGetVideoDevice());
            }
            catch
            {
                WriteLog("Occur Exception.");
            }
        }

        private void btnUnifiedLogin_Click(object sender, EventArgs e)
        {

            this.PerformAction(() =>
            {
                lock (this.syncRoot)
                {
                    if (this._device == null)
                    {
                        var device = IDeviceProvider.GetIDevice(frmMainDeviceCallback.GetMainDeviceCallback(this)) as IDevice;
                        if (device == null)
                        {
                            throw new Exception("Create device failed.");
                        }

                        this._device = device;
                    }
                }
                frmUnifiedLogin unifiedLogin = new frmUnifiedLogin(this);

                unifiedLogin.StartPosition = FormStartPosition.CenterParent;
                unifiedLogin.Text = this.btnUnifiedLogin.Text;
                if (unifiedLogin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    bool bLoginAgentServer = false;
                    Dictionary<string, string> settings = new Dictionary<string,string>(this._settings);

                    string loginAgentServer;
                    _uportalConfig.TryGetValue("IsLoginAgentServer", out loginAgentServer);                    
                    if ("false".Equals(loginAgentServer))
                    {
                        settings.Clear(); 
                        settings.Add("IsLoginAgentServer", "false");                                               
                    }
                    else
                    {                        
                        settings.Add("IsLoginAgentServer", "true");
                        settings.Add("HuaweiVCPhoneNumber", this._agentInfo.VCPhoneNumber);

                        if (this._agentInfo.AgentType == AgentType.Video)
                        {
                            settings.Add("IsVideoAgent", "true");                            
                        }
                        bLoginAgentServer = true;
                    }

                    string HuaweiCTIServerIP = string.Empty;
                    settings.TryGetValue("HuaweiCTIServerIP", out HuaweiCTIServerIP);

                    if (!string.IsNullOrEmpty(unifiedLogin.ServerIP) && !unifiedLogin.ServerIP.StartsWith("https")
                        || !string.IsNullOrEmpty(HuaweiCTIServerIP) && !HuaweiCTIServerIP.StartsWith("https"))
                    {
                        MessageBoxButtons messButton = MessageBoxButtons.OKCancel;

                        //默认情况下，如MessageBox.Show("确定要退出吗？")只显示一个“确定”按钮。
                        DialogResult dr = MessageBox.Show(ConfigHelper.GetString("HttpAlarm"), "Message", messButton);

                        if (dr != DialogResult.OK)//如果点击“确定”按钮
                        {
                            return;
                        }

                    }


                    string initNumber;
                    _uportalConfig.TryGetValue("InitPhoneNumber", out initNumber);

                    if (!string.IsNullOrEmpty(initNumber))
                    {
                        settings.Add("InitNumber", initNumber);
                    }

                    string regPhone;
                    _uportalConfig.TryGetValue("IsRegisterPhone", out regPhone);

                    string deviceInfoStr = string.Empty; 
                    if ("false".Equals(regPhone))
                    {
                        settings.Add("IsRegisterPhone", "false");
                        if (bLoginAgentServer)
                        {
                            settings.Add("HuaweiPhoneNumber", this._agentInfo.PhoneNumber);
                        }
                    }
                    else
                    {
                        this.OnSetVideoWindow();

                        settings.Add("IsRegisterPhone", "true");
						
                        if (_phoneConfig.ContainsKey("PhoneUsedMode"))
                        {
                            settings.Add("PhoneUsedMode", _phoneConfig["PhoneUsedMode"]);
                        }

                        if (_phoneConfig.ContainsKey("LocalIP"))
                        {
                            settings.Add("LocalSipIP", _phoneConfig["LocalIP"]);
                        }

                        if (_phoneConfig.ContainsKey("LocalSipPort"))
                        {
                            settings.Add("LocalSipPort", _phoneConfig["LocalSipPort"]);

                        }

                        if (_phoneConfig.ContainsKey("LocalAudioPort"))
                        {
                            settings.Add("LocalAudioPort", _phoneConfig["LocalAudioPort"]);
                        }

                        DeviceInfo deviceInfo = new DeviceInfo();
                        string tempDictionaryValue = null;

                        if (_phoneConfig.TryGetValue("IsAidEnable", out tempDictionaryValue))
                        {
                            deviceInfo.isAidEnable = (tempDictionaryValue == "true") ? true : false;

                            this._isEnableAidDevice = (tempDictionaryValue == "true") ? true : false;
                        }

                        if (_phoneConfig.TryGetValue("MainSpeaker", out tempDictionaryValue))
                        {
                            deviceInfo.mainSpeakerDeviceName = tempDictionaryValue;
                        }

                        if (_phoneConfig.TryGetValue("MainMic", out tempDictionaryValue))
                        {
                            deviceInfo.mainMicrophoneDeviceName = tempDictionaryValue;
                        }

                        if (_phoneConfig.TryGetValue("AidSpeaker", out tempDictionaryValue))
                        {
                            deviceInfo.aidSpeakerDeviceName = tempDictionaryValue;
                        }

                        if (_phoneConfig.TryGetValue("AidMic", out tempDictionaryValue))
                        {
                            deviceInfo.aidMicrophoneDeviceName = tempDictionaryValue;
                        }

                        if (_phoneConfig.TryGetValue("VideoDevice", out tempDictionaryValue))
                        {
                            deviceInfo.videoDeviceName = tempDictionaryValue;
                        }

                        if (_phoneConfig.TryGetValue("AidPolicy", out tempDictionaryValue))
                        {
                            if ("default" == tempDictionaryValue)
                            {
                                deviceInfo.newCallToAidPolicy = string.Empty;
                            }
                            else
                            {
                                deviceInfo.newCallToAidPolicy = tempDictionaryValue;
                            }
                        }

                        if (_phoneConfig.ContainsKey("IsAutoAnswerIPCC"))
                        {
                            settings.Add("IsAutoAnswerIPCC", _phoneConfig["IsAutoAnswerIPCC"]);
                        }

                        if (_phoneConfig.ContainsKey("IsAutoAnswerIPT"))
                        {
                            settings.Add("IsAutoAnswerIPT", _phoneConfig["IsAutoAnswerIPT"]);
                        }

                        if (_phoneConfig.ContainsKey("IsRejectCallAgentNotIdle"))
                        {
                            settings.Add("IsRejectCallAgentNotIdle", _phoneConfig["IsRejectCallAgentNotIdle"]);
                        }

                        deviceInfoStr = frmMainDeviceCallback.Serialize(deviceInfo);

                        settings.Add("DeviceInfo", deviceInfoStr);

                    }

                    this.PerformDeviceAction((device) =>
                    {
                        device.UnifiedLogin(unifiedLogin.ServerIP, unifiedLogin.Account, unifiedLogin.Password, settings);
                    });

                    ConfigHelper config = new ConfigHelper();
                    config.AgentInfo = this._agentInfo;
                    config.Settings = this._settings;
                    config.PhoneSettings = this._phoneConfig;
                    config.UportalSettings = this._uportalConfig;
                    config.Save();
                }

            });            
        }

        private void btnUnifiedLogout_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.UnifiedLogout());
        }

        private void btn_initializeVRCAgent_Click(object sender, EventArgs e)
        {
            frmVrcAgent VrcAgentLogin = new frmVrcAgent();
            VrcAgentLogin.StartPosition = FormStartPosition.CenterParent;
            VrcAgentLogin.Text = this.btn_initializeVRCAgent.Text;
            if (VrcAgentLogin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.PerformDeviceAction((device) => WriteLog("vrc = {0}", axVRCControl1.InitializeAgentEx(VrcAgentLogin.VRPList, 2, VrcAgentLogin.AgentID,
                                                              VrcAgentLogin.SelfIP, VrcAgentLogin.SelfPort, "", device.GetConnectToken())));
                }
                catch (Exception ex)
                {
                    WriteLog("Occur Exception: " + ex.Data);
                }
            }
        }

        private void btn_StartRecordScreen_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.StartRecordScreen());
        }

        private void btn_StopRecordScreen_Click(object sender, EventArgs e)
        {
            this.PerformDeviceAction((device) => device.StopRecordScreen());
        }

        private void Uninitialize_VRC_Click(object sender, EventArgs e)
        {
            try
            {
                axVRCControl1.UnInitialize();
                WriteLog("Uninitialize_VRC Success");
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }         
        }


        // begin: add by lujiale 00284681, for AR.WeChat.004.002, 2017-12-26
        // 多媒体交谈窗口列表
        //Dictionary<string, frmMultiMediaChat> m_dicMultiMediaChat = new Dictionary<string, frmMultiMediaChat>();
        Dictionary<string, frmMultiMediaChatForTest> m_dicMultiMediaChat = new Dictionary<string, frmMultiMediaChatForTest>();

        /// <summary>
        /// 多媒体呼叫到达事件
        /// </summary>
        public void OnReceiveMediaCallConnectEvent(int subMediaType, int uvid, bool isInnerCall, string callId, string caller,
                                                            string called, string realCaller, string displayName, string userInfo, string attachData)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<int, int, bool, string, string, string, string, string, string, string>(OnReceiveMediaCallConnectEvent),
                                        subMediaType, uvid, isInnerCall, callId, caller, called, realCaller, displayName, userInfo, attachData);
                return;
            }

            // 文字交谈弹窗
            try
            {
                frmMultiMediaChatForTest _mulMediaChatDialog;
                if (m_dicMultiMediaChat.ContainsKey(callId))
                {
                    _mulMediaChatDialog = m_dicMultiMediaChat[callId];
                }
                else
                {
                    _mulMediaChatDialog = new frmMultiMediaChatForTest(this._device, _agentInfo);
                    m_dicMultiMediaChat.Add(callId, _mulMediaChatDialog);
                }

                if (_mulMediaChatDialog != null)
                {
                    _mulMediaChatDialog.Show();
                    _mulMediaChatDialog.OnReceiveMediaCallConnectEvent(subMediaType, uvid, isInnerCall, callId, caller, called, realCaller, displayName, userInfo, attachData);
                }
            }
            catch (System.Exception ex)
            {
                WriteLog("Error: {0}", ex.Message);
            }
        }

        /// <summary>
        /// 接收到多媒体呼叫内容事件
        /// </summary>
        public void OnReceiveMediaCallContent(int subMediaType, string callId, int chatId, int chatContentType, string content)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<int, string, int, int, string>(OnReceiveMediaCallContent), subMediaType, callId, chatId, chatContentType, content);
                return;
            }

            try
            {
                if (m_dicMultiMediaChat.ContainsKey(callId))
                {
                    var _mulMediaChatDialog = m_dicMultiMediaChat[callId];
                    if (_mulMediaChatDialog != null)
                    {
                        _mulMediaChatDialog.OnReceiveMediaCallContent(subMediaType, callId, chatId, chatContentType, content);
                    }
                }
                else
                {
                    WriteLog("Error: can not find this multimedia chat dialog, callid = {0}", callId);
                }
            }
            catch (System.Exception ex)
            {
                WriteLog("Error: {0}", ex.Message);
            }
        }

        /// <summary>
        /// 多媒体呼叫释放通知
        /// </summary>
        /// <param name="callId">呼叫标志</param>
        public void OnReceiveMediaCallReleaseEvent(string callId)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(OnReceiveMediaCallReleaseEvent), callId);
                return;
            }

            try
            {
                if (m_dicMultiMediaChat.ContainsKey(callId))
                {
                    var _mulMediaChatDialog = m_dicMultiMediaChat[callId];
                    if (_mulMediaChatDialog != null)
                    {
                        _mulMediaChatDialog.OnReceiveMediaCallReleaseEvent(callId);
                        // 处理完成后，需要关闭交谈窗口，并从列表中删除
                        _mulMediaChatDialog.Close();
                        m_dicMultiMediaChat.Remove(callId);
                    }
                }
                else
                {
                    WriteLog("Error: can not find this multimedia chat dialog, callid = {0}", callId);
                }
            }
            catch (System.Exception ex)
            {
                WriteLog("Error: {0}", ex.Message);
            }
        }

        /// <summary>
        /// 多媒体呼叫转移结果
        /// </summary>
        /// <param name="callId">呼叫标志</param>
        /// <param name="flag">转移成功/失败标志</param>
        /// <param name="errorCode">转移失败原因码</param>
        public void OnTransferMediaCallToAgentResult(string callId, bool flag, int errorCode)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string, bool, int>(OnTransferMediaCallToAgentResult), callId, flag, errorCode);
                return;
            }

            try
            {
                if (m_dicMultiMediaChat.ContainsKey(callId))
                {
                    var _mulMediaChatDialog = m_dicMultiMediaChat[callId];
                    if (_mulMediaChatDialog != null)
                    {
                        _mulMediaChatDialog.OnTransferMediaCallToAgentResult(callId, flag, errorCode);
                    }
                }
                else
                {
                    WriteLog("Error: can not find this multimedia chat dialog, callid = {0}", callId);
                }
            }
            catch (System.Exception ex)
            {
                WriteLog("Error: {0}", ex.Message);
            }
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
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string, int, bool, int>(OnSendMediaContentResult), callId, chatId, flag, errorCode);
                return;
            }

            try
            {
                if (m_dicMultiMediaChat.ContainsKey(callId))
                {
                    var _mulMediaChatDialog = m_dicMultiMediaChat[callId];
                    if (_mulMediaChatDialog != null)
                    {
                        _mulMediaChatDialog.OnSendMediaContentResult(callId, chatId, flag, errorCode);
                    }
                }
                else
                {
                    WriteLog("Error: can not find this multimedia chat dialog, callid = {0}", callId);
                }
            }
            catch (System.Exception ex)
            {
                WriteLog("Error: {0}", ex.Message);
            }
        }

        /// <summary>
        /// 多媒体文件发送结果
        /// </summary>
        /// <param name="callId">呼叫标志</param>
        /// <param name="ulSeqNo">序列编号</param>
        /// <param name="flag">发送成功/失败标志</param>
        /// <param name="errorCode">发送失败原因码</param>
        public void OnSendMediaFileResult(string callId, int chatId, bool flag, int errorCode)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string, int, bool, int>(OnSendMediaFileResult), callId, chatId, flag, errorCode);
                return;
            }

            try
            {
                if (m_dicMultiMediaChat.ContainsKey(callId))
                {
                    var _mulMediaChatDialog = m_dicMultiMediaChat[callId];
                    if (_mulMediaChatDialog != null)
                    {
                        _mulMediaChatDialog.OnSendMediaFileResult(callId, chatId, flag, errorCode);
                    }
                }
                else
                {
                    WriteLog("Error: can not find this multimedia chat dialog, callid = {0}", callId);
                }
            }
            catch (System.Exception ex)
            {
                WriteLog("Error: {0}", ex.Message);
            }
        }

        /// <summary>
        /// 多媒体文件发送结果
        /// </summary>
        /// <param name="callId">呼叫标志</param>
        /// <param name="ulSeqNo">序列编号</param>
        /// <param name="flag">发送成功/失败标志</param>
        /// <param name="errorCode">发送失败原因码</param>
        public void OnReceiveMediaFileResult(string callId, bool flag, int errorCode)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string, bool, int>(OnReceiveMediaFileResult), callId, flag, errorCode);
                return;
            }

            try
            {
                if (m_dicMultiMediaChat.ContainsKey(callId))
                {
                    var _mulMediaChatDialog = m_dicMultiMediaChat[callId];
                    if (_mulMediaChatDialog != null)
                    {
                        _mulMediaChatDialog.OnReceiveMediaFileResult(callId, flag, errorCode);
                    }
                }
                else
                {
                    WriteLog("Error: can not find this multimedia chat dialog, callid = {0}", callId);
                }
            }
            catch (System.Exception ex)
            {
                WriteLog("Error: {0}", ex.Message);
            }
        }

        private void btnSuccTransferEx_Click(object sender, EventArgs e)
        {
            this.PerformAction(() =>
            {
                var dialog = new frmAgentIdWithMediaType();
                dialog.Text = btnSingleStepSuccTransfer.Text;
                dialog.Tag = "SingleStepSuccTransfer";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.PerformDeviceAction((device) => device.SingleStepSuccTransferEx(dialog.m_strAgentId, dialog.m_strPhoneNumber, dialog.m_iMediaAbility));
                }
            });
        }

        private void btn_mixedAndTempGroupStart_Click(object sender, EventArgs e)
        {
            try
            {
                frmMixedGroupConfig frm = new frmMixedGroupConfig();
                frm.Text = this.btn_mixedAndTempGroupStart.Text;
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MixedGroupUserInfoList usersList = new MixedGroupUserInfoList();
                    string userStr = string.IsNullOrWhiteSpace(frm.Users) ? "{\"users\":[]}" : frm.Users;
                    usersList = BaseServiceHelper.Deserialize<MixedGroupUserInfoList>(userStr);
                    string groupNumber = frm.GroupId;
                    string groupAlias = frm.GroupAlias;
                    bool muted = frm.Muted;
                    bool reservedSwitch = frm.ReservedSwitch;
                    if (!string.IsNullOrEmpty(callSessionID) && callSessionID != "0" && string.IsNullOrEmpty(otherCall))
                    {
                        otherCall = callSessionID;
                    }
                    string _taskId = string.Empty;
                    if (this._device != null)
                    {
                        foreach (string _tempId in frm.GroupId.Split('|'))
                        {
                            _taskId = this._device.MixedAndTempGroupCallStart(_tempId.Trim(), muted, groupAlias, reservedSwitch, usersList.users);
                            WriteLog("MixedGroupCallStart taskId={0}", _taskId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog("Occur Exception: " + ex.Data);
            }
        }

        private void btn_releaseCurUserGroupCall_Click(object sender, EventArgs e)
        {
            //释放当前调度席所有呼叫
            string _taskId = string.Empty;
            if (this._device != null)
            {
                _taskId = this._device.TalkingGroupReleaseAll();
            }
            WriteLog("TalkingGroupReleaseAll taskId={0}", _taskId);
        }

        // end: add by lujiale 00284681, for AR.WeChat.004.002, 2017-12-26
    }

    public class DeviceInfo
    {
        public bool isAidEnable { get; set; }

        public string mainSpeakerDeviceName { get; set; }

        public string mainMicrophoneDeviceName { get; set; }

        public string aidSpeakerDeviceName { get; set; }

        public string aidMicrophoneDeviceName { get; set; }

        public string videoDeviceName { get; set; }

        //声卡切换策略
        public string newCallToAidPolicy { get; set; }
    }

}
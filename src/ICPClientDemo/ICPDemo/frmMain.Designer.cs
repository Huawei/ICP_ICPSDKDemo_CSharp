namespace ICPDemo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.btnSMS = new System.Windows.Forms.Button();
            this.txtSkillID = new System.Windows.Forms.TextBox();
            this.btnUpdateMailConfig = new System.Windows.Forms.Button();
            this.btnPausePlayRecord = new System.Windows.Forms.Button();
            this.btnStopPlayRecord = new System.Windows.Forms.Button();
            this.btnGetRecordLength = new System.Windows.Forms.Button();
            this.btnPlayRecord = new System.Windows.Forms.Button();
            this.btnResumePlayRecord = new System.Windows.Forms.Button();
            this.btnPlayRecordSeekTo = new System.Windows.Forms.Button();
            this.btnQueryRedList = new System.Windows.Forms.Button();
            this.BtnRest = new System.Windows.Forms.Button();
            this.BtnCancelRest = new System.Windows.Forms.Button();
            this.btnRemoveAllRedList = new System.Windows.Forms.Button();
            this.btnRemoveFromRedList = new System.Windows.Forms.Button();
            this.btnSelectPickup = new System.Windows.Forms.Button();
            this.bntQueryUsingWirelessDevice = new System.Windows.Forms.Button();
            this.btnForceLogout = new System.Windows.Forms.Button();
            this.lblSkillID = new System.Windows.Forms.Label();
            this.axActiveMailSend = new AxACTIVEMAILLib.AxActiveMail();
            this.axActiveMailReply = new AxACTIVEMAILLib.AxActiveMail();
            this.btnQueryAgentCfgInfo = new System.Windows.Forms.Button();
            this.btnReleaseCallEx = new System.Windows.Forms.Button();
            this.btnGetCallOutNo = new System.Windows.Forms.Button();
            this.btnReplyEmail = new System.Windows.Forms.Button();
            this.btnReceiveMail = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnGetSendEmailIndex = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnInitial = new System.Windows.Forms.Button();
            this.btnUnInitial = new System.Windows.Forms.Button();
            this.btnSetIdle = new System.Windows.Forms.Button();
            this.btnSnatchPickup = new System.Windows.Forms.Button();
            this.btnSetBusy = new System.Windows.Forms.Button();
            this.btnSnatch = new System.Windows.Forms.Button();
            this.btnMonitorToSnatch = new System.Windows.Forms.Button();
            this.btnAddBlackList = new System.Windows.Forms.Button();
            this.btnMonitorToBarge = new System.Windows.Forms.Button();
            this.btnRemoveBlackList = new System.Windows.Forms.Button();
            this.btnBarge = new System.Windows.Forms.Button();
            this.btnClearBlackList = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnPTTOff = new System.Windows.Forms.Button();
            this.btnPTTOn = new System.Windows.Forms.Button();
            this.btnQueryWirelessInfo = new System.Windows.Forms.Button();
            this.btnQueryAllWireless = new System.Windows.Forms.Button();
            this.btnChangeAgentPwd = new System.Windows.Forms.Button();
            this.btnAddToRedList = new System.Windows.Forms.Button();
            this.btnWorkStop = new System.Windows.Forms.Button();
            this.btnAutoEnterIdle = new System.Windows.Forms.Button();
            this.btnQueryBlackList = new System.Windows.Forms.Button();
            this.lblSeekToTime = new System.Windows.Forms.Label();
            this.txtPlayRecordSeekTo = new System.Windows.Forms.TextBox();
            this.txtRecordId = new System.Windows.Forms.TextBox();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtMciPort = new System.Windows.Forms.TextBox();
            this.txtMciIp = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSMSSkillId = new System.Windows.Forms.Label();
            this.panelCfg = new System.Windows.Forms.Panel();
            this.btnUnifiedLogout = new System.Windows.Forms.Button();
            this.btnUnifiedLogin = new System.Windows.Forms.Button();
            this.btn_UninitialAll = new System.Windows.Forms.Button();
            this.btnResetAgentSkill = new System.Windows.Forms.Button();
            this.btnGetSysVersion = new System.Windows.Forms.Button();
            this.panelState = new System.Windows.Forms.Panel();
            this.btnExitACW = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnClearAutoEnterIdle = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_QueryRleaseAuthority = new System.Windows.Forms.Button();
            this.lblQuery = new System.Windows.Forms.Label();
            this.btn_StopSubscriberCallListChange = new System.Windows.Forms.Button();
            this.btn_SubscriberCallListChange = new System.Windows.Forms.Button();
            this.btnQueryCallIdOnAgent = new System.Windows.Forms.Button();
            this.btnQueryCallInfo = new System.Windows.Forms.Button();
            this.btnQueryAgentSkillGroups = new System.Windows.Forms.Button();
            this.btnQueryCurrentCallingScope = new System.Windows.Forms.Button();
            this.btnQuerySkillGroupStatus = new System.Windows.Forms.Button();
            this.btnQueryMaliciousCalls = new System.Windows.Forms.Button();
            this.btnQueryIVRInfo = new System.Windows.Forms.Button();
            this.btnQueryTotalSysInno = new System.Windows.Forms.Button();
            this.btnQueryLostCalls = new System.Windows.Forms.Button();
            this.btnQueryAllByGroupId = new System.Windows.Forms.Button();
            this.btnQueryCallData = new System.Windows.Forms.Button();
            this.btnQueryAgentStatus = new System.Windows.Forms.Button();
            this.btnQueryCallListByGroup = new System.Windows.Forms.Button();
            this.btnQuerySkillGroups = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCreateMeetingEx = new System.Windows.Forms.Button();
            this.btnQueryMeetingMembers = new System.Windows.Forms.Button();
            this.btnExitMeeting = new System.Windows.Forms.Button();
            this.lblMeeting = new System.Windows.Forms.Label();
            this.btnTransferMeetingMaster = new System.Windows.Forms.Button();
            this.btnCreateMeeting = new System.Windows.Forms.Button();
            this.BtnSingleStepMeeting = new System.Windows.Forms.Button();
            this.btnMakeMeeting = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSingleStepSuccTransferEx = new System.Windows.Forms.Button();
            this.btn_TransferConsulting = new System.Windows.Forms.Button();
            this.lblCall = new System.Windows.Forms.Label();
            this.btnAgentSendDTMF = new System.Windows.Forms.Button();
            this.btnTransToIVR = new System.Windows.Forms.Button();
            this.btnPollingCallEx = new System.Windows.Forms.Button();
            this.btnDialEx = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btUnMute = new System.Windows.Forms.Button();
            this.btnTransferToSkillGroup = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnHangup = new System.Windows.Forms.Button();
            this.btnEndConsultCall = new System.Windows.Forms.Button();
            this.btnBlindTransfer = new System.Windows.Forms.Button();
            this.btnTransToAgent = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnHoldCall = new System.Windows.Forms.Button();
            this.btnPickup = new System.Windows.Forms.Button();
            this.btnSetCustomerLevel = new System.Windows.Forms.Button();
            this.btnSetCustomizedRecordInfo = new System.Windows.Forms.Button();
            this.btnSingleStepSuccTransfer = new System.Windows.Forms.Button();
            this.btnSetCallData = new System.Windows.Forms.Button();
            this.btnPollingCall = new System.Windows.Forms.Button();
            this.btnRetrieveCall = new System.Windows.Forms.Button();
            this.btnCancelAutoAnswer = new System.Windows.Forms.Button();
            this.btnDial = new System.Windows.Forms.Button();
            this.btnSetAutoAnswer = new System.Windows.Forms.Button();
            this.tabWirelesss = new System.Windows.Forms.TabPage();
            this.tabList = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnQueryAllRedList = new System.Windows.Forms.Button();
            this.lblRed = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnQueryAllBlackListEx = new System.Windows.Forms.Button();
            this.btnQueryBlackListEx = new System.Windows.Forms.Button();
            this.btnAddBlackListEx = new System.Windows.Forms.Button();
            this.btnQueryAllBlackList = new System.Windows.Forms.Button();
            this.lblBlack = new System.Windows.Forms.Label();
            this.tabM = new System.Windows.Forms.TabPage();
            this.btnStopSubscribeAgentEvent = new System.Windows.Forms.Button();
            this.btnSubscribeAgentEvent = new System.Windows.Forms.Button();
            this.btnStopWhisper = new System.Windows.Forms.Button();
            this.btnWhisper = new System.Windows.Forms.Button();
            this.btnSuperviseSwitch = new System.Windows.Forms.Button();
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.txtDownloadFormat = new System.Windows.Forms.TextBox();
            this.lblDownloadFormat = new System.Windows.Forms.Label();
            this.txtStorePath = new System.Windows.Forms.TextBox();
            this.txtRecordPath = new System.Windows.Forms.TextBox();
            this.lblStorePath = new System.Windows.Forms.Label();
            this.lblRecordPath = new System.Windows.Forms.Label();
            this.btnDownloadRecord = new System.Windows.Forms.Button();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtucHandle = new System.Windows.Forms.TextBox();
            this.txtulTime = new System.Windows.Forms.TextBox();
            this.txtusDsn = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tabNote = new System.Windows.Forms.TabPage();
            this.btnSmsToAgent = new System.Windows.Forms.Button();
            this.lblSepNo = new System.Windows.Forms.Label();
            this.txtulSeqNo = new System.Windows.Forms.TextBox();
            this.tabVRC = new System.Windows.Forms.TabPage();
            this.Uninitialize_VRC = new System.Windows.Forms.Button();
            this.btn_StopRecordScreen = new System.Windows.Forms.Button();
            this.btn_StartRecordScreen = new System.Windows.Forms.Button();
            this.btn_initializeVRCAgent = new System.Windows.Forms.Button();
            this.btnQueryAgentIP = new System.Windows.Forms.Button();
            this.axVRCControl1 = new AxVRCCONTROLLib.AxVRCControl();
            this.tabVCC = new System.Windows.Forms.TabPage();
            this.btnHangupVCCall = new System.Windows.Forms.Button();
            this.btnPickupVCCall = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.panelECC = new System.Windows.Forms.Panel();
            this.lblFunction = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.label_AD = new System.Windows.Forms.Label();
            this.btn_Init = new System.Windows.Forms.Button();
            this.btn_PhoneUninit = new System.Windows.Forms.Button();
            this.btn_PhoneAnswer = new System.Windows.Forms.Button();
            this.btn_PhoneHangup = new System.Windows.Forms.Button();
            this.btn_PhoneMute = new System.Windows.Forms.Button();
            this.btn_PhoneUnmute = new System.Windows.Forms.Button();
            this.btn_SwitchAidDevice = new System.Windows.Forms.Button();
            this.btn_SwitchMainDevice = new System.Windows.Forms.Button();
            this.btn_GetSoundDevice = new System.Windows.Forms.Button();
            this.btn_SetSoundDevice = new System.Windows.Forms.Button();
            this.btn_GetVolume = new System.Windows.Forms.Button();
            this.btn_SetVolume = new System.Windows.Forms.Button();
            this.btn_GetVolumeGain = new System.Windows.Forms.Button();
            this.btn_SetVolumeGain = new System.Windows.Forms.Button();
            this.btn_GetDeviceVolume = new System.Windows.Forms.Button();
            this.btn_SetDeviceVolume = new System.Windows.Forms.Button();
            this.btn_UportalLogin = new System.Windows.Forms.Button();
            this.btn_LogoutUportal = new System.Windows.Forms.Button();
            this.btn_TalkingGroupQuery = new System.Windows.Forms.Button();
            this.btn_QueryGrupState = new System.Windows.Forms.Button();
            this.btn_AddTalking = new System.Windows.Forms.Button();
            this.btn_ModifyGroup = new System.Windows.Forms.Button();
            this.btn_DeleteTakling = new System.Windows.Forms.Button();
            this.panelAD = new System.Windows.Forms.Panel();
            this.btn_emergency_exit = new System.Windows.Forms.Button();
            this.btn_mixedAndTempGroupStart = new System.Windows.Forms.Button();
            this.bt_GetVideoDevice = new System.Windows.Forms.Button();
            this.bt_previewVideo = new System.Windows.Forms.Button();
            this.btn_emergency_answer = new System.Windows.Forms.Button();
            this.btn_get_pubParamters = new System.Windows.Forms.Button();
            this.btn_stop_emergency_note = new System.Windows.Forms.Button();
            this.btn_Record_Backplay = new System.Windows.Forms.Button();
            this.btn_releaseCurUserGroupCall = new System.Windows.Forms.Button();
            this.btn_GetNonce = new System.Windows.Forms.Button();
            this.btn_Record = new System.Windows.Forms.Button();
            this.btn_SetConfig = new System.Windows.Forms.Button();
            this.btn_GetConfig = new System.Windows.Forms.Button();
            this.btn_GroupDePTT = new System.Windows.Forms.Button();
            this.btn_GroupDesubscribe = new System.Windows.Forms.Button();
            this.btn_GroupDemonitor = new System.Windows.Forms.Button();
            this.btn_GroupDeselect = new System.Windows.Forms.Button();
            this.btn_MixedGroupChangeUserState = new System.Windows.Forms.Button();
            this.btn_MixedGroupCallEnd = new System.Windows.Forms.Button();
            this.btn_MixedGroupCallStart = new System.Windows.Forms.Button();
            this.btn_TalkingGroupGetCallInfo = new System.Windows.Forms.Button();
            this.btn_GroupPTT = new System.Windows.Forms.Button();
            this.btn_GroupSelect = new System.Windows.Forms.Button();
            this.btn_GroupMonitor = new System.Windows.Forms.Button();
            this.btn_TalkingGroupSubscribe = new System.Windows.Forms.Button();
            this.btn_RadioGroupQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axActiveMailSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axActiveMailReply)).BeginInit();
            this.panelCfg.SuspendLayout();
            this.panelState.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabWirelesss.SuspendLayout();
            this.tabList.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabM.SuspendLayout();
            this.tabRecord.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabNote.SuspendLayout();
            this.tabVRC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVRCControl1)).BeginInit();
            this.tabVCC.SuspendLayout();
            this.panelECC.SuspendLayout();
            this.panelAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEvents
            // 
            this.txtEvents.BackColor = System.Drawing.Color.White;
            this.txtEvents.Location = new System.Drawing.Point(8, 813);
            this.txtEvents.Multiline = true;
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEvents.Size = new System.Drawing.Size(1156, 137);
            this.txtEvents.TabIndex = 3;
            this.txtEvents.WordWrap = false;
            // 
            // btnSMS
            // 
            this.btnSMS.Location = new System.Drawing.Point(153, 225);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.Size = new System.Drawing.Size(100, 23);
            this.btnSMS.TabIndex = 10;
            this.btnSMS.Text = "Send";
            this.btnSMS.UseVisualStyleBackColor = true;
            this.btnSMS.Click += new System.EventHandler(this.btnSMS_Click);
            // 
            // txtSkillID
            // 
            this.txtSkillID.Location = new System.Drawing.Point(73, 13);
            this.txtSkillID.Name = "txtSkillID";
            this.txtSkillID.Size = new System.Drawing.Size(64, 21);
            this.txtSkillID.TabIndex = 31;
            // 
            // btnUpdateMailConfig
            // 
            this.btnUpdateMailConfig.Location = new System.Drawing.Point(8, 40);
            this.btnUpdateMailConfig.Name = "btnUpdateMailConfig";
            this.btnUpdateMailConfig.Size = new System.Drawing.Size(129, 23);
            this.btnUpdateMailConfig.TabIndex = 7;
            this.btnUpdateMailConfig.Text = "UpdateMailConfig";
            this.btnUpdateMailConfig.UseVisualStyleBackColor = true;
            this.btnUpdateMailConfig.Click += new System.EventHandler(this.btnUpdateMailConfig_Click);
            // 
            // btnPausePlayRecord
            // 
            this.btnPausePlayRecord.Location = new System.Drawing.Point(94, 82);
            this.btnPausePlayRecord.Name = "btnPausePlayRecord";
            this.btnPausePlayRecord.Size = new System.Drawing.Size(148, 23);
            this.btnPausePlayRecord.TabIndex = 29;
            this.btnPausePlayRecord.Text = "Pause Play Record";
            this.btnPausePlayRecord.UseVisualStyleBackColor = true;
            this.btnPausePlayRecord.Click += new System.EventHandler(this.btnPausePlayRecord_Click);
            // 
            // btnStopPlayRecord
            // 
            this.btnStopPlayRecord.Location = new System.Drawing.Point(439, 82);
            this.btnStopPlayRecord.Name = "btnStopPlayRecord";
            this.btnStopPlayRecord.Size = new System.Drawing.Size(152, 23);
            this.btnStopPlayRecord.TabIndex = 28;
            this.btnStopPlayRecord.Text = "Stop Play Record";
            this.btnStopPlayRecord.UseVisualStyleBackColor = true;
            this.btnStopPlayRecord.Click += new System.EventHandler(this.btnStopPlayRecord_Click);
            // 
            // btnGetRecordLength
            // 
            this.btnGetRecordLength.Location = new System.Drawing.Point(253, 15);
            this.btnGetRecordLength.Name = "btnGetRecordLength";
            this.btnGetRecordLength.Size = new System.Drawing.Size(170, 23);
            this.btnGetRecordLength.TabIndex = 22;
            this.btnGetRecordLength.Text = "Get Record Length";
            this.btnGetRecordLength.UseVisualStyleBackColor = true;
            this.btnGetRecordLength.Click += new System.EventHandler(this.btnGetRecordLength_Click);
            // 
            // btnPlayRecord
            // 
            this.btnPlayRecord.Location = new System.Drawing.Point(439, 15);
            this.btnPlayRecord.Name = "btnPlayRecord";
            this.btnPlayRecord.Size = new System.Drawing.Size(152, 23);
            this.btnPlayRecord.TabIndex = 27;
            this.btnPlayRecord.Text = "Play Record";
            this.btnPlayRecord.UseVisualStyleBackColor = true;
            this.btnPlayRecord.Click += new System.EventHandler(this.btnPlayRecord_Click);
            // 
            // btnResumePlayRecord
            // 
            this.btnResumePlayRecord.Location = new System.Drawing.Point(253, 82);
            this.btnResumePlayRecord.Name = "btnResumePlayRecord";
            this.btnResumePlayRecord.Size = new System.Drawing.Size(170, 23);
            this.btnResumePlayRecord.TabIndex = 30;
            this.btnResumePlayRecord.Text = "Resume Play Record";
            this.btnResumePlayRecord.UseVisualStyleBackColor = true;
            this.btnResumePlayRecord.Click += new System.EventHandler(this.btnResumePlayRecord_Click);
            // 
            // btnPlayRecordSeekTo
            // 
            this.btnPlayRecordSeekTo.Location = new System.Drawing.Point(253, 44);
            this.btnPlayRecordSeekTo.Name = "btnPlayRecordSeekTo";
            this.btnPlayRecordSeekTo.Size = new System.Drawing.Size(170, 23);
            this.btnPlayRecordSeekTo.TabIndex = 25;
            this.btnPlayRecordSeekTo.Text = "Record Seek To";
            this.btnPlayRecordSeekTo.UseVisualStyleBackColor = true;
            this.btnPlayRecordSeekTo.Click += new System.EventHandler(this.btnPlayRecordSeekTo_Click);
            // 
            // btnQueryRedList
            // 
            this.btnQueryRedList.Location = new System.Drawing.Point(532, 17);
            this.btnQueryRedList.Name = "btnQueryRedList";
            this.btnQueryRedList.Size = new System.Drawing.Size(150, 23);
            this.btnQueryRedList.TabIndex = 24;
            this.btnQueryRedList.Text = "QueryRedList";
            this.btnQueryRedList.UseVisualStyleBackColor = true;
            this.btnQueryRedList.Click += new System.EventHandler(this.btnQueryRedList_Click);
            // 
            // BtnRest
            // 
            this.BtnRest.Location = new System.Drawing.Point(142, 9);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(145, 23);
            this.BtnRest.TabIndex = 2;
            this.BtnRest.Text = "Set Rest";
            this.BtnRest.UseVisualStyleBackColor = true;
            this.BtnRest.Click += new System.EventHandler(this.BtnRest_Click);
            // 
            // BtnCancelRest
            // 
            this.BtnCancelRest.Location = new System.Drawing.Point(142, 38);
            this.BtnCancelRest.Name = "BtnCancelRest";
            this.BtnCancelRest.Size = new System.Drawing.Size(145, 23);
            this.BtnCancelRest.TabIndex = 3;
            this.BtnCancelRest.Text = "Cancel Rest";
            this.BtnCancelRest.UseVisualStyleBackColor = true;
            this.BtnCancelRest.Click += new System.EventHandler(this.BtnCancelRest_Click);
            // 
            // btnRemoveAllRedList
            // 
            this.btnRemoveAllRedList.Location = new System.Drawing.Point(356, 17);
            this.btnRemoveAllRedList.Name = "btnRemoveAllRedList";
            this.btnRemoveAllRedList.Size = new System.Drawing.Size(149, 23);
            this.btnRemoveAllRedList.TabIndex = 22;
            this.btnRemoveAllRedList.Text = "ClearRedList";
            this.btnRemoveAllRedList.UseVisualStyleBackColor = true;
            this.btnRemoveAllRedList.Click += new System.EventHandler(this.btnRemoveAllRedList_Click);
            // 
            // btnRemoveFromRedList
            // 
            this.btnRemoveFromRedList.Location = new System.Drawing.Point(178, 17);
            this.btnRemoveFromRedList.Name = "btnRemoveFromRedList";
            this.btnRemoveFromRedList.Size = new System.Drawing.Size(156, 23);
            this.btnRemoveFromRedList.TabIndex = 21;
            this.btnRemoveFromRedList.Text = "RemoveFromRedList";
            this.btnRemoveFromRedList.UseVisualStyleBackColor = true;
            this.btnRemoveFromRedList.Click += new System.EventHandler(this.btnRemoveFromRedList_Click);
            // 
            // btnSelectPickup
            // 
            this.btnSelectPickup.Location = new System.Drawing.Point(156, 50);
            this.btnSelectPickup.Name = "btnSelectPickup";
            this.btnSelectPickup.Size = new System.Drawing.Size(157, 23);
            this.btnSelectPickup.TabIndex = 50;
            this.btnSelectPickup.Text = "Select Pickup";
            this.btnSelectPickup.UseVisualStyleBackColor = true;
            this.btnSelectPickup.Click += new System.EventHandler(this.btnSelectPickup_Click);
            // 
            // bntQueryUsingWirelessDevice
            // 
            this.bntQueryUsingWirelessDevice.Location = new System.Drawing.Point(588, 27);
            this.bntQueryUsingWirelessDevice.Name = "bntQueryUsingWirelessDevice";
            this.bntQueryUsingWirelessDevice.Size = new System.Drawing.Size(181, 23);
            this.bntQueryUsingWirelessDevice.TabIndex = 33;
            this.bntQueryUsingWirelessDevice.Text = "Query Using Wireless Device";
            this.bntQueryUsingWirelessDevice.UseVisualStyleBackColor = true;
            this.bntQueryUsingWirelessDevice.Click += new System.EventHandler(this.bntQueryUsingWirelessDevice_Click);
            // 
            // btnForceLogout
            // 
            this.btnForceLogout.Location = new System.Drawing.Point(319, 50);
            this.btnForceLogout.Name = "btnForceLogout";
            this.btnForceLogout.Size = new System.Drawing.Size(176, 23);
            this.btnForceLogout.TabIndex = 37;
            this.btnForceLogout.Text = "Force Logout";
            this.btnForceLogout.UseVisualStyleBackColor = true;
            this.btnForceLogout.Click += new System.EventHandler(this.btnForceLogout_Click);
            // 
            // lblSkillID
            // 
            this.lblSkillID.AutoSize = true;
            this.lblSkillID.Location = new System.Drawing.Point(10, 16);
            this.lblSkillID.Name = "lblSkillID";
            this.lblSkillID.Size = new System.Drawing.Size(53, 12);
            this.lblSkillID.TabIndex = 58;
            this.lblSkillID.Text = "SkillID:";
            // 
            // axActiveMailSend
            // 
            this.axActiveMailSend.Enabled = true;
            this.axActiveMailSend.Location = new System.Drawing.Point(0, 0);
            this.axActiveMailSend.Name = "axActiveMailSend";
            this.axActiveMailSend.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axActiveMailSend.OcxState")));
            this.axActiveMailSend.Size = new System.Drawing.Size(300, 300);
            this.axActiveMailSend.TabIndex = 0;
            // 
            // axActiveMailReply
            // 
            this.axActiveMailReply.Enabled = true;
            this.axActiveMailReply.Location = new System.Drawing.Point(0, 0);
            this.axActiveMailReply.Name = "axActiveMailReply";
            this.axActiveMailReply.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axActiveMailReply.OcxState")));
            this.axActiveMailReply.Size = new System.Drawing.Size(300, 300);
            this.axActiveMailReply.TabIndex = 48;
            // 
            // btnQueryAgentCfgInfo
            // 
            this.btnQueryAgentCfgInfo.Location = new System.Drawing.Point(8, 73);
            this.btnQueryAgentCfgInfo.Name = "btnQueryAgentCfgInfo";
            this.btnQueryAgentCfgInfo.Size = new System.Drawing.Size(129, 23);
            this.btnQueryAgentCfgInfo.TabIndex = 35;
            this.btnQueryAgentCfgInfo.Text = "SDKQueryAgentCfgInfo";
            this.btnQueryAgentCfgInfo.UseVisualStyleBackColor = true;
            this.btnQueryAgentCfgInfo.Click += new System.EventHandler(this.btnQueryAgentCfgInfo_Click);
            // 
            // btnReleaseCallEx
            // 
            this.btnReleaseCallEx.Location = new System.Drawing.Point(8, 249);
            this.btnReleaseCallEx.Name = "btnReleaseCallEx";
            this.btnReleaseCallEx.Size = new System.Drawing.Size(129, 23);
            this.btnReleaseCallEx.TabIndex = 52;
            this.btnReleaseCallEx.Text = "SDKReleaseMailCall";
            this.btnReleaseCallEx.UseVisualStyleBackColor = true;
            this.btnReleaseCallEx.Click += new System.EventHandler(this.btnReleaseCallEx_Click);
            // 
            // btnGetCallOutNo
            // 
            this.btnGetCallOutNo.Location = new System.Drawing.Point(8, 179);
            this.btnGetCallOutNo.Name = "btnGetCallOutNo";
            this.btnGetCallOutNo.Size = new System.Drawing.Size(129, 23);
            this.btnGetCallOutNo.TabIndex = 50;
            this.btnGetCallOutNo.Text = "MailOcxGetCallOutNo";
            this.btnGetCallOutNo.UseVisualStyleBackColor = true;
            this.btnGetCallOutNo.Click += new System.EventHandler(this.btnGetCallOutNo_Click);
            // 
            // btnReplyEmail
            // 
            this.btnReplyEmail.Location = new System.Drawing.Point(8, 143);
            this.btnReplyEmail.Name = "btnReplyEmail";
            this.btnReplyEmail.Size = new System.Drawing.Size(129, 23);
            this.btnReplyEmail.TabIndex = 48;
            this.btnReplyEmail.Text = "SDKReplyEmail";
            this.btnReplyEmail.UseVisualStyleBackColor = true;
            this.btnReplyEmail.Click += new System.EventHandler(this.btnReplyEmail_Click);
            // 
            // btnReceiveMail
            // 
            this.btnReceiveMail.Location = new System.Drawing.Point(8, 108);
            this.btnReceiveMail.Name = "btnReceiveMail";
            this.btnReceiveMail.Size = new System.Drawing.Size(129, 23);
            this.btnReceiveMail.TabIndex = 44;
            this.btnReceiveMail.Text = "MailOcxReceiveMail";
            this.btnReceiveMail.UseVisualStyleBackColor = true;
            this.btnReceiveMail.Click += new System.EventHandler(this.btnReceiveMail_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(8, 215);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(129, 23);
            this.btnSendEmail.TabIndex = 33;
            this.btnSendEmail.Text = "SDKSendEmail";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnGetSendEmailIndex
            // 
            this.btnGetSendEmailIndex.Location = new System.Drawing.Point(3, 231);
            this.btnGetSendEmailIndex.Name = "btnGetSendEmailIndex";
            this.btnGetSendEmailIndex.Size = new System.Drawing.Size(131, 23);
            this.btnGetSendEmailIndex.TabIndex = 29;
            this.btnGetSendEmailIndex.Text = "SDKGetEmailIndex";
            this.btnGetSendEmailIndex.UseVisualStyleBackColor = true;
            this.btnGetSendEmailIndex.Visible = false;
            this.btnGetSendEmailIndex.Click += new System.EventHandler(this.btnGetSendEmailIndex_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(7, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(137, 23);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnInitial
            // 
            this.btnInitial.Location = new System.Drawing.Point(152, 12);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(139, 23);
            this.btnInitial.TabIndex = 1;
            this.btnInitial.Text = "Initial";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // btnUnInitial
            // 
            this.btnUnInitial.Location = new System.Drawing.Point(297, 12);
            this.btnUnInitial.Name = "btnUnInitial";
            this.btnUnInitial.Size = new System.Drawing.Size(134, 23);
            this.btnUnInitial.TabIndex = 2;
            this.btnUnInitial.Text = "UnInitial";
            this.btnUnInitial.UseVisualStyleBackColor = true;
            this.btnUnInitial.Click += new System.EventHandler(this.btnUnInitial_Click);
            // 
            // btnSetIdle
            // 
            this.btnSetIdle.Location = new System.Drawing.Point(7, 9);
            this.btnSetIdle.Name = "btnSetIdle";
            this.btnSetIdle.Size = new System.Drawing.Size(129, 23);
            this.btnSetIdle.TabIndex = 4;
            this.btnSetIdle.Text = "Set Idle";
            this.btnSetIdle.UseVisualStyleBackColor = true;
            this.btnSetIdle.Click += new System.EventHandler(this.btnSetIdle_Click);
            // 
            // btnSnatchPickup
            // 
            this.btnSnatchPickup.Location = new System.Drawing.Point(8, 50);
            this.btnSnatchPickup.Name = "btnSnatchPickup";
            this.btnSnatchPickup.Size = new System.Drawing.Size(143, 23);
            this.btnSnatchPickup.TabIndex = 38;
            this.btnSnatchPickup.Text = "Snatch Pickup";
            this.btnSnatchPickup.UseVisualStyleBackColor = true;
            this.btnSnatchPickup.Click += new System.EventHandler(this.btnSnatchPickup_Click);
            // 
            // btnSetBusy
            // 
            this.btnSetBusy.Location = new System.Drawing.Point(7, 38);
            this.btnSetBusy.Name = "btnSetBusy";
            this.btnSetBusy.Size = new System.Drawing.Size(129, 23);
            this.btnSetBusy.TabIndex = 5;
            this.btnSetBusy.Text = "Set Busy";
            this.btnSetBusy.UseVisualStyleBackColor = true;
            this.btnSetBusy.Click += new System.EventHandler(this.btnSetBusy_Click);
            // 
            // btnSnatch
            // 
            this.btnSnatch.Location = new System.Drawing.Point(652, 21);
            this.btnSnatch.Name = "btnSnatch";
            this.btnSnatch.Size = new System.Drawing.Size(139, 23);
            this.btnSnatch.TabIndex = 37;
            this.btnSnatch.Text = "Snatch";
            this.btnSnatch.UseVisualStyleBackColor = true;
            this.btnSnatch.Click += new System.EventHandler(this.btnSnatch_Click);
            // 
            // btnMonitorToSnatch
            // 
            this.btnMonitorToSnatch.Location = new System.Drawing.Point(319, 21);
            this.btnMonitorToSnatch.Name = "btnMonitorToSnatch";
            this.btnMonitorToSnatch.Size = new System.Drawing.Size(176, 23);
            this.btnMonitorToSnatch.TabIndex = 36;
            this.btnMonitorToSnatch.Text = "Monitor To Snatch";
            this.btnMonitorToSnatch.UseVisualStyleBackColor = true;
            this.btnMonitorToSnatch.Click += new System.EventHandler(this.btnMonitorToSnatch_Click);
            // 
            // btnAddBlackList
            // 
            this.btnAddBlackList.Location = new System.Drawing.Point(7, 15);
            this.btnAddBlackList.Name = "btnAddBlackList";
            this.btnAddBlackList.Size = new System.Drawing.Size(150, 23);
            this.btnAddBlackList.TabIndex = 6;
            this.btnAddBlackList.Text = "Add Black List";
            this.btnAddBlackList.UseVisualStyleBackColor = true;
            this.btnAddBlackList.Click += new System.EventHandler(this.btnAddBlackList_Click);
            // 
            // btnMonitorToBarge
            // 
            this.btnMonitorToBarge.Location = new System.Drawing.Point(156, 21);
            this.btnMonitorToBarge.Name = "btnMonitorToBarge";
            this.btnMonitorToBarge.Size = new System.Drawing.Size(157, 23);
            this.btnMonitorToBarge.TabIndex = 35;
            this.btnMonitorToBarge.Text = "Monitor To Barge";
            this.btnMonitorToBarge.UseVisualStyleBackColor = true;
            this.btnMonitorToBarge.Click += new System.EventHandler(this.btnMonitorToBarge_Click);
            // 
            // btnRemoveBlackList
            // 
            this.btnRemoveBlackList.Location = new System.Drawing.Point(178, 15);
            this.btnRemoveBlackList.Name = "btnRemoveBlackList";
            this.btnRemoveBlackList.Size = new System.Drawing.Size(156, 23);
            this.btnRemoveBlackList.TabIndex = 7;
            this.btnRemoveBlackList.Text = "Remove Black List";
            this.btnRemoveBlackList.UseVisualStyleBackColor = true;
            this.btnRemoveBlackList.Click += new System.EventHandler(this.btnRemoveBlackList_Click);
            // 
            // btnBarge
            // 
            this.btnBarge.Location = new System.Drawing.Point(501, 21);
            this.btnBarge.Name = "btnBarge";
            this.btnBarge.Size = new System.Drawing.Size(145, 23);
            this.btnBarge.TabIndex = 34;
            this.btnBarge.Text = "Barge";
            this.btnBarge.UseVisualStyleBackColor = true;
            this.btnBarge.Click += new System.EventHandler(this.btnBarge_Click);
            // 
            // btnClearBlackList
            // 
            this.btnClearBlackList.Location = new System.Drawing.Point(356, 15);
            this.btnClearBlackList.Name = "btnClearBlackList";
            this.btnClearBlackList.Size = new System.Drawing.Size(149, 23);
            this.btnClearBlackList.TabIndex = 8;
            this.btnClearBlackList.Text = "Clear Black List";
            this.btnClearBlackList.UseVisualStyleBackColor = true;
            this.btnClearBlackList.Click += new System.EventHandler(this.btnClearBlackList_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(8, 21);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(143, 23);
            this.btnMonitor.TabIndex = 33;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnPTTOff
            // 
            this.btnPTTOff.Location = new System.Drawing.Point(156, 27);
            this.btnPTTOff.Name = "btnPTTOff";
            this.btnPTTOff.Size = new System.Drawing.Size(129, 23);
            this.btnPTTOff.TabIndex = 24;
            this.btnPTTOff.Text = "PTT Off";
            this.btnPTTOff.UseVisualStyleBackColor = true;
            this.btnPTTOff.Click += new System.EventHandler(this.btnPTTOff_Click);
            // 
            // btnPTTOn
            // 
            this.btnPTTOn.Location = new System.Drawing.Point(12, 27);
            this.btnPTTOn.Name = "btnPTTOn";
            this.btnPTTOn.Size = new System.Drawing.Size(129, 23);
            this.btnPTTOn.TabIndex = 23;
            this.btnPTTOn.Text = "PTT On";
            this.btnPTTOn.UseVisualStyleBackColor = true;
            this.btnPTTOn.Click += new System.EventHandler(this.btnPTTOn_Click);
            // 
            // btnQueryWirelessInfo
            // 
            this.btnQueryWirelessInfo.Location = new System.Drawing.Point(298, 27);
            this.btnQueryWirelessInfo.Name = "btnQueryWirelessInfo";
            this.btnQueryWirelessInfo.Size = new System.Drawing.Size(129, 23);
            this.btnQueryWirelessInfo.TabIndex = 20;
            this.btnQueryWirelessInfo.Text = "Get Wireless Info";
            this.btnQueryWirelessInfo.UseVisualStyleBackColor = true;
            this.btnQueryWirelessInfo.Click += new System.EventHandler(this.btnQueryWirelessInfo_Click);
            // 
            // btnQueryAllWireless
            // 
            this.btnQueryAllWireless.Location = new System.Drawing.Point(444, 27);
            this.btnQueryAllWireless.Name = "btnQueryAllWireless";
            this.btnQueryAllWireless.Size = new System.Drawing.Size(129, 23);
            this.btnQueryAllWireless.TabIndex = 21;
            this.btnQueryAllWireless.Text = "Get All Wireless Info";
            this.btnQueryAllWireless.UseVisualStyleBackColor = true;
            this.btnQueryAllWireless.Click += new System.EventHandler(this.btnQueryAllWireless_Click);
            // 
            // btnChangeAgentPwd
            // 
            this.btnChangeAgentPwd.Location = new System.Drawing.Point(710, 12);
            this.btnChangeAgentPwd.Name = "btnChangeAgentPwd";
            this.btnChangeAgentPwd.Size = new System.Drawing.Size(124, 23);
            this.btnChangeAgentPwd.TabIndex = 15;
            this.btnChangeAgentPwd.Text = "ChangeAgentPwd";
            this.btnChangeAgentPwd.UseVisualStyleBackColor = true;
            this.btnChangeAgentPwd.Click += new System.EventHandler(this.btnChangeAgentPwd_Click);
            // 
            // btnAddToRedList
            // 
            this.btnAddToRedList.Location = new System.Drawing.Point(8, 17);
            this.btnAddToRedList.Name = "btnAddToRedList";
            this.btnAddToRedList.Size = new System.Drawing.Size(149, 23);
            this.btnAddToRedList.TabIndex = 16;
            this.btnAddToRedList.Text = "AddToRedList";
            this.btnAddToRedList.UseVisualStyleBackColor = true;
            this.btnAddToRedList.Click += new System.EventHandler(this.btnAddToRedList_Click);
            // 
            // btnWorkStop
            // 
            this.btnWorkStop.Location = new System.Drawing.Point(293, 38);
            this.btnWorkStop.Name = "btnWorkStop";
            this.btnWorkStop.Size = new System.Drawing.Size(148, 23);
            this.btnWorkStop.TabIndex = 28;
            this.btnWorkStop.Text = "Work Stop";
            this.btnWorkStop.UseVisualStyleBackColor = true;
            this.btnWorkStop.Click += new System.EventHandler(this.btnWorkStop_Click);
            // 
            // btnAutoEnterIdle
            // 
            this.btnAutoEnterIdle.Location = new System.Drawing.Point(449, 9);
            this.btnAutoEnterIdle.Name = "btnAutoEnterIdle";
            this.btnAutoEnterIdle.Size = new System.Drawing.Size(181, 23);
            this.btnAutoEnterIdle.TabIndex = 26;
            this.btnAutoEnterIdle.Text = "SetAutoEnterIdle";
            this.btnAutoEnterIdle.UseVisualStyleBackColor = true;
            this.btnAutoEnterIdle.Click += new System.EventHandler(this.btnAutoEnterIdle_Click);
            // 
            // btnQueryBlackList
            // 
            this.btnQueryBlackList.Location = new System.Drawing.Point(530, 15);
            this.btnQueryBlackList.Name = "btnQueryBlackList";
            this.btnQueryBlackList.Size = new System.Drawing.Size(152, 23);
            this.btnQueryBlackList.TabIndex = 5;
            this.btnQueryBlackList.Text = "QueryBlackList";
            this.btnQueryBlackList.UseVisualStyleBackColor = true;
            this.btnQueryBlackList.Click += new System.EventHandler(this.btnQueryBlackList_Click);
            // 
            // lblSeekToTime
            // 
            this.lblSeekToTime.Location = new System.Drawing.Point(1, 49);
            this.lblSeekToTime.Name = "lblSeekToTime";
            this.lblSeekToTime.Size = new System.Drawing.Size(89, 12);
            this.lblSeekToTime.TabIndex = 34;
            this.lblSeekToTime.Text = "Time:";
            this.lblSeekToTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPlayRecordSeekTo
            // 
            this.txtPlayRecordSeekTo.Location = new System.Drawing.Point(96, 46);
            this.txtPlayRecordSeekTo.Name = "txtPlayRecordSeekTo";
            this.txtPlayRecordSeekTo.Size = new System.Drawing.Size(146, 21);
            this.txtPlayRecordSeekTo.TabIndex = 24;
            // 
            // txtRecordId
            // 
            this.txtRecordId.Location = new System.Drawing.Point(96, 15);
            this.txtRecordId.Name = "txtRecordId";
            this.txtRecordId.Size = new System.Drawing.Size(146, 21);
            this.txtRecordId.TabIndex = 21;
            // 
            // lblRecordId
            // 
            this.lblRecordId.Location = new System.Drawing.Point(3, 20);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(87, 12);
            this.lblRecordId.TabIndex = 20;
            this.lblRecordId.Text = "Record ID:";
            this.lblRecordId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(5, 118);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(83, 12);
            this.lblNote.TabIndex = 9;
            this.lblNote.Text = "Note:";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(94, 118);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(331, 84);
            this.txtNote.TabIndex = 8;
            // 
            // txtMciPort
            // 
            this.txtMciPort.Location = new System.Drawing.Point(325, 53);
            this.txtMciPort.Name = "txtMciPort";
            this.txtMciPort.Size = new System.Drawing.Size(100, 21);
            this.txtMciPort.TabIndex = 7;
            // 
            // txtMciIp
            // 
            this.txtMciIp.Location = new System.Drawing.Point(94, 53);
            this.txtMciIp.Name = "txtMciIp";
            this.txtMciIp.Size = new System.Drawing.Size(100, 21);
            this.txtMciIp.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(325, 22);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 21);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(94, 22);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(100, 21);
            this.txtDeviceId.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(225, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 12);
            this.label20.TabIndex = 3;
            this.label20.Text = "MCI Port:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(1, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "MCI IP:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(223, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(96, 12);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Number:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSMSSkillId
            // 
            this.lblSMSSkillId.Location = new System.Drawing.Point(-1, 25);
            this.lblSMSSkillId.Name = "lblSMSSkillId";
            this.lblSMSSkillId.Size = new System.Drawing.Size(89, 12);
            this.lblSMSSkillId.TabIndex = 0;
            this.lblSMSSkillId.Text = "SkillId:";
            this.lblSMSSkillId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelCfg
            // 
            this.panelCfg.AutoScroll = true;
            this.panelCfg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCfg.Controls.Add(this.btnUnifiedLogout);
            this.panelCfg.Controls.Add(this.btnUnifiedLogin);
            this.panelCfg.Controls.Add(this.btn_UninitialAll);
            this.panelCfg.Controls.Add(this.btnResetAgentSkill);
            this.panelCfg.Controls.Add(this.btnUnInitial);
            this.panelCfg.Controls.Add(this.btnConfig);
            this.panelCfg.Controls.Add(this.btnInitial);
            this.panelCfg.Controls.Add(this.btnChangeAgentPwd);
            this.panelCfg.Location = new System.Drawing.Point(0, 13);
            this.panelCfg.Name = "panelCfg";
            this.panelCfg.Size = new System.Drawing.Size(1164, 45);
            this.panelCfg.TabIndex = 56;
            this.panelCfg.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUnifiedLogout
            // 
            this.btnUnifiedLogout.Location = new System.Drawing.Point(979, 12);
            this.btnUnifiedLogout.Name = "btnUnifiedLogout";
            this.btnUnifiedLogout.Size = new System.Drawing.Size(140, 23);
            this.btnUnifiedLogout.TabIndex = 70;
            this.btnUnifiedLogout.Text = "UnifiedLogout";
            this.btnUnifiedLogout.UseVisualStyleBackColor = true;
            this.btnUnifiedLogout.Click += new System.EventHandler(this.btnUnifiedLogout_Click);
            // 
            // btnUnifiedLogin
            // 
            this.btnUnifiedLogin.Location = new System.Drawing.Point(843, 12);
            this.btnUnifiedLogin.Name = "btnUnifiedLogin";
            this.btnUnifiedLogin.Size = new System.Drawing.Size(129, 23);
            this.btnUnifiedLogin.TabIndex = 69;
            this.btnUnifiedLogin.Text = "UnifiedLogin";
            this.btnUnifiedLogin.UseVisualStyleBackColor = true;
            this.btnUnifiedLogin.Click += new System.EventHandler(this.btnUnifiedLogin_Click);
            // 
            // btn_UninitialAll
            // 
            this.btn_UninitialAll.Location = new System.Drawing.Point(437, 12);
            this.btn_UninitialAll.Name = "btn_UninitialAll";
            this.btn_UninitialAll.Size = new System.Drawing.Size(128, 23);
            this.btn_UninitialAll.TabIndex = 68;
            this.btn_UninitialAll.Text = "Uninitial All";
            this.btn_UninitialAll.UseVisualStyleBackColor = true;
            this.btn_UninitialAll.Click += new System.EventHandler(this.btn_UninitialAll_Click);
            // 
            // btnResetAgentSkill
            // 
            this.btnResetAgentSkill.Location = new System.Drawing.Point(576, 12);
            this.btnResetAgentSkill.Name = "btnResetAgentSkill";
            this.btnResetAgentSkill.Size = new System.Drawing.Size(124, 23);
            this.btnResetAgentSkill.TabIndex = 67;
            this.btnResetAgentSkill.Text = "ResetAgentSkill";
            this.btnResetAgentSkill.UseVisualStyleBackColor = true;
            this.btnResetAgentSkill.Click += new System.EventHandler(this.btnResetAgentSkill_Click);
            // 
            // btnGetSysVersion
            // 
            this.btnGetSysVersion.Location = new System.Drawing.Point(935, 82);
            this.btnGetSysVersion.Name = "btnGetSysVersion";
            this.btnGetSysVersion.Size = new System.Drawing.Size(181, 23);
            this.btnGetSysVersion.TabIndex = 69;
            this.btnGetSysVersion.Text = "GetSysVersion";
            this.btnGetSysVersion.UseVisualStyleBackColor = true;
            this.btnGetSysVersion.Click += new System.EventHandler(this.button_GetSysVersion_Click);
            // 
            // panelState
            // 
            this.panelState.AutoScroll = true;
            this.panelState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelState.Controls.Add(this.btnExitACW);
            this.panelState.Controls.Add(this.btnWork);
            this.panelState.Controls.Add(this.btnClearAutoEnterIdle);
            this.panelState.Controls.Add(this.BtnCancelRest);
            this.panelState.Controls.Add(this.btnSetIdle);
            this.panelState.Controls.Add(this.BtnRest);
            this.panelState.Controls.Add(this.btnSetBusy);
            this.panelState.Controls.Add(this.btnWorkStop);
            this.panelState.Controls.Add(this.btnAutoEnterIdle);
            this.panelState.Location = new System.Drawing.Point(0, 78);
            this.panelState.Name = "panelState";
            this.panelState.Size = new System.Drawing.Size(1164, 70);
            this.panelState.TabIndex = 57;
            // 
            // btnExitACW
            // 
            this.btnExitACW.Location = new System.Drawing.Point(637, 9);
            this.btnExitACW.Name = "btnExitACW";
            this.btnExitACW.Size = new System.Drawing.Size(141, 23);
            this.btnExitACW.TabIndex = 31;
            this.btnExitACW.Text = "Exit ACW";
            this.btnExitACW.UseVisualStyleBackColor = true;
            this.btnExitACW.Click += new System.EventHandler(this.btnExitACW_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(293, 9);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(148, 23);
            this.btnWork.TabIndex = 30;
            this.btnWork.Text = "Set Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnClearAutoEnterIdle
            // 
            this.btnClearAutoEnterIdle.Location = new System.Drawing.Point(449, 38);
            this.btnClearAutoEnterIdle.Name = "btnClearAutoEnterIdle";
            this.btnClearAutoEnterIdle.Size = new System.Drawing.Size(181, 23);
            this.btnClearAutoEnterIdle.TabIndex = 29;
            this.btnClearAutoEnterIdle.Text = "CancelAutoEnterIdle";
            this.btnClearAutoEnterIdle.UseVisualStyleBackColor = true;
            this.btnClearAutoEnterIdle.Click += new System.EventHandler(this.btnClearAutoEnterIdle_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab);
            this.tabControl.Controls.Add(this.tabWirelesss);
            this.tabControl.Controls.Add(this.tabList);
            this.tabControl.Controls.Add(this.tabM);
            this.tabControl.Controls.Add(this.tabRecord);
            this.tabControl.Controls.Add(this.tabEmail);
            this.tabControl.Controls.Add(this.tabNote);
            this.tabControl.Controls.Add(this.tabVRC);
            this.tabControl.Controls.Add(this.tabVCC);
            this.tabControl.Location = new System.Drawing.Point(10, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1149, 385);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 59;
            // 
            // tab
            // 
            this.tab.AutoScroll = true;
            this.tab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab.Controls.Add(this.panel6);
            this.tab.Controls.Add(this.panel5);
            this.tab.Controls.Add(this.panel4);
            this.tab.Location = new System.Drawing.Point(4, 22);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(1141, 359);
            this.tab.TabIndex = 0;
            this.tab.Text = "语音";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnGetSysVersion);
            this.panel6.Controls.Add(this.btn_QueryRleaseAuthority);
            this.panel6.Controls.Add(this.lblQuery);
            this.panel6.Controls.Add(this.btn_StopSubscriberCallListChange);
            this.panel6.Controls.Add(this.btn_SubscriberCallListChange);
            this.panel6.Controls.Add(this.btnQueryCallIdOnAgent);
            this.panel6.Controls.Add(this.btnQueryCallInfo);
            this.panel6.Controls.Add(this.btnQueryAgentSkillGroups);
            this.panel6.Controls.Add(this.btnQueryCurrentCallingScope);
            this.panel6.Controls.Add(this.btnQuerySkillGroupStatus);
            this.panel6.Controls.Add(this.btnQueryMaliciousCalls);
            this.panel6.Controls.Add(this.btnQueryIVRInfo);
            this.panel6.Controls.Add(this.btnQueryTotalSysInno);
            this.panel6.Controls.Add(this.btnQueryLostCalls);
            this.panel6.Controls.Add(this.btnQueryAllByGroupId);
            this.panel6.Controls.Add(this.btnQueryCallData);
            this.panel6.Controls.Add(this.btnQueryAgentStatus);
            this.panel6.Controls.Add(this.btnQueryCallListByGroup);
            this.panel6.Controls.Add(this.btnQuerySkillGroups);
            this.panel6.Location = new System.Drawing.Point(3, 243);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1130, 113);
            this.panel6.TabIndex = 68;
            // 
            // btn_QueryRleaseAuthority
            // 
            this.btn_QueryRleaseAuthority.Location = new System.Drawing.Point(738, 80);
            this.btn_QueryRleaseAuthority.Name = "btn_QueryRleaseAuthority";
            this.btn_QueryRleaseAuthority.Size = new System.Drawing.Size(191, 26);
            this.btn_QueryRleaseAuthority.TabIndex = 65;
            this.btn_QueryRleaseAuthority.Text = "QueryRleaseAuthority";
            this.btn_QueryRleaseAuthority.UseVisualStyleBackColor = true;
            this.btn_QueryRleaseAuthority.Click += new System.EventHandler(this.btn_QueryRleaseAuthority_Click);
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(5, 5);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(35, 12);
            this.lblQuery.TabIndex = 67;
            this.lblQuery.Text = "查 询";
            // 
            // btn_StopSubscriberCallListChange
            // 
            this.btn_StopSubscriberCallListChange.Location = new System.Drawing.Point(547, 82);
            this.btn_StopSubscriberCallListChange.Name = "btn_StopSubscriberCallListChange";
            this.btn_StopSubscriberCallListChange.Size = new System.Drawing.Size(185, 23);
            this.btn_StopSubscriberCallListChange.TabIndex = 68;
            this.btn_StopSubscriberCallListChange.Text = "StopSubscriberCallList";
            this.btn_StopSubscriberCallListChange.UseVisualStyleBackColor = true;
            this.btn_StopSubscriberCallListChange.Click += new System.EventHandler(this.btn_StopSubscriberCallListChange_Click);
            // 
            // btn_SubscriberCallListChange
            // 
            this.btn_SubscriberCallListChange.Location = new System.Drawing.Point(370, 81);
            this.btn_SubscriberCallListChange.Name = "btn_SubscriberCallListChange";
            this.btn_SubscriberCallListChange.Size = new System.Drawing.Size(169, 23);
            this.btn_SubscriberCallListChange.TabIndex = 67;
            this.btn_SubscriberCallListChange.Text = "SubscriberCallList";
            this.btn_SubscriberCallListChange.UseVisualStyleBackColor = true;
            this.btn_SubscriberCallListChange.Click += new System.EventHandler(this.btn_SubscriberCallListChange_Click);
            // 
            // btnQueryCallIdOnAgent
            // 
            this.btnQueryCallIdOnAgent.Location = new System.Drawing.Point(370, 53);
            this.btnQueryCallIdOnAgent.Name = "btnQueryCallIdOnAgent";
            this.btnQueryCallIdOnAgent.Size = new System.Drawing.Size(169, 23);
            this.btnQueryCallIdOnAgent.TabIndex = 64;
            this.btnQueryCallIdOnAgent.Text = "QueryCallIdOnAgent";
            this.btnQueryCallIdOnAgent.UseVisualStyleBackColor = true;
            this.btnQueryCallIdOnAgent.Click += new System.EventHandler(this.btnQueryCallIdOnAgent_Click);
            // 
            // btnQueryCallInfo
            // 
            this.btnQueryCallInfo.Location = new System.Drawing.Point(183, 53);
            this.btnQueryCallInfo.Name = "btnQueryCallInfo";
            this.btnQueryCallInfo.Size = new System.Drawing.Size(181, 23);
            this.btnQueryCallInfo.TabIndex = 64;
            this.btnQueryCallInfo.Text = "QueryCallInfo";
            this.btnQueryCallInfo.UseVisualStyleBackColor = true;
            this.btnQueryCallInfo.Click += new System.EventHandler(this.btnQueryCallInfo_Click);
            // 
            // btnQueryAgentSkillGroups
            // 
            this.btnQueryAgentSkillGroups.Location = new System.Drawing.Point(738, 24);
            this.btnQueryAgentSkillGroups.Name = "btnQueryAgentSkillGroups";
            this.btnQueryAgentSkillGroups.Size = new System.Drawing.Size(191, 23);
            this.btnQueryAgentSkillGroups.TabIndex = 60;
            this.btnQueryAgentSkillGroups.Text = "QueryAgentSkillGroups";
            this.btnQueryAgentSkillGroups.UseVisualStyleBackColor = true;
            this.btnQueryAgentSkillGroups.Click += new System.EventHandler(this.btnQueryAgentSkillGroups_Click);
            // 
            // btnQueryCurrentCallingScope
            // 
            this.btnQueryCurrentCallingScope.Location = new System.Drawing.Point(183, 82);
            this.btnQueryCurrentCallingScope.Name = "btnQueryCurrentCallingScope";
            this.btnQueryCurrentCallingScope.Size = new System.Drawing.Size(181, 23);
            this.btnQueryCurrentCallingScope.TabIndex = 32;
            this.btnQueryCurrentCallingScope.Text = "Query Current Calling Scope";
            this.btnQueryCurrentCallingScope.UseVisualStyleBackColor = true;
            this.btnQueryCurrentCallingScope.Click += new System.EventHandler(this.btnQueryCurrentCallingScope_Click);
            // 
            // btnQuerySkillGroupStatus
            // 
            this.btnQuerySkillGroupStatus.Location = new System.Drawing.Point(935, 24);
            this.btnQuerySkillGroupStatus.Name = "btnQuerySkillGroupStatus";
            this.btnQuerySkillGroupStatus.Size = new System.Drawing.Size(181, 23);
            this.btnQuerySkillGroupStatus.TabIndex = 59;
            this.btnQuerySkillGroupStatus.Text = "QuerySkillGroupStatus";
            this.btnQuerySkillGroupStatus.UseVisualStyleBackColor = true;
            this.btnQuerySkillGroupStatus.Click += new System.EventHandler(this.btnQuerySkillGroupStatus_Click);
            // 
            // btnQueryMaliciousCalls
            // 
            this.btnQueryMaliciousCalls.Location = new System.Drawing.Point(935, 53);
            this.btnQueryMaliciousCalls.Name = "btnQueryMaliciousCalls";
            this.btnQueryMaliciousCalls.Size = new System.Drawing.Size(181, 23);
            this.btnQueryMaliciousCalls.TabIndex = 57;
            this.btnQueryMaliciousCalls.Text = "QueryMaliciousCalls";
            this.btnQueryMaliciousCalls.UseVisualStyleBackColor = true;
            this.btnQueryMaliciousCalls.Click += new System.EventHandler(this.btnQueryMaliciousCalls_Click);
            // 
            // btnQueryIVRInfo
            // 
            this.btnQueryIVRInfo.Location = new System.Drawing.Point(547, 53);
            this.btnQueryIVRInfo.Name = "btnQueryIVRInfo";
            this.btnQueryIVRInfo.Size = new System.Drawing.Size(185, 23);
            this.btnQueryIVRInfo.TabIndex = 57;
            this.btnQueryIVRInfo.Text = "QueryIVRInfo";
            this.btnQueryIVRInfo.UseVisualStyleBackColor = true;
            this.btnQueryIVRInfo.Click += new System.EventHandler(this.btnQueryIVRInfo_Click);
            // 
            // btnQueryTotalSysInno
            // 
            this.btnQueryTotalSysInno.Location = new System.Drawing.Point(738, 53);
            this.btnQueryTotalSysInno.Name = "btnQueryTotalSysInno";
            this.btnQueryTotalSysInno.Size = new System.Drawing.Size(191, 23);
            this.btnQueryTotalSysInno.TabIndex = 54;
            this.btnQueryTotalSysInno.Text = "QueryAccessCode";
            this.btnQueryTotalSysInno.UseVisualStyleBackColor = true;
            this.btnQueryTotalSysInno.Click += new System.EventHandler(this.btnQueryTotalSysInno_Click);
            // 
            // btnQueryLostCalls
            // 
            this.btnQueryLostCalls.Location = new System.Drawing.Point(6, 82);
            this.btnQueryLostCalls.Name = "btnQueryLostCalls";
            this.btnQueryLostCalls.Size = new System.Drawing.Size(171, 23);
            this.btnQueryLostCalls.TabIndex = 53;
            this.btnQueryLostCalls.Text = "Query Lost Calls";
            this.btnQueryLostCalls.UseVisualStyleBackColor = true;
            this.btnQueryLostCalls.Click += new System.EventHandler(this.btnQueryLostCalls_Click);
            // 
            // btnQueryAllByGroupId
            // 
            this.btnQueryAllByGroupId.Location = new System.Drawing.Point(183, 24);
            this.btnQueryAllByGroupId.Name = "btnQueryAllByGroupId";
            this.btnQueryAllByGroupId.Size = new System.Drawing.Size(181, 23);
            this.btnQueryAllByGroupId.TabIndex = 30;
            this.btnQueryAllByGroupId.Text = "QueryAllAgentStatus";
            this.btnQueryAllByGroupId.UseVisualStyleBackColor = true;
            this.btnQueryAllByGroupId.Click += new System.EventHandler(this.btnQueryAllByGroupId_Click);
            // 
            // btnQueryCallData
            // 
            this.btnQueryCallData.Location = new System.Drawing.Point(5, 53);
            this.btnQueryCallData.Name = "btnQueryCallData";
            this.btnQueryCallData.Size = new System.Drawing.Size(172, 23);
            this.btnQueryCallData.TabIndex = 28;
            this.btnQueryCallData.Text = "QueryCallData";
            this.btnQueryCallData.UseVisualStyleBackColor = true;
            this.btnQueryCallData.Click += new System.EventHandler(this.btnQueryCallData_Click);
            // 
            // btnQueryAgentStatus
            // 
            this.btnQueryAgentStatus.Location = new System.Drawing.Point(5, 24);
            this.btnQueryAgentStatus.Name = "btnQueryAgentStatus";
            this.btnQueryAgentStatus.Size = new System.Drawing.Size(172, 23);
            this.btnQueryAgentStatus.TabIndex = 28;
            this.btnQueryAgentStatus.Text = "QueryAgentStatus";
            this.btnQueryAgentStatus.UseVisualStyleBackColor = true;
            this.btnQueryAgentStatus.Click += new System.EventHandler(this.btnQueryAgentStatus_Click);
            // 
            // btnQueryCallListByGroup
            // 
            this.btnQueryCallListByGroup.Location = new System.Drawing.Point(547, 24);
            this.btnQueryCallListByGroup.Name = "btnQueryCallListByGroup";
            this.btnQueryCallListByGroup.Size = new System.Drawing.Size(185, 23);
            this.btnQueryCallListByGroup.TabIndex = 52;
            this.btnQueryCallListByGroup.Text = "QueryCallListByGroup";
            this.btnQueryCallListByGroup.UseVisualStyleBackColor = true;
            this.btnQueryCallListByGroup.Click += new System.EventHandler(this.btnQueryCallList_Click);
            // 
            // btnQuerySkillGroups
            // 
            this.btnQuerySkillGroups.Location = new System.Drawing.Point(370, 24);
            this.btnQuerySkillGroups.Name = "btnQuerySkillGroups";
            this.btnQuerySkillGroups.Size = new System.Drawing.Size(169, 23);
            this.btnQuerySkillGroups.TabIndex = 29;
            this.btnQuerySkillGroups.Text = "QuerySkillGroups";
            this.btnQuerySkillGroups.UseVisualStyleBackColor = true;
            this.btnQuerySkillGroups.Click += new System.EventHandler(this.btnQuerySkillGroups_Click);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnCreateMeetingEx);
            this.panel5.Controls.Add(this.btnQueryMeetingMembers);
            this.panel5.Controls.Add(this.btnExitMeeting);
            this.panel5.Controls.Add(this.lblMeeting);
            this.panel5.Controls.Add(this.btnTransferMeetingMaster);
            this.panel5.Controls.Add(this.btnCreateMeeting);
            this.panel5.Controls.Add(this.BtnSingleStepMeeting);
            this.panel5.Controls.Add(this.btnMakeMeeting);
            this.panel5.Location = new System.Drawing.Point(1, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1132, 70);
            this.panel5.TabIndex = 66;
            // 
            // btnCreateMeetingEx
            // 
            this.btnCreateMeetingEx.Location = new System.Drawing.Point(145, 28);
            this.btnCreateMeetingEx.Name = "btnCreateMeetingEx";
            this.btnCreateMeetingEx.Size = new System.Drawing.Size(158, 23);
            this.btnCreateMeetingEx.TabIndex = 49;
            this.btnCreateMeetingEx.Text = "CreateMeetingEx";
            this.btnCreateMeetingEx.UseVisualStyleBackColor = true;
            this.btnCreateMeetingEx.Click += new System.EventHandler(this.btnCreateMeetingEx_Click);
            // 
            // btnQueryMeetingMembers
            // 
            this.btnQueryMeetingMembers.Location = new System.Drawing.Point(617, 28);
            this.btnQueryMeetingMembers.Name = "btnQueryMeetingMembers";
            this.btnQueryMeetingMembers.Size = new System.Drawing.Size(169, 23);
            this.btnQueryMeetingMembers.TabIndex = 8;
            this.btnQueryMeetingMembers.Text = "QueryMeetingMembers";
            this.btnQueryMeetingMembers.UseVisualStyleBackColor = true;
            this.btnQueryMeetingMembers.Click += new System.EventHandler(this.btnQueryMeetingMembers_Click);
            // 
            // btnExitMeeting
            // 
            this.btnExitMeeting.Location = new System.Drawing.Point(981, 28);
            this.btnExitMeeting.Name = "btnExitMeeting";
            this.btnExitMeeting.Size = new System.Drawing.Size(135, 23);
            this.btnExitMeeting.TabIndex = 40;
            this.btnExitMeeting.Text = "Exit Meeting";
            this.btnExitMeeting.UseVisualStyleBackColor = true;
            this.btnExitMeeting.Click += new System.EventHandler(this.btnExitMeeting_Click);
            // 
            // lblMeeting
            // 
            this.lblMeeting.AutoSize = true;
            this.lblMeeting.Location = new System.Drawing.Point(6, 5);
            this.lblMeeting.Name = "lblMeeting";
            this.lblMeeting.Size = new System.Drawing.Size(53, 12);
            this.lblMeeting.TabIndex = 65;
            this.lblMeeting.Text = "会议控制";
            // 
            // btnTransferMeetingMaster
            // 
            this.btnTransferMeetingMaster.Location = new System.Drawing.Point(792, 28);
            this.btnTransferMeetingMaster.Name = "btnTransferMeetingMaster";
            this.btnTransferMeetingMaster.Size = new System.Drawing.Size(183, 23);
            this.btnTransferMeetingMaster.TabIndex = 47;
            this.btnTransferMeetingMaster.Text = "TransferMeetingMaster";
            this.btnTransferMeetingMaster.UseVisualStyleBackColor = true;
            this.btnTransferMeetingMaster.Click += new System.EventHandler(this.btnTransferMeetingMaster_Click);
            // 
            // btnCreateMeeting
            // 
            this.btnCreateMeeting.Location = new System.Drawing.Point(6, 28);
            this.btnCreateMeeting.Name = "btnCreateMeeting";
            this.btnCreateMeeting.Size = new System.Drawing.Size(132, 23);
            this.btnCreateMeeting.TabIndex = 15;
            this.btnCreateMeeting.Text = "Create Meeting";
            this.btnCreateMeeting.UseVisualStyleBackColor = true;
            this.btnCreateMeeting.Click += new System.EventHandler(this.btnCreateMeeting_Click);
            // 
            // BtnSingleStepMeeting
            // 
            this.BtnSingleStepMeeting.Location = new System.Drawing.Point(455, 28);
            this.BtnSingleStepMeeting.Name = "BtnSingleStepMeeting";
            this.BtnSingleStepMeeting.Size = new System.Drawing.Size(156, 23);
            this.BtnSingleStepMeeting.TabIndex = 7;
            this.BtnSingleStepMeeting.Text = "SingleStepMeeting";
            this.BtnSingleStepMeeting.UseVisualStyleBackColor = true;
            this.BtnSingleStepMeeting.Click += new System.EventHandler(this.BtnSingleStepMeeting_Click);
            // 
            // btnMakeMeeting
            // 
            this.btnMakeMeeting.Location = new System.Drawing.Point(309, 28);
            this.btnMakeMeeting.Name = "btnMakeMeeting";
            this.btnMakeMeeting.Size = new System.Drawing.Size(140, 23);
            this.btnMakeMeeting.TabIndex = 16;
            this.btnMakeMeeting.Text = "Make Meeting";
            this.btnMakeMeeting.UseVisualStyleBackColor = true;
            this.btnMakeMeeting.Click += new System.EventHandler(this.btnMakeMeeting_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSingleStepSuccTransferEx);
            this.panel4.Controls.Add(this.btn_TransferConsulting);
            this.panel4.Controls.Add(this.lblCall);
            this.panel4.Controls.Add(this.btnAgentSendDTMF);
            this.panel4.Controls.Add(this.btnTransToIVR);
            this.panel4.Controls.Add(this.btnPollingCallEx);
            this.panel4.Controls.Add(this.btnDialEx);
            this.panel4.Controls.Add(this.btnSendMessage);
            this.panel4.Controls.Add(this.btUnMute);
            this.panel4.Controls.Add(this.btnTransferToSkillGroup);
            this.panel4.Controls.Add(this.btnMute);
            this.panel4.Controls.Add(this.btnHangup);
            this.panel4.Controls.Add(this.btnEndConsultCall);
            this.panel4.Controls.Add(this.btnBlindTransfer);
            this.panel4.Controls.Add(this.btnTransToAgent);
            this.panel4.Controls.Add(this.btnConsult);
            this.panel4.Controls.Add(this.btnHoldCall);
            this.panel4.Controls.Add(this.btnPickup);
            this.panel4.Controls.Add(this.btnSetCustomerLevel);
            this.panel4.Controls.Add(this.btnSetCustomizedRecordInfo);
            this.panel4.Controls.Add(this.btnSingleStepSuccTransfer);
            this.panel4.Controls.Add(this.btnSetCallData);
            this.panel4.Controls.Add(this.btnPollingCall);
            this.panel4.Controls.Add(this.btnRetrieveCall);
            this.panel4.Controls.Add(this.btnCancelAutoAnswer);
            this.panel4.Controls.Add(this.btnDial);
            this.panel4.Controls.Add(this.btnSetAutoAnswer);
            this.panel4.Location = new System.Drawing.Point(0, 6);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel4.Size = new System.Drawing.Size(1133, 155);
            this.panel4.TabIndex = 64;
            // 
            // btnSingleStepSuccTransferEx
            // 
            this.btnSingleStepSuccTransferEx.Location = new System.Drawing.Point(140, 116);
            this.btnSingleStepSuccTransferEx.Name = "btnSingleStepSuccTransferEx";
            this.btnSingleStepSuccTransferEx.Size = new System.Drawing.Size(132, 23);
            this.btnSingleStepSuccTransferEx.TabIndex = 65;
            this.btnSingleStepSuccTransferEx.Text = "Succ TransferEx ";
            this.btnSingleStepSuccTransferEx.UseVisualStyleBackColor = true;
            this.btnSingleStepSuccTransferEx.Click += new System.EventHandler(this.btnSuccTransferEx_Click);
            // 
            // btn_TransferConsulting
            // 
            this.btn_TransferConsulting.Location = new System.Drawing.Point(6, 116);
            this.btn_TransferConsulting.Name = "btn_TransferConsulting";
            this.btn_TransferConsulting.Size = new System.Drawing.Size(129, 23);
            this.btn_TransferConsulting.TabIndex = 64;
            this.btn_TransferConsulting.Text = "TransferConsulting";
            this.btn_TransferConsulting.UseVisualStyleBackColor = true;
            this.btn_TransferConsulting.Click += new System.EventHandler(this.btn_TransferConsulting_Click);
            // 
            // lblCall
            // 
            this.lblCall.AutoSize = true;
            this.lblCall.Location = new System.Drawing.Point(6, 10);
            this.lblCall.Name = "lblCall";
            this.lblCall.Size = new System.Drawing.Size(53, 12);
            this.lblCall.TabIndex = 63;
            this.lblCall.Text = "呼叫控制";
            // 
            // btnAgentSendDTMF
            // 
            this.btnAgentSendDTMF.Location = new System.Drawing.Point(992, 58);
            this.btnAgentSendDTMF.Name = "btnAgentSendDTMF";
            this.btnAgentSendDTMF.Size = new System.Drawing.Size(124, 23);
            this.btnAgentSendDTMF.TabIndex = 56;
            this.btnAgentSendDTMF.Text = "SendDTMF";
            this.btnAgentSendDTMF.UseVisualStyleBackColor = true;
            this.btnAgentSendDTMF.Click += new System.EventHandler(this.btnAgentSendDTMF_Click);
            // 
            // btnTransToIVR
            // 
            this.btnTransToIVR.Location = new System.Drawing.Point(568, 58);
            this.btnTransToIVR.Name = "btnTransToIVR";
            this.btnTransToIVR.Size = new System.Drawing.Size(134, 23);
            this.btnTransToIVR.TabIndex = 57;
            this.btnTransToIVR.Text = "TransToIVR";
            this.btnTransToIVR.UseVisualStyleBackColor = true;
            this.btnTransToIVR.Click += new System.EventHandler(this.btnTransToIVR_Click);
            // 
            // btnPollingCallEx
            // 
            this.btnPollingCallEx.Location = new System.Drawing.Point(842, 29);
            this.btnPollingCallEx.Name = "btnPollingCallEx";
            this.btnPollingCallEx.Size = new System.Drawing.Size(144, 23);
            this.btnPollingCallEx.TabIndex = 55;
            this.btnPollingCallEx.Text = "PollingCallEx";
            this.btnPollingCallEx.UseVisualStyleBackColor = true;
            this.btnPollingCallEx.Click += new System.EventHandler(this.btnPollingCallEx_Click);
            // 
            // btnDialEx
            // 
            this.btnDialEx.Location = new System.Drawing.Point(842, 58);
            this.btnDialEx.Name = "btnDialEx";
            this.btnDialEx.Size = new System.Drawing.Size(144, 23);
            this.btnDialEx.TabIndex = 54;
            this.btnDialEx.Text = "DialEx";
            this.btnDialEx.UseVisualStyleBackColor = true;
            this.btnDialEx.Click += new System.EventHandler(this.btnDialEx_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(842, 87);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(144, 23);
            this.btnSendMessage.TabIndex = 61;
            this.btnSendMessage.Text = "SendMessage";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btUnMute
            // 
            this.btUnMute.Location = new System.Drawing.Point(423, 87);
            this.btUnMute.Name = "btUnMute";
            this.btUnMute.Size = new System.Drawing.Size(139, 23);
            this.btUnMute.TabIndex = 63;
            this.btUnMute.Text = "UnMute";
            this.btUnMute.UseVisualStyleBackColor = true;
            this.btUnMute.Click += new System.EventHandler(this.btUnMute_Click);
            // 
            // btnTransferToSkillGroup
            // 
            this.btnTransferToSkillGroup.Location = new System.Drawing.Point(423, 58);
            this.btnTransferToSkillGroup.Name = "btnTransferToSkillGroup";
            this.btnTransferToSkillGroup.Size = new System.Drawing.Size(139, 23);
            this.btnTransferToSkillGroup.TabIndex = 41;
            this.btnTransferToSkillGroup.Text = "TransferToSkillGroup";
            this.btnTransferToSkillGroup.UseVisualStyleBackColor = true;
            this.btnTransferToSkillGroup.Click += new System.EventHandler(this.btnTransferToSkillGroup_Click);
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(280, 87);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(137, 23);
            this.btnMute.TabIndex = 62;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnHangup
            // 
            this.btnHangup.Location = new System.Drawing.Point(141, 29);
            this.btnHangup.Name = "btnHangup";
            this.btnHangup.Size = new System.Drawing.Size(132, 23);
            this.btnHangup.TabIndex = 13;
            this.btnHangup.Text = "Hangup";
            this.btnHangup.UseVisualStyleBackColor = true;
            this.btnHangup.Click += new System.EventHandler(this.btnHangup_Click);
            // 
            // btnEndConsultCall
            // 
            this.btnEndConsultCall.Location = new System.Drawing.Point(708, 29);
            this.btnEndConsultCall.Name = "btnEndConsultCall";
            this.btnEndConsultCall.Size = new System.Drawing.Size(128, 23);
            this.btnEndConsultCall.TabIndex = 40;
            this.btnEndConsultCall.Text = "End Consult Call";
            this.btnEndConsultCall.UseVisualStyleBackColor = true;
            this.btnEndConsultCall.Click += new System.EventHandler(this.btnEndConsultCall_Click);
            // 
            // btnBlindTransfer
            // 
            this.btnBlindTransfer.Location = new System.Drawing.Point(140, 58);
            this.btnBlindTransfer.Name = "btnBlindTransfer";
            this.btnBlindTransfer.Size = new System.Drawing.Size(132, 23);
            this.btnBlindTransfer.TabIndex = 19;
            this.btnBlindTransfer.Text = "Blind Transfer";
            this.btnBlindTransfer.UseVisualStyleBackColor = true;
            this.btnBlindTransfer.Click += new System.EventHandler(this.btnBlindTransfer_Click);
            // 
            // btnTransToAgent
            // 
            this.btnTransToAgent.Location = new System.Drawing.Point(6, 58);
            this.btnTransToAgent.Name = "btnTransToAgent";
            this.btnTransToAgent.Size = new System.Drawing.Size(129, 23);
            this.btnTransToAgent.TabIndex = 18;
            this.btnTransToAgent.Text = "Trans to Agent";
            this.btnTransToAgent.UseVisualStyleBackColor = true;
            this.btnTransToAgent.Click += new System.EventHandler(this.btnTransToAgent_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(568, 29);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(134, 23);
            this.btnConsult.TabIndex = 14;
            this.btnConsult.Text = "Consult Call";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnHoldCall
            // 
            this.btnHoldCall.Location = new System.Drawing.Point(279, 29);
            this.btnHoldCall.Name = "btnHoldCall";
            this.btnHoldCall.Size = new System.Drawing.Size(138, 23);
            this.btnHoldCall.TabIndex = 11;
            this.btnHoldCall.Text = "Hold Call";
            this.btnHoldCall.UseVisualStyleBackColor = true;
            this.btnHoldCall.Click += new System.EventHandler(this.btnHoldCall_Click);
            // 
            // btnPickup
            // 
            this.btnPickup.Location = new System.Drawing.Point(6, 29);
            this.btnPickup.Name = "btnPickup";
            this.btnPickup.Size = new System.Drawing.Size(129, 23);
            this.btnPickup.TabIndex = 9;
            this.btnPickup.Text = "Pickup";
            this.btnPickup.UseVisualStyleBackColor = true;
            this.btnPickup.Click += new System.EventHandler(this.btnPickup_Click);
            // 
            // btnSetCustomerLevel
            // 
            this.btnSetCustomerLevel.Location = new System.Drawing.Point(708, 87);
            this.btnSetCustomerLevel.Name = "btnSetCustomerLevel";
            this.btnSetCustomerLevel.Size = new System.Drawing.Size(128, 23);
            this.btnSetCustomerLevel.TabIndex = 28;
            this.btnSetCustomerLevel.Text = "SetCustomerLevel";
            this.btnSetCustomerLevel.UseVisualStyleBackColor = true;
            this.btnSetCustomerLevel.Click += new System.EventHandler(this.btnSetCustomerLevel_Click);
            // 
            // btnSetCustomizedRecordInfo
            // 
            this.btnSetCustomizedRecordInfo.Location = new System.Drawing.Point(991, 87);
            this.btnSetCustomizedRecordInfo.Name = "btnSetCustomizedRecordInfo";
            this.btnSetCustomizedRecordInfo.Size = new System.Drawing.Size(128, 23);
            this.btnSetCustomizedRecordInfo.TabIndex = 28;
            this.btnSetCustomizedRecordInfo.Text = "SetCustomizedRecordInfo";
            this.btnSetCustomizedRecordInfo.UseVisualStyleBackColor = true;
            this.btnSetCustomizedRecordInfo.Click += new System.EventHandler(this.btnSetCustomizedRecordInfo_Click);
            // 
            // btnSingleStepSuccTransfer
            // 
            this.btnSingleStepSuccTransfer.Location = new System.Drawing.Point(279, 58);
            this.btnSingleStepSuccTransfer.Name = "btnSingleStepSuccTransfer";
            this.btnSingleStepSuccTransfer.Size = new System.Drawing.Size(138, 23);
            this.btnSingleStepSuccTransfer.TabIndex = 10;
            this.btnSingleStepSuccTransfer.Text = "Succ Transfer";
            this.btnSingleStepSuccTransfer.UseVisualStyleBackColor = true;
            this.btnSingleStepSuccTransfer.Click += new System.EventHandler(this.btnSingleStepSuccTransfer_Click);
            // 
            // btnSetCallData
            // 
            this.btnSetCallData.Location = new System.Drawing.Point(568, 87);
            this.btnSetCallData.Name = "btnSetCallData";
            this.btnSetCallData.Size = new System.Drawing.Size(134, 23);
            this.btnSetCallData.TabIndex = 28;
            this.btnSetCallData.Text = "SetCallData";
            this.btnSetCallData.UseVisualStyleBackColor = true;
            this.btnSetCallData.Click += new System.EventHandler(this.btnSetCallData_Click);
            // 
            // btnPollingCall
            // 
            this.btnPollingCall.Location = new System.Drawing.Point(992, 29);
            this.btnPollingCall.Name = "btnPollingCall";
            this.btnPollingCall.Size = new System.Drawing.Size(124, 23);
            this.btnPollingCall.TabIndex = 4;
            this.btnPollingCall.Text = "PollingCall";
            this.btnPollingCall.UseVisualStyleBackColor = true;
            this.btnPollingCall.Click += new System.EventHandler(this.btnPollingCall_Click);
            // 
            // btnRetrieveCall
            // 
            this.btnRetrieveCall.Location = new System.Drawing.Point(423, 29);
            this.btnRetrieveCall.Name = "btnRetrieveCall";
            this.btnRetrieveCall.Size = new System.Drawing.Size(139, 23);
            this.btnRetrieveCall.TabIndex = 12;
            this.btnRetrieveCall.Text = "Retrieve Call";
            this.btnRetrieveCall.UseVisualStyleBackColor = true;
            this.btnRetrieveCall.Click += new System.EventHandler(this.btnRetrieveCall_Click);
            // 
            // btnCancelAutoAnswer
            // 
            this.btnCancelAutoAnswer.Location = new System.Drawing.Point(140, 87);
            this.btnCancelAutoAnswer.Name = "btnCancelAutoAnswer";
            this.btnCancelAutoAnswer.Size = new System.Drawing.Size(132, 23);
            this.btnCancelAutoAnswer.TabIndex = 28;
            this.btnCancelAutoAnswer.Text = "CancelAutoAnswer";
            this.btnCancelAutoAnswer.UseVisualStyleBackColor = true;
            this.btnCancelAutoAnswer.Click += new System.EventHandler(this.btnCancelAutoAnswer_Click);
            // 
            // btnDial
            // 
            this.btnDial.Location = new System.Drawing.Point(708, 58);
            this.btnDial.Name = "btnDial";
            this.btnDial.Size = new System.Drawing.Size(128, 23);
            this.btnDial.TabIndex = 10;
            this.btnDial.Text = "Dial";
            this.btnDial.UseVisualStyleBackColor = true;
            this.btnDial.Click += new System.EventHandler(this.btnDial_Click);
            // 
            // btnSetAutoAnswer
            // 
            this.btnSetAutoAnswer.Location = new System.Drawing.Point(6, 87);
            this.btnSetAutoAnswer.Name = "btnSetAutoAnswer";
            this.btnSetAutoAnswer.Size = new System.Drawing.Size(129, 23);
            this.btnSetAutoAnswer.TabIndex = 28;
            this.btnSetAutoAnswer.Text = "SetAutoAnswer";
            this.btnSetAutoAnswer.UseVisualStyleBackColor = true;
            this.btnSetAutoAnswer.Click += new System.EventHandler(this.btnSetAutoAnswer_Click);
            // 
            // tabWirelesss
            // 
            this.tabWirelesss.AutoScroll = true;
            this.tabWirelesss.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabWirelesss.Controls.Add(this.btnPTTOff);
            this.tabWirelesss.Controls.Add(this.bntQueryUsingWirelessDevice);
            this.tabWirelesss.Controls.Add(this.btnPTTOn);
            this.tabWirelesss.Controls.Add(this.btnQueryWirelessInfo);
            this.tabWirelesss.Controls.Add(this.btnQueryAllWireless);
            this.tabWirelesss.Location = new System.Drawing.Point(4, 22);
            this.tabWirelesss.Name = "tabWirelesss";
            this.tabWirelesss.Padding = new System.Windows.Forms.Padding(3);
            this.tabWirelesss.Size = new System.Drawing.Size(1141, 359);
            this.tabWirelesss.TabIndex = 2;
            this.tabWirelesss.Text = "Wireless";
            // 
            // tabList
            // 
            this.tabList.AutoScroll = true;
            this.tabList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabList.Controls.Add(this.panel8);
            this.tabList.Controls.Add(this.lblRed);
            this.tabList.Controls.Add(this.panel7);
            this.tabList.Controls.Add(this.lblBlack);
            this.tabList.Location = new System.Drawing.Point(4, 22);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(1141, 359);
            this.tabList.TabIndex = 3;
            this.tabList.Text = "名单管理";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.AutoScroll = true;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnQueryAllRedList);
            this.panel8.Controls.Add(this.btnRemoveFromRedList);
            this.panel8.Controls.Add(this.btnRemoveAllRedList);
            this.panel8.Controls.Add(this.btnQueryRedList);
            this.panel8.Controls.Add(this.btnAddToRedList);
            this.panel8.Location = new System.Drawing.Point(3, 157);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1063, 65);
            this.panel8.TabIndex = 66;
            // 
            // btnQueryAllRedList
            // 
            this.btnQueryAllRedList.Location = new System.Drawing.Point(712, 17);
            this.btnQueryAllRedList.Name = "btnQueryAllRedList";
            this.btnQueryAllRedList.Size = new System.Drawing.Size(160, 23);
            this.btnQueryAllRedList.TabIndex = 25;
            this.btnQueryAllRedList.Text = "Query All Red List";
            this.btnQueryAllRedList.UseVisualStyleBackColor = true;
            this.btnQueryAllRedList.Click += new System.EventHandler(this.btnQueryAllRedList_Click);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(7, 142);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(65, 12);
            this.lblRed.TabIndex = 65;
            this.lblRed.Text = "红名单管理";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.AutoScroll = true;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnQueryAllBlackListEx);
            this.panel7.Controls.Add(this.btnQueryBlackListEx);
            this.panel7.Controls.Add(this.btnAddBlackListEx);
            this.panel7.Controls.Add(this.btnQueryAllBlackList);
            this.panel7.Controls.Add(this.btnQueryBlackList);
            this.panel7.Controls.Add(this.btnAddBlackList);
            this.panel7.Controls.Add(this.btnRemoveBlackList);
            this.panel7.Controls.Add(this.btnClearBlackList);
            this.panel7.Location = new System.Drawing.Point(3, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1063, 92);
            this.panel7.TabIndex = 64;
            // 
            // btnQueryAllBlackListEx
            // 
            this.btnQueryAllBlackListEx.Location = new System.Drawing.Point(356, 54);
            this.btnQueryAllBlackListEx.Name = "btnQueryAllBlackListEx";
            this.btnQueryAllBlackListEx.Size = new System.Drawing.Size(160, 23);
            this.btnQueryAllBlackListEx.TabIndex = 12;
            this.btnQueryAllBlackListEx.Text = "Query All Black List(Ex)";
            this.btnQueryAllBlackListEx.UseVisualStyleBackColor = true;
            this.btnQueryAllBlackListEx.Click += new System.EventHandler(this.btnQueryAllBlackListEx_Click);
            // 
            // btnQueryBlackListEx
            // 
            this.btnQueryBlackListEx.Location = new System.Drawing.Point(178, 54);
            this.btnQueryBlackListEx.Name = "btnQueryBlackListEx";
            this.btnQueryBlackListEx.Size = new System.Drawing.Size(152, 23);
            this.btnQueryBlackListEx.TabIndex = 11;
            this.btnQueryBlackListEx.Text = "Query Black List(Ex)";
            this.btnQueryBlackListEx.UseVisualStyleBackColor = true;
            this.btnQueryBlackListEx.Click += new System.EventHandler(this.btnQueryBlackListEx_Click);
            // 
            // btnAddBlackListEx
            // 
            this.btnAddBlackListEx.Location = new System.Drawing.Point(7, 54);
            this.btnAddBlackListEx.Name = "btnAddBlackListEx";
            this.btnAddBlackListEx.Size = new System.Drawing.Size(150, 23);
            this.btnAddBlackListEx.TabIndex = 10;
            this.btnAddBlackListEx.Text = "Add Black List(Ex)";
            this.btnAddBlackListEx.UseVisualStyleBackColor = true;
            this.btnAddBlackListEx.Click += new System.EventHandler(this.btnAddBlackListEx_Click);
            // 
            // btnQueryAllBlackList
            // 
            this.btnQueryAllBlackList.Location = new System.Drawing.Point(712, 15);
            this.btnQueryAllBlackList.Name = "btnQueryAllBlackList";
            this.btnQueryAllBlackList.Size = new System.Drawing.Size(160, 23);
            this.btnQueryAllBlackList.TabIndex = 9;
            this.btnQueryAllBlackList.Text = "Query All Black List";
            this.btnQueryAllBlackList.UseVisualStyleBackColor = true;
            this.btnQueryAllBlackList.Click += new System.EventHandler(this.btnQueryAllBlackList_Click);
            // 
            // lblBlack
            // 
            this.lblBlack.AutoSize = true;
            this.lblBlack.Location = new System.Drawing.Point(6, 17);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(65, 12);
            this.lblBlack.TabIndex = 63;
            this.lblBlack.Text = "黑名单管理";
            // 
            // tabM
            // 
            this.tabM.AutoScroll = true;
            this.tabM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabM.Controls.Add(this.btnStopSubscribeAgentEvent);
            this.tabM.Controls.Add(this.btnSubscribeAgentEvent);
            this.tabM.Controls.Add(this.btnStopWhisper);
            this.tabM.Controls.Add(this.btnWhisper);
            this.tabM.Controls.Add(this.btnSuperviseSwitch);
            this.tabM.Controls.Add(this.btnSnatchPickup);
            this.tabM.Controls.Add(this.btnMonitorToBarge);
            this.tabM.Controls.Add(this.btnMonitor);
            this.tabM.Controls.Add(this.btnBarge);
            this.tabM.Controls.Add(this.btnMonitorToSnatch);
            this.tabM.Controls.Add(this.btnSnatch);
            this.tabM.Controls.Add(this.btnSelectPickup);
            this.tabM.Controls.Add(this.btnForceLogout);
            this.tabM.Location = new System.Drawing.Point(4, 22);
            this.tabM.Name = "tabM";
            this.tabM.Padding = new System.Windows.Forms.Padding(3);
            this.tabM.Size = new System.Drawing.Size(1141, 359);
            this.tabM.TabIndex = 4;
            this.tabM.Text = "质检";
            // 
            // btnStopSubscribeAgentEvent
            // 
            this.btnStopSubscribeAgentEvent.Location = new System.Drawing.Point(319, 81);
            this.btnStopSubscribeAgentEvent.Name = "btnStopSubscribeAgentEvent";
            this.btnStopSubscribeAgentEvent.Size = new System.Drawing.Size(176, 23);
            this.btnStopSubscribeAgentEvent.TabIndex = 55;
            this.btnStopSubscribeAgentEvent.Text = "Stop Subscribe Event";
            this.btnStopSubscribeAgentEvent.UseVisualStyleBackColor = true;
            this.btnStopSubscribeAgentEvent.Click += new System.EventHandler(this.btnStopSubscribeAgentEvent_Click);
            // 
            // btnSubscribeAgentEvent
            // 
            this.btnSubscribeAgentEvent.Location = new System.Drawing.Point(157, 81);
            this.btnSubscribeAgentEvent.Name = "btnSubscribeAgentEvent";
            this.btnSubscribeAgentEvent.Size = new System.Drawing.Size(156, 23);
            this.btnSubscribeAgentEvent.TabIndex = 54;
            this.btnSubscribeAgentEvent.Text = "Subscribe  Event";
            this.btnSubscribeAgentEvent.UseVisualStyleBackColor = true;
            this.btnSubscribeAgentEvent.Click += new System.EventHandler(this.btnSubscribeAgentEvent_Click);
            // 
            // btnStopWhisper
            // 
            this.btnStopWhisper.Location = new System.Drawing.Point(652, 50);
            this.btnStopWhisper.Name = "btnStopWhisper";
            this.btnStopWhisper.Size = new System.Drawing.Size(139, 23);
            this.btnStopWhisper.TabIndex = 52;
            this.btnStopWhisper.Text = "Supervise Stop";
            this.btnStopWhisper.UseVisualStyleBackColor = true;
            this.btnStopWhisper.Click += new System.EventHandler(this.btnStopWhisper_Click);
            // 
            // btnWhisper
            // 
            this.btnWhisper.Location = new System.Drawing.Point(501, 50);
            this.btnWhisper.Name = "btnWhisper";
            this.btnWhisper.Size = new System.Drawing.Size(145, 23);
            this.btnWhisper.TabIndex = 51;
            this.btnWhisper.Text = "Whisper";
            this.btnWhisper.UseVisualStyleBackColor = true;
            this.btnWhisper.Click += new System.EventHandler(this.btnWhisper_Click);
            // 
            // btnSuperviseSwitch
            // 
            this.btnSuperviseSwitch.Location = new System.Drawing.Point(8, 79);
            this.btnSuperviseSwitch.Name = "btnSuperviseSwitch";
            this.btnSuperviseSwitch.Size = new System.Drawing.Size(143, 23);
            this.btnSuperviseSwitch.TabIndex = 53;
            this.btnSuperviseSwitch.Text = "SuperviseSwitch";
            this.btnSuperviseSwitch.UseVisualStyleBackColor = true;
            this.btnSuperviseSwitch.Click += new System.EventHandler(this.btnSuperviseSwitch_Click);
            // 
            // tabRecord
            // 
            this.tabRecord.AutoScroll = true;
            this.tabRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRecord.Controls.Add(this.txtDownloadFormat);
            this.tabRecord.Controls.Add(this.lblDownloadFormat);
            this.tabRecord.Controls.Add(this.txtStorePath);
            this.tabRecord.Controls.Add(this.txtRecordPath);
            this.tabRecord.Controls.Add(this.lblStorePath);
            this.tabRecord.Controls.Add(this.lblRecordPath);
            this.tabRecord.Controls.Add(this.btnDownloadRecord);
            this.tabRecord.Controls.Add(this.lblSeekToTime);
            this.tabRecord.Controls.Add(this.btnStopPlayRecord);
            this.tabRecord.Controls.Add(this.btnPausePlayRecord);
            this.tabRecord.Controls.Add(this.btnGetRecordLength);
            this.tabRecord.Controls.Add(this.btnPlayRecordSeekTo);
            this.tabRecord.Controls.Add(this.btnPlayRecord);
            this.tabRecord.Controls.Add(this.txtPlayRecordSeekTo);
            this.tabRecord.Controls.Add(this.txtRecordId);
            this.tabRecord.Controls.Add(this.btnResumePlayRecord);
            this.tabRecord.Controls.Add(this.lblRecordId);
            this.tabRecord.Location = new System.Drawing.Point(4, 22);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecord.Size = new System.Drawing.Size(1141, 359);
            this.tabRecord.TabIndex = 5;
            this.tabRecord.Text = "录音管理";
            // 
            // txtDownloadFormat
            // 
            this.txtDownloadFormat.Location = new System.Drawing.Point(115, 188);
            this.txtDownloadFormat.Name = "txtDownloadFormat";
            this.txtDownloadFormat.Size = new System.Drawing.Size(100, 21);
            this.txtDownloadFormat.TabIndex = 48;
            this.txtDownloadFormat.Text = "1";
            // 
            // lblDownloadFormat
            // 
            this.lblDownloadFormat.AutoSize = true;
            this.lblDownloadFormat.Location = new System.Drawing.Point(11, 197);
            this.lblDownloadFormat.Name = "lblDownloadFormat";
            this.lblDownloadFormat.Size = new System.Drawing.Size(101, 12);
            this.lblDownloadFormat.TabIndex = 47;
            this.lblDownloadFormat.Text = "Download Format:";
            // 
            // txtStorePath
            // 
            this.txtStorePath.Location = new System.Drawing.Point(115, 156);
            this.txtStorePath.Name = "txtStorePath";
            this.txtStorePath.Size = new System.Drawing.Size(333, 21);
            this.txtStorePath.TabIndex = 46;
            this.txtStorePath.Text = "c:\\11.wav";
            // 
            // txtRecordPath
            // 
            this.txtRecordPath.Location = new System.Drawing.Point(115, 121);
            this.txtRecordPath.Name = "txtRecordPath";
            this.txtRecordPath.Size = new System.Drawing.Size(333, 21);
            this.txtRecordPath.TabIndex = 45;
            // 
            // lblStorePath
            // 
            this.lblStorePath.AutoSize = true;
            this.lblStorePath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStorePath.Location = new System.Drawing.Point(12, 165);
            this.lblStorePath.Name = "lblStorePath";
            this.lblStorePath.Size = new System.Drawing.Size(71, 12);
            this.lblStorePath.TabIndex = 44;
            this.lblStorePath.Text = "Store Path:";
            // 
            // lblRecordPath
            // 
            this.lblRecordPath.AutoSize = true;
            this.lblRecordPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRecordPath.Location = new System.Drawing.Point(12, 130);
            this.lblRecordPath.Name = "lblRecordPath";
            this.lblRecordPath.Size = new System.Drawing.Size(77, 12);
            this.lblRecordPath.TabIndex = 43;
            this.lblRecordPath.Text = "Record Path:";
            // 
            // btnDownloadRecord
            // 
            this.btnDownloadRecord.Location = new System.Drawing.Point(466, 119);
            this.btnDownloadRecord.Name = "btnDownloadRecord";
            this.btnDownloadRecord.Size = new System.Drawing.Size(152, 23);
            this.btnDownloadRecord.TabIndex = 42;
            this.btnDownloadRecord.Text = "Download Record";
            this.btnDownloadRecord.UseVisualStyleBackColor = true;
            this.btnDownloadRecord.Click += new System.EventHandler(this.btnDownloadRecord_Click);
            // 
            // tabEmail
            // 
            this.tabEmail.AutoScroll = true;
            this.tabEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabEmail.Controls.Add(this.panel10);
            this.tabEmail.Controls.Add(this.panel9);
            this.tabEmail.Controls.Add(this.btnUpdateMailConfig);
            this.tabEmail.Controls.Add(this.btnQueryAgentCfgInfo);
            this.tabEmail.Controls.Add(this.lblSkillID);
            this.tabEmail.Controls.Add(this.btnSendEmail);
            this.tabEmail.Controls.Add(this.btnReceiveMail);
            this.tabEmail.Controls.Add(this.btnReplyEmail);
            this.tabEmail.Controls.Add(this.btnGetCallOutNo);
            this.tabEmail.Controls.Add(this.btnReleaseCallEx);
            this.tabEmail.Controls.Add(this.txtSkillID);
            this.tabEmail.Location = new System.Drawing.Point(4, 22);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmail.Size = new System.Drawing.Size(1141, 359);
            this.tabEmail.TabIndex = 6;
            this.tabEmail.Text = "邮件";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtIndex);
            this.panel10.Controls.Add(this.txtucHandle);
            this.panel10.Controls.Add(this.axActiveMailReply);
            this.panel10.Controls.Add(this.txtulTime);
            this.panel10.Controls.Add(this.txtusDsn);
            this.panel10.Controls.Add(this.btnGetSendEmailIndex);
            this.panel10.Location = new System.Drawing.Point(156, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(400, 284);
            this.panel10.TabIndex = 60;
            // 
            // txtIndex
            // 
            this.txtIndex.Enabled = false;
            this.txtIndex.Location = new System.Drawing.Point(250, 233);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(126, 21);
            this.txtIndex.TabIndex = 32;
            this.txtIndex.Visible = false;
            // 
            // txtucHandle
            // 
            this.txtucHandle.Enabled = false;
            this.txtucHandle.Location = new System.Drawing.Point(14, 233);
            this.txtucHandle.Name = "txtucHandle";
            this.txtucHandle.Size = new System.Drawing.Size(109, 21);
            this.txtucHandle.TabIndex = 47;
            this.txtucHandle.Visible = false;
            // 
            // txtulTime
            // 
            this.txtulTime.Enabled = false;
            this.txtulTime.Location = new System.Drawing.Point(126, 76);
            this.txtulTime.Name = "txtulTime";
            this.txtulTime.Size = new System.Drawing.Size(109, 21);
            this.txtulTime.TabIndex = 45;
            this.txtulTime.Visible = false;
            // 
            // txtusDsn
            // 
            this.txtusDsn.Enabled = false;
            this.txtusDsn.Location = new System.Drawing.Point(241, 92);
            this.txtusDsn.Name = "txtusDsn";
            this.txtusDsn.Size = new System.Drawing.Size(100, 21);
            this.txtusDsn.TabIndex = 46;
            this.txtusDsn.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.axActiveMailSend);
            this.panel9.Location = new System.Drawing.Point(561, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(407, 284);
            this.panel9.TabIndex = 59;
            // 
            // tabNote
            // 
            this.tabNote.AutoScroll = true;
            this.tabNote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabNote.Controls.Add(this.btnSmsToAgent);
            this.tabNote.Controls.Add(this.lblSepNo);
            this.tabNote.Controls.Add(this.txtulSeqNo);
            this.tabNote.Controls.Add(this.btnSMS);
            this.tabNote.Controls.Add(this.lblSMSSkillId);
            this.tabNote.Controls.Add(this.lblNote);
            this.tabNote.Controls.Add(this.lblUser);
            this.tabNote.Controls.Add(this.txtNote);
            this.tabNote.Controls.Add(this.label19);
            this.tabNote.Controls.Add(this.txtMciPort);
            this.tabNote.Controls.Add(this.label20);
            this.tabNote.Controls.Add(this.txtMciIp);
            this.tabNote.Controls.Add(this.txtDeviceId);
            this.tabNote.Controls.Add(this.txtPhoneNumber);
            this.tabNote.Location = new System.Drawing.Point(4, 22);
            this.tabNote.Name = "tabNote";
            this.tabNote.Padding = new System.Windows.Forms.Padding(3);
            this.tabNote.Size = new System.Drawing.Size(1141, 359);
            this.tabNote.TabIndex = 7;
            this.tabNote.Text = "短信";
            // 
            // btnSmsToAgent
            // 
            this.btnSmsToAgent.Location = new System.Drawing.Point(259, 225);
            this.btnSmsToAgent.Name = "btnSmsToAgent";
            this.btnSmsToAgent.Size = new System.Drawing.Size(166, 23);
            this.btnSmsToAgent.TabIndex = 13;
            this.btnSmsToAgent.Text = "TranSMSToAgent ";
            this.btnSmsToAgent.UseVisualStyleBackColor = true;
            this.btnSmsToAgent.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSepNo
            // 
            this.lblSepNo.Location = new System.Drawing.Point(3, 86);
            this.lblSepNo.Name = "lblSepNo";
            this.lblSepNo.Size = new System.Drawing.Size(85, 12);
            this.lblSepNo.TabIndex = 12;
            this.lblSepNo.Text = "序列号:";
            this.lblSepNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtulSeqNo
            // 
            this.txtulSeqNo.Location = new System.Drawing.Point(94, 83);
            this.txtulSeqNo.Name = "txtulSeqNo";
            this.txtulSeqNo.Size = new System.Drawing.Size(100, 21);
            this.txtulSeqNo.TabIndex = 11;
            // 
            // tabVRC
            // 
            this.tabVRC.AutoScroll = true;
            this.tabVRC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabVRC.Controls.Add(this.Uninitialize_VRC);
            this.tabVRC.Controls.Add(this.btn_StopRecordScreen);
            this.tabVRC.Controls.Add(this.btn_StartRecordScreen);
            this.tabVRC.Controls.Add(this.btn_initializeVRCAgent);
            this.tabVRC.Controls.Add(this.btnQueryAgentIP);
            this.tabVRC.Controls.Add(this.axVRCControl1);
            this.tabVRC.Location = new System.Drawing.Point(4, 22);
            this.tabVRC.Name = "tabVRC";
            this.tabVRC.Padding = new System.Windows.Forms.Padding(3);
            this.tabVRC.Size = new System.Drawing.Size(1141, 359);
            this.tabVRC.TabIndex = 8;
            this.tabVRC.Text = "VRC";
            // 
            // Uninitialize_VRC
            // 
            this.Uninitialize_VRC.Location = new System.Drawing.Point(652, 23);
            this.Uninitialize_VRC.Name = "Uninitialize_VRC";
            this.Uninitialize_VRC.Size = new System.Drawing.Size(112, 23);
            this.Uninitialize_VRC.TabIndex = 65;
            this.Uninitialize_VRC.Text = "Uninitialize_VRC";
            this.Uninitialize_VRC.UseVisualStyleBackColor = true;
            this.Uninitialize_VRC.Click += new System.EventHandler(this.Uninitialize_VRC_Click);
            // 
            // btn_StopRecordScreen
            // 
            this.btn_StopRecordScreen.Location = new System.Drawing.Point(515, 23);
            this.btn_StopRecordScreen.Name = "btn_StopRecordScreen";
            this.btn_StopRecordScreen.Size = new System.Drawing.Size(118, 23);
            this.btn_StopRecordScreen.TabIndex = 64;
            this.btn_StopRecordScreen.Text = "StopRecordScreen";
            this.btn_StopRecordScreen.UseVisualStyleBackColor = true;
            this.btn_StopRecordScreen.Click += new System.EventHandler(this.btn_StopRecordScreen_Click);
            // 
            // btn_StartRecordScreen
            // 
            this.btn_StartRecordScreen.Location = new System.Drawing.Point(361, 23);
            this.btn_StartRecordScreen.Name = "btn_StartRecordScreen";
            this.btn_StartRecordScreen.Size = new System.Drawing.Size(127, 23);
            this.btn_StartRecordScreen.TabIndex = 63;
            this.btn_StartRecordScreen.Text = "StartRecordScreen";
            this.btn_StartRecordScreen.UseVisualStyleBackColor = true;
            this.btn_StartRecordScreen.Click += new System.EventHandler(this.btn_StartRecordScreen_Click);
            // 
            // btn_initializeVRCAgent
            // 
            this.btn_initializeVRCAgent.Location = new System.Drawing.Point(202, 23);
            this.btn_initializeVRCAgent.Name = "btn_initializeVRCAgent";
            this.btn_initializeVRCAgent.Size = new System.Drawing.Size(130, 23);
            this.btn_initializeVRCAgent.TabIndex = 62;
            this.btn_initializeVRCAgent.Text = "InitializeVRCAgent";
            this.btn_initializeVRCAgent.UseVisualStyleBackColor = true;
            this.btn_initializeVRCAgent.Click += new System.EventHandler(this.btn_initializeVRCAgent_Click);
            // 
            // btnQueryAgentIP
            // 
            this.btnQueryAgentIP.Location = new System.Drawing.Point(26, 24);
            this.btnQueryAgentIP.Name = "btnQueryAgentIP";
            this.btnQueryAgentIP.Size = new System.Drawing.Size(147, 23);
            this.btnQueryAgentIP.TabIndex = 60;
            this.btnQueryAgentIP.Text = "QueryAgentIP";
            this.btnQueryAgentIP.UseVisualStyleBackColor = true;
            this.btnQueryAgentIP.Click += new System.EventHandler(this.btnQueryAgentIP_Click);
            // 
            // axVRCControl1
            // 
            this.axVRCControl1.Enabled = true;
            this.axVRCControl1.Location = new System.Drawing.Point(22, 289);
            this.axVRCControl1.Name = "axVRCControl1";
            this.axVRCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVRCControl1.OcxState")));
            this.axVRCControl1.Size = new System.Drawing.Size(100, 50);
            this.axVRCControl1.TabIndex = 0;
            this.axVRCControl1.Visible = false;
            // 
            // tabVCC
            // 
            this.tabVCC.AutoScroll = true;
            this.tabVCC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabVCC.Controls.Add(this.btnHangupVCCall);
            this.tabVCC.Controls.Add(this.btnPickupVCCall);
            this.tabVCC.Location = new System.Drawing.Point(4, 22);
            this.tabVCC.Name = "tabVCC";
            this.tabVCC.Padding = new System.Windows.Forms.Padding(3);
            this.tabVCC.Size = new System.Drawing.Size(1141, 359);
            this.tabVCC.TabIndex = 9;
            this.tabVCC.Text = "视频";
            // 
            // btnHangupVCCall
            // 
            this.btnHangupVCCall.Location = new System.Drawing.Point(177, 19);
            this.btnHangupVCCall.Name = "btnHangupVCCall";
            this.btnHangupVCCall.Size = new System.Drawing.Size(161, 23);
            this.btnHangupVCCall.TabIndex = 66;
            this.btnHangupVCCall.Text = "HangupVCCall";
            this.btnHangupVCCall.UseVisualStyleBackColor = true;
            this.btnHangupVCCall.Click += new System.EventHandler(this.btnHangupVCCall_Click);
            // 
            // btnPickupVCCall
            // 
            this.btnPickupVCCall.Location = new System.Drawing.Point(8, 19);
            this.btnPickupVCCall.Name = "btnPickupVCCall";
            this.btnPickupVCCall.Size = new System.Drawing.Size(154, 23);
            this.btnPickupVCCall.TabIndex = 65;
            this.btnPickupVCCall.Text = "PickupVCCall";
            this.btnPickupVCCall.UseVisualStyleBackColor = true;
            this.btnPickupVCCall.Click += new System.EventHandler(this.btnPickupVCCall_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(6, 63);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(53, 12);
            this.lblState.TabIndex = 60;
            this.lblState.Text = "状态管理";
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // panelECC
            // 
            this.panelECC.AutoScroll = true;
            this.panelECC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelECC.Controls.Add(this.tabControl);
            this.panelECC.Location = new System.Drawing.Point(0, 169);
            this.panelECC.Name = "panelECC";
            this.panelECC.Size = new System.Drawing.Size(1164, 402);
            this.panelECC.TabIndex = 61;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(6, 154);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(53, 12);
            this.lblFunction.TabIndex = 62;
            this.lblFunction.Text = "功能菜单";
            this.lblFunction.Click += new System.EventHandler(this.lblFunction_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Image = ((System.Drawing.Image)(resources.GetObject("btnClearLog.Image")));
            this.btnClearLog.Location = new System.Drawing.Point(35, 951);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(24, 24);
            this.btnClearLog.TabIndex = 25;
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // label_AD
            // 
            this.label_AD.AutoSize = true;
            this.label_AD.Location = new System.Drawing.Point(9, 579);
            this.label_AD.Name = "label_AD";
            this.label_AD.Size = new System.Drawing.Size(41, 12);
            this.label_AD.TabIndex = 64;
            this.label_AD.Text = "AD [-]";
            this.label_AD.Click += new System.EventHandler(this.label_AD_Click);
            // 
            // btn_Init
            // 
            this.btn_Init.Location = new System.Drawing.Point(12, 13);
            this.btn_Init.Name = "btn_Init";
            this.btn_Init.Size = new System.Drawing.Size(132, 23);
            this.btn_Init.TabIndex = 0;
            this.btn_Init.Text = "Phone Init";
            this.btn_Init.UseVisualStyleBackColor = true;
            this.btn_Init.Click += new System.EventHandler(this.btn_Init_Click);
            // 
            // btn_PhoneUninit
            // 
            this.btn_PhoneUninit.Location = new System.Drawing.Point(150, 13);
            this.btn_PhoneUninit.Name = "btn_PhoneUninit";
            this.btn_PhoneUninit.Size = new System.Drawing.Size(132, 23);
            this.btn_PhoneUninit.TabIndex = 1;
            this.btn_PhoneUninit.Text = "Phone Uninit";
            this.btn_PhoneUninit.UseVisualStyleBackColor = true;
            this.btn_PhoneUninit.Click += new System.EventHandler(this.btn_PhoneUninit_Click);
            // 
            // btn_PhoneAnswer
            // 
            this.btn_PhoneAnswer.Location = new System.Drawing.Point(288, 13);
            this.btn_PhoneAnswer.Name = "btn_PhoneAnswer";
            this.btn_PhoneAnswer.Size = new System.Drawing.Size(132, 23);
            this.btn_PhoneAnswer.TabIndex = 2;
            this.btn_PhoneAnswer.Text = "Phone Answer";
            this.btn_PhoneAnswer.UseVisualStyleBackColor = true;
            this.btn_PhoneAnswer.Click += new System.EventHandler(this.btn_PhoneAnswer_Click);
            // 
            // btn_PhoneHangup
            // 
            this.btn_PhoneHangup.Location = new System.Drawing.Point(426, 13);
            this.btn_PhoneHangup.Name = "btn_PhoneHangup";
            this.btn_PhoneHangup.Size = new System.Drawing.Size(132, 23);
            this.btn_PhoneHangup.TabIndex = 3;
            this.btn_PhoneHangup.Text = "Phone Hangup";
            this.btn_PhoneHangup.UseVisualStyleBackColor = true;
            this.btn_PhoneHangup.Click += new System.EventHandler(this.btn_PhoneHangup_Click);
            // 
            // btn_PhoneMute
            // 
            this.btn_PhoneMute.Location = new System.Drawing.Point(564, 13);
            this.btn_PhoneMute.Name = "btn_PhoneMute";
            this.btn_PhoneMute.Size = new System.Drawing.Size(132, 23);
            this.btn_PhoneMute.TabIndex = 4;
            this.btn_PhoneMute.Text = "Phone Mute";
            this.btn_PhoneMute.UseVisualStyleBackColor = true;
            this.btn_PhoneMute.Click += new System.EventHandler(this.btn_PhoneMute_Click);
            // 
            // btn_PhoneUnmute
            // 
            this.btn_PhoneUnmute.Location = new System.Drawing.Point(702, 13);
            this.btn_PhoneUnmute.Name = "btn_PhoneUnmute";
            this.btn_PhoneUnmute.Size = new System.Drawing.Size(132, 23);
            this.btn_PhoneUnmute.TabIndex = 5;
            this.btn_PhoneUnmute.Text = "Phone UnMute";
            this.btn_PhoneUnmute.UseVisualStyleBackColor = true;
            this.btn_PhoneUnmute.Click += new System.EventHandler(this.btn_PhoneUnmute_Click);
            // 
            // btn_SwitchAidDevice
            // 
            this.btn_SwitchAidDevice.Location = new System.Drawing.Point(840, 13);
            this.btn_SwitchAidDevice.Name = "btn_SwitchAidDevice";
            this.btn_SwitchAidDevice.Size = new System.Drawing.Size(132, 23);
            this.btn_SwitchAidDevice.TabIndex = 6;
            this.btn_SwitchAidDevice.Text = "SwitchToAidDevice";
            this.btn_SwitchAidDevice.UseVisualStyleBackColor = true;
            this.btn_SwitchAidDevice.Click += new System.EventHandler(this.btn_SwitchAidDevice_Click);
            // 
            // btn_SwitchMainDevice
            // 
            this.btn_SwitchMainDevice.Location = new System.Drawing.Point(978, 13);
            this.btn_SwitchMainDevice.Name = "btn_SwitchMainDevice";
            this.btn_SwitchMainDevice.Size = new System.Drawing.Size(132, 23);
            this.btn_SwitchMainDevice.TabIndex = 7;
            this.btn_SwitchMainDevice.Text = "SwitchToMainDevice";
            this.btn_SwitchMainDevice.UseVisualStyleBackColor = true;
            this.btn_SwitchMainDevice.Click += new System.EventHandler(this.btn_SwitchMainDevice_Click);
            // 
            // btn_GetSoundDevice
            // 
            this.btn_GetSoundDevice.Location = new System.Drawing.Point(12, 42);
            this.btn_GetSoundDevice.Name = "btn_GetSoundDevice";
            this.btn_GetSoundDevice.Size = new System.Drawing.Size(132, 23);
            this.btn_GetSoundDevice.TabIndex = 8;
            this.btn_GetSoundDevice.Text = "Get Sound Device";
            this.btn_GetSoundDevice.UseVisualStyleBackColor = true;
            this.btn_GetSoundDevice.Click += new System.EventHandler(this.btn_GetSoundDevice_Click);
            // 
            // btn_SetSoundDevice
            // 
            this.btn_SetSoundDevice.Location = new System.Drawing.Point(150, 42);
            this.btn_SetSoundDevice.Name = "btn_SetSoundDevice";
            this.btn_SetSoundDevice.Size = new System.Drawing.Size(132, 23);
            this.btn_SetSoundDevice.TabIndex = 9;
            this.btn_SetSoundDevice.Text = "Set Sound Device";
            this.btn_SetSoundDevice.UseVisualStyleBackColor = true;
            this.btn_SetSoundDevice.Click += new System.EventHandler(this.btn_SetSoundDevice_Click);
            // 
            // btn_GetVolume
            // 
            this.btn_GetVolume.Location = new System.Drawing.Point(288, 42);
            this.btn_GetVolume.Name = "btn_GetVolume";
            this.btn_GetVolume.Size = new System.Drawing.Size(132, 23);
            this.btn_GetVolume.TabIndex = 10;
            this.btn_GetVolume.Text = "Get Volume";
            this.btn_GetVolume.UseVisualStyleBackColor = true;
            this.btn_GetVolume.Click += new System.EventHandler(this.btn_GetVolume_Click);
            // 
            // btn_SetVolume
            // 
            this.btn_SetVolume.Location = new System.Drawing.Point(426, 42);
            this.btn_SetVolume.Name = "btn_SetVolume";
            this.btn_SetVolume.Size = new System.Drawing.Size(132, 23);
            this.btn_SetVolume.TabIndex = 65;
            this.btn_SetVolume.Text = "Set Volume";
            this.btn_SetVolume.UseVisualStyleBackColor = true;
            this.btn_SetVolume.Click += new System.EventHandler(this.btn_SetVolume_Click);
            // 
            // btn_GetVolumeGain
            // 
            this.btn_GetVolumeGain.Location = new System.Drawing.Point(564, 42);
            this.btn_GetVolumeGain.Name = "btn_GetVolumeGain";
            this.btn_GetVolumeGain.Size = new System.Drawing.Size(132, 23);
            this.btn_GetVolumeGain.TabIndex = 66;
            this.btn_GetVolumeGain.Text = "Get Volume Gain";
            this.btn_GetVolumeGain.UseVisualStyleBackColor = true;
            this.btn_GetVolumeGain.Click += new System.EventHandler(this.btn_GetVolumeGain_Click);
            // 
            // btn_SetVolumeGain
            // 
            this.btn_SetVolumeGain.Location = new System.Drawing.Point(702, 42);
            this.btn_SetVolumeGain.Name = "btn_SetVolumeGain";
            this.btn_SetVolumeGain.Size = new System.Drawing.Size(132, 23);
            this.btn_SetVolumeGain.TabIndex = 67;
            this.btn_SetVolumeGain.Text = "Set Volume Gain";
            this.btn_SetVolumeGain.UseVisualStyleBackColor = true;
            this.btn_SetVolumeGain.Click += new System.EventHandler(this.btn_SetVolumeGain_Click);
            // 
            // btn_GetDeviceVolume
            // 
            this.btn_GetDeviceVolume.Location = new System.Drawing.Point(840, 42);
            this.btn_GetDeviceVolume.Name = "btn_GetDeviceVolume";
            this.btn_GetDeviceVolume.Size = new System.Drawing.Size(132, 23);
            this.btn_GetDeviceVolume.TabIndex = 68;
            this.btn_GetDeviceVolume.Text = "GetDeviceVolume";
            this.btn_GetDeviceVolume.UseVisualStyleBackColor = true;
            this.btn_GetDeviceVolume.Click += new System.EventHandler(this.btn_GetDeviceVolume_Click);
            // 
            // btn_SetDeviceVolume
            // 
            this.btn_SetDeviceVolume.Location = new System.Drawing.Point(978, 42);
            this.btn_SetDeviceVolume.Name = "btn_SetDeviceVolume";
            this.btn_SetDeviceVolume.Size = new System.Drawing.Size(132, 23);
            this.btn_SetDeviceVolume.TabIndex = 69;
            this.btn_SetDeviceVolume.Text = "SetDeviceVolume";
            this.btn_SetDeviceVolume.UseVisualStyleBackColor = true;
            this.btn_SetDeviceVolume.Click += new System.EventHandler(this.btn_SetDeviceVolume_Click);
            // 
            // btn_UportalLogin
            // 
            this.btn_UportalLogin.Location = new System.Drawing.Point(12, 71);
            this.btn_UportalLogin.Name = "btn_UportalLogin";
            this.btn_UportalLogin.Size = new System.Drawing.Size(132, 23);
            this.btn_UportalLogin.TabIndex = 70;
            this.btn_UportalLogin.Text = "Login Uportal";
            this.btn_UportalLogin.UseVisualStyleBackColor = true;
            this.btn_UportalLogin.Click += new System.EventHandler(this.btn_UportalLogin_Click);
            // 
            // btn_LogoutUportal
            // 
            this.btn_LogoutUportal.Location = new System.Drawing.Point(150, 71);
            this.btn_LogoutUportal.Name = "btn_LogoutUportal";
            this.btn_LogoutUportal.Size = new System.Drawing.Size(132, 23);
            this.btn_LogoutUportal.TabIndex = 71;
            this.btn_LogoutUportal.Text = "Logout Uportal";
            this.btn_LogoutUportal.UseVisualStyleBackColor = true;
            this.btn_LogoutUportal.Click += new System.EventHandler(this.btn_LogoutUportal_Click);
            // 
            // btn_TalkingGroupQuery
            // 
            this.btn_TalkingGroupQuery.Location = new System.Drawing.Point(288, 71);
            this.btn_TalkingGroupQuery.Name = "btn_TalkingGroupQuery";
            this.btn_TalkingGroupQuery.Size = new System.Drawing.Size(132, 23);
            this.btn_TalkingGroupQuery.TabIndex = 72;
            this.btn_TalkingGroupQuery.Text = "Query Talking Group";
            this.btn_TalkingGroupQuery.UseVisualStyleBackColor = true;
            this.btn_TalkingGroupQuery.Click += new System.EventHandler(this.btn_TalkingGroupQuery_Click);
            // 
            // btn_QueryGrupState
            // 
            this.btn_QueryGrupState.Location = new System.Drawing.Point(426, 71);
            this.btn_QueryGrupState.Name = "btn_QueryGrupState";
            this.btn_QueryGrupState.Size = new System.Drawing.Size(132, 23);
            this.btn_QueryGrupState.TabIndex = 73;
            this.btn_QueryGrupState.Text = "Query Group State";
            this.btn_QueryGrupState.UseVisualStyleBackColor = true;
            this.btn_QueryGrupState.Click += new System.EventHandler(this.btn_QueryGrupState_Click);
            // 
            // btn_AddTalking
            // 
            this.btn_AddTalking.Location = new System.Drawing.Point(564, 71);
            this.btn_AddTalking.Name = "btn_AddTalking";
            this.btn_AddTalking.Size = new System.Drawing.Size(132, 23);
            this.btn_AddTalking.TabIndex = 74;
            this.btn_AddTalking.Text = "Add Talking";
            this.btn_AddTalking.UseVisualStyleBackColor = true;
            this.btn_AddTalking.Click += new System.EventHandler(this.btn_AddTalking_Click);
            // 
            // btn_ModifyGroup
            // 
            this.btn_ModifyGroup.Location = new System.Drawing.Point(702, 71);
            this.btn_ModifyGroup.Name = "btn_ModifyGroup";
            this.btn_ModifyGroup.Size = new System.Drawing.Size(132, 23);
            this.btn_ModifyGroup.TabIndex = 75;
            this.btn_ModifyGroup.Text = "Modify Group";
            this.btn_ModifyGroup.UseVisualStyleBackColor = true;
            this.btn_ModifyGroup.Click += new System.EventHandler(this.btn_ModifyGroup_Click);
            // 
            // btn_DeleteTakling
            // 
            this.btn_DeleteTakling.Location = new System.Drawing.Point(840, 71);
            this.btn_DeleteTakling.Name = "btn_DeleteTakling";
            this.btn_DeleteTakling.Size = new System.Drawing.Size(132, 23);
            this.btn_DeleteTakling.TabIndex = 76;
            this.btn_DeleteTakling.Text = "Delete Talking";
            this.btn_DeleteTakling.UseVisualStyleBackColor = true;
            this.btn_DeleteTakling.Click += new System.EventHandler(this.btn_DeleteTakling_Click);
            // 
            // panelAD
            // 
            this.panelAD.AutoScroll = true;
            this.panelAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAD.Controls.Add(this.btn_emergency_exit);
            this.panelAD.Controls.Add(this.btn_mixedAndTempGroupStart);
            this.panelAD.Controls.Add(this.bt_GetVideoDevice);
            this.panelAD.Controls.Add(this.bt_previewVideo);
            this.panelAD.Controls.Add(this.btn_emergency_answer);
            this.panelAD.Controls.Add(this.btn_get_pubParamters);
            this.panelAD.Controls.Add(this.btn_stop_emergency_note);
            this.panelAD.Controls.Add(this.btn_Record_Backplay);
            this.panelAD.Controls.Add(this.btn_releaseCurUserGroupCall);
            this.panelAD.Controls.Add(this.btn_GetNonce);
            this.panelAD.Controls.Add(this.btn_Record);
            this.panelAD.Controls.Add(this.btn_SetConfig);
            this.panelAD.Controls.Add(this.btn_GetConfig);
            this.panelAD.Controls.Add(this.btn_GroupDePTT);
            this.panelAD.Controls.Add(this.btn_GroupDesubscribe);
            this.panelAD.Controls.Add(this.btn_GroupDemonitor);
            this.panelAD.Controls.Add(this.btn_GroupDeselect);
            this.panelAD.Controls.Add(this.btn_MixedGroupChangeUserState);
            this.panelAD.Controls.Add(this.btn_MixedGroupCallEnd);
            this.panelAD.Controls.Add(this.btn_MixedGroupCallStart);
            this.panelAD.Controls.Add(this.btn_TalkingGroupGetCallInfo);
            this.panelAD.Controls.Add(this.btn_GroupPTT);
            this.panelAD.Controls.Add(this.btn_GroupSelect);
            this.panelAD.Controls.Add(this.btn_GroupMonitor);
            this.panelAD.Controls.Add(this.btn_TalkingGroupSubscribe);
            this.panelAD.Controls.Add(this.btn_RadioGroupQuery);
            this.panelAD.Controls.Add(this.btn_DeleteTakling);
            this.panelAD.Controls.Add(this.btn_ModifyGroup);
            this.panelAD.Controls.Add(this.btn_AddTalking);
            this.panelAD.Controls.Add(this.btn_QueryGrupState);
            this.panelAD.Controls.Add(this.btn_TalkingGroupQuery);
            this.panelAD.Controls.Add(this.btn_LogoutUportal);
            this.panelAD.Controls.Add(this.btn_UportalLogin);
            this.panelAD.Controls.Add(this.btn_SetDeviceVolume);
            this.panelAD.Controls.Add(this.btn_GetDeviceVolume);
            this.panelAD.Controls.Add(this.btn_SetVolumeGain);
            this.panelAD.Controls.Add(this.btn_GetVolumeGain);
            this.panelAD.Controls.Add(this.btn_SetVolume);
            this.panelAD.Controls.Add(this.btn_GetVolume);
            this.panelAD.Controls.Add(this.btn_SetSoundDevice);
            this.panelAD.Controls.Add(this.btn_GetSoundDevice);
            this.panelAD.Controls.Add(this.btn_SwitchMainDevice);
            this.panelAD.Controls.Add(this.btn_SwitchAidDevice);
            this.panelAD.Controls.Add(this.btn_PhoneUnmute);
            this.panelAD.Controls.Add(this.btn_PhoneMute);
            this.panelAD.Controls.Add(this.btn_PhoneHangup);
            this.panelAD.Controls.Add(this.btn_PhoneAnswer);
            this.panelAD.Controls.Add(this.btn_PhoneUninit);
            this.panelAD.Controls.Add(this.btn_Init);
            this.panelAD.Location = new System.Drawing.Point(0, 592);
            this.panelAD.Name = "panelAD";
            this.panelAD.Size = new System.Drawing.Size(1164, 215);
            this.panelAD.TabIndex = 63;
            // 
            // btn_emergency_exit
            // 
            this.btn_emergency_exit.Location = new System.Drawing.Point(843, 158);
            this.btn_emergency_exit.Name = "btn_emergency_exit";
            this.btn_emergency_exit.Size = new System.Drawing.Size(129, 23);
            this.btn_emergency_exit.TabIndex = 103;
            this.btn_emergency_exit.Text = "EmergencyExit";
            this.btn_emergency_exit.UseVisualStyleBackColor = true;
            this.btn_emergency_exit.Click += new System.EventHandler(this.btn_emergency_exit_Click);
            // 
            // btn_mixedAndTempGroupStart
            // 
            this.btn_mixedAndTempGroupStart.Location = new System.Drawing.Point(978, 158);
            this.btn_mixedAndTempGroupStart.Name = "btn_mixedAndTempGroupStart";
            this.btn_mixedAndTempGroupStart.Size = new System.Drawing.Size(132, 23);
            this.btn_mixedAndTempGroupStart.TabIndex = 103;
            this.btn_mixedAndTempGroupStart.Text = "MixedAndTempGroupCallStart";
            this.btn_mixedAndTempGroupStart.UseVisualStyleBackColor = true;
            this.btn_mixedAndTempGroupStart.Click += new System.EventHandler(this.btn_mixedAndTempGroupStart_Click);
            // 
            // bt_GetVideoDevice
            // 
            this.bt_GetVideoDevice.Location = new System.Drawing.Point(702, 159);
            this.bt_GetVideoDevice.Name = "bt_GetVideoDevice";
            this.bt_GetVideoDevice.Size = new System.Drawing.Size(132, 22);
            this.bt_GetVideoDevice.TabIndex = 102;
            this.bt_GetVideoDevice.Text = "Get Video Device";
            this.bt_GetVideoDevice.UseVisualStyleBackColor = true;
            this.bt_GetVideoDevice.Click += new System.EventHandler(this.bt_GetVideoDevice_Click);
            // 
            // bt_previewVideo
            // 
            this.bt_previewVideo.Location = new System.Drawing.Point(564, 158);
            this.bt_previewVideo.Name = "bt_previewVideo";
            this.bt_previewVideo.Size = new System.Drawing.Size(132, 23);
            this.bt_previewVideo.TabIndex = 98;
            this.bt_previewVideo.Text = "PreviewVideo";
            this.bt_previewVideo.UseVisualStyleBackColor = true;
            this.bt_previewVideo.Click += new System.EventHandler(this.bt_previewVideo_Click);
            // 
            // btn_emergency_answer
            // 
            this.btn_emergency_answer.Location = new System.Drawing.Point(427, 158);
            this.btn_emergency_answer.Name = "btn_emergency_answer";
            this.btn_emergency_answer.Size = new System.Drawing.Size(130, 23);
            this.btn_emergency_answer.TabIndex = 97;
            this.btn_emergency_answer.Text = "EmergencyAnswer";
            this.btn_emergency_answer.UseVisualStyleBackColor = true;
            this.btn_emergency_answer.Click += new System.EventHandler(this.btn_emergency_answer_Click);
            // 
            // btn_get_pubParamters
            // 
            this.btn_get_pubParamters.Location = new System.Drawing.Point(288, 158);
            this.btn_get_pubParamters.Name = "btn_get_pubParamters";
            this.btn_get_pubParamters.Size = new System.Drawing.Size(132, 23);
            this.btn_get_pubParamters.TabIndex = 96;
            this.btn_get_pubParamters.Text = "GetServiceParameters";
            this.btn_get_pubParamters.UseVisualStyleBackColor = true;
            this.btn_get_pubParamters.Click += new System.EventHandler(this.btn_get_pubParamters_Click);
            // 
            // btn_stop_emergency_note
            // 
            this.btn_stop_emergency_note.Location = new System.Drawing.Point(151, 158);
            this.btn_stop_emergency_note.Name = "btn_stop_emergency_note";
            this.btn_stop_emergency_note.Size = new System.Drawing.Size(131, 23);
            this.btn_stop_emergency_note.TabIndex = 95;
            this.btn_stop_emergency_note.Text = "StopPlayEmergencyNote";
            this.btn_stop_emergency_note.UseVisualStyleBackColor = true;
            this.btn_stop_emergency_note.Click += new System.EventHandler(this.btn_stop_emergency_note_Click);
            // 
            // btn_Record_Backplay
            // 
            this.btn_Record_Backplay.Location = new System.Drawing.Point(12, 158);
            this.btn_Record_Backplay.Name = "btn_Record_Backplay";
            this.btn_Record_Backplay.Size = new System.Drawing.Size(132, 23);
            this.btn_Record_Backplay.TabIndex = 93;
            this.btn_Record_Backplay.Text = "RecordBackplay";
            this.btn_Record_Backplay.UseVisualStyleBackColor = true;
            this.btn_Record_Backplay.Click += new System.EventHandler(this.btn_RecordBackplay_Click);
            // 
            // btn_releaseCurUserGroupCall
            // 
            this.btn_releaseCurUserGroupCall.Location = new System.Drawing.Point(12, 187);
            this.btn_releaseCurUserGroupCall.Name = "btn_releaseCurUserGroupCall";
            this.btn_releaseCurUserGroupCall.Size = new System.Drawing.Size(132, 23);
            this.btn_releaseCurUserGroupCall.TabIndex = 65;
            this.btn_releaseCurUserGroupCall.Text = "Relaese All";
            this.btn_releaseCurUserGroupCall.UseVisualStyleBackColor = true;
            this.btn_releaseCurUserGroupCall.Click += new System.EventHandler(this.btn_releaseCurUserGroupCall_Click);
            // 
            // btn_GetNonce
            // 
            this.btn_GetNonce.Location = new System.Drawing.Point(978, 129);
            this.btn_GetNonce.Name = "btn_GetNonce";
            this.btn_GetNonce.Size = new System.Drawing.Size(132, 23);
            this.btn_GetNonce.TabIndex = 65;
            this.btn_GetNonce.Text = "Get Nonce";
            this.btn_GetNonce.UseVisualStyleBackColor = true;
            this.btn_GetNonce.Click += new System.EventHandler(this.btn_GetNonce_Click);
            // 
            // btn_Record
            // 
            this.btn_Record.Location = new System.Drawing.Point(840, 129);
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Size = new System.Drawing.Size(132, 23);
            this.btn_Record.TabIndex = 92;
            this.btn_Record.Text = "Record";
            this.btn_Record.UseVisualStyleBackColor = true;
            this.btn_Record.Click += new System.EventHandler(this.btn_Record_Click);
            // 
            // btn_SetConfig
            // 
            this.btn_SetConfig.Location = new System.Drawing.Point(289, 129);
            this.btn_SetConfig.Name = "btn_SetConfig";
            this.btn_SetConfig.Size = new System.Drawing.Size(132, 23);
            this.btn_SetConfig.TabIndex = 91;
            this.btn_SetConfig.Text = "Set Congfiguration";
            this.btn_SetConfig.UseVisualStyleBackColor = true;
            this.btn_SetConfig.Click += new System.EventHandler(this.btn_SetConfig_Click);
            // 
            // btn_GetConfig
            // 
            this.btn_GetConfig.Location = new System.Drawing.Point(151, 129);
            this.btn_GetConfig.Name = "btn_GetConfig";
            this.btn_GetConfig.Size = new System.Drawing.Size(132, 23);
            this.btn_GetConfig.TabIndex = 90;
            this.btn_GetConfig.Text = "Get Congfiguration";
            this.btn_GetConfig.UseVisualStyleBackColor = true;
            this.btn_GetConfig.Click += new System.EventHandler(this.btn_GetConfig_Click);
            // 
            // btn_GroupDePTT
            // 
            this.btn_GroupDePTT.Location = new System.Drawing.Point(978, 100);
            this.btn_GroupDePTT.Name = "btn_GroupDePTT";
            this.btn_GroupDePTT.Size = new System.Drawing.Size(132, 23);
            this.btn_GroupDePTT.TabIndex = 89;
            this.btn_GroupDePTT.Text = "Group DePTT";
            this.btn_GroupDePTT.UseVisualStyleBackColor = true;
            this.btn_GroupDePTT.Click += new System.EventHandler(this.btn_GroupDePTT_Click);
            // 
            // btn_GroupDesubscribe
            // 
            this.btn_GroupDesubscribe.BackColor = System.Drawing.SystemColors.Control;
            this.btn_GroupDesubscribe.Location = new System.Drawing.Point(150, 100);
            this.btn_GroupDesubscribe.Name = "btn_GroupDesubscribe";
            this.btn_GroupDesubscribe.Size = new System.Drawing.Size(132, 23);
            this.btn_GroupDesubscribe.TabIndex = 88;
            this.btn_GroupDesubscribe.Text = "Group Desubscribe";
            this.btn_GroupDesubscribe.UseVisualStyleBackColor = false;
            this.btn_GroupDesubscribe.Click += new System.EventHandler(this.button_GroupDesubscribe_Click);
            // 
            // btn_GroupDemonitor
            // 
            this.btn_GroupDemonitor.Location = new System.Drawing.Point(426, 100);
            this.btn_GroupDemonitor.Name = "btn_GroupDemonitor";
            this.btn_GroupDemonitor.Size = new System.Drawing.Size(132, 23);
            this.btn_GroupDemonitor.TabIndex = 87;
            this.btn_GroupDemonitor.Text = "Group Demonitor";
            this.btn_GroupDemonitor.UseVisualStyleBackColor = true;
            this.btn_GroupDemonitor.Click += new System.EventHandler(this.buttonGroupDemonitor_Click);
            // 
            // btn_GroupDeselect
            // 
            this.btn_GroupDeselect.Location = new System.Drawing.Point(702, 100);
            this.btn_GroupDeselect.Name = "btn_GroupDeselect";
            this.btn_GroupDeselect.Size = new System.Drawing.Size(132, 23);
            this.btn_GroupDeselect.TabIndex = 86;
            this.btn_GroupDeselect.Text = "Group Deselect";
            this.btn_GroupDeselect.UseVisualStyleBackColor = true;
            this.btn_GroupDeselect.Click += new System.EventHandler(this.button_GroupDeselect_Click);
            // 
            // btn_MixedGroupChangeUserState
            // 
            this.btn_MixedGroupChangeUserState.Location = new System.Drawing.Point(702, 129);
            this.btn_MixedGroupChangeUserState.Name = "btn_MixedGroupChangeUserState";
            this.btn_MixedGroupChangeUserState.Size = new System.Drawing.Size(132, 23);
            this.btn_MixedGroupChangeUserState.TabIndex = 85;
            this.btn_MixedGroupChangeUserState.Text = "MixedGroupChangeUserState";
            this.btn_MixedGroupChangeUserState.UseVisualStyleBackColor = true;
            this.btn_MixedGroupChangeUserState.Click += new System.EventHandler(this.btn_MixedGroupChangeUserState_Click);
            // 
            // btn_MixedGroupCallEnd
            // 
            this.btn_MixedGroupCallEnd.Location = new System.Drawing.Point(564, 129);
            this.btn_MixedGroupCallEnd.Name = "btn_MixedGroupCallEnd";
            this.btn_MixedGroupCallEnd.Size = new System.Drawing.Size(132, 23);
            this.btn_MixedGroupCallEnd.TabIndex = 84;
            this.btn_MixedGroupCallEnd.Text = "MixedGroupCallEnd";
            this.btn_MixedGroupCallEnd.UseVisualStyleBackColor = true;
            this.btn_MixedGroupCallEnd.Click += new System.EventHandler(this.btn_MixedGroupCallEnd_Click);
            // 
            // btn_MixedGroupCallStart
            // 
            this.btn_MixedGroupCallStart.Location = new System.Drawing.Point(425, 129);
            this.btn_MixedGroupCallStart.Name = "btn_MixedGroupCallStart";
            this.btn_MixedGroupCallStart.Size = new System.Drawing.Size(132, 23);
            this.btn_MixedGroupCallStart.TabIndex = 83;
            this.btn_MixedGroupCallStart.Text = "MixedGroupCallStart";
            this.btn_MixedGroupCallStart.UseVisualStyleBackColor = true;
            this.btn_MixedGroupCallStart.Click += new System.EventHandler(this.btn_MixedGroupCallStart_Click);
            // 
            // btn_TalkingGroupGetCallInfo
            // 
            this.btn_TalkingGroupGetCallInfo.Location = new System.Drawing.Point(12, 129);
            this.btn_TalkingGroupGetCallInfo.Name = "btn_TalkingGroupGetCallInfo";
            this.btn_TalkingGroupGetCallInfo.Size = new System.Drawing.Size(132, 23);
            this.btn_TalkingGroupGetCallInfo.TabIndex = 82;
            this.btn_TalkingGroupGetCallInfo.Text = "Get Group Call Info";
            this.btn_TalkingGroupGetCallInfo.UseVisualStyleBackColor = true;
            this.btn_TalkingGroupGetCallInfo.Click += new System.EventHandler(this.btn_TalkingGroupGetCallInfo_Click);
            // 
            // btn_GroupPTT
            // 
            this.btn_GroupPTT.Location = new System.Drawing.Point(840, 100);
            this.btn_GroupPTT.Name = "btn_GroupPTT";
            this.btn_GroupPTT.Size = new System.Drawing.Size(132, 23);
            this.btn_GroupPTT.TabIndex = 81;
            this.btn_GroupPTT.Text = "Group PTT";
            this.btn_GroupPTT.UseVisualStyleBackColor = true;
            this.btn_GroupPTT.Click += new System.EventHandler(this.btn_GroupPTT_Click);
            // 
            // btn_GroupSelect
            // 
            this.btn_GroupSelect.Location = new System.Drawing.Point(564, 100);
            this.btn_GroupSelect.Name = "btn_GroupSelect";
            this.btn_GroupSelect.Size = new System.Drawing.Size(132, 23);
            this.btn_GroupSelect.TabIndex = 80;
            this.btn_GroupSelect.Text = "Group Select";
            this.btn_GroupSelect.UseVisualStyleBackColor = true;
            this.btn_GroupSelect.Click += new System.EventHandler(this.btn_GroupSelect_Click);
            // 
            // btn_GroupMonitor
            // 
            this.btn_GroupMonitor.Location = new System.Drawing.Point(288, 100);
            this.btn_GroupMonitor.Name = "btn_GroupMonitor";
            this.btn_GroupMonitor.Size = new System.Drawing.Size(132, 23);
            this.btn_GroupMonitor.TabIndex = 79;
            this.btn_GroupMonitor.Text = "Group Monitor";
            this.btn_GroupMonitor.UseVisualStyleBackColor = true;
            this.btn_GroupMonitor.Click += new System.EventHandler(this.btn_GroupMonitor_Click);
            // 
            // btn_TalkingGroupSubscribe
            // 
            this.btn_TalkingGroupSubscribe.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TalkingGroupSubscribe.Location = new System.Drawing.Point(12, 100);
            this.btn_TalkingGroupSubscribe.Name = "btn_TalkingGroupSubscribe";
            this.btn_TalkingGroupSubscribe.Size = new System.Drawing.Size(132, 23);
            this.btn_TalkingGroupSubscribe.TabIndex = 78;
            this.btn_TalkingGroupSubscribe.Text = "Group Subscribe";
            this.btn_TalkingGroupSubscribe.UseVisualStyleBackColor = false;
            this.btn_TalkingGroupSubscribe.Click += new System.EventHandler(this.btn_TalkingGroupSubscribe_Click);
            // 
            // btn_RadioGroupQuery
            // 
            this.btn_RadioGroupQuery.Location = new System.Drawing.Point(978, 71);
            this.btn_RadioGroupQuery.Name = "btn_RadioGroupQuery";
            this.btn_RadioGroupQuery.Size = new System.Drawing.Size(132, 23);
            this.btn_RadioGroupQuery.TabIndex = 77;
            this.btn_RadioGroupQuery.Text = "Radio Group Query";
            this.btn_RadioGroupQuery.UseVisualStyleBackColor = true;
            this.btn_RadioGroupQuery.Click += new System.EventHandler(this.btn_RadioGroupQuery_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 882);
            this.Controls.Add(this.label_AD);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.panelAD);
            this.Controls.Add(this.panelECC);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.panelState);
            this.Controls.Add(this.panelCfg);
            this.Controls.Add(this.txtEvents);
            this.Controls.Add(this.btnClearLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICPDemo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.frmMain_Scroll);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.axActiveMailSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axActiveMailReply)).EndInit();
            this.panelCfg.ResumeLayout(false);
            this.panelState.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabWirelesss.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.tabList.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tabM.ResumeLayout(false);
            this.tabRecord.ResumeLayout(false);
            this.tabRecord.PerformLayout();
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tabNote.ResumeLayout(false);
            this.tabNote.PerformLayout();
            this.tabVRC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVRCControl1)).EndInit();
            this.tabVCC.ResumeLayout(false);
            this.panelECC.ResumeLayout(false);
            this.panelAD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnSMS;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtMciPort;
        private System.Windows.Forms.TextBox txtMciIp;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSMSSkillId;
        private AxACTIVEMAILLib.AxActiveMail axActiveMailReply;
        private System.Windows.Forms.TextBox txtSkillID;
        private System.Windows.Forms.Button btnUpdateMailConfig;
        private System.Windows.Forms.Button btnReleaseCallEx;
        private System.Windows.Forms.Button btnGetCallOutNo;
        private System.Windows.Forms.Button btnReplyEmail;
        private System.Windows.Forms.Button btnReceiveMail;
        private System.Windows.Forms.Button btnQueryAgentCfgInfo;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnGetSendEmailIndex;
        private System.Windows.Forms.Label lblSeekToTime;
        private System.Windows.Forms.Button btnPlayRecordSeekTo;
        private System.Windows.Forms.TextBox txtPlayRecordSeekTo;
        private System.Windows.Forms.TextBox txtRecordId;
        private System.Windows.Forms.Label lblRecordId;
        private System.Windows.Forms.Button btnResumePlayRecord;
        private System.Windows.Forms.Button btnPlayRecord;
        private System.Windows.Forms.Button btnGetRecordLength;
        private System.Windows.Forms.Button btnStopPlayRecord;
        private System.Windows.Forms.Button btnPausePlayRecord;
        private System.Windows.Forms.Button btnWorkStop;
        private System.Windows.Forms.Button btnForceLogout;
        private System.Windows.Forms.Button bntQueryUsingWirelessDevice;
        private System.Windows.Forms.Button btnAutoEnterIdle;
        public System.Windows.Forms.Button btnChangeAgentPwd;
        private System.Windows.Forms.Button btnSelectPickup;
        private System.Windows.Forms.Button btnAddToRedList;
        private System.Windows.Forms.Button btnRemoveFromRedList;
        private System.Windows.Forms.Button btnRemoveAllRedList;
        private System.Windows.Forms.Button BtnCancelRest;
        private System.Windows.Forms.Button btnQueryBlackList;
        private System.Windows.Forms.Button BtnRest;
        private System.Windows.Forms.Button btnQueryRedList;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.Button btnUnInitial;
        private System.Windows.Forms.Button btnSetIdle;
        private System.Windows.Forms.Button btnSnatchPickup;
        private System.Windows.Forms.Button btnSetBusy;
        private System.Windows.Forms.Button btnSnatch;
        private System.Windows.Forms.Button btnMonitorToSnatch;
        private System.Windows.Forms.Button btnAddBlackList;
        private System.Windows.Forms.Button btnMonitorToBarge;
        private System.Windows.Forms.Button btnRemoveBlackList;
        private System.Windows.Forms.Button btnBarge;
        private System.Windows.Forms.Button btnClearBlackList;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnPTTOff;
        private System.Windows.Forms.Button btnPTTOn;
        private System.Windows.Forms.Button btnQueryWirelessInfo;
        private System.Windows.Forms.Button btnQueryAllWireless;
        private AxACTIVEMAILLib.AxActiveMail axActiveMailSend;
        private System.Windows.Forms.Label lblSkillID;
        private System.Windows.Forms.Panel panelCfg;
        private System.Windows.Forms.Panel panelState;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabWirelesss;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabM;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.TabPage tabEmail;
        private System.Windows.Forms.TabPage tabNote;
        private System.Windows.Forms.Button btnClearAutoEnterIdle;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Panel panelECC;
        public System.Windows.Forms.TextBox txtucHandle;
        public System.Windows.Forms.TextBox txtusDsn;
        public System.Windows.Forms.TextBox txtulTime;
        public System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtulSeqNo;
        private System.Windows.Forms.Label lblSepNo;
        private System.Windows.Forms.Button btnQueryAllBlackList;
        private System.Windows.Forms.Button btnQueryAllRedList;// add by xiezhengquan for AR. eSDK.001.001.001
        private System.Windows.Forms.Button btnSmsToAgent;
        private System.Windows.Forms.TabPage tabVRC;

        private System.Windows.Forms.Button btnStopWhisper;
        private System.Windows.Forms.Button btnWhisper;
        private System.Windows.Forms.Button btnSuperviseSwitch;
        private System.Windows.Forms.Button btnResetAgentSkill;
        private System.Windows.Forms.Button btnExitACW;
        private System.Windows.Forms.Button btnSubscribeAgentEvent;
        private System.Windows.Forms.Button btnStopSubscribeAgentEvent;
        private System.Windows.Forms.Button btnHangupVCCall;
        private System.Windows.Forms.Button btnPickupVCCall;
        private System.Windows.Forms.TabPage tabVCC;
		private System.Windows.Forms.Button btnQueryAllBlackListEx;
        private System.Windows.Forms.Button btnQueryBlackListEx;
        private System.Windows.Forms.Button btnAddBlackListEx;
        private System.Windows.Forms.TextBox txtDownloadFormat;
        private System.Windows.Forms.Label lblDownloadFormat;
        private System.Windows.Forms.TextBox txtStorePath;
        private System.Windows.Forms.TextBox txtRecordPath;
        private System.Windows.Forms.Label lblStorePath;
        private System.Windows.Forms.Label lblRecordPath;
        private System.Windows.Forms.Button btnDownloadRecord;
        private System.Windows.Forms.Button btnQueryAgentIP;
        private System.Windows.Forms.Label label_AD;
        private System.Windows.Forms.Button btn_Init;
        private System.Windows.Forms.Button btn_PhoneUninit;
        private System.Windows.Forms.Button btn_PhoneAnswer;
        private System.Windows.Forms.Button btn_PhoneHangup;
        private System.Windows.Forms.Button btn_PhoneMute;
        private System.Windows.Forms.Button btn_PhoneUnmute;
        private System.Windows.Forms.Button btn_SwitchAidDevice;
        private System.Windows.Forms.Button btn_SwitchMainDevice;
        private System.Windows.Forms.Button btn_GetSoundDevice;
        private System.Windows.Forms.Button btn_SetSoundDevice;
        private System.Windows.Forms.Button btn_GetVolume;
        private System.Windows.Forms.Button btn_SetVolume;
        private System.Windows.Forms.Button btn_GetVolumeGain;
        private System.Windows.Forms.Button btn_SetVolumeGain;
        private System.Windows.Forms.Button btn_GetDeviceVolume;
        private System.Windows.Forms.Button btn_SetDeviceVolume;
        private System.Windows.Forms.Button btn_UportalLogin;
        private System.Windows.Forms.Button btn_LogoutUportal;
        private System.Windows.Forms.Button btn_TalkingGroupQuery;
        private System.Windows.Forms.Button btn_QueryGrupState;
        private System.Windows.Forms.Button btn_AddTalking;
        private System.Windows.Forms.Button btn_ModifyGroup;
        private System.Windows.Forms.Button btn_DeleteTakling;
        private System.Windows.Forms.Panel panelAD;
        private System.Windows.Forms.Button btn_MixedGroupChangeUserState;
        private System.Windows.Forms.Button btn_MixedGroupCallEnd;
        private System.Windows.Forms.Button btn_MixedGroupCallStart;
        private System.Windows.Forms.Button btn_TalkingGroupGetCallInfo;
        private System.Windows.Forms.Button btn_GroupPTT;
        private System.Windows.Forms.Button btn_GroupSelect;
        private System.Windows.Forms.Button btn_GroupMonitor;
        private System.Windows.Forms.Button btn_TalkingGroupSubscribe;
        private System.Windows.Forms.Button btn_RadioGroupQuery;
        private System.Windows.Forms.Button btn_GroupDesubscribe;
        private System.Windows.Forms.Button btn_GroupDemonitor;
        private System.Windows.Forms.Button btn_GroupDeselect;
        private System.Windows.Forms.Button btn_GroupDePTT;
        private System.Windows.Forms.Button btn_SetConfig;
        private System.Windows.Forms.Button btn_GetConfig;
        private System.Windows.Forms.Button btn_UninitialAll;
        private System.Windows.Forms.Button btn_Record;
        private System.Windows.Forms.Button btn_GetNonce;
        private System.Windows.Forms.Button btn_Record_Backplay;
        private System.Windows.Forms.Button btn_stop_emergency_note;
        private System.Windows.Forms.Button btn_get_pubParamters;
        private System.Windows.Forms.Button btn_emergency_answer;
        private System.Windows.Forms.Button btnGetSysVersion;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_QueryRleaseAuthority;
        private System.Windows.Forms.Button btn_StopSubscriberCallListChange;
        private System.Windows.Forms.Button btn_SubscriberCallListChange;
        private System.Windows.Forms.Button btnQueryCallIdOnAgent;
        private System.Windows.Forms.Button btnQueryCallInfo;
        private System.Windows.Forms.Button btnQueryAgentSkillGroups;
        private System.Windows.Forms.Button btnQueryCurrentCallingScope;
        private System.Windows.Forms.Button btnQuerySkillGroupStatus;
        private System.Windows.Forms.Button btnQueryMaliciousCalls;
        private System.Windows.Forms.Button btnQueryIVRInfo;
        private System.Windows.Forms.Button btnQueryTotalSysInno;
        private System.Windows.Forms.Button btnQueryLostCalls;
        private System.Windows.Forms.Button btnQueryAllByGroupId;
        private System.Windows.Forms.Button btnQueryCallData;
        private System.Windows.Forms.Button btnQueryAgentStatus;
        private System.Windows.Forms.Button btnQueryCallListByGroup;
        private System.Windows.Forms.Button btnQuerySkillGroups;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCreateMeetingEx;
        private System.Windows.Forms.Button btnQueryMeetingMembers;
        private System.Windows.Forms.Button btnExitMeeting;
        private System.Windows.Forms.Button btnTransferMeetingMaster;
        private System.Windows.Forms.Button btnCreateMeeting;
        private System.Windows.Forms.Button BtnSingleStepMeeting;
        private System.Windows.Forms.Button btnMakeMeeting;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_TransferConsulting;
        private System.Windows.Forms.Button btnAgentSendDTMF;
        private System.Windows.Forms.Button btnTransToIVR;
        private System.Windows.Forms.Button btnPollingCallEx;
        private System.Windows.Forms.Button btnDialEx;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btUnMute;
        private System.Windows.Forms.Button btnTransferToSkillGroup;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnHangup;
        private System.Windows.Forms.Button btnEndConsultCall;
        private System.Windows.Forms.Button btnBlindTransfer;
        private System.Windows.Forms.Button btnTransToAgent;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnHoldCall;
        private System.Windows.Forms.Button btnPickup;
        private System.Windows.Forms.Button btnSetCustomerLevel;
        private System.Windows.Forms.Button btnSetCustomizedRecordInfo;
        private System.Windows.Forms.Button btnSingleStepSuccTransfer;
        private System.Windows.Forms.Button btnSetCallData;
        private System.Windows.Forms.Button btnPollingCall;
        private System.Windows.Forms.Button btnRetrieveCall;
        private System.Windows.Forms.Button btnCancelAutoAnswer;
        private System.Windows.Forms.Button btnDial;
        private System.Windows.Forms.Button btnSetAutoAnswer;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Label lblMeeting;
        private System.Windows.Forms.Label lblCall;
        private System.Windows.Forms.Button btnUnifiedLogout;
        private System.Windows.Forms.Button btnUnifiedLogin;
		private System.Windows.Forms.Button bt_previewVideo;
        private System.Windows.Forms.Button bt_GetVideoDevice;
        private AxVRCCONTROLLib.AxVRCControl axVRCControl1;
        private System.Windows.Forms.Button btn_initializeVRCAgent;
        private System.Windows.Forms.Button btn_StartRecordScreen;
        private System.Windows.Forms.Button btn_StopRecordScreen;
        private System.Windows.Forms.Button Uninitialize_VRC;
        private System.Windows.Forms.Button btnSingleStepSuccTransferEx;
        private System.Windows.Forms.Button btn_emergency_exit;

        private System.Windows.Forms.Button btn_mixedAndTempGroupStart;
        private System.Windows.Forms.Button btn_releaseCurUserGroupCall;

    }
}

namespace ICPDemo
{
    partial class frmConfig
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabPage_VideoInfo = new System.Windows.Forms.TabPage();
            this.VideoDeviceComb = new System.Windows.Forms.ComboBox();
            this.label_VideoDevice = new System.Windows.Forms.Label();
            this.tabPage_Language = new System.Windows.Forms.TabPage();
            this.ENLanguageChecked = new System.Windows.Forms.RadioButton();
            this.CNLanguageChecked = new System.Windows.Forms.RadioButton();
            this.tabPage_AudioInfo = new System.Windows.Forms.TabPage();
            this.AidMicComb = new System.Windows.Forms.ComboBox();
            this.AidSpkComb = new System.Windows.Forms.ComboBox();
            this.mainMicComb = new System.Windows.Forms.ComboBox();
            this.mainSpkComb = new System.Windows.Forms.ComboBox();
            this.label_AidPlicy = new System.Windows.Forms.Label();
            this.comboBox_AidPolicy = new System.Windows.Forms.ComboBox();
            this.label_AidMic = new System.Windows.Forms.Label();
            this.label_AidSpeaker = new System.Windows.Forms.Label();
            this.label_MainMic = new System.Windows.Forms.Label();
            this.label_MainSpeaker = new System.Windows.Forms.Label();
            this.checkBox_IsAidEnable = new System.Windows.Forms.CheckBox();
            this.tabPage_PhoneSettings = new System.Windows.Forms.TabPage();
            this.ckbRejectCallNotIdle = new System.Windows.Forms.CheckBox();
            this.comboBox_PhoneUsedMode = new System.Windows.Forms.ComboBox();
            this.textBox_SipRealName = new System.Windows.Forms.TextBox();
            this.textBox_LocalAudioPort = new System.Windows.Forms.TextBox();
            this.textBox_LocalSipPort = new System.Windows.Forms.TextBox();
            this.textBox_LocalIP = new System.Windows.Forms.TextBox();
            this.textBox_SipServerInfo = new System.Windows.Forms.TextBox();
            this.textBox_DispatchNum = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNum = new System.Windows.Forms.TextBox();
            this.textBox_PhonePw5 = new System.Windows.Forms.TextBox();
            this.checkBox_IsAutoAnswerIPCC = new System.Windows.Forms.CheckBox();
            this.checkBox_IsAutoAnswerIPT = new System.Windows.Forms.CheckBox();
            this.label_PhoneUsedMode = new System.Windows.Forms.Label();
            this.label_LocalAudioPort = new System.Windows.Forms.Label();
            this.label_LocalSipPort = new System.Windows.Forms.Label();
            this.label_LocalIP = new System.Windows.Forms.Label();
            this.label_SipRealName = new System.Windows.Forms.Label();
            this.label_SipServerInfo = new System.Windows.Forms.Label();
            this.label_PhonePw5 = new System.Windows.Forms.Label();
            this.label_PhoneNum = new System.Windows.Forms.Label();
            this.label_DispatchNum = new System.Windows.Forms.Label();
            this.tabAgentInfo = new System.Windows.Forms.TabPage();
            this.cmbAgentType = new System.Windows.Forms.ComboBox();
            this.lblAgentType = new System.Windows.Forms.Label();
            this.txtVCPhoneNumber = new System.Windows.Forms.TextBox();
            this.textExtension = new System.Windows.Forms.TextBox();
            this.textAgentId = new System.Windows.Forms.TextBox();
            this.lblVCPhoneNumber = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblAgentId = new System.Windows.Forms.Label();
            this.lblAgentPwd = new System.Windows.Forms.Label();
            this.textAgentPw5 = new System.Windows.Forms.TextBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label_PhoneLinkage = new System.Windows.Forms.Label();
            this.comboBox_PhoneLinkage = new System.Windows.Forms.ComboBox();
            this.chkIsForceLogin = new System.Windows.Forms.CheckBox();
            this.chkIsEnableACW = new System.Windows.Forms.CheckBox();
            this.chkSetAutoAnswer = new System.Windows.Forms.CheckBox();
            this.textTimeout = new System.Windows.Forms.TextBox();
            this.textCTIServerIP = new System.Windows.Forms.TextBox();
            this.textExtensionLength = new System.Windows.Forms.TextBox();
            this.textExtensionPrefix = new System.Windows.Forms.TextBox();
            this.textOutboundPrefix = new System.Windows.Forms.TextBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.lblAgentServer = new System.Windows.Forms.Label();
            this.lblExtensionLength = new System.Windows.Forms.Label();
            this.lblExtensionPrefix = new System.Windows.Forms.Label();
            this.lblOutboundPrefix = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage_VideoInfo.SuspendLayout();
            this.tabPage_Language.SuspendLayout();
            this.tabPage_AudioInfo.SuspendLayout();
            this.tabPage_PhoneSettings.SuspendLayout();
            this.tabAgentInfo.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(441, 467);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(329, 467);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabPage_VideoInfo
            // 
            this.tabPage_VideoInfo.Controls.Add(this.VideoDeviceComb);
            this.tabPage_VideoInfo.Controls.Add(this.label_VideoDevice);
            this.tabPage_VideoInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_VideoInfo.Name = "tabPage_VideoInfo";
            this.tabPage_VideoInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_VideoInfo.Size = new System.Drawing.Size(511, 420);
            this.tabPage_VideoInfo.TabIndex = 5;
            this.tabPage_VideoInfo.Text = "Video Info";
            this.tabPage_VideoInfo.UseVisualStyleBackColor = true;
            // 
            // VideoDeviceComb
            // 
            this.VideoDeviceComb.FormattingEnabled = true;
            this.VideoDeviceComb.Location = new System.Drawing.Point(145, 35);
            this.VideoDeviceComb.Name = "VideoDeviceComb";
            this.VideoDeviceComb.Size = new System.Drawing.Size(234, 20);
            this.VideoDeviceComb.TabIndex = 37;
            this.VideoDeviceComb.DropDown += new System.EventHandler(this.VideoDeviceComb_DropDown);
            // 
            // label_VideoDevice
            // 
            this.label_VideoDevice.Location = new System.Drawing.Point(39, 40);
            this.label_VideoDevice.Name = "label_VideoDevice";
            this.label_VideoDevice.Size = new System.Drawing.Size(100, 12);
            this.label_VideoDevice.TabIndex = 36;
            this.label_VideoDevice.Text = "Video Device:";
            this.label_VideoDevice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage_Language
            // 
            this.tabPage_Language.Controls.Add(this.ENLanguageChecked);
            this.tabPage_Language.Controls.Add(this.CNLanguageChecked);
            this.tabPage_Language.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Language.Name = "tabPage_Language";
            this.tabPage_Language.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Language.Size = new System.Drawing.Size(511, 420);
            this.tabPage_Language.TabIndex = 4;
            this.tabPage_Language.Text = "Language";
            this.tabPage_Language.UseVisualStyleBackColor = true;
            // 
            // ENLanguageChecked
            // 
            this.ENLanguageChecked.AutoSize = true;
            this.ENLanguageChecked.Location = new System.Drawing.Point(20, 54);
            this.ENLanguageChecked.Name = "ENLanguageChecked";
            this.ENLanguageChecked.Size = new System.Drawing.Size(65, 16);
            this.ENLanguageChecked.TabIndex = 1;
            this.ENLanguageChecked.Text = "English";
            this.ENLanguageChecked.UseVisualStyleBackColor = true;
            this.ENLanguageChecked.CheckedChanged += new System.EventHandler(this.ENLanguageChecked_CheckedChanged);
            // 
            // CNLanguageChecked
            // 
            this.CNLanguageChecked.AutoSize = true;
            this.CNLanguageChecked.Checked = true;
            this.CNLanguageChecked.Location = new System.Drawing.Point(20, 31);
            this.CNLanguageChecked.Name = "CNLanguageChecked";
            this.CNLanguageChecked.Size = new System.Drawing.Size(47, 16);
            this.CNLanguageChecked.TabIndex = 0;
            this.CNLanguageChecked.TabStop = true;
            this.CNLanguageChecked.Text = "中文";
            this.CNLanguageChecked.UseVisualStyleBackColor = true;
            this.CNLanguageChecked.CheckedChanged += new System.EventHandler(this.CNLanguageChecked_CheckedChanged);
            // 
            // tabPage_AudioInfo
            // 
            this.tabPage_AudioInfo.Controls.Add(this.AidMicComb);
            this.tabPage_AudioInfo.Controls.Add(this.AidSpkComb);
            this.tabPage_AudioInfo.Controls.Add(this.mainMicComb);
            this.tabPage_AudioInfo.Controls.Add(this.mainSpkComb);
            this.tabPage_AudioInfo.Controls.Add(this.label_AidPlicy);
            this.tabPage_AudioInfo.Controls.Add(this.comboBox_AidPolicy);
            this.tabPage_AudioInfo.Controls.Add(this.label_AidMic);
            this.tabPage_AudioInfo.Controls.Add(this.label_AidSpeaker);
            this.tabPage_AudioInfo.Controls.Add(this.label_MainMic);
            this.tabPage_AudioInfo.Controls.Add(this.label_MainSpeaker);
            this.tabPage_AudioInfo.Controls.Add(this.checkBox_IsAidEnable);
            this.tabPage_AudioInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AudioInfo.Name = "tabPage_AudioInfo";
            this.tabPage_AudioInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AudioInfo.Size = new System.Drawing.Size(511, 420);
            this.tabPage_AudioInfo.TabIndex = 3;
            this.tabPage_AudioInfo.Text = "Audio Info";
            this.tabPage_AudioInfo.UseVisualStyleBackColor = true;
            // 
            // AidMicComb
            // 
            this.AidMicComb.FormattingEnabled = true;
            this.AidMicComb.Location = new System.Drawing.Point(143, 175);
            this.AidMicComb.Name = "AidMicComb";
            this.AidMicComb.Size = new System.Drawing.Size(234, 20);
            this.AidMicComb.TabIndex = 33;
            this.AidMicComb.DropDown += new System.EventHandler(this.AidMicComb_DropDown);
            // 
            // AidSpkComb
            // 
            this.AidSpkComb.FormattingEnabled = true;
            this.AidSpkComb.Location = new System.Drawing.Point(144, 132);
            this.AidSpkComb.Name = "AidSpkComb";
            this.AidSpkComb.Size = new System.Drawing.Size(233, 20);
            this.AidSpkComb.TabIndex = 32;
            this.AidSpkComb.DropDown += new System.EventHandler(this.AidSpkComb_DropDown);
            // 
            // mainMicComb
            // 
            this.mainMicComb.FormattingEnabled = true;
            this.mainMicComb.Location = new System.Drawing.Point(144, 84);
            this.mainMicComb.Name = "mainMicComb";
            this.mainMicComb.Size = new System.Drawing.Size(234, 20);
            this.mainMicComb.TabIndex = 31;
            this.mainMicComb.DropDown += new System.EventHandler(this.mainMicComb_DropDown);
            // 
            // mainSpkComb
            // 
            this.mainSpkComb.FormattingEnabled = true;
            this.mainSpkComb.Location = new System.Drawing.Point(144, 31);
            this.mainSpkComb.Name = "mainSpkComb";
            this.mainSpkComb.Size = new System.Drawing.Size(233, 20);
            this.mainSpkComb.TabIndex = 30;
            this.mainSpkComb.DropDown += new System.EventHandler(this.mainSpkComb_DropDown);
            // 
            // label_AidPlicy
            // 
            this.label_AidPlicy.Location = new System.Drawing.Point(2, 225);
            this.label_AidPlicy.Name = "label_AidPlicy";
            this.label_AidPlicy.Size = new System.Drawing.Size(135, 12);
            this.label_AidPlicy.TabIndex = 29;
            this.label_AidPlicy.Text = "Aid Policy:";
            this.label_AidPlicy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox_AidPolicy
            // 
            this.comboBox_AidPolicy.FormattingEnabled = true;
            this.comboBox_AidPolicy.Items.AddRange(new object[] {
            "Default",
            "Auto",
            "Manual"});
            this.comboBox_AidPolicy.Location = new System.Drawing.Point(143, 222);
            this.comboBox_AidPolicy.Name = "comboBox_AidPolicy";
            this.comboBox_AidPolicy.Size = new System.Drawing.Size(235, 20);
            this.comboBox_AidPolicy.TabIndex = 28;
            this.comboBox_AidPolicy.Text = "Auto";
            // 
            // label_AidMic
            // 
            this.label_AidMic.Location = new System.Drawing.Point(37, 180);
            this.label_AidMic.Name = "label_AidMic";
            this.label_AidMic.Size = new System.Drawing.Size(100, 12);
            this.label_AidMic.TabIndex = 23;
            this.label_AidMic.Text = "Aid Mic:";
            this.label_AidMic.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_AidSpeaker
            // 
            this.label_AidSpeaker.Location = new System.Drawing.Point(60, 134);
            this.label_AidSpeaker.Name = "label_AidSpeaker";
            this.label_AidSpeaker.Size = new System.Drawing.Size(77, 12);
            this.label_AidSpeaker.TabIndex = 22;
            this.label_AidSpeaker.Text = "Aid Speaker:";
            this.label_AidSpeaker.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_MainMic
            // 
            this.label_MainMic.Location = new System.Drawing.Point(78, 87);
            this.label_MainMic.Name = "label_MainMic";
            this.label_MainMic.Size = new System.Drawing.Size(59, 12);
            this.label_MainMic.TabIndex = 21;
            this.label_MainMic.Text = "Main Mic:";
            this.label_MainMic.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_MainSpeaker
            // 
            this.label_MainSpeaker.Location = new System.Drawing.Point(54, 32);
            this.label_MainSpeaker.Name = "label_MainSpeaker";
            this.label_MainSpeaker.Size = new System.Drawing.Size(83, 12);
            this.label_MainSpeaker.TabIndex = 20;
            this.label_MainSpeaker.Text = "Main Speaker:";
            this.label_MainSpeaker.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBox_IsAidEnable
            // 
            this.checkBox_IsAidEnable.AutoSize = true;
            this.checkBox_IsAidEnable.Location = new System.Drawing.Point(351, 344);
            this.checkBox_IsAidEnable.Name = "checkBox_IsAidEnable";
            this.checkBox_IsAidEnable.Size = new System.Drawing.Size(102, 16);
            this.checkBox_IsAidEnable.TabIndex = 19;
            this.checkBox_IsAidEnable.Text = "Is Aid Enable";
            this.checkBox_IsAidEnable.UseVisualStyleBackColor = true;
            // 
            // tabPage_PhoneSettings
            // 
            this.tabPage_PhoneSettings.Controls.Add(this.ckbRejectCallNotIdle);
            this.tabPage_PhoneSettings.Controls.Add(this.comboBox_PhoneUsedMode);
            this.tabPage_PhoneSettings.Controls.Add(this.textBox_SipRealName);
            this.tabPage_PhoneSettings.Controls.Add(this.textBox_LocalAudioPort);
            this.tabPage_PhoneSettings.Controls.Add(this.textBox_LocalSipPort);
            this.tabPage_PhoneSettings.Controls.Add(this.textBox_LocalIP);
            this.tabPage_PhoneSettings.Controls.Add(this.textBox_SipServerInfo);
            this.tabPage_PhoneSettings.Controls.Add(this.textBox_DispatchNum);
            this.tabPage_PhoneSettings.Controls.Add(this.textBox_PhoneNum);
            this.tabPage_PhoneSettings.Controls.Add(this.textBox_PhonePw5);
            this.tabPage_PhoneSettings.Controls.Add(this.checkBox_IsAutoAnswerIPCC);
            this.tabPage_PhoneSettings.Controls.Add(this.checkBox_IsAutoAnswerIPT);
            this.tabPage_PhoneSettings.Controls.Add(this.label_PhoneUsedMode);
            this.tabPage_PhoneSettings.Controls.Add(this.label_LocalAudioPort);
            this.tabPage_PhoneSettings.Controls.Add(this.label_LocalSipPort);
            this.tabPage_PhoneSettings.Controls.Add(this.label_LocalIP);
            this.tabPage_PhoneSettings.Controls.Add(this.label_SipRealName);
            this.tabPage_PhoneSettings.Controls.Add(this.label_SipServerInfo);
            this.tabPage_PhoneSettings.Controls.Add(this.label_PhonePw5);
            this.tabPage_PhoneSettings.Controls.Add(this.label_PhoneNum);
            this.tabPage_PhoneSettings.Controls.Add(this.label_DispatchNum);
            this.tabPage_PhoneSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_PhoneSettings.Name = "tabPage_PhoneSettings";
            this.tabPage_PhoneSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PhoneSettings.Size = new System.Drawing.Size(511, 420);
            this.tabPage_PhoneSettings.TabIndex = 2;
            this.tabPage_PhoneSettings.Text = "Phone Settings";
            this.tabPage_PhoneSettings.UseVisualStyleBackColor = true;
            // 
            // ckbRejectCallNotIdle
            // 
            this.ckbRejectCallNotIdle.AutoSize = true;
            this.ckbRejectCallNotIdle.Location = new System.Drawing.Point(59, 341);
            this.ckbRejectCallNotIdle.Name = "ckbRejectCallNotIdle";
            this.ckbRejectCallNotIdle.Size = new System.Drawing.Size(210, 16);
            this.ckbRejectCallNotIdle.TabIndex = 41;
            this.ckbRejectCallNotIdle.Text = "Reject Call When Agent Not Idle";
            this.ckbRejectCallNotIdle.UseVisualStyleBackColor = true;
            // 
            // comboBox_PhoneUsedMode
            // 
            this.comboBox_PhoneUsedMode.DisplayMember = "PhoneEmbeddedMode";
            this.comboBox_PhoneUsedMode.FormattingEnabled = true;
            this.comboBox_PhoneUsedMode.Items.AddRange(new object[] {
            "PhoneEmbeddedMode",
            "PhoneLinkedMode"});
            this.comboBox_PhoneUsedMode.Location = new System.Drawing.Point(152, 227);
            this.comboBox_PhoneUsedMode.Name = "comboBox_PhoneUsedMode";
            this.comboBox_PhoneUsedMode.Size = new System.Drawing.Size(130, 20);
            this.comboBox_PhoneUsedMode.TabIndex = 40;
            this.comboBox_PhoneUsedMode.Text = "PhoneEmbeddedMode";
            this.comboBox_PhoneUsedMode.ValueMember = "PhoneEmbeddedMode";
            // 
            // textBox_SipRealName
            // 
            this.textBox_SipRealName.Location = new System.Drawing.Point(152, 257);
            this.textBox_SipRealName.Name = "textBox_SipRealName";
            this.textBox_SipRealName.Size = new System.Drawing.Size(130, 21);
            this.textBox_SipRealName.TabIndex = 39;
            // 
            // textBox_LocalAudioPort
            // 
            this.textBox_LocalAudioPort.Location = new System.Drawing.Point(152, 197);
            this.textBox_LocalAudioPort.Name = "textBox_LocalAudioPort";
            this.textBox_LocalAudioPort.Size = new System.Drawing.Size(130, 21);
            this.textBox_LocalAudioPort.TabIndex = 38;
            // 
            // textBox_LocalSipPort
            // 
            this.textBox_LocalSipPort.Location = new System.Drawing.Point(152, 167);
            this.textBox_LocalSipPort.Name = "textBox_LocalSipPort";
            this.textBox_LocalSipPort.Size = new System.Drawing.Size(130, 21);
            this.textBox_LocalSipPort.TabIndex = 37;
            // 
            // textBox_LocalIP
            // 
            this.textBox_LocalIP.Location = new System.Drawing.Point(152, 137);
            this.textBox_LocalIP.Name = "textBox_LocalIP";
            this.textBox_LocalIP.Size = new System.Drawing.Size(130, 21);
            this.textBox_LocalIP.TabIndex = 36;
            // 
            // textBox_SipServerInfo
            // 
            this.textBox_SipServerInfo.Location = new System.Drawing.Point(152, 107);
            this.textBox_SipServerInfo.Name = "textBox_SipServerInfo";
            this.textBox_SipServerInfo.Size = new System.Drawing.Size(130, 21);
            this.textBox_SipServerInfo.TabIndex = 35;
            // 
            // textBox_DispatchNum
            // 
            this.textBox_DispatchNum.Location = new System.Drawing.Point(152, 47);
            this.textBox_DispatchNum.Name = "textBox_DispatchNum";
            this.textBox_DispatchNum.Size = new System.Drawing.Size(130, 21);
            this.textBox_DispatchNum.TabIndex = 33;
            // 
            // textBox_PhoneNum
            // 
            this.textBox_PhoneNum.Location = new System.Drawing.Point(152, 17);
            this.textBox_PhoneNum.Name = "textBox_PhoneNum";
            this.textBox_PhoneNum.Size = new System.Drawing.Size(130, 21);
            this.textBox_PhoneNum.TabIndex = 32;
            // 
            // textBox_PhonePw5
            // 
            this.textBox_PhonePw5.Location = new System.Drawing.Point(152, 77);
            this.textBox_PhonePw5.Name = "textBox_PhonePw5";
            this.textBox_PhonePw5.Size = new System.Drawing.Size(130, 21);
            this.textBox_PhonePw5.TabIndex = 34;
            this.textBox_PhonePw5.UseSystemPasswordChar = true;
            // 
            // checkBox_IsAutoAnswerIPCC
            // 
            this.checkBox_IsAutoAnswerIPCC.AutoSize = true;
            this.checkBox_IsAutoAnswerIPCC.Location = new System.Drawing.Point(59, 318);
            this.checkBox_IsAutoAnswerIPCC.Name = "checkBox_IsAutoAnswerIPCC";
            this.checkBox_IsAutoAnswerIPCC.Size = new System.Drawing.Size(138, 16);
            this.checkBox_IsAutoAnswerIPCC.TabIndex = 31;
            this.checkBox_IsAutoAnswerIPCC.Text = "Is Auto Answer IPCC";
            this.checkBox_IsAutoAnswerIPCC.UseVisualStyleBackColor = true;
            // 
            // checkBox_IsAutoAnswerIPT
            // 
            this.checkBox_IsAutoAnswerIPT.AutoSize = true;
            this.checkBox_IsAutoAnswerIPT.Location = new System.Drawing.Point(59, 296);
            this.checkBox_IsAutoAnswerIPT.Name = "checkBox_IsAutoAnswerIPT";
            this.checkBox_IsAutoAnswerIPT.Size = new System.Drawing.Size(132, 16);
            this.checkBox_IsAutoAnswerIPT.TabIndex = 30;
            this.checkBox_IsAutoAnswerIPT.Text = "Is Auto Answer IPT";
            this.checkBox_IsAutoAnswerIPT.UseVisualStyleBackColor = true;
            // 
            // label_PhoneUsedMode
            // 
            this.label_PhoneUsedMode.Location = new System.Drawing.Point(45, 230);
            this.label_PhoneUsedMode.Name = "label_PhoneUsedMode";
            this.label_PhoneUsedMode.Size = new System.Drawing.Size(101, 12);
            this.label_PhoneUsedMode.TabIndex = 29;
            this.label_PhoneUsedMode.Text = "Phone Used Mode:";
            this.label_PhoneUsedMode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_LocalAudioPort
            // 
            this.label_LocalAudioPort.Location = new System.Drawing.Point(39, 200);
            this.label_LocalAudioPort.Name = "label_LocalAudioPort";
            this.label_LocalAudioPort.Size = new System.Drawing.Size(107, 12);
            this.label_LocalAudioPort.TabIndex = 28;
            this.label_LocalAudioPort.Text = "Local Audio Port:";
            this.label_LocalAudioPort.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_LocalSipPort
            // 
            this.label_LocalSipPort.Location = new System.Drawing.Point(51, 170);
            this.label_LocalSipPort.Name = "label_LocalSipPort";
            this.label_LocalSipPort.Size = new System.Drawing.Size(95, 12);
            this.label_LocalSipPort.TabIndex = 27;
            this.label_LocalSipPort.Text = "Local Sip Port:";
            this.label_LocalSipPort.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_LocalIP
            // 
            this.label_LocalIP.Location = new System.Drawing.Point(87, 140);
            this.label_LocalIP.Name = "label_LocalIP";
            this.label_LocalIP.Size = new System.Drawing.Size(59, 12);
            this.label_LocalIP.TabIndex = 26;
            this.label_LocalIP.Text = "Local IP:";
            this.label_LocalIP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_SipRealName
            // 
            this.label_SipRealName.Location = new System.Drawing.Point(57, 260);
            this.label_SipRealName.Name = "label_SipRealName";
            this.label_SipRealName.Size = new System.Drawing.Size(89, 12);
            this.label_SipRealName.TabIndex = 25;
            this.label_SipRealName.Text = "Sip Real Name:";
            this.label_SipRealName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_SipServerInfo
            // 
            this.label_SipServerInfo.Location = new System.Drawing.Point(45, 110);
            this.label_SipServerInfo.Name = "label_SipServerInfo";
            this.label_SipServerInfo.Size = new System.Drawing.Size(101, 12);
            this.label_SipServerInfo.TabIndex = 24;
            this.label_SipServerInfo.Text = "Sip Server Info:";
            this.label_SipServerInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_PhonePw5
            // 
            this.label_PhonePw5.Location = new System.Drawing.Point(3, 80);
            this.label_PhonePw5.Name = "label_PhonePw5";
            this.label_PhonePw5.Size = new System.Drawing.Size(143, 12);
            this.label_PhonePw5.TabIndex = 23;
            this.label_PhonePw5.Text = "Dispatch Password:";
            this.label_PhonePw5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_PhoneNum
            // 
            this.label_PhoneNum.Location = new System.Drawing.Point(45, 50);
            this.label_PhoneNum.Name = "label_PhoneNum";
            this.label_PhoneNum.Size = new System.Drawing.Size(101, 12);
            this.label_PhoneNum.TabIndex = 22;
            this.label_PhoneNum.Text = "Phone Number:";
            this.label_PhoneNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_DispatchNum
            // 
            this.label_DispatchNum.Location = new System.Drawing.Point(6, 20);
            this.label_DispatchNum.Name = "label_DispatchNum";
            this.label_DispatchNum.Size = new System.Drawing.Size(140, 12);
            this.label_DispatchNum.TabIndex = 21;
            this.label_DispatchNum.Text = "Dispatch Number:";
            this.label_DispatchNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabAgentInfo
            // 
            this.tabAgentInfo.Controls.Add(this.cmbAgentType);
            this.tabAgentInfo.Controls.Add(this.lblAgentType);
            this.tabAgentInfo.Controls.Add(this.txtVCPhoneNumber);
            this.tabAgentInfo.Controls.Add(this.textExtension);
            this.tabAgentInfo.Controls.Add(this.textAgentId);
            this.tabAgentInfo.Controls.Add(this.lblVCPhoneNumber);
            this.tabAgentInfo.Controls.Add(this.lblExtension);
            this.tabAgentInfo.Controls.Add(this.lblAgentId);
            this.tabAgentInfo.Controls.Add(this.lblAgentPwd);
            this.tabAgentInfo.Controls.Add(this.textAgentPw5);
            this.tabAgentInfo.Location = new System.Drawing.Point(4, 22);
            this.tabAgentInfo.Name = "tabAgentInfo";
            this.tabAgentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgentInfo.Size = new System.Drawing.Size(511, 420);
            this.tabAgentInfo.TabIndex = 1;
            this.tabAgentInfo.Text = "Agent Info";
            this.tabAgentInfo.UseVisualStyleBackColor = true;
            // 
            // cmbAgentType
            // 
            this.cmbAgentType.DisplayMember = "PC+Phone";
            this.cmbAgentType.FormattingEnabled = true;
            this.cmbAgentType.Items.AddRange(new object[] {
            "pc+phone",
            "pc+videophone"});
            this.cmbAgentType.Location = new System.Drawing.Point(130, 110);
            this.cmbAgentType.Name = "cmbAgentType";
            this.cmbAgentType.Size = new System.Drawing.Size(111, 20);
            this.cmbAgentType.TabIndex = 9;
            this.cmbAgentType.Text = "pc+phone";
            this.cmbAgentType.ValueMember = "PC+Phone";
            // 
            // lblAgentType
            // 
            this.lblAgentType.Location = new System.Drawing.Point(24, 113);
            this.lblAgentType.Name = "lblAgentType";
            this.lblAgentType.Size = new System.Drawing.Size(100, 12);
            this.lblAgentType.TabIndex = 8;
            this.lblAgentType.Text = "Agent Type:";
            this.lblAgentType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVCPhoneNumber
            // 
            this.txtVCPhoneNumber.Location = new System.Drawing.Point(130, 203);
            this.txtVCPhoneNumber.Name = "txtVCPhoneNumber";
            this.txtVCPhoneNumber.Size = new System.Drawing.Size(111, 21);
            this.txtVCPhoneNumber.TabIndex = 7;
            // 
            // textExtension
            // 
            this.textExtension.Location = new System.Drawing.Point(130, 67);
            this.textExtension.Name = "textExtension";
            this.textExtension.Size = new System.Drawing.Size(111, 21);
            this.textExtension.TabIndex = 3;
            // 
            // textAgentId
            // 
            this.textAgentId.Location = new System.Drawing.Point(130, 22);
            this.textAgentId.Name = "textAgentId";
            this.textAgentId.Size = new System.Drawing.Size(111, 21);
            this.textAgentId.TabIndex = 1;
            // 
            // lblVCPhoneNumber
            // 
            this.lblVCPhoneNumber.Location = new System.Drawing.Point(24, 206);
            this.lblVCPhoneNumber.Name = "lblVCPhoneNumber";
            this.lblVCPhoneNumber.Size = new System.Drawing.Size(100, 12);
            this.lblVCPhoneNumber.TabIndex = 6;
            this.lblVCPhoneNumber.Text = "VCPhoneNumber:";
            this.lblVCPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblExtension
            // 
            this.lblExtension.Location = new System.Drawing.Point(24, 70);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(100, 12);
            this.lblExtension.TabIndex = 2;
            this.lblExtension.Text = "Extension:";
            this.lblExtension.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAgentId
            // 
            this.lblAgentId.Location = new System.Drawing.Point(14, 25);
            this.lblAgentId.Name = "lblAgentId";
            this.lblAgentId.Size = new System.Drawing.Size(110, 12);
            this.lblAgentId.TabIndex = 0;
            this.lblAgentId.Text = "Agent ID:";
            this.lblAgentId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAgentPwd
            // 
            this.lblAgentPwd.Location = new System.Drawing.Point(14, 157);
            this.lblAgentPwd.Name = "lblAgentPwd";
            this.lblAgentPwd.Size = new System.Drawing.Size(110, 12);
            this.lblAgentPwd.TabIndex = 4;
            this.lblAgentPwd.Text = "Agent Password:";
            this.lblAgentPwd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textAgentPw5
            // 
            this.textAgentPw5.Location = new System.Drawing.Point(130, 154);
            this.textAgentPw5.Name = "textAgentPw5";
            this.textAgentPw5.Size = new System.Drawing.Size(111, 21);
            this.textAgentPw5.TabIndex = 5;
            this.textAgentPw5.UseSystemPasswordChar = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.label_PhoneLinkage);
            this.tabSettings.Controls.Add(this.comboBox_PhoneLinkage);
            this.tabSettings.Controls.Add(this.chkIsForceLogin);
            this.tabSettings.Controls.Add(this.chkIsEnableACW);
            this.tabSettings.Controls.Add(this.chkSetAutoAnswer);
            this.tabSettings.Controls.Add(this.textTimeout);
            this.tabSettings.Controls.Add(this.textCTIServerIP);
            this.tabSettings.Controls.Add(this.textExtensionLength);
            this.tabSettings.Controls.Add(this.textExtensionPrefix);
            this.tabSettings.Controls.Add(this.textOutboundPrefix);
            this.tabSettings.Controls.Add(this.lblTimeOut);
            this.tabSettings.Controls.Add(this.lblAgentServer);
            this.tabSettings.Controls.Add(this.lblExtensionLength);
            this.tabSettings.Controls.Add(this.lblExtensionPrefix);
            this.tabSettings.Controls.Add(this.lblOutboundPrefix);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(511, 420);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label_PhoneLinkage
            // 
            this.label_PhoneLinkage.Location = new System.Drawing.Point(30, 214);
            this.label_PhoneLinkage.Name = "label_PhoneLinkage";
            this.label_PhoneLinkage.Size = new System.Drawing.Size(83, 12);
            this.label_PhoneLinkage.TabIndex = 34;
            this.label_PhoneLinkage.Text = "PhoneLinkage:";
            this.label_PhoneLinkage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_PhoneLinkage.Click += new System.EventHandler(this.label_PhoneLinkage_Click);
            // 
            // comboBox_PhoneLinkage
            // 
            this.comboBox_PhoneLinkage.FormattingEnabled = true;
            this.comboBox_PhoneLinkage.Items.AddRange(new object[] {
            "Linkage",
            "Normal",
            "Keep Communicated"});
            this.comboBox_PhoneLinkage.Location = new System.Drawing.Point(119, 212);
            this.comboBox_PhoneLinkage.Name = "comboBox_PhoneLinkage";
            this.comboBox_PhoneLinkage.Size = new System.Drawing.Size(182, 20);
            this.comboBox_PhoneLinkage.TabIndex = 33;
            this.comboBox_PhoneLinkage.Text = "Linkage";
            this.comboBox_PhoneLinkage.SelectedIndexChanged += new System.EventHandler(this.comboBox_PhoneLinkage_SelectedIndexChanged);
            // 
            // chkIsForceLogin
            // 
            this.chkIsForceLogin.AutoSize = true;
            this.chkIsForceLogin.Location = new System.Drawing.Point(22, 281);
            this.chkIsForceLogin.Name = "chkIsForceLogin";
            this.chkIsForceLogin.Size = new System.Drawing.Size(96, 16);
            this.chkIsForceLogin.TabIndex = 32;
            this.chkIsForceLogin.Text = "IsForceLogin";
            this.chkIsForceLogin.UseVisualStyleBackColor = true;
            // 
            // chkIsEnableACW
            // 
            this.chkIsEnableACW.AutoSize = true;
            this.chkIsEnableACW.Location = new System.Drawing.Point(22, 258);
            this.chkIsEnableACW.Name = "chkIsEnableACW";
            this.chkIsEnableACW.Size = new System.Drawing.Size(90, 16);
            this.chkIsEnableACW.TabIndex = 30;
            this.chkIsEnableACW.Text = "IsEnableACW";
            this.chkIsEnableACW.UseVisualStyleBackColor = true;
            // 
            // chkSetAutoAnswer
            // 
            this.chkSetAutoAnswer.AutoSize = true;
            this.chkSetAutoAnswer.Location = new System.Drawing.Point(22, 303);
            this.chkSetAutoAnswer.Name = "chkSetAutoAnswer";
            this.chkSetAutoAnswer.Size = new System.Drawing.Size(102, 16);
            this.chkSetAutoAnswer.TabIndex = 29;
            this.chkSetAutoAnswer.Text = "SetAutoAnswer";
            this.chkSetAutoAnswer.UseVisualStyleBackColor = true;
            // 
            // textTimeout
            // 
            this.textTimeout.Location = new System.Drawing.Point(119, 63);
            this.textTimeout.Name = "textTimeout";
            this.textTimeout.Size = new System.Drawing.Size(119, 21);
            this.textTimeout.TabIndex = 9;
            this.textTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textCTIServerIP
            // 
            this.textCTIServerIP.Location = new System.Drawing.Point(119, 33);
            this.textCTIServerIP.Name = "textCTIServerIP";
            this.textCTIServerIP.Size = new System.Drawing.Size(379, 21);
            this.textCTIServerIP.TabIndex = 1;
            // 
            // textExtensionLength
            // 
            this.textExtensionLength.Location = new System.Drawing.Point(119, 136);
            this.textExtensionLength.Name = "textExtensionLength";
            this.textExtensionLength.Size = new System.Drawing.Size(183, 21);
            this.textExtensionLength.TabIndex = 24;
            // 
            // textExtensionPrefix
            // 
            this.textExtensionPrefix.Location = new System.Drawing.Point(119, 102);
            this.textExtensionPrefix.Name = "textExtensionPrefix";
            this.textExtensionPrefix.Size = new System.Drawing.Size(183, 21);
            this.textExtensionPrefix.TabIndex = 22;
            // 
            // textOutboundPrefix
            // 
            this.textOutboundPrefix.Location = new System.Drawing.Point(119, 173);
            this.textOutboundPrefix.Name = "textOutboundPrefix";
            this.textOutboundPrefix.Size = new System.Drawing.Size(182, 21);
            this.textOutboundPrefix.TabIndex = 20;
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.Location = new System.Drawing.Point(30, 66);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(86, 12);
            this.lblTimeOut.TabIndex = 8;
            this.lblTimeOut.Text = "Timeout:";
            this.lblTimeOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAgentServer
            // 
            this.lblAgentServer.AutoEllipsis = true;
            this.lblAgentServer.Location = new System.Drawing.Point(3, 35);
            this.lblAgentServer.Name = "lblAgentServer";
            this.lblAgentServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAgentServer.Size = new System.Drawing.Size(115, 18);
            this.lblAgentServer.TabIndex = 0;
            this.lblAgentServer.Text = "AgentGWUri:";
            this.lblAgentServer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblExtensionLength
            // 
            this.lblExtensionLength.Location = new System.Drawing.Point(8, 139);
            this.lblExtensionLength.Name = "lblExtensionLength";
            this.lblExtensionLength.Size = new System.Drawing.Size(107, 12);
            this.lblExtensionLength.TabIndex = 23;
            this.lblExtensionLength.Text = "Extension Length:";
            this.lblExtensionLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblExtensionPrefix
            // 
            this.lblExtensionPrefix.Location = new System.Drawing.Point(8, 106);
            this.lblExtensionPrefix.Name = "lblExtensionPrefix";
            this.lblExtensionPrefix.Size = new System.Drawing.Size(107, 12);
            this.lblExtensionPrefix.TabIndex = 21;
            this.lblExtensionPrefix.Text = "Extension Prefix:";
            this.lblExtensionPrefix.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOutboundPrefix
            // 
            this.lblOutboundPrefix.Location = new System.Drawing.Point(12, 176);
            this.lblOutboundPrefix.Name = "lblOutboundPrefix";
            this.lblOutboundPrefix.Size = new System.Drawing.Size(101, 12);
            this.lblOutboundPrefix.TabIndex = 19;
            this.lblOutboundPrefix.Text = "Outbound Prefix:";
            this.lblOutboundPrefix.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabSettings);
            this.tab.Controls.Add(this.tabAgentInfo);
            this.tab.Controls.Add(this.tabPage_PhoneSettings);
            this.tab.Controls.Add(this.tabPage_AudioInfo);
            this.tab.Controls.Add(this.tabPage_VideoInfo);
            this.tab.Controls.Add(this.tabPage_Language);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(519, 446);
            this.tab.TabIndex = 0;
            // 
            // frmConfig
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(543, 502);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tab);
            this.Name = "frmConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.tabPage_VideoInfo.ResumeLayout(false);
            this.tabPage_Language.ResumeLayout(false);
            this.tabPage_Language.PerformLayout();
            this.tabPage_AudioInfo.ResumeLayout(false);
            this.tabPage_AudioInfo.PerformLayout();
            this.tabPage_PhoneSettings.ResumeLayout(false);
            this.tabPage_PhoneSettings.PerformLayout();
            this.tabAgentInfo.ResumeLayout(false);
            this.tabAgentInfo.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabPage tabPage_VideoInfo;
        private System.Windows.Forms.ComboBox VideoDeviceComb;
        private System.Windows.Forms.Label label_VideoDevice;
        private System.Windows.Forms.TabPage tabPage_Language;
        private System.Windows.Forms.RadioButton ENLanguageChecked;
        private System.Windows.Forms.RadioButton CNLanguageChecked;
        private System.Windows.Forms.TabPage tabPage_AudioInfo;
        private System.Windows.Forms.ComboBox AidMicComb;
        private System.Windows.Forms.ComboBox AidSpkComb;
        private System.Windows.Forms.ComboBox mainMicComb;
        private System.Windows.Forms.ComboBox mainSpkComb;
        private System.Windows.Forms.Label label_AidPlicy;
        private System.Windows.Forms.ComboBox comboBox_AidPolicy;
        private System.Windows.Forms.Label label_AidMic;
        private System.Windows.Forms.Label label_AidSpeaker;
        private System.Windows.Forms.Label label_MainMic;
        private System.Windows.Forms.Label label_MainSpeaker;
        private System.Windows.Forms.CheckBox checkBox_IsAidEnable;
        private System.Windows.Forms.TabPage tabPage_PhoneSettings;
        private System.Windows.Forms.CheckBox ckbRejectCallNotIdle;
        private System.Windows.Forms.ComboBox comboBox_PhoneUsedMode;
        private System.Windows.Forms.TextBox textBox_SipRealName;
        private System.Windows.Forms.TextBox textBox_LocalAudioPort;
        private System.Windows.Forms.TextBox textBox_LocalSipPort;
        private System.Windows.Forms.TextBox textBox_LocalIP;
        private System.Windows.Forms.TextBox textBox_SipServerInfo;
        private System.Windows.Forms.TextBox textBox_DispatchNum;
        private System.Windows.Forms.TextBox textBox_PhoneNum;
        private System.Windows.Forms.TextBox textBox_PhonePw5;
        private System.Windows.Forms.CheckBox checkBox_IsAutoAnswerIPCC;
        private System.Windows.Forms.CheckBox checkBox_IsAutoAnswerIPT;
        private System.Windows.Forms.Label label_PhoneUsedMode;
        private System.Windows.Forms.Label label_LocalAudioPort;
        private System.Windows.Forms.Label label_LocalSipPort;
        private System.Windows.Forms.Label label_LocalIP;
        private System.Windows.Forms.Label label_SipRealName;
        private System.Windows.Forms.Label label_SipServerInfo;
        private System.Windows.Forms.Label label_PhonePw5;
        private System.Windows.Forms.Label label_PhoneNum;
        private System.Windows.Forms.Label label_DispatchNum;
        private System.Windows.Forms.TabPage tabAgentInfo;
        private System.Windows.Forms.ComboBox cmbAgentType;
        private System.Windows.Forms.Label lblAgentType;
        private System.Windows.Forms.TextBox txtVCPhoneNumber;
        private System.Windows.Forms.TextBox textExtension;
        private System.Windows.Forms.TextBox textAgentId;
        private System.Windows.Forms.Label lblVCPhoneNumber;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblAgentId;
        private System.Windows.Forms.Label lblAgentPwd;
        private System.Windows.Forms.TextBox textAgentPw5;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label label_PhoneLinkage;
        private System.Windows.Forms.ComboBox comboBox_PhoneLinkage;
        private System.Windows.Forms.CheckBox chkIsForceLogin;
        private System.Windows.Forms.CheckBox chkIsEnableACW;
        private System.Windows.Forms.CheckBox chkSetAutoAnswer;
        private System.Windows.Forms.TextBox textTimeout;
        private System.Windows.Forms.TextBox textCTIServerIP;
        private System.Windows.Forms.TextBox textExtensionLength;
        private System.Windows.Forms.TextBox textExtensionPrefix;
        private System.Windows.Forms.TextBox textOutboundPrefix;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.Label lblAgentServer;
        private System.Windows.Forms.Label lblExtensionLength;
        protected System.Windows.Forms.Label lblExtensionPrefix;
        private System.Windows.Forms.Label lblOutboundPrefix;
        private System.Windows.Forms.TabControl tab;
    }
}


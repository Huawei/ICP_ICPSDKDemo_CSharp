using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Com.Huawei.Device.ServiceModel;
using Com.Huawei.Device.Contract;
using Com.Huawei.Device;
using System.Security;


namespace ICPDemo
{
    public partial class frmConfig : Form
    {
        private AgentInfo _agentInfo = null;
        private Dictionary<string, string> _settings = null;

        private Dictionary<string, string> _phoneSettings = null;

        private List<SoundDeviceInfo> _inputDev;
        private List<SoundDeviceInfo> _outputDev;
        private List<SoundDeviceInfo> _videoDev;

        private bool inputUpdate;
        private bool outputUpdate;
        private bool videoUpdate;

        /// <summary>
        /// 
        /// </summary>
        public AgentInfo AgentInfo
        {
            get { return this._agentInfo; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> Settings
        {
            get { return this._settings; }
        }

        public Dictionary<string, string> PhoneSettings
        {
            get { return this._phoneSettings; }
        }
        private IDevice _device;
        /// <summary>
        /// 
        /// </summary>
        public frmConfig(IDevice device, List<SoundDeviceInfo> inputDev, List<SoundDeviceInfo> outputDev, List<SoundDeviceInfo> videoDev)
        {
            InitializeComponent();
            _device = device;
            _inputDev = inputDev;
            _outputDev = outputDev;
            _videoDev = videoDev;
        }

        public string PhoneNumber
        {
            get
            {
                return this.textBox_PhoneNum.Text;
            }

            set
            {
                this.textBox_PhoneNum.Text = value;
            }
        }

        public string DispatchNumber
        {
            get
            {
                return this.textBox_DispatchNum.Text;
            }

            set
            {
                this.textBox_DispatchNum.Text = value;
            }
        }

        public string PhonePassword
        {
            get
            {
                return this.textBox_PhonePw5.Text;
            }
        }

        public string SipServerInfo
        {
            get
            {
                return this.textBox_SipServerInfo.Text;
            }

            set
            {
                this.textBox_SipServerInfo.Text = value;
            }
        }

        public string LocalIP
        {
            get
            {
                return this.textBox_LocalIP.Text;
            }

            set
            {
                this.textBox_LocalIP.Text = value;
            }
        }

        public Int32 LocalSipPort
        {
            get
            {
                Int32 temp = 0;
                return Int32.TryParse(this.textBox_LocalSipPort.Text, out temp) ? temp : 0;
            }

            set
            {
                this.textBox_LocalSipPort.Text = value.ToString();
            }
        }

        public Int32 LocalAudioPort
        {
            get
            {
                Int32 temp = 0;

                return Int32.TryParse(this.textBox_LocalAudioPort.Text, out temp) ? temp : 0;
            }

            set
            {
                this.textBox_LocalAudioPort.Text = value.ToString();
            }
        }

        public bool IsAutoAnswerIPT
        {
            get
            {
                return this.checkBox_IsAutoAnswerIPT.Checked;
            }

            set
            {
                this.checkBox_IsAutoAnswerIPT.Checked = value;
            }
        }

        public bool IsAutoAnswerIPCC
        {
            get
            {
                return this.checkBox_IsAutoAnswerIPCC.Checked;
            }

            set
            {
                this.checkBox_IsAutoAnswerIPCC.Checked = value;
            }
        }

        public bool IsAidEnable
        {
            get
            {
                return this.checkBox_IsAidEnable.Checked;
            }
        }        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentInfo"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public DialogResult ShowDialog(AgentInfo agentInfo, Dictionary<string, string> settings, Dictionary<string, string> phoneSettings)
        {
            this._agentInfo = agentInfo;
            this._settings = settings;
            this._phoneSettings = phoneSettings;

            return this.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
                this._settings = new Dictionary<string, string>();
                this._agentInfo = new AgentInfo();
                this._phoneSettings = new Dictionary<string, string>();

                this._settings.Add("HuaweiCTIServerIP", this.ValidateString(this.textCTIServerIP, false, "CTI Server"));
               
                this._settings.Add("HuaweiTimeout", this.ValidateInteger(this.textTimeout, true, -1, int.MaxValue, "Timeout").ToString());

                this._settings.Add("HuaweiOutboundPrefix", this.ValidateString(this.textOutboundPrefix, false, "Outbound prefix"));
                this._settings.Add("HuaweiExtensionPrefix", this.ValidateString(this.textExtensionPrefix, false, "Extension prefix"));
                this._settings.Add("HuaweiExtensionLength", this.ValidateInteger(this.textExtensionLength, false, 0, 20, "Extension length").ToString());

                this._agentInfo.AgentId = this.ValidateString(this.textAgentId, false, "Agent ID");
                this._agentInfo.PassWord = this.ValidateString(this.textAgentPw5, false, "Agent Password");
                this._agentInfo.PhoneNumber = this.ValidateString(this.textExtension, false, "Exension");

                this._phoneSettings.Add("PhoneNumber", this.ValidateString(this.textBox_PhoneNum, false, "Phone Number"));
                this._phoneSettings.Add("PhonePassword", this.ValidateString(this.textBox_PhonePw5, false, "Phone Password"));
                this._phoneSettings.Add("DispatchNumber", this.ValidateString(this.textBox_DispatchNum, false, "Dispatch Number"));
                this._phoneSettings.Add("SipServerInfo", this.ValidateString(this.textBox_SipServerInfo, false, "Sip Server Info"));
                this._phoneSettings.Add("SipRealName", this.ValidateString(this.textBox_SipRealName, false, "Sip Real Name"));
                this._phoneSettings.Add("LocalIP", this.ValidateString(this.textBox_LocalIP, false, "Local IP"));
                this._phoneSettings.Add("LocalSipPort", this.ValidateString(this.textBox_LocalSipPort, false, "Local Sip Port"));
                this._phoneSettings.Add("LocalAudioPort", this.ValidateString(this.textBox_LocalAudioPort, false, "Local Audio Port"));
                this._phoneSettings.Add("PhoneUsedMode", this.comboBox_PhoneUsedMode.Text);

                this._phoneSettings.Add("IsAutoAnswerIPT", this.checkBox_IsAutoAnswerIPT.Checked ? "true":"false");
                this._phoneSettings.Add("IsAutoAnswerIPCC", this.checkBox_IsAutoAnswerIPCC.Checked ? "true" : "false");
                this._phoneSettings.Add("IsAidEnable", this.checkBox_IsAidEnable.Checked ? "true" : "false");
                
                this._phoneSettings.Add("MainSpeaker", this.mainSpkComb.Text);
                this._phoneSettings.Add("MainMic", this.mainMicComb.Text);
                if (this.checkBox_IsAidEnable.Checked)
                {
                    this._phoneSettings.Add("AidSpeaker", this.AidSpkComb.Text);
                    this._phoneSettings.Add("AidMic", this.AidMicComb.Text);
                }
                this._phoneSettings.Add("VideoDevice", this.VideoDeviceComb.Text);

                this._phoneSettings.Add("IsRejectCallAgentNotIdle", this.ckbRejectCallNotIdle.Checked ? "true" : "false");
               

                if (string.IsNullOrEmpty(this.txtVCPhoneNumber.Text))
                {
                    this._agentInfo.VCPhoneNumber = string.Empty;
                }
                else
                {
                    this.ValidateInteger(this.txtVCPhoneNumber, false, 1, int.MaxValue, "VC PhoneNumber").ToString();
                    //防止去掉前面的0
                    this._agentInfo.VCPhoneNumber = this.txtVCPhoneNumber.Text;
                }

                if (this.cmbAgentType.SelectedIndex == 1)
                {
                    this._agentInfo.AgentType = AgentType.Video;
                }
                else
                {
                    this._agentInfo.AgentType = AgentType.Audio;
                }

                //C60新增设置
                if (chkSetAutoAnswer.CheckState == CheckState.Checked)
                {
                    this._settings.Add("HuaweiSetAutoAnswer", "true");
                }
                else
                {
                    this._settings.Add("HuaweiSetAutoAnswer", "false");
                }
               
                
                //是否启用事后整理态
                if (chkIsEnableACW.CheckState == CheckState.Checked)
                {
                    this._settings.Add("HuaweiIsEnableACW", "true");
                }
                else
                {
                    this._settings.Add("HuaweiIsEnableACW", "false");
                }

                //是否启动联动
                if (this.comboBox_PhoneLinkage.SelectedIndex == 0)
                {
                    this._settings.Add("HuaweiPhoneLinkage", "0");
                }
                else if (this.comboBox_PhoneLinkage.SelectedIndex == 1)
                {
                    this._settings.Add("HuaweiPhoneLinkage", "1");
                }
                else
                {
                    this._settings.Add("HuaweiPhoneLinkage", "2");
                }

                //是否强制登录
                if (chkIsForceLogin.CheckState == CheckState.Checked)
                {
                    this._settings.Add("IsForceLogin", "true");
                }
                else
                {
                    this._settings.Add("IsForceLogin", "false");
                }

                //双声卡场景下，声卡的切换策略
                if (this.comboBox_AidPolicy.SelectedIndex == 2)
                {
                    this._phoneSettings.Add("AidPolicy", "manual");
                }
                else if (this.comboBox_AidPolicy.SelectedIndex == 1)
                {
                    this._phoneSettings.Add("AidPolicy", "auto");
                }
                else
                {
                    this._phoneSettings.Add("AidPolicy", "default");
                }

                if (this.CNLanguageChecked.Checked)
                {
                    this._settings.Add("Language", "CN");
                }
                else if (this.ENLanguageChecked.Checked)
                {
                    this._settings.Add("Language", "EN");
                }                

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (InvalidOperationException invalidOperationException)
            {
                MsgBox.Error(invalidOperationException.Message);
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        private void SetFocus(Control control)
        {
            try
            {
                var tabPage = control.Parent as TabPage;

                if (tabPage != null)
                {
                    var tabControl = tabPage.Parent as TabControl;

                    if (tabControl != null && tabControl.SelectedTab != tabPage)
                    {
                        tabControl.SelectedTab = tabPage;
                    }
                }

                control.Focus();
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="mandatory"></param>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private string ValidateString(TextBox control, bool mandatory = false, string prompt = null)
        {
            //CodeDEX:安全整改
            SecureString inputStr = new SecureString();
            char[] charList = (control.Text.Trim()).ToCharArray();
            foreach (char ch in charList)
            {
                inputStr.AppendChar(ch);
            }
            inputStr.MakeReadOnly();
            var text = Com.Huawei.Device.Helper.SecureStringToString(inputStr);

            if (string.IsNullOrEmpty(text) && mandatory)
            {
                this.SetFocus(control);

                throw new InvalidOperationException("Please input " + prompt + ".");
            }

            return text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="mandatory"></param>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private int ValidateInteger(TextBox control, bool mandatory = false, int min = 0, int max = int.MaxValue, string prompt = null)
        {
            var text = this.ValidateString(control, mandatory, prompt);

            int value = 0;

            if (!string.IsNullOrEmpty(text) && !int.TryParse(text, out value))
            {
                this.SetFocus(control);

                throw new InvalidOperationException(prompt + " must be an integer number.");
            }

            if (value < min)
            {
                this.SetFocus(control);

                throw new InvalidOperationException(string.Concat(prompt, " must be greater than ", min, "."));
            }

            if (value > max)
            {
                this.SetFocus(control);

                throw new InvalidOperationException(string.Concat(prompt, " must be less than ", max, "."));
            }

            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private string GetSetting(string name, Dictionary<string, string> setting)
        {
            if (name == null || setting == null)
            {
                return null;
            }

            string value = null;

            setting.TryGetValue(name, out value);

            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private int GetSettingInt(string name, int defaultValue = 0)
        {
            var str = this.GetSetting(name, this._settings);

            int value = 0;

            if (str != null && int.TryParse(str, out value))
            {
                return value;
            }

            return defaultValue;
        }

        private void SetResourceCulture()
        {
            this.Text = ConfigHelper.GetString("Config");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.tabSettings.Text = ConfigHelper.GetString("TabSettings");
            this.tabAgentInfo.Text = ConfigHelper.GetString("TabAgentInfo");
            this.tabPage_PhoneSettings.Text = ConfigHelper.GetString("PhoneSettings");
            this.tabPage_AudioInfo.Text = ConfigHelper.GetString("AudioInfo");
            this.tabPage_VideoInfo.Text = ConfigHelper.GetString("VideoInfo");
            this.tabPage_Language.Text = ConfigHelper.GetString("LanguageSetting");

            this.lblAgentServer.Text = ConfigHelper.GetString("ServerURI");
            this.lblTimeOut.Text = ConfigHelper.GetString("TimeOut");
            this.lblOutboundPrefix.Text = ConfigHelper.GetString("OutboundPrefix");
            this.lblExtensionPrefix.Text = ConfigHelper.GetString("ExtensionPrefix");

            this.lblExtensionLength.Text = ConfigHelper.GetString("ExtensionLength");
            this.chkIsForceLogin.Text = ConfigHelper.GetString("IsForceLogin");
            this.lblAgentId.Text = ConfigHelper.GetString("AgentId");
            this.lblExtension.Text = ConfigHelper.GetString("PhoneNumber");
            this.lblAgentPwd.Text = ConfigHelper.GetString("pwd");
            this.lblVCPhoneNumber.Text = ConfigHelper.GetString("VCPhoneNumber");

            //C60新增设置
            this.chkSetAutoAnswer.Text = ConfigHelper.GetString("SetAutoAnswer");

            this.chkIsEnableACW.Text = ConfigHelper.GetString("IsEnableACW");   //启用整理态
            this.label_PhoneLinkage.Text = ConfigHelper.GetString("PhoneLinkage");

            //C80新增设置
            this.comboBox_PhoneLinkage.Items[0] = ConfigHelper.GetString("Linkage");
            this.comboBox_PhoneLinkage.Items[1] = ConfigHelper.GetString("Normal");
            this.comboBox_PhoneLinkage.Items[2] = ConfigHelper.GetString("KeepCommunicated");

            this.comboBox_AidPolicy.Items[0] = ConfigHelper.GetString("Default");
            this.comboBox_AidPolicy.Items[1] = ConfigHelper.GetString("Auto");
            this.comboBox_AidPolicy.Items[2] = ConfigHelper.GetString("Manual");

            //AD设置
            this.label_AidMic.Text = ConfigHelper.GetString("AidMic");
            this.label_AidSpeaker.Text = ConfigHelper.GetString("AidSpeaker");
            this.label_PhoneNum.Text = ConfigHelper.GetString("PhoneNumber");
            this.label_LocalAudioPort.Text = ConfigHelper.GetString("LocalAudioPort");
            this.label_LocalIP.Text = ConfigHelper.GetString("LocalIP");
            this.label_LocalSipPort.Text = ConfigHelper.GetString("LocalSipPort");
            this.label_MainSpeaker.Text = ConfigHelper.GetString("MainSpeaker");
            this.label_MainMic.Text = ConfigHelper.GetString("MainMic");
            this.label_DispatchNum.Text = ConfigHelper.GetString("DispatchNumber");
            this.label_PhonePw5.Text = ConfigHelper.GetString("DispatchPassword");
            this.label_PhoneUsedMode.Text = ConfigHelper.GetString("PhoneUsedMode");
            this.label_SipRealName.Text = ConfigHelper.GetString("SipRealName");
            this.label_SipServerInfo.Text = ConfigHelper.GetString("SipServerInfo");
            this.checkBox_IsAidEnable.Text = ConfigHelper.GetString("IsAidEnable");
            this.checkBox_IsAutoAnswerIPCC.Text = ConfigHelper.GetString("IsAutoAnswerIPCC");
            this.checkBox_IsAutoAnswerIPT.Text = ConfigHelper.GetString("IsAutoAnswerIPT");
            this.label_AidPlicy.Text = ConfigHelper.GetString("AidPolicy");
            this.lblAgentType.Text = ConfigHelper.GetString("AgentType");
            this.ckbRejectCallNotIdle.Text = ConfigHelper.GetString("CheckAgentState");
            this.label_VideoDevice.Text = ConfigHelper.GetString("VideoDevice");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSetting_Load(object sender, EventArgs e)
        {
            try
            {
                SetResourceCulture(); 

                if (this._settings != null)
                {
                    this.textCTIServerIP.Text = this.GetSetting("HuaweiCTIServerIP", this._settings);
                    
                    this.textTimeout.Text = this.GetSettingInt("HuaweiTimeout", 30000).ToString();
                    

                    this.textOutboundPrefix.Text = this.GetSetting("HuaweiOutboundPrefix", this._settings);
                    this.textExtensionPrefix.Text = this.GetSetting("HuaweiExtensionPrefix", this._settings);
                    this.textExtensionLength.Text = this.GetSettingInt("HuaweiExtensionLength", 8).ToString();

                    if (String.Compare(this.GetSetting("HuaweiSetAutoAnswer", this._settings), "true") == 0)
                    {
                        this.chkSetAutoAnswer.CheckState = CheckState.Checked;
                    }

                    if (String.Compare(this.GetSetting("Language", this._settings), "CN") == 0)
                    {
                        this.CNLanguageChecked.Checked = true;
                    }
                    else
                    {
                        this.ENLanguageChecked.Checked = true;
                    }                  

                    //启用整理态
                    if (String.Compare(this.GetSetting("HuaweiIsEnableACW", this._settings), "true") == 0)
                    {
                        this.chkIsEnableACW.CheckState = CheckState.Checked;
                    }
                    if (String.Compare(this.GetSetting("IsForceLogin", this._settings), "true") == 0)
                    {
                        this.chkIsForceLogin.CheckState = CheckState.Checked;
                    }

                    //启动话机联动
                    if ("0".Equals(this.GetSetting("HuaweiPhoneLinkage", this._settings)))
                    {
                        this.comboBox_PhoneLinkage.SelectedIndex = 0;
                    }
                    else if ("1".Equals(this.GetSetting("HuaweiPhoneLinkage", this._settings)))
                    {
                        this.comboBox_PhoneLinkage.SelectedIndex = 1;
                    }
                    else
                    {
                        this.comboBox_PhoneLinkage.SelectedIndex = 2;
                    }
                }

                if (this._agentInfo != null)
                {
                    this.textAgentId.Text = this._agentInfo.AgentId;
                    this.textAgentPw5.Text = this._agentInfo.PassWord;
                    this.textExtension.Text = this._agentInfo.PhoneNumber;
                    this.txtVCPhoneNumber.Text = this._agentInfo.VCPhoneNumber;

                    if (this._agentInfo.AgentType == AgentType.Video)
                    {
                        this.cmbAgentType.SelectedIndex = 1;
                    }
                    else
                    {
                        this.cmbAgentType.SelectedIndex = 0;
                    }
                }

                if ((this._phoneSettings != null) && (this._phoneSettings.Count>0))
                {                    
                    this.textBox_PhoneNum.Text = this.GetSetting("PhoneNumber", this._phoneSettings);
                    this.textBox_DispatchNum.Text = this.GetSetting("DispatchNumber", this._phoneSettings);
                    this.textBox_PhonePw5.Text = this.GetSetting("PhonePassword", this._phoneSettings);
                   
                    this.textBox_LocalAudioPort.Text = this.GetSetting("LocalAudioPort", this._phoneSettings);
                    this.textBox_LocalIP.Text = this.GetSetting("LocalIP", this._phoneSettings);
                    this.textBox_LocalSipPort.Text = this.GetSetting("LocalSipPort", this._phoneSettings);
                    this.textBox_SipRealName.Text = this.GetSetting("SipRealName", this._phoneSettings);
                    this.textBox_SipServerInfo.Text = this.GetSetting("SipServerInfo", this._phoneSettings);
                    this.checkBox_IsAidEnable.Checked = (this.GetSetting("IsAidEnable", this._phoneSettings) == "true") ? true : false;
                    this.checkBox_IsAutoAnswerIPCC.Checked = (this.GetSetting("IsAutoAnswerIPCC", this._phoneSettings) == "true") ? true : false;
                    this.checkBox_IsAutoAnswerIPT.Checked = (this.GetSetting("IsAutoAnswerIPT", this._phoneSettings) == "true") ? true : false;

                    this.mainSpkComb.Text = this.GetSetting("MainSpeaker", this._phoneSettings);
                    this.mainMicComb.Text = this.GetSetting("MainMic", this._phoneSettings);

                    if (this.checkBox_IsAidEnable.Checked)
                    {
                        this.AidSpkComb.Text = this.GetSetting("AidSpeaker", this._phoneSettings);
                        this.AidMicComb.Text = this.GetSetting("AidMic", this._phoneSettings);
                    }
                    this.VideoDeviceComb.Text = this.GetSetting("VideoDevice", this._phoneSettings);

                    if ("manual".Equals(this.GetSetting("AidPolicy", this._phoneSettings)))
                    {
                        this.comboBox_AidPolicy.SelectedIndex = 2;
                    }
                    else if ("auto".Equals(this.GetSetting("AidPolicy", this._phoneSettings)))
                    {
                        this.comboBox_AidPolicy.SelectedIndex = 1;
                    }
                    else
                    {
                        this.comboBox_AidPolicy.SelectedIndex = 0;
                    }

                    if ("PhoneLinkedMode".Equals(this.GetSetting("PhoneUsedMode", this._phoneSettings)))
                    {
                        this.comboBox_PhoneUsedMode.SelectedIndex = 1;
                    }
                    else
                    {
                        this.comboBox_PhoneUsedMode.SelectedIndex = 0;
                    }

                    this.ckbRejectCallNotIdle.Checked = this.GetSetting("IsRejectCallAgentNotIdle", this._phoneSettings) == "true";
               }
            }
            catch (InvalidOperationException invalidOperationException)
            {
                MsgBox.Error(invalidOperationException.Message);
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        private void comboBox_PhoneLinkage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_PhoneLinkage_Click(object sender, EventArgs e)
        {

        }

        private void CNLanguageChecked_CheckedChanged(object sender, EventArgs e)
        {
            ConfigHelper.SetCurrentCulture("zh-CN");
            SetResourceCulture();
        }

        private void ENLanguageChecked_CheckedChanged(object sender, EventArgs e)
        {
            ConfigHelper.SetCurrentCulture("en-US");
            SetResourceCulture();
        }

        
        public void SetDeviceInfo(List<SoundDeviceInfo> deviceList, MediaDeviceType mediaDeviceType)
        {
            if (deviceList == null)
            {
                return;
            }

            if (MediaDeviceType.AudioOutput == mediaDeviceType)
            {
                _outputDev = deviceList;
                outputUpdate = true;
                mainSpkComb.Items.Clear();
                AidSpkComb.Items.Clear();
            }
            else if (MediaDeviceType.AudioInput == mediaDeviceType)
            {
                _inputDev  = deviceList;
                inputUpdate = true;
                mainMicComb.Items.Clear();
                AidMicComb.Items.Clear();
            }
            else
            {
                _videoDev = deviceList;
                videoUpdate = true;
                VideoDeviceComb.Items.Clear();
            }

            foreach (var dev in deviceList)
            {
                if (MediaDeviceType.AudioOutput == mediaDeviceType)
                {
                    mainSpkComb.Items.Add(dev.deviceName);
                    AidSpkComb.Items.Add(dev.deviceName);
                }
                else if (MediaDeviceType.AudioInput == mediaDeviceType)
                {
                    mainMicComb.Items.Add(dev.deviceName);
                    AidMicComb.Items.Add(dev.deviceName);
                }
                else
                {
                    VideoDeviceComb.Items.Add(dev.deviceName);
                }
            }
        }

        private void deviceCombItemUpdate(ComboBox cmb, MediaDeviceType mediaDeviceType)
        {            
            if (MediaDeviceType.AudioOutput == mediaDeviceType)
            {
                if (_outputDev == null)
                {
                    if (!outputUpdate)
                    {
                        _device.PhoneGetSoundDevice(false);
                    }
                }
                else
                {
                    cmb.Items.Clear();
                    foreach (var dev in _outputDev)
                    {
                        cmb.Items.Add(dev.deviceName);
                    }
                }
            }
            else if(MediaDeviceType.AudioInput == mediaDeviceType)
            {
                if (_inputDev == null)
                {
                    if (!inputUpdate)
                    {
                        _device.PhoneGetSoundDevice(true);
                    }
                }
                else
                {
                    cmb.Items.Clear();
                    foreach (var dev in _inputDev)
                    {
                        cmb.Items.Add(dev.deviceName);
                    }
                }
            }
            else
            {
                if (_videoDev == null)
                {
                    if (!videoUpdate)
                    {
                        _device.PhoneGetVideoDevice();
                    }
                }
                else
                {
                    cmb.Items.Clear();
                    foreach (var dev in _videoDev)
                    {
                        cmb.Items.Add(dev.deviceName);
                    }
                }
            }
            
        }

        private void mainSpkComb_DropDown(object sender, EventArgs e)
        {
            deviceCombItemUpdate(mainSpkComb, MediaDeviceType.AudioOutput);
        }

        private void mainMicComb_DropDown(object sender, EventArgs e)
        {
            deviceCombItemUpdate(mainMicComb, MediaDeviceType.AudioInput);
        }

        private void AidSpkComb_DropDown(object sender, EventArgs e)
        {
            deviceCombItemUpdate(AidSpkComb, MediaDeviceType.AudioOutput);
        }

        private void AidMicComb_DropDown(object sender, EventArgs e)
        {
            deviceCombItemUpdate(AidMicComb, MediaDeviceType.AudioInput);
        }
        
        private void VideoDeviceComb_DropDown(object sender, EventArgs e)
        {
            deviceCombItemUpdate(VideoDeviceComb, MediaDeviceType.Video);
        }
    }
}
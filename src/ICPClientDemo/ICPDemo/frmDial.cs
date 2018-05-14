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
    public partial class frmDial : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ShowCallType { get; private set; }
        public bool IsDisconnectCall { get; private set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DialContent DialContent { get; private set; }

        public string accessCode { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public frmDial(bool isDailEx = false, bool isMediaAbility = false)
        {
            InitializeComponent();
            if (isDailEx)
            {
                labAccessCode.Visible = true;
                txtAccessCode.Visible = true;
            }

            if (isMediaAbility)
            {
                cmbMediaAbility.Enabled = true;       
            }

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
                accessCode = this.txtAccessCode.Text.Trim();

                string number = this.textPhoneNumber.Text.Trim();

                if (string.IsNullOrEmpty(number))
                {
                    this.textPhoneNumber.Focus();
                    MsgBox.Info("Please input phone number.");

                    return;
                }

                DialContent dialContent = new DialContent();
                DeviceType phoneType = DeviceType.Phone;
                DeviceCallType callType = DeviceCallType.ConventionCall;

                if (this.ShowCallType)
                {
                    var intCallType = this.cboCallType.SelectedIndex;

                    if (intCallType == 0)
                    {
                        phoneType = DeviceType.Phone;
                    }
                    else if (intCallType == 1 || intCallType == 2)
                    {
                        if (intCallType == 1)
                        {
                            callType = DeviceCallType.GroupCall;
                        }
                        else
                        {
                            callType = DeviceCallType.SecretCall;
                        }

                        var wirelessType = this.cboWirelessType.SelectedIndex;

                        if (wirelessType == 0)
                        {
                            phoneType = DeviceType.SW;
                        }
                        else if (wirelessType == 1)
                        {
                            phoneType = DeviceType.WLDigitalDevice;
                        }
                        else if (wirelessType == 2)
                        {
                            phoneType = DeviceType.WLSimulateDevice;
                        }
                        else if (wirelessType == 3)
                        {
                            phoneType = DeviceType.LTE;
                        }
                        else
                        {
                            MsgBox.Info("Please select wireless type.");
                            this.cboWirelessType.Focus();

                            return;
                        }
                    }
                    else
                    {
                        MsgBox.Info("Please select call type.");
                        this.cboCallType.Focus();

                        return;
                    }
                }

                var mediaAblty = MediaAbility.Default;

                if (cmbMediaAbility.Enabled)
                {
                    if (cmbMediaAbility.SelectedIndex == 0)
                    {
                        mediaAblty = MediaAbility.Audio;
                    }
                    else if (cmbMediaAbility.SelectedIndex == 1)
                    {
                        mediaAblty = MediaAbility.Video;
                    }
                }

                dialContent.PhoneNumber = number;
                dialContent.PhoneType = phoneType;
                dialContent.CallType = callType;
                dialContent.MediaAbility = mediaAblty;
                dialContent.AccessCode = accessCode;
                if (IsDisconnectCall)
                {
                    dialContent.CallId = number;
                }

                this.DialContent = dialContent;

                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDial_Load(object sender, EventArgs e)
        {
            this.cboCallType.SelectedIndex = 0;
            this.cboWirelessType.SelectedIndex = 0;

            this.cmbMediaAbility.Items.Clear();
            this.cmbMediaAbility.Items.AddRange(new object[] {
            ConfigHelper.GetString("Audio"),
            ConfigHelper.GetString("Video"),
            ConfigHelper.GetString("Default")});
            this.cmbMediaAbility.SelectedIndex = 2;

            this.lblCallType.Visible = this.ShowCallType;
            this.cboCallType.Visible = this.ShowCallType;
            this.lblWirelessType.Visible = this.ShowCallType;
            this.cboWirelessType.Visible = this.ShowCallType;

            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblPhoneNumber.Text = ConfigHelper.GetString("PhoneNumber");
            this.lblCallType.Text = ConfigHelper.GetString("CallType");
            this.lblWirelessType.Text = ConfigHelper.GetString("WirelessType");
            this.labAccessCode.Text = ConfigHelper.GetString("AccessCode");
            this.lblMediaAbility.Text = ConfigHelper.GetString("MediaAbility");

            if (IsDisconnectCall)
            {
                this.lblPhoneNumber.Text = ConfigHelper.GetString("CallId");
            }
            if(this.Text == ConfigHelper.GetString("ConsultCall"))
            {
                this.labAccessCode.Location = new System.Drawing.Point(40, 46);
                this.txtAccessCode.Location = new System.Drawing.Point(126, 43);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="showCallType"></param>
        /// <returns></returns>
        public DialogResult ShowDialog(bool showCallType, bool isDisconnectCall = false)
        {
            this.ShowCallType = showCallType;
            this.IsDisconnectCall = isDisconnectCall;

            return this.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCallType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = this.cboCallType.SelectedIndex;
            var isWireless = index == 1 || index == 2;

            this.lblWirelessType.Enabled = isWireless;
            this.cboWirelessType.Enabled = isWireless;
        }
    }
}
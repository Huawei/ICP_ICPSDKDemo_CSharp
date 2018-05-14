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
    public partial class frmPollingCall : Form
    {
        public List<DialContent> dialContents= new List<DialContent>();
        public int timeout;
        bool isPolling = false;
        bool isAccessCode = false;
        public string accessCode { get; private set; }

        public frmPollingCall(bool isPoll,bool isAccessCode = false)
        {
            InitializeComponent();
            this.cboCallType.SelectedIndex = 0;
            this.cboWirelessType.SelectedIndex = 0;
            this.txtTimeOut.Text = "60";
            isPolling = isPoll;
            this.isAccessCode = isAccessCode;

            if (isAccessCode)
            {
                labAccessCode.Visible = true;
                txtAccessCode.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string number = this.textPhoneNumber.Text.Trim();

                if (string.IsNullOrEmpty(number))
                {
                    this.textPhoneNumber.Focus();
                    MsgBox.Info("Please input phone number.");

                    return;
                }
                foreach(DialContent dial in dialContents)
                {
                    if (dial.PhoneNumber == number)
                    {
                        return;
                    }
                }
                DialContent dialContent = new DialContent();
                DeviceType phoneType = DeviceType.Phone;
                DeviceCallType callType = DeviceCallType.ConventionCall;


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
                var mediaAblty = MediaAbility.Default;

                if (cmbMediaAbility.Enabled)
                {
                    if (cmbMediaAbility.SelectedIndex == 0)
                    {
                        mediaAblty = MediaAbility.Video;
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
                dialContents.Add(dialContent);
                listBoxCall.Items.Add(dialContent.PhoneNumber);
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                accessCode = this.txtAccessCode.Text.Trim();
                timeout = Convert.ToInt32(this.txtTimeOut.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        private void frmPollingCall_Load(object sender, EventArgs e)
        {
            this.lblPhoneNumber.Text = ConfigHelper.GetString("PhoneNumber");
            this.lblCallType.Text = ConfigHelper.GetString("CallType");
            this.lblWirelessType.Text = ConfigHelper.GetString("WirelessType");
            this.btnAdd.Text = ConfigHelper.GetString("Add");
            this.btnDel.Text = ConfigHelper.GetString("Remove");
            this.lblTimeout.Text = ConfigHelper.GetString("TimeOut");
            this.btnOK.Text = ConfigHelper.GetString("Call");
            this.labAccessCode.Text = ConfigHelper.GetString("AccessCode");
            this.lblMediaAbility.Text = ConfigHelper.GetString("MediaAbility");
            txtTimeOut.Enabled = isPolling;

            this.cmbMediaAbility.Items.Clear();
            this.cmbMediaAbility.Items.AddRange(new object[] {
            ConfigHelper.GetString("Audio"),
            ConfigHelper.GetString("Video"),
            ConfigHelper.GetString("Default")});
            this.cmbMediaAbility.SelectedIndex = 2;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DialContent content in dialContents)
            {
                if (content.PhoneNumber == listBoxCall.SelectedItem.ToString())
                {
                    dialContents.Remove(content);
                    listBoxCall.Items.RemoveAt(listBoxCall.SelectedIndex);
                    break;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

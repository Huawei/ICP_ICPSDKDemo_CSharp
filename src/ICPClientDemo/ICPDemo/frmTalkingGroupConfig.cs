using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.Huawei.Device;
using Com.Huawei.Device.Contract;
using Com.Huawei.Device.ServiceModel;
using AD;
namespace ICPDemo
{
    public partial class frmTalkingGroupConfig : Form
    {
        private TalkingGroup talkGroup;
        public string TalkGroupName        
        {
            get { return txtTalkGroupName.Text; }
        }

        public string TalkGroupNumber
        {
            get { return txtTalkGroupNumber.Text; }
        }

        int tmp = 0;

        public int TalkGroupType
        {
            get {
                tmp = 0;
                int.TryParse(txtTalkGroupType.Text, out tmp);
                //return int.Parse(txtTalkGroupType.Text); 
                return tmp;
            }
        }

        public List<string> RadioNumber
        {            
            get
            {
                if (string.IsNullOrEmpty(txtRadioTrunkNumber.Text))
                {
                    return null;
                }
                return new List<string>(txtRadioTrunkNumber.Text.Split(','));
            }
        }

        public List<string> DispatchNumber
        {
            get
            {
                if (string.IsNullOrEmpty(txtDispatchPosNumber.Text))
                {
                    return null;
                }
                return new List<string>(txtDispatchPosNumber.Text.Split(','));
            }
        }

        public List<string> OtherUserNumber
        {

            get 
            {
                if(string.IsNullOrEmpty(txtOtherUserNumber.Text))
                {
                    return null;
                }
                return new List<string>(txtOtherUserNumber.Text.Split(','));

            }
        }

        public string TalkGroupDesc
        {
            get { return txtTalkGroupDesc.Text; }
        }

        public frmTalkingGroupConfig(TalkingGroup talkGroup)
        {
            InitializeComponent();
            this.talkGroup = talkGroup;
        }

        public bool ReceiveOnly
        {
            get { return this.checkBox_ReceiveOnly.Checked; }
        }

        public string pttTimeoutInterval
        {
            get { return this.tbPttTimeoutInterval.Text.Trim(); }
        }

        public string noPttTimeoutInterval
        {
            get { return this.tbnoPttTimeoutInterval.Text.Trim(); }
        }

        public bool RadioToRadio
        {
            get { return this.checkBox_RadioToRadio.Checked; }
        }

        public bool isConfigUser
        {
            get { return this.checkBox_isConfigUser.Checked; }
        }

        private void frmTalkingGroupConfig_Load(object sender, EventArgs e)
        {
            this.lblDispatchPosNumber.Text = ConfigHelper.GetString("DispatchNumber");
            this.lblOtheUserNumber.Text = ConfigHelper.GetString("OtherUserNumber");
            this.lblRadioTrunkNumber.Text = ConfigHelper.GetString("RadioGroupNumber");
            this.lblTalkGroupDesc.Text = ConfigHelper.GetString("TalkingGroupDesc");
            this.lblTalkGroupName.Text = ConfigHelper.GetString("TalkingGroupName");
            this.lblTalkGroupNumber.Text = ConfigHelper.GetString("TalkingGroupNumber");
            this.lblTalkGroupType.Text = ConfigHelper.GetString("TalkingGroupType");
            this.lblNoPttTimeoutInterval.Text = ConfigHelper.GetString("NoPttTimeoutInterval");
            this.lblPttTimeoutInterval.Text = ConfigHelper.GetString("PttTimeoutInterval");
            this.btnOk.Text = ConfigHelper.GetString("Ok");
            this.checkBox_ReceiveOnly.Text = ConfigHelper.GetString("ReceiveOnly");
            this.checkBox_RadioToRadio.Text = ConfigHelper.GetString("RadioToRadio");
            this.checkBox_isConfigUser.Text = ConfigHelper.GetString("IsConfigUser");

            this.txtTalkGroupName.Text = talkGroup.talkGroupName;

            this.txtTalkGroupNumber.Text = talkGroup.talkGroupNumber;
            if (0 != talkGroup.talkGroupType)
            {
                this.txtTalkGroupType.Text = talkGroup.talkGroupType.ToString();
            }
            else
            {
                this.txtTalkGroupType.Text = "1";
            }

            if (talkGroup.radioGroupNumber != null && talkGroup.radioGroupNumber.Count > 0)            
            {
                this.txtRadioTrunkNumber.Text = talkGroup.radioGroupNumber[0].ToString();
            }

            if (talkGroup.dispatchNumber != null && talkGroup.dispatchNumber.Count > 0)            
            {
                this.txtDispatchPosNumber.Text = talkGroup.dispatchNumber[0].ToString();
            }

            if (!string.IsNullOrWhiteSpace(talkGroup.receiveOnly))
            {
                this.checkBox_ReceiveOnly.Checked = talkGroup.receiveOnly.Equals("true");
            }

            if (!string.IsNullOrWhiteSpace(talkGroup.radioToRadio))
            {
                this.checkBox_RadioToRadio.Checked = talkGroup.radioToRadio.Equals("true");
            }

            if (!string.IsNullOrWhiteSpace(talkGroup.configureUser))
            {
                this.checkBox_isConfigUser.Checked = talkGroup.configureUser.Equals("true");
            }
            
            this.txtTalkGroupDesc.Text = talkGroup.talkGroupDesc;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTalkGroupNumber.Text))
            {
                MessageBox.Show("TalkGroupNumber can not be empty");
                return;
            }
            //if (string.IsNullOrEmpty(txtTalkGroupType.Text))
            //{
            //    MessageBox.Show("TalkGroupType can not be empty");
            //    return;
            //}

            //if (string.IsNullOrEmpty(txtDispatchPosNumber.Text))
            //{
            //    MessageBox.Show("DispatchPosNumber can not be empty");
            //    return;
            //}

            this.DialogResult = DialogResult.OK;
        }
    }
}

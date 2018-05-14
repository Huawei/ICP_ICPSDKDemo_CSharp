using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Com.Huawei.Device.ServiceModel;
using Com.Huawei.Device;
using System.Security;
namespace ICPDemo
{
    public partial class frmUportalLogin : Form
    {
        private frmMain mainFrm;

        public frmUportalLogin(frmMain mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
        }

        public string Account
        { 
            get
            {
                return this.textBox_Account.Text; 
            }

            set
            {
                this.textBox_Account.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return this.textBox_Pw5.Text;
            }

            set
            {
                this.textBox_Pw5.Text = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.textBox_PhoneNumber.Text;
            }

            set
            {
                this.textBox_PhoneNumber.Text = value;
            }
        }

        public string ServerIP
        {
            get
            {
                return this.textBox_ServerIP.Text;
            }

            set
            {
                this.textBox_ServerIP.Text = value;
            }
        }

        private void frmUportalLogin_Loads(object sender, EventArgs e)
        {
            this.label_Account.Text = ConfigHelper.GetString("Account");
            this.label_PhoneNumber.Text = ConfigHelper.GetString("PhoneNumber");
            this.label_ServerIP.Text = ConfigHelper.GetString("ServerIP");
            this.label_UportalPw5.Text = ConfigHelper.GetString("Password");
            this.btn_OK.Text = ConfigHelper.GetString("Ok");

            this.Account = this.GetSetting("UportalAccount", mainFrm._uportalConfig);
            this.Password = mainFrm.UportalPassword;
            this.ServerIP = this.GetSetting("UportalServer", mainFrm._uportalConfig);
            this.PhoneNumber = this.GetSetting("InitPhoneNumber", mainFrm._uportalConfig);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                mainFrm._uportalConfig = new Dictionary<string, string>();

                mainFrm._uportalConfig.Add("UportalAccount", this.ValidateString(textBox_Account, true, "Uportal Account"));

                mainFrm._uportalConfig.Add("UportalServer", this.ValidateString(textBox_ServerIP, true, "Uportal Server"));

                mainFrm._uportalConfig.Add("InitPhoneNumber", this.ValidateString(textBox_PhoneNumber, false, "Init Phone Number"));

                mainFrm.UportalPassword = this.ValidateString(textBox_Pw5, false, "Account Password");

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (InvalidOperationException invalidOperationException)
            {
                MsgBox.Error(invalidOperationException.Message);
            }
        }


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
                control.Focus();
                throw new InvalidOperationException("Please input " + prompt + ".");
            }
            return text;
        }
    }
}

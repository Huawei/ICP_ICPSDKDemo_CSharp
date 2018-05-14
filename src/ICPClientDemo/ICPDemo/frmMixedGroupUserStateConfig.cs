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
    public partial class frmMixedGroupUserStateConfig : Form
    {
        public frmMixedGroupUserStateConfig()
        {
            InitializeComponent();
        }

        private string singleUser;

        private UserStateInfo userStateInfo = new UserStateInfo();

        public string GroupId
        {
            get
            {
                return txtGroupId.Text;
            }
        }

        public string SingleUser
        {
            get
            {
                int tmp;
                userStateInfo.state = txtState.Text;
                userStateInfo.userNumber = txtUserNumber.Text;
                int.TryParse(txtUserType.Text, out tmp);
                userStateInfo.userType = tmp;
                singleUser = frmMainDeviceCallback.Serialize(userStateInfo);
                return singleUser;
            }
        }

        public string MuiltUsers
        {
            get
            {
                return txtMuiltUsers.Text;
            }
        }

        public bool IsSingleUser
        {
            get
            {
                return rdoTrue.Checked;
            }
        }

        private void frmMixedGroupUserStateConfig_Load(object sender, EventArgs e)
        {
            this.groupSingleUser.Text = ConfigHelper.GetString("SingleUser");
            this.lblGroupId.Text = ConfigHelper.GetString("MixedGroupID");
            this.lblIsSingleUser.Text = ConfigHelper.GetString("IsSingleUser");
            this.lblMuiltUsers.Text = ConfigHelper.GetString("MultiUsers");
            this.lblState.Text = ConfigHelper.GetString("MixedGroupState");
            this.lblUserNumber.Text = ConfigHelper.GetString("UserNumber");
            this.lblUserType.Text = ConfigHelper.GetString("UserType");
            this.rdoFalse.Text = ConfigHelper.GetString("False");
            this.rdoTrue.Text = ConfigHelper.GetString("True");
            this.btnOk.Text = ConfigHelper.GetString("Ok");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }

    internal class UserStateInfo
    {
        public string userNumber { get; set; }

        public int userType { get; set; }

        public string state { get; set; }
    }
}

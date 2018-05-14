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
    public partial class frmMixedGroupConfig : Form
    {
        public frmMixedGroupConfig()
        {
            InitializeComponent();
        }

        public string GroupId
        {
            get
            {
                return txtGroupId.Text;
            }
        }

        public string Users
        {
            get
            {
                return txtUsers.Text;
            }
        }

        public bool ReservedSwitch
        {
            get 
            {
                return checkBox_reservedSwitch.Checked;
            }
        }

        public bool Muted
        {
            get 
            {
                return checkBox_Muted.Checked;
            }
        }

        public string GroupAlias
        {
            get
            {
                return textBox_groupAlias.Text;
            }
        }

        private void frmMixedGroupConfig_Load(object sender, EventArgs e)
        {
            this.lblGroupId.Text = ConfigHelper.GetString("MixedGroupID");
            this.lblUsers.Text = ConfigHelper.GetString("Users");
            this.btnOk.Text = ConfigHelper.GetString("Ok");
            this.label_group_alias.Text = ConfigHelper.GetString("GroupAlias");
            this.checkBox_Muted.Text = ConfigHelper.GetString("Muted");
            this.checkBox_reservedSwitch.Text = ConfigHelper.GetString("ReservedSwitch");
        }

        public void HideMute()
        {
            this.label_group_alias.Visible = false;
            this.textBox_groupAlias.Visible = false;
            this.checkBox_Muted.Visible = false;
            this.checkBox_reservedSwitch.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

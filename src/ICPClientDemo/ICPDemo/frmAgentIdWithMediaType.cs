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
    public partial class frmAgentIdWithMediaType : Form
    {
        public string m_strAgentId;
        public string m_strPhoneNumber;
        public int m_iMediaAbility;

        public frmAgentIdWithMediaType()
        {
            InitializeComponent();
        }

        private void frmAgentIdWithMediaType_Load(object sender, EventArgs e)
        {
            this.lbPhoneNumber.Text = ConfigHelper.GetString("PhoneNumber");
            this.lbMediaAbility.Text = ConfigHelper.GetString("MediaAbility") + ":";
            this.lbAgentId.Text = ConfigHelper.GetString("AgentId");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                m_strAgentId = this.tbAgentId.Text.Trim();
                if (string.IsNullOrEmpty(m_strAgentId) && null == this.Tag)
                {
                    MsgBox.Info("Please input agent id.");
                    this.tbAgentId.Focus();

                    return;
                }
                
                m_strPhoneNumber= this.tbPhoneNumber.Text.Trim();
                string _strMediaAbility = this.tbMediaAbility.Text.Trim();
                m_iMediaAbility = Convert.ToInt32(_strMediaAbility);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch
            {
                MsgBox.Error("input error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

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
    public partial class frmStopEmergencyNote : Form
    {
        public string TalkingGroupID
        {
            get
            {
                return this.textBox_TalkingGroupID.Text.Trim();
            }

            set
            {
                this.textBox_TalkingGroupID.Text = value;
            }
        }

        public frmStopEmergencyNote()
        {
            InitializeComponent();
        }

        private void frmStopEmergencyNote_Load(object sender, System.EventArgs e)
        {
            this.label_TalkingGroupID.Text = ConfigHelper.GetString("NoteConfig");            
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

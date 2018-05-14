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
    public partial class frmGetSoundDevice : Form
    {
        public frmGetSoundDevice()
        {
            InitializeComponent();
        }

        internal bool IsInput 
        {
            get
            {
                return this.radioButton_Input.Checked;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmGetSoundDevice_Load(object sender, EventArgs e)
        {
            this.label_DeviceType.Text = ConfigHelper.GetString("DeviceType");
            this.radioButton_Input.Text = ConfigHelper.GetString("Input");
            this.radioButton_Output.Text = ConfigHelper.GetString("Output");
            this.btn_Cancel.Text = ConfigHelper.GetString("Cancel");
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

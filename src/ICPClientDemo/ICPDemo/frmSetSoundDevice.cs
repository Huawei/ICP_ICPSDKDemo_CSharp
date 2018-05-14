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
    public partial class frmSetSoundDevice : Form
    {
        public frmSetSoundDevice()
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

        internal string DeviceIndex
        {
            get
            {
                return this.textBox_DeviceIndex.Text;
            }
        }

        private void frmSetSoundDevice_Load(object sender, EventArgs e)
        {
            this.label_DeviceIndex.Text = ConfigHelper.GetString("DeviceIndex");
            this.label_DeviceType.Text = ConfigHelper.GetString("DeviceType");
            this.radioButton_Input.Text = ConfigHelper.GetString("Input");
            this.radioButton_Output.Text = ConfigHelper.GetString("Output");
            this.btn_cancel.Text = ConfigHelper.GetString("Cancel");
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

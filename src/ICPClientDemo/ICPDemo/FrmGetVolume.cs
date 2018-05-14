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
    public partial class FrmGetVolume : Form
    {
        public FrmGetVolume()
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

        internal bool IsAidDvice
        {
            get
            {
                return this.radioButton_AidDevice.Checked;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FrmVolumeDeivce_Load(object sender, EventArgs e)
        {
            this.label_DeviceType.Text = ConfigHelper.GetString("DeviceType");
            this.radioButton_Input.Text = ConfigHelper.GetString("Input");
            this.radioButton_Output.Text = ConfigHelper.GetString("Output");
            this.radioButton_MainDevice.Text = ConfigHelper.GetString("MainAudioDevice");
            this.radioButton_AidDevice.Text = ConfigHelper.GetString("AidAudioDevice");
            this.btn_Cancel.Text = ConfigHelper.GetString("Cancel");
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
        }
    }
}

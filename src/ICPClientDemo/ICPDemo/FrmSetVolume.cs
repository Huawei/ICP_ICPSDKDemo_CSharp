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
    public partial class FrmSetVolume : Form
    {
        public FrmSetVolume()
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

        internal bool IsAidDevice
        {
            get
            {
                return this.radioButton_AidDevice.Checked;
            }
        }

        internal Int32 VolumeValue
        {
            get
            {
                return (Int32)this.numericUpDown_Volume.Value;
            }
        }

        private void frmSetVolume_Load(object sender, EventArgs e)
        {
            this.label_DeviceType.Text = ConfigHelper.GetString("DeviceType");
            this.label_Volume.Text = ConfigHelper.GetString("Volume");
            this.radioButton_Input.Text = ConfigHelper.GetString("Input");
            this.radioButton_Output.Text = ConfigHelper.GetString("Output");
            this.radioButton_MainDevice.Text = ConfigHelper.GetString("MainAudioDevice");
            this.radioButton_AidDevice.Text = ConfigHelper.GetString("AidAudioDevice");
            this.btn_Cancel.Text = ConfigHelper.GetString("Cancel");
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

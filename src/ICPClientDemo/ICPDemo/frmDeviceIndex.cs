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
    public partial class frmDeviceIndex : Form
    {
        public frmDeviceIndex()
        {
            InitializeComponent();
        }

        private void frmDeviceIndex_Load(object sender, EventArgs e)
        {
            this.label_DeviceIndex.Text = ConfigHelper.GetString("DeviceIndex");
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

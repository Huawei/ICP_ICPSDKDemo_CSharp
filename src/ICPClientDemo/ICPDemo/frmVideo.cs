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
    public partial class frmVideo : Form
    {
        private frmMain mainFrm;
        public frmVideo(frmMain mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {

        }

        private void frmVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainFrm.PerformDeviceAction((device) => device.ClosePreviewVideo());
        }
    }
}

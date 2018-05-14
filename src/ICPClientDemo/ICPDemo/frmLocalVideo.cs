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
    public partial class frmLocalVideo : Form
    {
        public frmLocalVideo()
        {
            InitializeComponent();
        }

        private void frmLocalVideo_Load(object sender, EventArgs e)
        {
            int height = SystemInformation.PrimaryMonitorSize.Width;
            int width = SystemInformation.PrimaryMonitorSize.Height;
            this.Location = new System.Drawing.Point(width / 2, height / 2 - 450);
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        
        private void frmLocalVideo_formClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

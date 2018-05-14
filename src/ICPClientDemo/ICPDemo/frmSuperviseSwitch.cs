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
    public partial class frmSuperviseSwitch : Form
    {
        //质检类型(0=侦听,1=插入,3=耳语)
        public int Type { get; set; }
        private int index_2 = 2;
        private int index_3 = 3;
        public frmSuperviseSwitch()
        {
            InitializeComponent();
        }

        private void frmSuperviseSwitch_Load(object sender, EventArgs e)
        {
            this.btnOk.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblType.Text = ConfigHelper.GetString("Type");
            string whisper = ConfigHelper.GetString("Whisper");
            string monitor = ConfigHelper.GetString("Monitor");
            string barge = ConfigHelper.GetString("Barge");
            this.combSupervise.Items.Add(monitor);
            this.combSupervise.Items.Add(barge);
            this.combSupervise.Items.Add(whisper);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void combSupervise_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = combSupervise.SelectedIndex;
            Type = index == index_2 ? index_3 : index;
        }
    }
}

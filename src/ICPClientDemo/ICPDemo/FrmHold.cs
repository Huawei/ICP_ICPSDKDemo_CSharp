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
    public partial class FrmHold : Form
    {
        public FrmHold()
        {
            InitializeComponent();
        }

        public string CallId
        {
            get
            {
                return this.textBox_CallID.Text.Trim();
            }
        }


        private void FrmHold_Load(object sender, EventArgs e)
        {
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
            this.btn_Cancel.Text = ConfigHelper.GetString("Cancel");
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

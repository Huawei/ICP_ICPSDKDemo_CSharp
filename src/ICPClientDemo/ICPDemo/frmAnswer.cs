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
    public partial class frmAnswer : Form
    {
        public frmAnswer()
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

        public bool _isVideo;

        private void frmAnswer_Load(object sender, EventArgs e)
        {
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
            this.btn_Cancel.Text = ConfigHelper.GetString("Cancel");
            this.lblCallType.Text = ConfigHelper.GetString("IsVideo");

            this.isVideo.Items.Clear();
            this.isVideo.Items.AddRange(new object[] {
            ConfigHelper.GetString("True"),
            ConfigHelper.GetString("False")});
            this.isVideo.SelectedIndex = 0;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            var intCallType = this.isVideo.SelectedIndex;

            if (true == this.isVideo.Visible)
            {
                if (0 == intCallType)
                {
                    this._isVideo = true;
                }
                else if (1 == intCallType)
                {
                    this._isVideo = false;
                }
                else
                {
                    MsgBox.Info("Please select call type.");
                    this.isVideo.Focus();

                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

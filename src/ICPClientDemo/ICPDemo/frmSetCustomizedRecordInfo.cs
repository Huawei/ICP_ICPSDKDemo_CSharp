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
    public partial class frmSetCustomizedRecordInfo : Form
    {
        public string RecordId { get; set; }
        public string Data { get; set; }
        public frmSetCustomizedRecordInfo()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RecordId = this.textRecordId.Text.Trim();
            Data = this.textData.Text.Trim();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmSetCustomizedRecordInfo_Load(object sender, EventArgs e)
        {
            this.Text = ConfigHelper.GetString("SetCustomizedRecordInfo");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblRecordId.Text = ConfigHelper.GetString("RecordId");
            this.lblData.Text = ConfigHelper.GetString("Data");
        }
    }
}

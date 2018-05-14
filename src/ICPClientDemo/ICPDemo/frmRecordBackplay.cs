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
    public partial class frmRecordBackplay : Form
    {
        public frmRecordBackplay()
        {
            InitializeComponent();
        }

        public string nonce
        {
            get
            {
                return this.textBox_Nonce.Text.Trim();
            }

            set
            {
                this.textBox_Nonce.Text = value;
            }
        }

        public string fileFolder
        {
            get
            {
                return this.textBox_Filefolder.Text.Trim();
            }

            set
            {
                this.textBox_Filefolder.Text = value;
            }
        }

        public string recordFile
        {
            get
            {
                return this.textBox_Recordfile.Text.Trim();
            }

            set
            {
                this.textBox_Recordfile.Text = value;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void frmRecordBackplay_Load(object sender, EventArgs e)
        {
            this.label_Addr.Text = ConfigHelper.GetString("ServerIP");
            this.label_Filefolder.Text = ConfigHelper.GetString("FileFolder");
            this.label_Nonce.Text = ConfigHelper.GetString("Nonce");
            this.label_Recordfile.Text = ConfigHelper.GetString("RecordFile");
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
        }

        public string address 
        {
            get
            {
                return this.textBox_Addr.Text.Trim();
            }

            set
            {
                this.textBox_Addr.Text = value;
            }
        }
    }
}

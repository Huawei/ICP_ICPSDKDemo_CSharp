using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICPDemo
{
    public partial class frmDeviceId : Form
    {
        public string WirelessDeviceId { get; private set; }
        bool isPtt = false;

        public frmDeviceId(bool isPtt = false)
        {
            InitializeComponent();
            this.isPtt = isPtt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                var number = this.textPhoneNumber.Text.Trim();

                if (!isPtt && string.IsNullOrEmpty(number))
                {
                    MsgBox.Info("Please input device id.");
                    this.textPhoneNumber.Focus();

                    return;
                }

                this.WirelessDeviceId = number;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        private void frmDeviceId_Load(object sender, EventArgs e)
        {
            if (isPtt == false)
            {
                this.Text = ConfigHelper.GetString("QueryWirelessInfo");
                this.lblDevice.Text = ConfigHelper.GetString("DeviceId");
            }
            else
            {
                this.Text = ConfigHelper.GetString("PTTOn");
                this.lblDevice.Text = ConfigHelper.GetString("Level");
            }
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.Huawei.Device.Contract;
using Com.Huawei.Device.ServiceModel;

namespace ICPDemo
{
    public partial class Rest : Form
    {
        //休息时间
        public int RestTime { get; set; }
        //休息原因
        public int RestCode { get; set; }

        private IDevice _device;
        public Rest(IDevice device)
        {
            InitializeComponent();
            this._device = device;
        }

        //查询休息原因列表
        private void cboRestReason_Click(object sender, EventArgs e)
        {
            this._device.QueryRestReasons();
        }
        //把查询的休息原因绑定到界面
        public void GetRestReasons(List<RestReason> listRestReason)
        {
            cboRestReason.Items.Clear();
            if (listRestReason != null && listRestReason.Count > 0)
            {
                foreach (RestReason rest in listRestReason)
                {
                    cboRestReason.Items.Add(rest.RestCode + "_" + rest.RestReasonInfo);
                    cboRestReason.ValueMember = rest.RestCode.ToString();
                }
            }
            else
            {
                cboRestReason.Items.Add("null");
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            int time;
            string restTime = this.txtRestTime.Text.Trim();
            int usCause = 0;

            string selectedText = this.cboRestReason.Text;
            if (!string.IsNullOrEmpty(selectedText))
            {
                string[] values = selectedText.Split('_');
                if (null != values && values.Length > 1)
                {
                    string restCode = values[0];
                    if (restCode != null && !int.TryParse(restCode, out usCause))
                    {
                        MsgBox.Info("Please input virtual value.");
                    }
                }
            }
            if (string.IsNullOrEmpty(restTime))
            {
                MsgBox.Info("Please input rest time and cause.");
                this.txtRestTime.Focus();
                return;
            }
            if (!int.TryParse(restTime, out time))
            {
                MsgBox.Info("Please input virtual value.");
                return;
            }
            this.RestTime = time;
            this.RestCode = usCause;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Rest_Load(object sender, EventArgs e)
        {
            this.Text = ConfigHelper.GetString("Rest");
            this.lblTime.Text = ConfigHelper.GetString("lblRestTime");
            this.lblCause.Text = ConfigHelper.GetString("lblCause");
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
        }
    }
}

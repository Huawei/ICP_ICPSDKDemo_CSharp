using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.Huawei.Device.Contract;

namespace ICPDemo
{
    public partial class frmReplySMS : Form
    {
        IDevice _device { get;  set; }
        public string callNumber { get; set; }
       public string ulTime{ get;  set; }
       public int mediaType { get; set; }
       public int CCBIdx { get; set; }
       public string mediaStreamInfo { get; set; }
       public frmReplySMS(IDevice device, int mediaType, int CCBIdx, string ulTime, string callNumber, string mediaStreamInfo)
       {
           InitializeComponent();
           this._device = device;
           this.ulTime = ulTime;
           this.CCBIdx = CCBIdx;
           this.mediaType = mediaType;
           this.mediaStreamInfo = mediaStreamInfo;
           this.callNumber = callNumber;
           this.Text = callNumber;
           txtSMSInfo.Text = "[" + callNumber + "]" + ulTime + ":" + mediaStreamInfo;
       }

        //更新属性值
       public void UpdateSMS(string ulTime, int mediaType, int CCBIdx, string callNumber, string mediaStreamInfo)
       {
           txtSMSInfo.Text += "\r\n" +"[" + callNumber+"]" + ulTime + ":" + mediaStreamInfo;
           this.ulTime = ulTime;
           this.CCBIdx = CCBIdx;
           this.mediaType = mediaType;
           this.callNumber = callNumber;
       }
        //回复
        private void button1_Click(object sender, EventArgs e)
        {
            if (this._device != null)
            {
                DateTime dt = DateTime.Now;
                string replySMS = txtSendInfo.Text.Trim();
                int ulSeqNo = 0;
                string txtUlSeqNo = txtulSeqNo.Text.Trim();
                if (!string.IsNullOrEmpty(txtUlSeqNo) && !int.TryParse(txtUlSeqNo, out ulSeqNo))
                {
                    ulSeqNo = -1;
                }
                _device.ReplySMS(CCBIdx, replySMS, ulSeqNo);
                txtSMSInfo.Text += "\r\n" + "[Me]" + dt.ToString("yyyy-MM-dd HH:mm:ss") + ":" + replySMS;
                txtSendInfo.Text = "";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _device.ReleaseCallExWithCCBIdx(CCBIdx); 
        }

        private void frmReplySMS_Load(object sender, EventArgs e)
        {
            this.Text = ConfigHelper.GetString("Note");
            this.btnRePly.Text = ConfigHelper.GetString("SendSMS");
            this.btnStop.Text = ConfigHelper.GetString("CloseEnded");
            this.lblNo.Text = ConfigHelper.GetString("SeqNo");
        }
    }
}

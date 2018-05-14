using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.Huawei.Device.ServiceModel;

namespace ICPDemo
{
    public partial class frmChangeMemberMode : Form
    {
        public int OpType { get; set; }
        public DialContent DialContent { get; set; }
        public string MeetingID { get; set; }

        private string _meetingId;
        private DialContent _dialContent;
        public frmChangeMemberMode(string meetingId,DialContent dialContent)
        {
            InitializeComponent();
            this._meetingId = meetingId;
            this._dialContent = dialContent;
        }

        //加载事件
        private void frmChangeMemberMode_Load(object sender, EventArgs e)
        {
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            this.lblPhoneNumber.Text = ConfigHelper.GetString("PhoneNumber");
            this.lblType.Text = ConfigHelper.GetString("Type");
            this.lblMeeting.Text = ConfigHelper.GetString("MeetingId");
            this.combType.Items.Add(ConfigHelper.GetString("NotTalking"));
            this.combType.Items.Add(ConfigHelper.GetString("NotListen"));
            this.combType.Items.Add(ConfigHelper.GetString("HoldCancel"));
            this.combType.Items.Add(ConfigHelper.GetString("Hold"));

            if (null != _dialContent)
            {
                this.txtPhone.Text = _dialContent.PhoneNumber;
            }
            this.txtMeetingID.Text = this._meetingId;
        }

        //确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialContent dialContent = null;
            var index = combType.SelectedIndex;
            if (index >= 0)
            {
                OpType = index + 1;

                var phone = txtPhone.Text.Trim();
                if (!string.IsNullOrEmpty(phone))
                {
                    dialContent = new DialContent();
                    dialContent.PhoneNumber = phone;
                }
                MeetingID = txtMeetingID.Text.Trim();
            }
            DialContent = dialContent;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

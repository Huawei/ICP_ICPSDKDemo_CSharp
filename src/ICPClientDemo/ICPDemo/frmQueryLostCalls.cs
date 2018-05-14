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
    public partial class frmQueryLostCalls : Form
    {
        IDevice _device { get; set; }
        public frmQueryLostCalls()
        {
            InitializeComponent();
        }
        public frmQueryLostCalls(IDevice device)
       {
           InitializeComponent();
           this._device = device;
       }

       //查询选择时间段内丢失通话数量
        private void btnQueryCallsCount_Click(object sender, EventArgs e)
        {
            if (_device != null)
            {
                var beginTime = this.beginTimePicker.Value;
                var endTime = this.endTimePicker.Value;
                if (endTime < beginTime)
                {
                    MsgBox.Error("EndTime is small than BeginTime");
                    return;
                }
                _device.QueryLostCallsCount(beginTime, endTime);
            }
            else
            {
                MsgBox.Error(ConfigHelper.GetString("NotInitialized"));
            }
        }

        //查询丢失通话详细信息
        private void btnQueryLostCalls_Click(object sender, EventArgs e)
        {
            if (_device != null)
            {
                var beginTime = this.beginTimePicker.Value;
                var endTime = this.endTimePicker.Value;
                var start = this.txtStartPosition.Text.Trim();
                var end=this.txtEndPosition.Text.Trim();
                int startPosition=0,endPosition =0;
                if (!int.TryParse(start, out startPosition) || !int.TryParse(end, out endPosition))
                {
                    MsgBox.Error("input error");
                    return;
                }

                if (startPosition == 0 || endPosition == 0 || endPosition < startPosition)
                {
                    MsgBox.Error("input error");
                    return;
                }

                if (endTime < beginTime)
                {
                    MsgBox.Error("EndTime is small than BeginTime");
                    return;
                }
                _device.QueryLostCalls(startPosition, endPosition, beginTime,endTime);
            }
            else
            {
                MsgBox.Error(ConfigHelper.GetString("NotInitialized"));
            }
        }

        private void frmQueryLostCalls_Load(object sender, EventArgs e)
        {
            this.btnQueryLostCalls.Text = ConfigHelper.GetString("QueryLostCalls");
            this.btnQueryCallsCount.Text = ConfigHelper.GetString("QueryLostCallsCount");
            this.lblBeginTime.Text = ConfigHelper.GetString("BeginTime");
            this.lblEndTime.Text = ConfigHelper.GetString("EndTime");
            this.lblStartPosition.Text = ConfigHelper.GetString("StartPosition");
            this.lblEndPosition.Text = ConfigHelper.GetString("EndPosition");
        }
    }
}

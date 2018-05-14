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
    public partial class FrmQueryCallList : Form
    {
        frmMainDeviceCallback frmMainDeviceCallback = null;
        frmMain frmMain = null;
        public FrmQueryCallList(frmMainDeviceCallback frmMainDeviceCallback, frmMain frmMain)
        {
            InitializeComponent();
            if (frmMainDeviceCallback != null)
            {
                this.frmMainDeviceCallback = frmMainDeviceCallback;
                this.frmMain = frmMain;
                this.Load += new EventHandler(FrmQueryCallList_Load);
                this.frmMainDeviceCallback.CallListChanged = OnCallListChange;
            }
        }

        void FrmQueryCallList_Load(object sender, EventArgs e)
        {
            this.btnOK.Text = ConfigHelper.GetString("Ok");
            this.lblCallId.Text = ConfigHelper.GetString("lblSkillID");
            this.Text = ConfigHelper.GetString("QueryCallListByGroupId");
            this.btnDisconnectCall.Text = ConfigHelper.GetString("DisconnectCall");
            this.btnStopQuery.Text = ConfigHelper.GetString("StopQuery");
            this.button1.Text = ConfigHelper.GetString("DisconnectCall");
            this.lCallId.Text = ConfigHelper.GetString("CallId");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string groupId = textId.Text.Trim();
            if (string.IsNullOrEmpty(groupId))
            {
                MsgBox.Info("Please input groupId.");
                textId.Focus();
                return;
            }
            frmMain.PerformDeviceAction((device) => device.QueryCallListByGroupId(groupId));
        }

        private void OnCallListChange(object callId, CallListDetailsChanged callList)
        {
            try
            {
                this.lstCall.Invoke(new Action(() =>
                {

                    if (callList.BIsAddCall)
                    {
                        for (int i = 0; i < this.lstCall.Items.Count; i++)
                        {
                            object ob = this.lstCall.Items[i];
                            if (callList.CallId == ob.ToString().Split(';')[0].ToString())
                            {
                                return;
                            }
                        }
                        this.lstCall.Items.Add(callList.CallId.ToString() + ";" + callList.CallerNumber + ";" + callList.GroupId + ";" + callList.CustomerLevel);
                    }
                    else
                    {
                        for (int i = 0; i < this.lstCall.Items.Count; i++)
                        {
                            object ob = this.lstCall.Items[i];
                            if (callList.CallId == ob.ToString().Split(';')[0].ToString())
                            {
                                this.lstCall.Items.RemoveAt(i);
                                break;
                            }
                        }
                    };
                }));
            }
            catch
            {
                MessageBox.Show("OnCallListChange error");
            }          
        }

        private void btnDisconnectCall_Click(object sender, EventArgs e)
        {
            if (this.lstCall.SelectedIndex > -1)
            {
                frmMain.PerformDeviceAction((device) => device.DisconnectCall(this.lstCall.SelectedItem.ToString().Split(';')[0]));
            }
        }

        private void btnStopQuery_Click(object sender, EventArgs e)
        {
            frmMain.PerformDeviceAction((device) => device.StopQueryCallListByGroupId(textId.Text.Trim()));

            try
            {
                if (textId.Text.Trim() == string.Empty)
                {
                    this.lstCall.Items.Clear();
                    return;
                }
                List<object> lst = new List<object>();
                for (int i = 0; i < this.lstCall.Items.Count; i++)
                {
                    object ob = this.lstCall.Items[i];
                    if (textId.Text.Trim() == ob.ToString().Split(';')[2].ToString())
                    {
                        lst.Add(ob);
                    }
                }
                for (int i = 0; i < lst.Count; i++)
                {
                    this.lstCall.Items.Remove(lst[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        //根据输入框中的ID拆除通话
        private void button1_Click(object sender, EventArgs e)
        {
            var callID = txtCallID.Text;
            frmMain.PerformDeviceAction((device) => device.DisconnectCall(callID));
        }

    }
}

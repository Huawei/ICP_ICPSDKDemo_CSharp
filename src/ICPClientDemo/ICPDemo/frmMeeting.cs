using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Com.Huawei.Device.Contract;
using Com.Huawei.Device.ServiceModel;

namespace ICPDemo
{
    public partial class frmMeeting : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public IDevice Device { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public AgentInfo AgentInfo { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string MeetingId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<DialContent> DialContentList { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public frmMeeting(IDevice device, AgentInfo agentInfo)
        {
            InitializeComponent();

            this.Device = device;
            this.AgentInfo = agentInfo;
            this.DialContentList = new List<DialContent>();

            this.lvwMembers.Items.Clear();
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        public void ClearList()
        {
            this.lvwMembers.Items.Clear();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="phoneNumber"></param>
        public DialContent FindDialContent(string phoneNumber)
        {
            var list = this.DialContentList;

            if (list == null)
            {
                return null;
            }

            var itemArray = list.ToArray();

            foreach (var item in itemArray)
            {
                if (item.PhoneNumber == phoneNumber)
                {
                    return item;
                }
            }

            return null;
        }
        public  bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }

            phoneNumber = phoneNumber.Trim();

            foreach (char ch in phoneNumber)
            {
                if ((ch >= '0' && ch <= '9') || ch == '*' || ch == '#')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dialContent"></param>
        public void AddDialContent(DialContent dialContent)
        {
            if (dialContent == null)
            {
                return;
            }

            var obj = this.FindDialContent(dialContent.PhoneNumber);

            if (obj == null)
            {
                this.DialContentList.Add(dialContent);
            }

            var item = this.lvwMembers.Items[dialContent.PhoneNumber];

            if (item != null)
            {
                item.SubItems[1].Text = dialContent.Status.ToString();
            }
            else
            {
                item = this.lvwMembers.Items.Add(dialContent.PhoneNumber, dialContent.PhoneNumber, null);
                item.SubItems.Add(dialContent.Status.ToString());
                item.Tag = dialContent;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dialContent"></param>
        public void RemoveDialContent(DialContent dialContent)
        {
            if (dialContent == null)
            {
                return;
            }

            var obj = this.FindDialContent(dialContent.PhoneNumber);

            if (obj != null)
            {
                this.DialContentList.Remove(obj);

                this.lvwMembers.Items.RemoveByKey(obj.PhoneNumber);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndMeeting_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Device == null)
                {
                    return;
                }

                this.Device.EndMeeting(this.MeetingId);
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {              
                var dialog = new frmDial(true);
                dialog.Text = btnAddMember.Text;
                if (dialog.ShowDialog(true) == System.Windows.Forms.DialogResult.OK)
                {
                    var content = dialog.DialContent;

                    if (this.FindDialContent(content.PhoneNumber) != null)
                    {
                        MsgBox.Info(ConfigHelper.GetString("AlreadyExist"), content.PhoneNumber);

                        return;
                    }
                    if (!this.IsValidPhoneNumber(content.PhoneNumber))
                    {
                        MsgBox.Info("Invalid phone number.");

                        return;
                    }
                    content.Status = MeetingStatus.Loading;

                    this.AddDialContent(content);

                    if (this.Device != null)
                    {
                        this.Device.InviteMeetingMember(this.MeetingId, content);
                    }
                }
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }
        //批量增加成员
        private void BtnInviteMembers_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new frmPollingCall(false);
                dialog.Text = BtnInviteMembers.Text;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var contents = dialog.dialContents;
                    if (null != contents && contents.Count > 0)
                    {
                        string phone = "";
                        for (int i = 0; i < contents.Count; i++)
                        {
                            if (contents[i] != null)
                            {
                                var content = contents[i] as DialContent;
                                phone =  content !=null ? content.PhoneNumber : "";
                            }
                            if (this.FindDialContent(phone) == null)
                            {
                                this.Device.InviteMeetingMember(this.MeetingId, contents[i]);
                            }
                        }
                    }
                }
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        private void frmMeeting_Load(object sender, EventArgs e)
        {
            this.Text = ConfigHelper.GetString("lblMeeting");
            this.btnAddMember.Text = ConfigHelper.GetString("InviteMeetingMember");
            this.BtnInviteMembers.Text = ConfigHelper.GetString("InviteMembers");
            this.btnRemoveMember.Text = ConfigHelper.GetString("RemoveMeetingMember");
            this.BtnRemoveMembers.Text = ConfigHelper.GetString("RemoveMeetingMembers");
            this.btnEndMeeting.Text = ConfigHelper.GetString("EndMeeting");
            this.btnChangeMemberMode.Text = ConfigHelper.GetString("ChangeMemberMode");
            this.btnQueryMembers.Text = ConfigHelper.GetString("QueryMeetingMembers");
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Device == null)
                {
                    return;
                }

                var selectedItems = this.lvwMembers.SelectedItems;

                if (selectedItems == null || selectedItems.Count == 0)
                {
                    return;
                }

                DialContent dialContent = (DialContent)selectedItems[0].Tag;

                if (this.AgentInfo != null && dialContent != null && this.AgentInfo.PhoneNumber == dialContent.PhoneNumber)
                {
                    MsgBox.Error("Cannot remove self.");
                    return;
                }

                this.Device.RemoveMeetingMember(this.MeetingId, dialContent);
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        //批量移除成员
        private void BtnRemoveMembers_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Device == null)
                {
                    return;
                }

                var selectedItems = this.lvwMembers.Items;

                if (selectedItems == null || selectedItems.Count == 0)
                {
                    return;
                }
                for (int i = 0; i < selectedItems.Count; i++)
                {
                    DialContent dialContent = (DialContent)selectedItems[i].Tag;
                    if (this.AgentInfo != null && dialContent != null && this.AgentInfo.PhoneNumber != dialContent.PhoneNumber)
                    {
                        this.Device.RemoveMeetingMember(this.MeetingId, dialContent);
                    }
                }
            }
            catch
            {
                MsgBox.Error("occur exception");
            }
        }

        //改变会议成员属性
        private void btnChangeMemberMode_Click(object sender, EventArgs e)
        {
            DialContent dialContent = null;
            var selectedItems = this.lvwMembers.SelectedItems;

            if (selectedItems != null && selectedItems.Count > 0)
            {
                dialContent = selectedItems[0].Tag == null ? null : (DialContent)selectedItems[0].Tag;
            }
            var dialog = new frmChangeMemberMode(this.MeetingId, dialContent);
            dialog.Text = btnChangeMemberMode.Text;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && null != dialog.DialContent)
            {
                this.Device.ChangeMeetingMemberMode(dialog.MeetingID, dialog.DialContent, dialog.OpType);
            }
        }

        //查询会议成员
        private void btnQueryMembers_Click(object sender, EventArgs e)
        {
            var dialog = new CommonForm(this.MeetingId, false);
            dialog.Text = btnQueryMembers.Text;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               this. Device.QueryMeetingMembers(dialog.MettingId);
            }
        }
    }
}
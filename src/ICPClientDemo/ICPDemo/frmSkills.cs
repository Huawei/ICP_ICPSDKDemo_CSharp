using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Com.Huawei.Device.Contract;
using Com.Huawei.Device.ServiceModel;

namespace ICPDemo
{
    public partial class frmSkills : Form
    {
        IDevice _device { get; set; }
        public List<int> Groups { get; set; }
        public string AgentID { get; set; }
        public frmSkills(IDevice device)
        {
            InitializeComponent();
            _device = device;
        }

        //跟新列表
        public void ResetAgentSkill(List<SkillGroup> listSkill)
        {
            checkedListBox.Items.Clear();
            if (null != listSkill && listSkill.Count > 0)
            {
                foreach (SkillGroup skill in listSkill)
                {
                    checkedListBox.Items.Add(skill.GroupId + "_" + skill.GroupName);
                }
            }
        }
        //加载
        private void frmSkills_Load(object sender, EventArgs e)
        {
            this.btnQuerySkillGroups.Text = ConfigHelper.GetString("QuerySkillGroups");
            this.btnResetAgentSkill.Text = ConfigHelper.GetString("ResetAgentSkill");
            this.lblAgentID.Text = ConfigHelper.GetString("AgentId");
            this.btnCancel.Text = ConfigHelper.GetString("Cancel");
            
        }

        //查询技能队列
        private void btnQuerySkillGroups_Click(object sender, EventArgs e)
        {

            if (_device != null)
            {
                _device.QuerySkillGroups();
            }
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        //重置
        private void btnResetAgentSkill_Click(object sender, EventArgs e)
        {
            AgentID = this.txtAgentID.Text.Trim();
            string output = string.Empty; 
            string[] grop=null;
            int gropID=0;
            Groups = new List<int>();
            for (int i = 0; i < checkedListBox.CheckedIndices.Count; i++)
            {
                output=checkedListBox.Items[checkedListBox.CheckedIndices[i]].ToString();
                if(!string.IsNullOrEmpty(output))
                {
                    grop = output.Split('_');
                    if (null != grop && grop.Length > 0 && int.TryParse(grop[0], out gropID))
                    {
                        Groups.Add(gropID);
                    }
                }
            } 
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}

namespace ICPDemo
{
    partial class frmSkills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnQuerySkillGroups = new System.Windows.Forms.Button();
            this.btnResetAgentSkill = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAgentID = new System.Windows.Forms.TextBox();
            this.lblAgentID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(67, 32);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(130, 116);
            this.checkedListBox.TabIndex = 0;
            // 
            // btnQuerySkillGroups
            // 
            this.btnQuerySkillGroups.Location = new System.Drawing.Point(67, 3);
            this.btnQuerySkillGroups.Name = "btnQuerySkillGroups";
            this.btnQuerySkillGroups.Size = new System.Drawing.Size(130, 23);
            this.btnQuerySkillGroups.TabIndex = 30;
            this.btnQuerySkillGroups.Text = "QuerySkillGroups";
            this.btnQuerySkillGroups.UseVisualStyleBackColor = true;
            this.btnQuerySkillGroups.Click += new System.EventHandler(this.btnQuerySkillGroups_Click);
            // 
            // btnResetAgentSkill
            // 
            this.btnResetAgentSkill.Location = new System.Drawing.Point(67, 181);
            this.btnResetAgentSkill.Name = "btnResetAgentSkill";
            this.btnResetAgentSkill.Size = new System.Drawing.Size(130, 23);
            this.btnResetAgentSkill.TabIndex = 31;
            this.btnResetAgentSkill.Text = "ResetAgentSkill";
            this.btnResetAgentSkill.UseVisualStyleBackColor = true;
            this.btnResetAgentSkill.Click += new System.EventHandler(this.btnResetAgentSkill_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(67, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAgentID
            // 
            this.txtAgentID.Location = new System.Drawing.Point(67, 154);
            this.txtAgentID.Name = "txtAgentID";
            this.txtAgentID.Size = new System.Drawing.Size(130, 21);
            this.txtAgentID.TabIndex = 33;
            // 
            // lblAgentID
            // 
            this.lblAgentID.AutoSize = true;
            this.lblAgentID.Location = new System.Drawing.Point(7, 157);
            this.lblAgentID.Name = "lblAgentID";
            this.lblAgentID.Size = new System.Drawing.Size(53, 12);
            this.lblAgentID.TabIndex = 34;
            this.lblAgentID.Text = "AgentID:";
            // 
            // frmSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 236);
            this.Controls.Add(this.lblAgentID);
            this.Controls.Add(this.txtAgentID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnResetAgentSkill);
            this.Controls.Add(this.btnQuerySkillGroups);
            this.Controls.Add(this.checkedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSkills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSkills";
            this.Load += new System.EventHandler(this.frmSkills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button btnQuerySkillGroups;
        private System.Windows.Forms.Button btnResetAgentSkill;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAgentID;
        private System.Windows.Forms.Label lblAgentID;
    }
}
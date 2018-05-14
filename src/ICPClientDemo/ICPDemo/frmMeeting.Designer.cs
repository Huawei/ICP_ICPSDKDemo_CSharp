namespace ICPDemo
{
    partial class frmMeeting
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.btnEndMeeting = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.lvwMembers = new System.Windows.Forms.ListView();
            this.colPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnInviteMembers = new System.Windows.Forms.Button();
            this.BtnRemoveMembers = new System.Windows.Forms.Button();
            this.btnQueryMembers = new System.Windows.Forms.Button();
            this.btnChangeMemberMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEndMeeting
            // 
            this.btnEndMeeting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndMeeting.Location = new System.Drawing.Point(438, 346);
            this.btnEndMeeting.Name = "btnEndMeeting";
            this.btnEndMeeting.Size = new System.Drawing.Size(120, 23);
            this.btnEndMeeting.TabIndex = 6;
            this.btnEndMeeting.Text = "End Meeting";
            this.btnEndMeeting.UseVisualStyleBackColor = true;
            this.btnEndMeeting.Click += new System.EventHandler(this.btnEndMeeting_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMember.Location = new System.Drawing.Point(12, 317);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(118, 23);
            this.btnAddMember.TabIndex = 8;
            this.btnAddMember.Text = "Invite Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveMember.Location = new System.Drawing.Point(146, 317);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(113, 23);
            this.btnRemoveMember.TabIndex = 9;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // lvwMembers
            // 
            this.lvwMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPhoneNumber,
            this.colState});
            this.lvwMembers.FullRowSelect = true;
            this.lvwMembers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lvwMembers.Location = new System.Drawing.Point(12, 12);
            this.lvwMembers.MultiSelect = false;
            this.lvwMembers.Name = "lvwMembers";
            this.lvwMembers.Size = new System.Drawing.Size(539, 299);
            this.lvwMembers.TabIndex = 10;
            this.lvwMembers.UseCompatibleStateImageBehavior = false;
            this.lvwMembers.View = System.Windows.Forms.View.Details;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Text = "Phone Number";
            this.colPhoneNumber.Width = 291;
            // 
            // colState
            // 
            this.colState.Text = "State";
            this.colState.Width = 205;
            // 
            // BtnInviteMembers
            // 
            this.BtnInviteMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnInviteMembers.Location = new System.Drawing.Point(12, 346);
            this.BtnInviteMembers.Name = "BtnInviteMembers";
            this.BtnInviteMembers.Size = new System.Drawing.Size(118, 23);
            this.BtnInviteMembers.TabIndex = 11;
            this.BtnInviteMembers.Text = "InviteMembers";
            this.BtnInviteMembers.UseVisualStyleBackColor = true;
            this.BtnInviteMembers.Click += new System.EventHandler(this.BtnInviteMembers_Click);
            // 
            // BtnRemoveMembers
            // 
            this.BtnRemoveMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRemoveMembers.Location = new System.Drawing.Point(146, 346);
            this.BtnRemoveMembers.Name = "BtnRemoveMembers";
            this.BtnRemoveMembers.Size = new System.Drawing.Size(113, 23);
            this.BtnRemoveMembers.TabIndex = 12;
            this.BtnRemoveMembers.Text = "RemoveMembers";
            this.BtnRemoveMembers.UseVisualStyleBackColor = true;
            this.BtnRemoveMembers.Click += new System.EventHandler(this.BtnRemoveMembers_Click);
            // 
            // btnQueryMembers
            // 
            this.btnQueryMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQueryMembers.Location = new System.Drawing.Point(275, 317);
            this.btnQueryMembers.Name = "btnQueryMembers";
            this.btnQueryMembers.Size = new System.Drawing.Size(157, 23);
            this.btnQueryMembers.TabIndex = 13;
            this.btnQueryMembers.Text = "QueryMeetingMembers";
            this.btnQueryMembers.UseVisualStyleBackColor = true;
            this.btnQueryMembers.Click += new System.EventHandler(this.btnQueryMembers_Click);
            // 
            // btnChangeMemberMode
            // 
            this.btnChangeMemberMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeMemberMode.Location = new System.Drawing.Point(275, 346);
            this.btnChangeMemberMode.Name = "btnChangeMemberMode";
            this.btnChangeMemberMode.Size = new System.Drawing.Size(157, 23);
            this.btnChangeMemberMode.TabIndex = 14;
            this.btnChangeMemberMode.Text = "ChangeMemberMode";
            this.btnChangeMemberMode.UseVisualStyleBackColor = true;
            this.btnChangeMemberMode.Click += new System.EventHandler(this.btnChangeMemberMode_Click);
            // 
            // frmMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 376);
            this.Controls.Add(this.btnChangeMemberMode);
            this.Controls.Add(this.btnQueryMembers);
            this.Controls.Add(this.BtnRemoveMembers);
            this.Controls.Add(this.BtnInviteMembers);
            this.Controls.Add(this.lvwMembers);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnEndMeeting);
            this.MinimumSize = new System.Drawing.Size(525, 250);
            this.Name = "frmMeeting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting";
            this.Load += new System.EventHandler(this.frmMeeting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEndMeeting;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.ListView lvwMembers;
        private System.Windows.Forms.ColumnHeader colPhoneNumber;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.Button BtnInviteMembers;
        private System.Windows.Forms.Button BtnRemoveMembers;
        private System.Windows.Forms.Button btnQueryMembers;
        private System.Windows.Forms.Button btnChangeMemberMode;
    }
}
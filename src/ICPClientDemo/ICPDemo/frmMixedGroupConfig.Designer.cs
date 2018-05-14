namespace ICPDemo
{
    partial class frmMixedGroupConfig
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.textBox_groupAlias = new System.Windows.Forms.TextBox();
            this.label_group_alias = new System.Windows.Forms.Label();
            this.checkBox_reservedSwitch = new System.Windows.Forms.CheckBox();
            this.checkBox_Muted = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(105, 212);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblGroupId
            // 
            this.lblGroupId.Location = new System.Drawing.Point(12, 53);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(100, 12);
            this.lblGroupId.TabIndex = 1;
            this.lblGroupId.Text = "GroupID:";
            this.lblGroupId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsers
            // 
            this.lblUsers.Location = new System.Drawing.Point(12, 85);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(100, 12);
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "Users:";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(135, 50);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(100, 21);
            this.txtGroupId.TabIndex = 3;
            this.txtGroupId.Text = "3456005";
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(135, 82);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(100, 21);
            this.txtUsers.TabIndex = 4;
            // 
            // textBox_groupAlias
            // 
            this.textBox_groupAlias.Location = new System.Drawing.Point(135, 116);
            this.textBox_groupAlias.Name = "textBox_groupAlias";
            this.textBox_groupAlias.Size = new System.Drawing.Size(100, 21);
            this.textBox_groupAlias.TabIndex = 6;
            // 
            // label_group_alias
            // 
            this.label_group_alias.Location = new System.Drawing.Point(12, 119);
            this.label_group_alias.Name = "label_group_alias";
            this.label_group_alias.Size = new System.Drawing.Size(100, 12);
            this.label_group_alias.TabIndex = 5;
            this.label_group_alias.Text = "GroupAlias";
            this.label_group_alias.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBox_reservedSwitch
            // 
            this.checkBox_reservedSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_reservedSwitch.AutoSize = true;
            this.checkBox_reservedSwitch.Location = new System.Drawing.Point(136, 172);
            this.checkBox_reservedSwitch.Name = "checkBox_reservedSwitch";
            this.checkBox_reservedSwitch.Size = new System.Drawing.Size(108, 16);
            this.checkBox_reservedSwitch.TabIndex = 23;
            this.checkBox_reservedSwitch.Text = "ReservedSwitch";
            this.checkBox_reservedSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_reservedSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBox_Muted
            // 
            this.checkBox_Muted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_Muted.AutoSize = true;
            this.checkBox_Muted.Location = new System.Drawing.Point(136, 149);
            this.checkBox_Muted.Name = "checkBox_Muted";
            this.checkBox_Muted.Size = new System.Drawing.Size(48, 16);
            this.checkBox_Muted.TabIndex = 22;
            this.checkBox_Muted.Text = "Mute";
            this.checkBox_Muted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Muted.UseVisualStyleBackColor = true;
            // 
            // frmMixedGroupConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkBox_reservedSwitch);
            this.Controls.Add(this.checkBox_Muted);
            this.Controls.Add(this.textBox_groupAlias);
            this.Controls.Add(this.label_group_alias);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.txtGroupId);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.btnOk);
            this.Name = "frmMixedGroupConfig";
            this.Text = "frmMixedGroupConfig";
            this.Load += new System.EventHandler(this.frmMixedGroupConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.TextBox textBox_groupAlias;
        private System.Windows.Forms.Label label_group_alias;
        private System.Windows.Forms.CheckBox checkBox_reservedSwitch;
        private System.Windows.Forms.CheckBox checkBox_Muted;
    }
}
namespace ICPDemo
{
    partial class frmMixedGroupUserStateConfig
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
            this.txtMuiltUsers = new System.Windows.Forms.TextBox();
            this.lblMuiltUsers = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupSingleUser = new System.Windows.Forms.GroupBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.lblIsSingleUser = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.groupSingleUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMuiltUsers
            // 
            this.txtMuiltUsers.Location = new System.Drawing.Point(139, 229);
            this.txtMuiltUsers.Name = "txtMuiltUsers";
            this.txtMuiltUsers.Size = new System.Drawing.Size(100, 21);
            this.txtMuiltUsers.TabIndex = 9;
            // 
            // lblMuiltUsers
            // 
            this.lblMuiltUsers.Location = new System.Drawing.Point(28, 232);
            this.lblMuiltUsers.Name = "lblMuiltUsers";
            this.lblMuiltUsers.Size = new System.Drawing.Size(100, 12);
            this.lblMuiltUsers.TabIndex = 7;
            this.lblMuiltUsers.Text = "MuiltUsers:";
            this.lblMuiltUsers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(99, 304);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupSingleUser
            // 
            this.groupSingleUser.Controls.Add(this.txtState);
            this.groupSingleUser.Controls.Add(this.txtUserType);
            this.groupSingleUser.Controls.Add(this.txtUserNumber);
            this.groupSingleUser.Controls.Add(this.lblState);
            this.groupSingleUser.Controls.Add(this.lblUserType);
            this.groupSingleUser.Controls.Add(this.lblUserNumber);
            this.groupSingleUser.Location = new System.Drawing.Point(36, 69);
            this.groupSingleUser.Name = "groupSingleUser";
            this.groupSingleUser.Size = new System.Drawing.Size(224, 144);
            this.groupSingleUser.TabIndex = 16;
            this.groupSingleUser.TabStop = false;
            this.groupSingleUser.Text = "SingleUser";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(103, 115);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 21);
            this.txtState.TabIndex = 23;
            // 
            // txtUserType
            // 
            this.txtUserType.Location = new System.Drawing.Point(103, 71);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(100, 21);
            this.txtUserType.TabIndex = 22;
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(103, 29);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(100, 21);
            this.txtUserNumber.TabIndex = 21;
            // 
            // lblUserType
            // 
            this.lblUserType.Location = new System.Drawing.Point(-8, 74);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(100, 12);
            this.lblUserType.TabIndex = 19;
            this.lblUserType.Text = "UserType:";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.Location = new System.Drawing.Point(-8, 32);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(100, 12);
            this.lblUserNumber.TabIndex = 18;
            this.lblUserNumber.Text = "UserNumber:";
            this.lblUserNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(139, 30);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(100, 21);
            this.txtGroupId.TabIndex = 17;
            // 
            // lblGroupId
            // 
            this.lblGroupId.Location = new System.Drawing.Point(28, 33);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(100, 12);
            this.lblGroupId.TabIndex = 16;
            this.lblGroupId.Text = "GroupID:";
            this.lblGroupId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdoFalse
            // 
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Location = new System.Drawing.Point(207, 273);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(53, 16);
            this.rdoFalse.TabIndex = 19;
            this.rdoFalse.Text = "False";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Checked = true;
            this.rdoTrue.Location = new System.Drawing.Point(139, 273);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(47, 16);
            this.rdoTrue.TabIndex = 18;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "True";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // lblIsSingleUser
            // 
            this.lblIsSingleUser.Location = new System.Drawing.Point(45, 275);
            this.lblIsSingleUser.Name = "lblIsSingleUser";
            this.lblIsSingleUser.Size = new System.Drawing.Size(83, 12);
            this.lblIsSingleUser.TabIndex = 17;
            this.lblIsSingleUser.Text = "IsSingleUser:";
            this.lblIsSingleUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(-8, 118);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(100, 12);
            this.lblState.TabIndex = 20;
            this.lblState.Text = "State:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmMixedGroupUserStateConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 359);
            this.Controls.Add(this.rdoFalse);
            this.Controls.Add(this.rdoTrue);
            this.Controls.Add(this.lblIsSingleUser);
            this.Controls.Add(this.groupSingleUser);
            this.Controls.Add(this.txtMuiltUsers);
            this.Controls.Add(this.lblMuiltUsers);
            this.Controls.Add(this.txtGroupId);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblGroupId);
            this.Name = "frmMixedGroupUserStateConfig";
            this.Text = "frmMixedGroupUserStateConfig";
            this.Load += new System.EventHandler(this.frmMixedGroupUserStateConfig_Load);
            this.groupSingleUser.ResumeLayout(false);
            this.groupSingleUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMuiltUsers;
        private System.Windows.Forms.Label lblMuiltUsers;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupSingleUser;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.RadioButton rdoTrue;
        private System.Windows.Forms.Label lblIsSingleUser;
        private System.Windows.Forms.Label lblState;
    }
}
namespace ICPDemo
{
    partial class frmChangeMemberMode
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
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.combType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMeetingID = new System.Windows.Forms.TextBox();
            this.lblMeeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 50);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(114, 12);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "PhoneNumber:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(117, 47);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(122, 21);
            this.txtPhone.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(12, 86);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(105, 12);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // combType
            // 
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(117, 83);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(122, 20);
            this.combType.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(149, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(46, 113);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMeetingID
            // 
            this.txtMeetingID.Location = new System.Drawing.Point(117, 12);
            this.txtMeetingID.Name = "txtMeetingID";
            this.txtMeetingID.Size = new System.Drawing.Size(122, 21);
            this.txtMeetingID.TabIndex = 7;
            // 
            // lblMeeting
            // 
            this.lblMeeting.Location = new System.Drawing.Point(5, 15);
            this.lblMeeting.Name = "lblMeeting";
            this.lblMeeting.Size = new System.Drawing.Size(112, 12);
            this.lblMeeting.TabIndex = 6;
            this.lblMeeting.Text = "MeetingID:";
            this.lblMeeting.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmChangeMemberMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 148);
            this.Controls.Add(this.txtMeetingID);
            this.Controls.Add(this.lblMeeting);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.combType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhoneNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangeMemberMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangeMemberMode";
            this.Load += new System.EventHandler(this.frmChangeMemberMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMeetingID;
        private System.Windows.Forms.Label lblMeeting;
    }
}
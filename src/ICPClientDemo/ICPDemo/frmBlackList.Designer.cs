namespace ICPDemo
{
    partial class frmBlackList
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
        private void InitializeComponent(bool showFilterMode = false)
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.textLockTime = new System.Windows.Forms.TextBox();
            this.lblLockTime = new System.Windows.Forms.Label();
            this.rBtn_Reject = new System.Windows.Forms.RadioButton();
            this.rBtn_LowPriority = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(41, 143);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 25);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(123, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(40, 17);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(42, 34);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(153, 20);
            this.textPhoneNumber.TabIndex = 1;
            // 
            // textLockTime
            // 
            this.textLockTime.Location = new System.Drawing.Point(42, 76);
            this.textLockTime.Name = "textLockTime";
            this.textLockTime.Size = new System.Drawing.Size(153, 20);
            this.textLockTime.TabIndex = 3;
            // 
            // lblLockTime
            // 
            this.lblLockTime.AutoSize = true;
            this.lblLockTime.Location = new System.Drawing.Point(40, 60);
            this.lblLockTime.Name = "lblLockTime";
            this.lblLockTime.Size = new System.Drawing.Size(60, 13);
            this.lblLockTime.TabIndex = 2;
            this.lblLockTime.Text = "Lock Time:";

            if (showFilterMode)
            {
                // 
                // rBtn_Reject
                // 
                this.rBtn_Reject.AutoSize = true;
                this.rBtn_Reject.Location = new System.Drawing.Point(43, 112);
                this.rBtn_Reject.Name = "rBtn_Reject";
                this.rBtn_Reject.Size = new System.Drawing.Size(56, 17);
                this.rBtn_Reject.TabIndex = 6;
                this.rBtn_Reject.TabStop = true;
                this.rBtn_Reject.Text = "Reject";
                this.rBtn_Reject.UseVisualStyleBackColor = true;
                // 
                // rBtn_LowPriority
                // 
                this.rBtn_LowPriority.AutoSize = true;
                this.rBtn_LowPriority.Location = new System.Drawing.Point(123, 112);
                this.rBtn_LowPriority.Name = "rBtn_LowPriority";
                this.rBtn_LowPriority.Size = new System.Drawing.Size(76, 17);
                this.rBtn_LowPriority.TabIndex = 7;
                this.rBtn_LowPriority.TabStop = true;
                this.rBtn_LowPriority.Text = "LowPriority";
                this.rBtn_LowPriority.UseVisualStyleBackColor = true;
            }
           
            // 
            // frmBlackList
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(245, 217);
            this.Controls.Add(this.rBtn_LowPriority);
            this.Controls.Add(this.rBtn_Reject);
            this.Controls.Add(this.textLockTime);
            this.Controls.Add(this.lblLockTime);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBlackList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmBlackList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.TextBox textLockTime;
        private System.Windows.Forms.Label lblLockTime;
        private System.Windows.Forms.RadioButton rBtn_Reject;
        private System.Windows.Forms.RadioButton rBtn_LowPriority;
    }
}

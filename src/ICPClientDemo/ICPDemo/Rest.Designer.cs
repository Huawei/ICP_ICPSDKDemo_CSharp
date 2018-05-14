namespace ICPDemo
{
    partial class Rest
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
            this.cboRestReason = new System.Windows.Forms.ComboBox();
            this.txtRestTime = new System.Windows.Forms.TextBox();
            this.lblCause = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboRestReason
            // 
            this.cboRestReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRestReason.FormattingEnabled = true;
            this.cboRestReason.Location = new System.Drawing.Point(51, 71);
            this.cboRestReason.Name = "cboRestReason";
            this.cboRestReason.Size = new System.Drawing.Size(149, 20);
            this.cboRestReason.TabIndex = 36;
            this.cboRestReason.Click += new System.EventHandler(this.cboRestReason_Click);
            // 
            // txtRestTime
            // 
            this.txtRestTime.Location = new System.Drawing.Point(51, 25);
            this.txtRestTime.Name = "txtRestTime";
            this.txtRestTime.Size = new System.Drawing.Size(149, 21);
            this.txtRestTime.TabIndex = 33;
            // 
            // lblCause
            // 
            this.lblCause.AutoSize = true;
            this.lblCause.Location = new System.Drawing.Point(49, 53);
            this.lblCause.Name = "lblCause";
            this.lblCause.Size = new System.Drawing.Size(41, 12);
            this.lblCause.TabIndex = 35;
            this.lblCause.Text = "Cause:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(49, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 12);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "Time:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(126, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(48, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 23);
            this.btnOK.TabIndex = 37;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Rest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 151);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboRestReason);
            this.Controls.Add(this.txtRestTime);
            this.Controls.Add(this.lblCause);
            this.Controls.Add(this.lblTime);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rest";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rest";
            this.Load += new System.EventHandler(this.Rest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRestReason;
        private System.Windows.Forms.TextBox txtRestTime;
        private System.Windows.Forms.Label lblCause;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
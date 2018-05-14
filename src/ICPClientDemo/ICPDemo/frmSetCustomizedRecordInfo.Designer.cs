namespace ICPDemo
{
    partial class frmSetCustomizedRecordInfo
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
            this.lblRecordId = new System.Windows.Forms.Label();
            this.textRecordId = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhoneNumber
            // 
            this.lblRecordId.BackColor = System.Drawing.SystemColors.Control;
            this.lblRecordId.Location = new System.Drawing.Point(5, 40);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(112, 12);
            this.lblRecordId.TabIndex = 1;
            this.lblRecordId.Text = "RecordId:";
            this.lblRecordId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textPhoneNumber
            // 
            this.textRecordId.Location = new System.Drawing.Point(123, 37);
            this.textRecordId.Name = "textRecordId";
            this.textRecordId.Size = new System.Drawing.Size(130, 21);
            this.textRecordId.TabIndex = 1;
            // 
            // lblCustomerLevel
            // 
            this.lblData.BackColor = System.Drawing.SystemColors.Control;
            this.lblData.Location = new System.Drawing.Point(3, 70);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(114, 12);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textCustomerLevel
            // 
            this.textData.Location = new System.Drawing.Point(123, 67);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(130, 21);
            this.textData.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(163, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(56, 111);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSetCustomerLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.textRecordId);
            this.Controls.Add(this.lblRecordId);
            this.Name = "frmSetCustomizedRecordId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetCustomizedRecordId";
            this.Load += new System.EventHandler(this.frmSetCustomizedRecordInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecordId;
        private System.Windows.Forms.TextBox textRecordId;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
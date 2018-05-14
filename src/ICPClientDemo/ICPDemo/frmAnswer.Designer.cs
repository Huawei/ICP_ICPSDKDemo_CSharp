namespace ICPDemo
{
    partial class frmAnswer
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.textBox_CallID = new System.Windows.Forms.TextBox();
            this.label_CallID = new System.Windows.Forms.Label();
            this.isVideo = new System.Windows.Forms.ComboBox();
            this.lblCallType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(174, 173);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(38, 173);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBox_CallID
            // 
            this.textBox_CallID.Location = new System.Drawing.Point(104, 56);
            this.textBox_CallID.Name = "textBox_CallID";
            this.textBox_CallID.Size = new System.Drawing.Size(145, 21);
            this.textBox_CallID.TabIndex = 5;
            // 
            // label_CallID
            // 
            this.label_CallID.AutoSize = true;
            this.label_CallID.Location = new System.Drawing.Point(36, 59);
            this.label_CallID.Name = "label_CallID";
            this.label_CallID.Size = new System.Drawing.Size(53, 12);
            this.label_CallID.TabIndex = 4;
            this.label_CallID.Text = "Call ID:";
            // 
            // isVideo
            // 
            this.isVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isVideo.FormattingEnabled = true;
            this.isVideo.Items.AddRange(new object[] {
            "True",
            "False"});
            this.isVideo.Location = new System.Drawing.Point(102, 104);
            this.isVideo.Name = "isVideo";
            this.isVideo.Size = new System.Drawing.Size(147, 20);
            this.isVideo.TabIndex = 9;
            // 
            // lblCallType
            // 
            this.lblCallType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCallType.Location = new System.Drawing.Point(-31, 107);
            this.lblCallType.Name = "lblCallType";
            this.lblCallType.Size = new System.Drawing.Size(120, 12);
            this.lblCallType.TabIndex = 8;
            this.lblCallType.Text = "IsVideo:";
            this.lblCallType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.isVideo);
            this.Controls.Add(this.lblCallType);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_CallID);
            this.Controls.Add(this.label_CallID);
            this.Name = "frmAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnswer";
            this.Load += new System.EventHandler(this.frmAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox textBox_CallID;
        private System.Windows.Forms.Label label_CallID;
        public System.Windows.Forms.ComboBox isVideo;
        public System.Windows.Forms.Label lblCallType;
    }
}
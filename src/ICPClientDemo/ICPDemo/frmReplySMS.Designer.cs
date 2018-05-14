namespace ICPDemo
{
    partial class frmReplySMS
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
            this.txtSMSInfo = new System.Windows.Forms.TextBox();
            this.txtSendInfo = new System.Windows.Forms.TextBox();
            this.btnRePly = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtulSeqNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSMSInfo
            // 
            this.txtSMSInfo.Location = new System.Drawing.Point(12, 21);
            this.txtSMSInfo.Multiline = true;
            this.txtSMSInfo.Name = "txtSMSInfo";
            this.txtSMSInfo.Size = new System.Drawing.Size(347, 196);
            this.txtSMSInfo.TabIndex = 0;
            // 
            // txtSendInfo
            // 
            this.txtSendInfo.Location = new System.Drawing.Point(12, 239);
            this.txtSendInfo.Multiline = true;
            this.txtSendInfo.Name = "txtSendInfo";
            this.txtSendInfo.Size = new System.Drawing.Size(347, 102);
            this.txtSendInfo.TabIndex = 1;
            // 
            // btnRePly
            // 
            this.btnRePly.Location = new System.Drawing.Point(173, 361);
            this.btnRePly.Name = "btnRePly";
            this.btnRePly.Size = new System.Drawing.Size(79, 21);
            this.btnRePly.TabIndex = 2;
            this.btnRePly.Text = "Reply";
            this.btnRePly.UseVisualStyleBackColor = true;
            this.btnRePly.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(279, 361);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(79, 21);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Close";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtulSeqNo
            // 
            this.txtulSeqNo.Location = new System.Drawing.Point(76, 361);
            this.txtulSeqNo.Name = "txtulSeqNo";
            this.txtulSeqNo.Size = new System.Drawing.Size(54, 21);
            this.txtulSeqNo.TabIndex = 4;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(13, 364);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(47, 12);
            this.lblNo.TabIndex = 5;
            this.lblNo.Text = "Number:";
            // 
            // frmReplySMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 394);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.txtulSeqNo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRePly);
            this.Controls.Add(this.txtSendInfo);
            this.Controls.Add(this.txtSMSInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReplySMS";
            this.Text = "frmReplySMS";
            this.Load += new System.EventHandler(this.frmReplySMS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSMSInfo;
        private System.Windows.Forms.TextBox txtSendInfo;
        private System.Windows.Forms.Button btnRePly;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtulSeqNo;
        private System.Windows.Forms.Label lblNo;
    }
}
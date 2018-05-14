namespace ICPDemo
{
    partial class frmStopEmergencyNote
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.label_TalkingGroupID = new System.Windows.Forms.Label();
            this.textBox_TalkingGroupID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(138, 49);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(62, 23);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label_TalkingGroupID
            // 
            this.label_TalkingGroupID.Location = new System.Drawing.Point(12, 12);
            this.label_TalkingGroupID.Name = "label_TalkingGroupID";
            this.label_TalkingGroupID.Size = new System.Drawing.Size(120, 21);
            this.label_TalkingGroupID.TabIndex = 6;
            this.label_TalkingGroupID.Text = "Note Config:";
            this.label_TalkingGroupID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_TalkingGroupID
            // 
            this.textBox_TalkingGroupID.Location = new System.Drawing.Point(138, 9);
            this.textBox_TalkingGroupID.Name = "textBox_TalkingGroupID";
            this.textBox_TalkingGroupID.Size = new System.Drawing.Size(135, 21);
            this.textBox_TalkingGroupID.TabIndex = 5;
            // 
            // frmStopEmergencyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 87);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label_TalkingGroupID);
            this.Controls.Add(this.textBox_TalkingGroupID);
            this.Name = "frmStopEmergencyNote";
            this.Load += new System.EventHandler(this.frmStopEmergencyNote_Load);
            this.Text = "StopEmergencyNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label_TalkingGroupID;
        private System.Windows.Forms.TextBox textBox_TalkingGroupID;
    }
}
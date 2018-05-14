namespace ICPDemo
{
    partial class frmTransToIVR
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
            this.lblSkillID = new System.Windows.Forms.Label();
            this.txtSkillID = new System.Windows.Forms.TextBox();
            this.rbReleaseTransfer = new System.Windows.Forms.RadioButton();
            this.rbSuccTransfer = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSkillID
            // 
            this.lblSkillID.AutoSize = true;
            this.lblSkillID.Location = new System.Drawing.Point(34, 9);
            this.lblSkillID.Name = "lblSkillID";
            this.lblSkillID.Size = new System.Drawing.Size(71, 12);
            this.lblSkillID.TabIndex = 0;
            this.lblSkillID.Text = "AccessCode:";
            // 
            // txtSkillID
            // 
            this.txtSkillID.Location = new System.Drawing.Point(36, 24);
            this.txtSkillID.Name = "txtSkillID";
            this.txtSkillID.Size = new System.Drawing.Size(165, 21);
            this.txtSkillID.TabIndex = 1;
            // 
            // rbReleaseTransfer
            // 
            this.rbReleaseTransfer.AutoSize = true;
            this.rbReleaseTransfer.Checked = true;
            this.rbReleaseTransfer.Location = new System.Drawing.Point(36, 53);
            this.rbReleaseTransfer.Name = "rbReleaseTransfer";
            this.rbReleaseTransfer.Size = new System.Drawing.Size(59, 16);
            this.rbReleaseTransfer.TabIndex = 2;
            this.rbReleaseTransfer.TabStop = true;
            this.rbReleaseTransfer.Text = "释放转";
            this.rbReleaseTransfer.UseVisualStyleBackColor = true;
            // 
            // rbSuccTransfer
            // 
            this.rbSuccTransfer.AutoSize = true;
            this.rbSuccTransfer.Location = new System.Drawing.Point(36, 80);
            this.rbSuccTransfer.Name = "rbSuccTransfer";
            this.rbSuccTransfer.Size = new System.Drawing.Size(59, 16);
            this.rbSuccTransfer.TabIndex = 3;
            this.rbSuccTransfer.Text = "成功转";
            this.rbSuccTransfer.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(29, 118);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTransToIVR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 160);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rbSuccTransfer);
            this.Controls.Add(this.rbReleaseTransfer);
            this.Controls.Add(this.txtSkillID);
            this.Controls.Add(this.lblSkillID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransToIVR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransToIVR";
            this.Load += new System.EventHandler(this.frmTransferToSkillGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkillID;
        private System.Windows.Forms.TextBox txtSkillID;
        private System.Windows.Forms.RadioButton rbReleaseTransfer;
        private System.Windows.Forms.RadioButton rbSuccTransfer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
namespace ICPDemo
{
    partial class CommonForm
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
            this.txtOldNumber = new System.Windows.Forms.TextBox();
            this.textMettingId = new System.Windows.Forms.TextBox();
            this.lblMetting = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.lblOlderNumber = new System.Windows.Forms.Label();
            this.lblNewNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOldNumber
            // 
            this.txtOldNumber.Location = new System.Drawing.Point(28, 64);
            this.txtOldNumber.Name = "txtOldNumber";
            this.txtOldNumber.Size = new System.Drawing.Size(155, 21);
            this.txtOldNumber.TabIndex = 9;
            // 
            // textMettingId
            // 
            this.textMettingId.Location = new System.Drawing.Point(28, 25);
            this.textMettingId.Name = "textMettingId";
            this.textMettingId.Size = new System.Drawing.Size(155, 21);
            this.textMettingId.TabIndex = 7;
            // 
            // lblMetting
            // 
            this.lblMetting.AutoSize = true;
            this.lblMetting.Location = new System.Drawing.Point(26, 10);
            this.lblMetting.Name = "lblMetting";
            this.lblMetting.Size = new System.Drawing.Size(71, 12);
            this.lblMetting.TabIndex = 6;
            this.lblMetting.Text = "Metting ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(113, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(27, 130);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.Location = new System.Drawing.Point(28, 103);
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.Size = new System.Drawing.Size(155, 21);
            this.txtNewNumber.TabIndex = 10;
            // 
            // lblOlderNumber
            // 
            this.lblOlderNumber.AutoSize = true;
            this.lblOlderNumber.Location = new System.Drawing.Point(26, 49);
            this.lblOlderNumber.Name = "lblOlderNumber";
            this.lblOlderNumber.Size = new System.Drawing.Size(65, 12);
            this.lblOlderNumber.TabIndex = 44;
            this.lblOlderNumber.Text = "OldMaster:";
            // 
            // lblNewNumber
            // 
            this.lblNewNumber.AutoSize = true;
            this.lblNewNumber.Location = new System.Drawing.Point(26, 88);
            this.lblNewNumber.Name = "lblNewNumber";
            this.lblNewNumber.Size = new System.Drawing.Size(65, 12);
            this.lblNewNumber.TabIndex = 46;
            this.lblNewNumber.Text = "NewMaster:";
            // 
            // CommonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 159);
            this.Controls.Add(this.lblNewNumber);
            this.Controls.Add(this.lblOlderNumber);
            this.Controls.Add(this.txtNewNumber);
            this.Controls.Add(this.txtOldNumber);
            this.Controls.Add(this.textMettingId);
            this.Controls.Add(this.lblMetting);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CommonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommonForm";
            this.Load += new System.EventHandler(this.CommonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldNumber;
        private System.Windows.Forms.TextBox textMettingId;
        private System.Windows.Forms.Label lblMetting;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Label lblOlderNumber;
        private System.Windows.Forms.Label lblNewNumber;
    }
}
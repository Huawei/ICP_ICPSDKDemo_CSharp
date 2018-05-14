namespace ICPDemo
{
    partial class frmChangePwd
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
            this.lblNew = new System.Windows.Forms.Label();
            this.lblOld = new System.Windows.Forms.Label();
            this.txtNewPw5 = new System.Windows.Forms.TextBox();
            this.txtOldPw5 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblPutAgain = new System.Windows.Forms.Label();
            this.txtAgainPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(39, 57);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(77, 12);
            this.lblNew.TabIndex = 47;
            this.lblNew.Text = "NewPassWord:";
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Location = new System.Drawing.Point(39, 12);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(77, 12);
            this.lblOld.TabIndex = 46;
            this.lblOld.Text = "OldPassWord:";
            // 
            // txtNewPw5
            // 
            this.txtNewPw5.Location = new System.Drawing.Point(40, 72);
            this.txtNewPw5.Name = "txtNewPw5";
            this.txtNewPw5.PasswordChar = '*';
            this.txtNewPw5.Size = new System.Drawing.Size(151, 21);
            this.txtNewPw5.TabIndex = 45;
            // 
            // txtOldPw5
            // 
            this.txtOldPw5.Location = new System.Drawing.Point(41, 27);
            this.txtOldPw5.Name = "txtOldPw5";
            this.txtOldPw5.PasswordChar = '*';
            this.txtOldPw5.Size = new System.Drawing.Size(150, 21);
            this.txtOldPw5.TabIndex = 44;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(125, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 23);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(40, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 23);
            this.btnOK.TabIndex = 48;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblPutAgain
            // 
            this.lblPutAgain.AutoSize = true;
            this.lblPutAgain.Location = new System.Drawing.Point(40, 104);
            this.lblPutAgain.Name = "lblPutAgain";
            this.lblPutAgain.Size = new System.Drawing.Size(77, 12);
            this.lblPutAgain.TabIndex = 53;
            this.lblPutAgain.Text = "NewPassWord:";
            // 
            // txtAgainPut
            // 
            this.txtAgainPut.Location = new System.Drawing.Point(41, 119);
            this.txtAgainPut.Name = "txtAgainPut";
            this.txtAgainPut.PasswordChar = '*';
            this.txtAgainPut.Size = new System.Drawing.Size(151, 21);
            this.txtAgainPut.TabIndex = 46;
            // 
            // frmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 206);
            this.Controls.Add(this.lblPutAgain);
            this.Controls.Add(this.txtAgainPut);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.txtNewPw5);
            this.Controls.Add(this.txtOldPw5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePwd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePwd";
            this.Load += new System.EventHandler(this.frmChangePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.TextBox txtNewPw5;
        private System.Windows.Forms.TextBox txtOldPw5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblPutAgain;
        private System.Windows.Forms.TextBox txtAgainPut;
    }
}
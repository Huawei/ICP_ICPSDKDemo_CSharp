namespace ICPDemo
{
    partial class frmUnifiedLogin
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
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.textBox_ServerIP = new System.Windows.Forms.TextBox();
            this.textBox_Pw5 = new System.Windows.Forms.TextBox();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.label_ServerIP = new System.Windows.Forms.Label();
            this.label_UportalPw5 = new System.Windows.Forms.Label();
            this.label_Account = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ckbPhoneReg = new System.Windows.Forms.CheckBox();
            this.ckbAgentServLogin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(124, 141);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(183, 21);
            this.textBox_PhoneNumber.TabIndex = 3;
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoEllipsis = true;
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Location = new System.Drawing.Point(19, 144);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(83, 12);
            this.label_PhoneNumber.TabIndex = 11;
            this.label_PhoneNumber.Text = "Phone Number:";
            this.label_PhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(64, 247);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(89, 32);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBox_ServerIP
            // 
            this.textBox_ServerIP.Location = new System.Drawing.Point(124, 33);
            this.textBox_ServerIP.Name = "textBox_ServerIP";
            this.textBox_ServerIP.Size = new System.Drawing.Size(183, 21);
            this.textBox_ServerIP.TabIndex = 0;
            // 
            // textBox_Pw5
            // 
            this.textBox_Pw5.Location = new System.Drawing.Point(124, 101);
            this.textBox_Pw5.Name = "textBox_Pw5";
            this.textBox_Pw5.Size = new System.Drawing.Size(183, 21);
            this.textBox_Pw5.TabIndex = 2;
            this.textBox_Pw5.UseSystemPasswordChar = true;
            // 
            // textBox_Account
            // 
            this.textBox_Account.Location = new System.Drawing.Point(124, 68);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.Size = new System.Drawing.Size(183, 21);
            this.textBox_Account.TabIndex = 1;
            // 
            // label_ServerIP
            // 
            this.label_ServerIP.AutoEllipsis = true;
            this.label_ServerIP.Location = new System.Drawing.Point(22, 36);
            this.label_ServerIP.Name = "label_ServerIP";
            this.label_ServerIP.Size = new System.Drawing.Size(80, 12);
            this.label_ServerIP.TabIndex = 8;
            this.label_ServerIP.Text = "Server IP:";
            this.label_ServerIP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_UportalPw5
            // 
            this.label_UportalPw5.AutoEllipsis = true;
            this.label_UportalPw5.Location = new System.Drawing.Point(43, 104);
            this.label_UportalPw5.Name = "label_UportalPw5";
            this.label_UportalPw5.Size = new System.Drawing.Size(59, 12);
            this.label_UportalPw5.TabIndex = 10;
            this.label_UportalPw5.Text = "Password:";
            this.label_UportalPw5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_Account
            // 
            this.label_Account.AutoEllipsis = true;
            this.label_Account.Location = new System.Drawing.Point(49, 71);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(53, 12);
            this.label_Account.TabIndex = 9;
            this.label_Account.Text = "Account:";
            this.label_Account.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ckbPhoneReg
            // 
            this.ckbPhoneReg.AutoSize = true;
            this.ckbPhoneReg.Location = new System.Drawing.Point(24, 179);
            this.ckbPhoneReg.Name = "ckbPhoneReg";
            this.ckbPhoneReg.Size = new System.Drawing.Size(144, 16);
            this.ckbPhoneReg.TabIndex = 4;
            this.ckbPhoneReg.Text = "register inner phone";
            this.ckbPhoneReg.UseVisualStyleBackColor = true;
            // 
            // ckbAgentServLogin
            // 
            this.ckbAgentServLogin.AutoSize = true;
            this.ckbAgentServLogin.Location = new System.Drawing.Point(24, 211);
            this.ckbAgentServLogin.Name = "ckbAgentServLogin";
            this.ckbAgentServLogin.Size = new System.Drawing.Size(132, 16);
            this.ckbAgentServLogin.TabIndex = 5;
            this.ckbAgentServLogin.Text = "login agent server";
            this.ckbAgentServLogin.UseVisualStyleBackColor = true;
            // 
            // frmUnifiedLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 297);
            this.Controls.Add(this.ckbAgentServLogin);
            this.Controls.Add(this.ckbPhoneReg);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_ServerIP);
            this.Controls.Add(this.textBox_Pw5);
            this.Controls.Add(this.textBox_Account);
            this.Controls.Add(this.label_ServerIP);
            this.Controls.Add(this.label_UportalPw5);
            this.Controls.Add(this.label_Account);
            this.Name = "frmUnifiedLogin";
            this.Text = "frmUnifiedLogin";
            this.Load += new System.EventHandler(this.frmUnifiedLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox textBox_ServerIP;
        private System.Windows.Forms.TextBox textBox_Pw5;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.Label label_ServerIP;
        private System.Windows.Forms.Label label_UportalPw5;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckbPhoneReg;
        private System.Windows.Forms.CheckBox ckbAgentServLogin;
    }
}
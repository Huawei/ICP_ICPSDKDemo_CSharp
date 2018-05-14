namespace ICPDemo
{
    partial class frmUportalLogin
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
            this.label_Account = new System.Windows.Forms.Label();
            this.label_UportalPw5 = new System.Windows.Forms.Label();
            this.label_ServerIP = new System.Windows.Forms.Label();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.textBox_Pw5 = new System.Windows.Forms.TextBox();
            this.textBox_ServerIP = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Account
            // 
            this.label_Account.Location = new System.Drawing.Point(40, 30);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(53, 12);
            this.label_Account.TabIndex = 0;
            this.label_Account.Text = "Account:";
            this.label_Account.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_UportalPw5
            // 
            this.label_UportalPw5.Location = new System.Drawing.Point(34, 70);
            this.label_UportalPw5.Name = "label_UportalPw5";
            this.label_UportalPw5.Size = new System.Drawing.Size(59, 12);
            this.label_UportalPw5.TabIndex = 1;
            this.label_UportalPw5.Text = "Password:";
            this.label_UportalPw5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_ServerIP
            // 
            this.label_ServerIP.Location = new System.Drawing.Point(13, 150);
            this.label_ServerIP.Name = "label_ServerIP";
            this.label_ServerIP.Size = new System.Drawing.Size(80, 12);
            this.label_ServerIP.TabIndex = 2;
            this.label_ServerIP.Text = "Server IP:";
            this.label_ServerIP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_Account
            // 
            this.textBox_Account.Location = new System.Drawing.Point(118, 30);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.Size = new System.Drawing.Size(100, 21);
            this.textBox_Account.TabIndex = 3;
            // 
            // textBox_Pw5
            // 
            this.textBox_Pw5.Location = new System.Drawing.Point(118, 67);
            this.textBox_Pw5.Name = "textBox_Pw5";
            this.textBox_Pw5.Size = new System.Drawing.Size(100, 21);
            this.textBox_Pw5.TabIndex = 4;
            this.textBox_Pw5.UseSystemPasswordChar = true;
            // 
            // textBox_ServerIP
            // 
            this.textBox_ServerIP.Location = new System.Drawing.Point(118, 147);
            this.textBox_ServerIP.Name = "textBox_ServerIP";
            this.textBox_ServerIP.Size = new System.Drawing.Size(100, 21);
            this.textBox_ServerIP.TabIndex = 5;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(96, 216);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.Location = new System.Drawing.Point(10, 110);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(83, 12);
            this.label_PhoneNumber.TabIndex = 7;
            this.label_PhoneNumber.Text = "Phone Number:";
            this.label_PhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(118, 107);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_PhoneNumber.TabIndex = 8;
            // 
            // frmUportalLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_ServerIP);
            this.Controls.Add(this.textBox_Pw5);
            this.Controls.Add(this.textBox_Account);
            this.Controls.Add(this.label_ServerIP);
            this.Controls.Add(this.label_UportalPw5);
            this.Controls.Add(this.label_Account);
            this.Name = "frmUportalLogin";
            this.Text = "frmUportalLogin";
            this.Load += new System.EventHandler(this.frmUportalLogin_Loads);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.Label label_UportalPw5;
        private System.Windows.Forms.Label label_ServerIP;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.TextBox textBox_Pw5;
        private System.Windows.Forms.TextBox textBox_ServerIP;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;

    }
}
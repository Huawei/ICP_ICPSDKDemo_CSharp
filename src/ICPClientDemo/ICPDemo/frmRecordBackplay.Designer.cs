namespace ICPDemo
{
    partial class frmRecordBackplay
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
            this.label_Filefolder = new System.Windows.Forms.Label();
            this.textBox_Filefolder = new System.Windows.Forms.TextBox();
            this.label_Recordfile = new System.Windows.Forms.Label();
            this.textBox_Recordfile = new System.Windows.Forms.TextBox();
            this.textBox_Nonce = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.textBox_Addr = new System.Windows.Forms.TextBox();
            this.label_Nonce = new System.Windows.Forms.Label();
            this.label_Addr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Filefolder
            // 
            this.label_Filefolder.Location = new System.Drawing.Point(12, 25);
            this.label_Filefolder.Name = "label_Filefolder";
            this.label_Filefolder.Size = new System.Drawing.Size(94, 18);
            this.label_Filefolder.TabIndex = 0;
            this.label_Filefolder.Text = "Filefolder:";
            this.label_Filefolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_Filefolder
            // 
            this.textBox_Filefolder.Location = new System.Drawing.Point(118, 22);
            this.textBox_Filefolder.Name = "textBox_Filefolder";
            this.textBox_Filefolder.Size = new System.Drawing.Size(182, 21);
            this.textBox_Filefolder.TabIndex = 1;
            // 
            // label_Recordfile
            // 
            this.label_Recordfile.Location = new System.Drawing.Point(14, 54);
            this.label_Recordfile.Name = "label_Recordfile";
            this.label_Recordfile.Size = new System.Drawing.Size(92, 18);
            this.label_Recordfile.TabIndex = 2;
            this.label_Recordfile.Text = "Recordfile:";
            this.label_Recordfile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_Recordfile
            // 
            this.textBox_Recordfile.Location = new System.Drawing.Point(118, 51);
            this.textBox_Recordfile.Name = "textBox_Recordfile";
            this.textBox_Recordfile.Size = new System.Drawing.Size(182, 21);
            this.textBox_Recordfile.TabIndex = 3;
            // 
            // textBox_Nonce
            // 
            this.textBox_Nonce.Location = new System.Drawing.Point(118, 80);
            this.textBox_Nonce.Name = "textBox_Nonce";
            this.textBox_Nonce.Size = new System.Drawing.Size(182, 21);
            this.textBox_Nonce.TabIndex = 5;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(118, 152);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBox_Addr
            // 
            this.textBox_Addr.Location = new System.Drawing.Point(118, 108);
            this.textBox_Addr.Name = "textBox_Addr";
            this.textBox_Addr.Size = new System.Drawing.Size(182, 21);
            this.textBox_Addr.TabIndex = 7;
            // 
            // label_Nonce
            // 
            this.label_Nonce.Location = new System.Drawing.Point(14, 83);
            this.label_Nonce.Name = "label_Nonce";
            this.label_Nonce.Size = new System.Drawing.Size(92, 18);
            this.label_Nonce.TabIndex = 9;
            this.label_Nonce.Text = "Nonce:";
            this.label_Nonce.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_Addr
            // 
            this.label_Addr.Location = new System.Drawing.Point(16, 111);
            this.label_Addr.Name = "label_Addr";
            this.label_Addr.Size = new System.Drawing.Size(90, 18);
            this.label_Addr.TabIndex = 10;
            this.label_Addr.Text = "Server IP:";
            this.label_Addr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmRecordBackplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 183);
            this.Controls.Add(this.label_Addr);
            this.Controls.Add(this.label_Nonce);
            this.Controls.Add(this.textBox_Addr);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_Nonce);
            this.Controls.Add(this.textBox_Recordfile);
            this.Controls.Add(this.label_Recordfile);
            this.Controls.Add(this.textBox_Filefolder);
            this.Controls.Add(this.label_Filefolder);
            this.Name = "frmRecordBackplay";
            this.Text = "frmRecordBackplay";
            this.Load += new System.EventHandler(this.frmRecordBackplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Filefolder;
        private System.Windows.Forms.TextBox textBox_Filefolder;
        private System.Windows.Forms.Label label_Recordfile;
        private System.Windows.Forms.TextBox textBox_Recordfile;
        private System.Windows.Forms.TextBox textBox_Nonce;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox textBox_Addr;
        private System.Windows.Forms.Label label_Nonce;
        private System.Windows.Forms.Label label_Addr;
    }
}
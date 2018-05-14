namespace ICPDemo
{
    partial class frmDeviceIndex
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.textBox_DeviceIndex = new System.Windows.Forms.TextBox();
            this.label_DeviceIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(162, 100);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 26);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(48, 100);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 26);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBox_DeviceIndex
            // 
            this.textBox_DeviceIndex.Location = new System.Drawing.Point(135, 41);
            this.textBox_DeviceIndex.Name = "textBox_DeviceIndex";
            this.textBox_DeviceIndex.Size = new System.Drawing.Size(102, 21);
            this.textBox_DeviceIndex.TabIndex = 8;
            // 
            // label_DeviceIndex
            // 
            this.label_DeviceIndex.Location = new System.Drawing.Point(29, 44);
            this.label_DeviceIndex.Name = "label_DeviceIndex";
            this.label_DeviceIndex.Size = new System.Drawing.Size(100, 12);
            this.label_DeviceIndex.TabIndex = 7;
            this.label_DeviceIndex.Text = "Device Index:";
            this.label_DeviceIndex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmDeviceIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 177);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.textBox_DeviceIndex);
            this.Controls.Add(this.label_DeviceIndex);
            this.Name = "frmDeviceIndex";
            this.Text = "frmDeviceIndex";
            this.Load += new System.EventHandler(this.frmDeviceIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_OK;
        internal System.Windows.Forms.TextBox textBox_DeviceIndex;
        private System.Windows.Forms.Label label_DeviceIndex;
    }
}
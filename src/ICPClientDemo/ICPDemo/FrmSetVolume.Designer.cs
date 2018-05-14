namespace ICPDemo
{
    partial class FrmSetVolume
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
            this.panelDeviceType = new System.Windows.Forms.Panel();
            this.radioButton_Output = new System.Windows.Forms.RadioButton();
            this.radioButton_Input = new System.Windows.Forms.RadioButton();
            this.panelAudioType = new System.Windows.Forms.Panel();
            this.radioButton_MainDevice = new System.Windows.Forms.RadioButton();
            this.radioButton_AidDevice = new System.Windows.Forms.RadioButton();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label_DeviceType = new System.Windows.Forms.Label();
            this.label_Volume = new System.Windows.Forms.Label();
            this.numericUpDown_Volume = new System.Windows.Forms.NumericUpDown();
            this.panelDeviceType.SuspendLayout();
            this.panelAudioType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDeviceType
            // 
            this.panelDeviceType.Controls.Add(this.radioButton_Output);
            this.panelDeviceType.Controls.Add(this.radioButton_Input);
            this.panelDeviceType.Location = new System.Drawing.Point(28, 45);
            this.panelDeviceType.Name = "panelDeviceType";
            this.panelDeviceType.Size = new System.Drawing.Size(270, 46);
            this.panelDeviceType.TabIndex = 20;
            // 
            // radioButton_Output
            // 
            this.radioButton_Output.AutoSize = true;
            this.radioButton_Output.Location = new System.Drawing.Point(148, 17);
            this.radioButton_Output.Name = "radioButton_Output";
            this.radioButton_Output.Size = new System.Drawing.Size(59, 16);
            this.radioButton_Output.TabIndex = 9;
            this.radioButton_Output.Text = "Output";
            this.radioButton_Output.UseVisualStyleBackColor = true;
            // 
            // radioButton_Input
            // 
            this.radioButton_Input.AutoSize = true;
            this.radioButton_Input.Checked = true;
            this.radioButton_Input.Location = new System.Drawing.Point(9, 17);
            this.radioButton_Input.Name = "radioButton_Input";
            this.radioButton_Input.Size = new System.Drawing.Size(53, 16);
            this.radioButton_Input.TabIndex = 8;
            this.radioButton_Input.TabStop = true;
            this.radioButton_Input.Text = "Input";
            this.radioButton_Input.UseVisualStyleBackColor = true;
            // 
            // panelAudioType
            // 
            this.panelAudioType.BackColor = System.Drawing.SystemColors.Control;
            this.panelAudioType.Controls.Add(this.radioButton_MainDevice);
            this.panelAudioType.Controls.Add(this.radioButton_AidDevice);
            this.panelAudioType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAudioType.Location = new System.Drawing.Point(28, 97);
            this.panelAudioType.Name = "panelAudioType";
            this.panelAudioType.Size = new System.Drawing.Size(270, 46);
            this.panelAudioType.TabIndex = 19;
            // 
            // radioButton_MainDevice
            // 
            this.radioButton_MainDevice.AutoSize = true;
            this.radioButton_MainDevice.Checked = true;
            this.radioButton_MainDevice.Location = new System.Drawing.Point(9, 14);
            this.radioButton_MainDevice.Name = "radioButton_MainDevice";
            this.radioButton_MainDevice.Size = new System.Drawing.Size(125, 16);
            this.radioButton_MainDevice.TabIndex = 12;
            this.radioButton_MainDevice.TabStop = true;
            this.radioButton_MainDevice.Text = "Main Audio Device";
            this.radioButton_MainDevice.UseVisualStyleBackColor = true;
            // 
            // radioButton_AidDevice
            // 
            this.radioButton_AidDevice.AutoSize = true;
            this.radioButton_AidDevice.Location = new System.Drawing.Point(148, 14);
            this.radioButton_AidDevice.Name = "radioButton_AidDevice";
            this.radioButton_AidDevice.Size = new System.Drawing.Size(119, 16);
            this.radioButton_AidDevice.TabIndex = 13;
            this.radioButton_AidDevice.Text = "Aid Audio Device";
            this.radioButton_AidDevice.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(176, 204);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(81, 21);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(37, 204);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(81, 21);
            this.btn_OK.TabIndex = 17;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label_DeviceType
            // 
            this.label_DeviceType.Location = new System.Drawing.Point(26, 30);
            this.label_DeviceType.Name = "label_DeviceType";
            this.label_DeviceType.Size = new System.Drawing.Size(80, 12);
            this.label_DeviceType.TabIndex = 16;
            this.label_DeviceType.Text = "Device Type:";
            this.label_DeviceType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_Volume
            // 
            this.label_Volume.Location = new System.Drawing.Point(3, 165);
            this.label_Volume.Name = "label_Volume";
            this.label_Volume.Size = new System.Drawing.Size(80, 12);
            this.label_Volume.TabIndex = 22;
            this.label_Volume.Text = "Volume:";
            this.label_Volume.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericUpDown_Volume
            // 
            this.numericUpDown_Volume.Location = new System.Drawing.Point(89, 163);
            this.numericUpDown_Volume.Name = "numericUpDown_Volume";
            this.numericUpDown_Volume.Size = new System.Drawing.Size(101, 21);
            this.numericUpDown_Volume.TabIndex = 21;
            // 
            // FrmSetVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 262);
            this.Controls.Add(this.label_Volume);
            this.Controls.Add(this.numericUpDown_Volume);
            this.Controls.Add(this.panelDeviceType);
            this.Controls.Add(this.panelAudioType);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label_DeviceType);
            this.Name = "FrmSetVolume";
            this.Text = "FrmSetVolume";
            this.Load += new System.EventHandler(this.frmSetVolume_Load);
            this.panelDeviceType.ResumeLayout(false);
            this.panelDeviceType.PerformLayout();
            this.panelAudioType.ResumeLayout(false);
            this.panelAudioType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDeviceType;
        internal System.Windows.Forms.RadioButton radioButton_Output;
        internal System.Windows.Forms.RadioButton radioButton_Input;
        private System.Windows.Forms.Panel panelAudioType;
        internal System.Windows.Forms.RadioButton radioButton_MainDevice;
        internal System.Windows.Forms.RadioButton radioButton_AidDevice;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label_DeviceType;
        private System.Windows.Forms.Label label_Volume;
        internal System.Windows.Forms.NumericUpDown numericUpDown_Volume;
    }
}
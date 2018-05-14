namespace ICPDemo
{
    partial class frmGetSoundDevice
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
            this.label_DeviceType = new System.Windows.Forms.Label();
            this.radioButton_Input = new System.Windows.Forms.RadioButton();
            this.radioButton_Output = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_DeviceType
            // 
            this.label_DeviceType.Location = new System.Drawing.Point(9, 32);
            this.label_DeviceType.Name = "label_DeviceType";
            this.label_DeviceType.Size = new System.Drawing.Size(80, 12);
            this.label_DeviceType.TabIndex = 0;
            this.label_DeviceType.Text = "Device Type:";
            this.label_DeviceType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioButton_Input
            // 
            this.radioButton_Input.AutoSize = true;
            this.radioButton_Input.Checked = true;
            this.radioButton_Input.Location = new System.Drawing.Point(14, 61);
            this.radioButton_Input.Name = "radioButton_Input";
            this.radioButton_Input.Size = new System.Drawing.Size(53, 16);
            this.radioButton_Input.TabIndex = 1;
            this.radioButton_Input.TabStop = true;
            this.radioButton_Input.Text = "Input";
            this.radioButton_Input.UseVisualStyleBackColor = true;
            // 
            // radioButton_Output
            // 
            this.radioButton_Output.AutoSize = true;
            this.radioButton_Output.Location = new System.Drawing.Point(135, 61);
            this.radioButton_Output.Name = "radioButton_Output";
            this.radioButton_Output.Size = new System.Drawing.Size(59, 16);
            this.radioButton_Output.TabIndex = 2;
            this.radioButton_Output.Text = "Output";
            this.radioButton_Output.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(8, 113);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(81, 21);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(135, 113);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(81, 21);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmGetSoundDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 155);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.radioButton_Output);
            this.Controls.Add(this.radioButton_Input);
            this.Controls.Add(this.label_DeviceType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGetSoundDevice";
            this.Text = "Get Sound Device";
            this.Load += new System.EventHandler(this.frmGetSoundDevice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DeviceType;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.RadioButton radioButton_Input;
        internal System.Windows.Forms.RadioButton radioButton_Output;
    }
}
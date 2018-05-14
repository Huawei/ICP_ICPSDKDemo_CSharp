namespace ICPDemo
{
    partial class frmVolume
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
            this.numericUpDown_Volume = new System.Windows.Forms.NumericUpDown();
            this.label_Volume = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DeviceType
            // 
            this.label_DeviceType.Location = new System.Drawing.Point(5, 34);
            this.label_DeviceType.Name = "label_DeviceType";
            this.label_DeviceType.Size = new System.Drawing.Size(100, 12);
            this.label_DeviceType.TabIndex = 0;
            this.label_DeviceType.Text = "Device Type:";
            this.label_DeviceType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioButton_Input
            // 
            this.radioButton_Input.AutoSize = true;
            this.radioButton_Input.Checked = true;
            this.radioButton_Input.Location = new System.Drawing.Point(30, 74);
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
            this.radioButton_Output.Location = new System.Drawing.Point(139, 74);
            this.radioButton_Output.Name = "radioButton_Output";
            this.radioButton_Output.Size = new System.Drawing.Size(59, 16);
            this.radioButton_Output.TabIndex = 2;
            this.radioButton_Output.Text = "Output";
            this.radioButton_Output.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Volume
            // 
            this.numericUpDown_Volume.Location = new System.Drawing.Point(81, 119);
            this.numericUpDown_Volume.Name = "numericUpDown_Volume";
            this.numericUpDown_Volume.Size = new System.Drawing.Size(117, 21);
            this.numericUpDown_Volume.TabIndex = 3;
            // 
            // label_Volume
            // 
            this.label_Volume.Location = new System.Drawing.Point(-5, 121);
            this.label_Volume.Name = "label_Volume";
            this.label_Volume.Size = new System.Drawing.Size(80, 12);
            this.label_Volume.TabIndex = 4;
            this.label_Volume.Text = "Volume:";
            this.label_Volume.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(30, 164);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 26);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(123, 164);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 26);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 212);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label_Volume);
            this.Controls.Add(this.numericUpDown_Volume);
            this.Controls.Add(this.radioButton_Output);
            this.Controls.Add(this.radioButton_Input);
            this.Controls.Add(this.label_DeviceType);
            this.Name = "frmVolume";
            this.Text = "frmVolume";
            this.Load += new System.EventHandler(this.frmVolume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DeviceType;
        private System.Windows.Forms.RadioButton radioButton_Input;
        private System.Windows.Forms.RadioButton radioButton_Output;
        internal System.Windows.Forms.NumericUpDown numericUpDown_Volume;
        private System.Windows.Forms.Label label_Volume;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
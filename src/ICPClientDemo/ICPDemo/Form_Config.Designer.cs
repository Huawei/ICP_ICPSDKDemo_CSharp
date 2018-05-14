namespace ICPDemo
{
    partial class Form_Config
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
            this.textBox_ConfigKey = new System.Windows.Forms.TextBox();
            this.label_ConfigKey = new System.Windows.Forms.Label();
            this.label_ConfigValue = new System.Windows.Forms.Label();
            this.textBox_ConfigValue = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ConfigKey
            // 
            this.textBox_ConfigKey.Location = new System.Drawing.Point(115, 34);
            this.textBox_ConfigKey.Name = "textBox_ConfigKey";
            this.textBox_ConfigKey.Size = new System.Drawing.Size(141, 21);
            this.textBox_ConfigKey.TabIndex = 0;
            // 
            // label_ConfigKey
            // 
            this.label_ConfigKey.Location = new System.Drawing.Point(38, 37);
            this.label_ConfigKey.Name = "label_ConfigKey";
            this.label_ConfigKey.Size = new System.Drawing.Size(71, 12);
            this.label_ConfigKey.TabIndex = 1;
            this.label_ConfigKey.Text = "Config Key:";
            this.label_ConfigKey.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_ConfigValue
            // 
            this.label_ConfigValue.Location = new System.Drawing.Point(26, 90);
            this.label_ConfigValue.Name = "label_ConfigValue";
            this.label_ConfigValue.Size = new System.Drawing.Size(83, 12);
            this.label_ConfigValue.TabIndex = 3;
            this.label_ConfigValue.Text = "Config Value:";
            this.label_ConfigValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_ConfigValue
            // 
            this.textBox_ConfigValue.Location = new System.Drawing.Point(115, 87);
            this.textBox_ConfigValue.Name = "textBox_ConfigValue";
            this.textBox_ConfigValue.Size = new System.Drawing.Size(141, 21);
            this.textBox_ConfigValue.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(40, 165);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(181, 165);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label_ConfigValue);
            this.Controls.Add(this.textBox_ConfigValue);
            this.Controls.Add(this.label_ConfigKey);
            this.Controls.Add(this.textBox_ConfigKey);
            this.Name = "Form_Config";
            this.Text = "Form_Config";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ConfigKey;
        private System.Windows.Forms.Label label_ConfigKey;
        private System.Windows.Forms.Label label_ConfigValue;
        private System.Windows.Forms.TextBox textBox_ConfigValue;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
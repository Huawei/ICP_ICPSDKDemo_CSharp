namespace ICPDemo
{
    partial class frmSuperviseSwitch
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
            this.combSupervise = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combSupervise
            // 
            this.combSupervise.FormattingEnabled = true;
            this.combSupervise.Location = new System.Drawing.Point(92, 23);
            this.combSupervise.Name = "combSupervise";
            this.combSupervise.Size = new System.Drawing.Size(138, 20);
            this.combSupervise.TabIndex = 0;
            this.combSupervise.SelectedIndexChanged += new System.EventHandler(this.combSupervise_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(47, 73);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 24);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(4, 26);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(82, 12);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "类型:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 24);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Canncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSuperviseSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.combSupervise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuperviseSwitch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuperviseSwitch";
            this.Load += new System.EventHandler(this.frmSuperviseSwitch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combSupervise;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnCancel;
    }
}
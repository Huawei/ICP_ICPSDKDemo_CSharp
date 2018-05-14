namespace ICPDemo
{
    partial class frmDial
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
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblCallType = new System.Windows.Forms.Label();
            this.cboCallType = new System.Windows.Forms.ComboBox();
            this.lblWirelessType = new System.Windows.Forms.Label();
            this.cboWirelessType = new System.Windows.Forms.ComboBox();
            this.labAccessCode = new System.Windows.Forms.Label();
            this.txtAccessCode = new System.Windows.Forms.TextBox();
            this.lblMediaAbility = new System.Windows.Forms.Label();
            this.cmbMediaAbility = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(126, 12);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(147, 21);
            this.textPhoneNumber.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 15);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(111, 12);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(183, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(62, 163);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblCallType
            // 
            this.lblCallType.Location = new System.Drawing.Point(3, 74);
            this.lblCallType.Name = "lblCallType";
            this.lblCallType.Size = new System.Drawing.Size(120, 12);
            this.lblCallType.TabIndex = 2;
            this.lblCallType.Text = "Call Type:";
            this.lblCallType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboCallType
            // 
            this.cboCallType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCallType.FormattingEnabled = true;
            this.cboCallType.Items.AddRange(new object[] {
            "Normal",
            "Wireless Group",
            "Wireless P2P"});
            this.cboCallType.Location = new System.Drawing.Point(126, 72);
            this.cboCallType.Name = "cboCallType";
            this.cboCallType.Size = new System.Drawing.Size(147, 20);
            this.cboCallType.TabIndex = 3;
            this.cboCallType.SelectedIndexChanged += new System.EventHandler(this.cboCallType_SelectedIndexChanged);
            // 
            // lblWirelessType
            // 
            this.lblWirelessType.Location = new System.Drawing.Point(-1, 105);
            this.lblWirelessType.Name = "lblWirelessType";
            this.lblWirelessType.Size = new System.Drawing.Size(124, 12);
            this.lblWirelessType.TabIndex = 4;
            this.lblWirelessType.Text = "Wireless Type:";
            this.lblWirelessType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboWirelessType
            // 
            this.cboWirelessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWirelessType.FormattingEnabled = true;
            this.cboWirelessType.Items.AddRange(new object[] {
            "SW",
            "Digital",
            "Analog",
            "LTE"});
            this.cboWirelessType.Location = new System.Drawing.Point(126, 102);
            this.cboWirelessType.Name = "cboWirelessType";
            this.cboWirelessType.Size = new System.Drawing.Size(147, 20);
            this.cboWirelessType.TabIndex = 5;
            // 
            // labAccessCode
            // 
            this.labAccessCode.Location = new System.Drawing.Point(13, 135);
            this.labAccessCode.Name = "labAccessCode";
            this.labAccessCode.Size = new System.Drawing.Size(110, 12);
            this.labAccessCode.TabIndex = 8;
            this.labAccessCode.Text = "AccessCode:";
            this.labAccessCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labAccessCode.Visible = false;
            // 
            // txtAccessCode
            // 
            this.txtAccessCode.Location = new System.Drawing.Point(126, 132);
            this.txtAccessCode.Name = "txtAccessCode";
            this.txtAccessCode.Size = new System.Drawing.Size(147, 21);
            this.txtAccessCode.TabIndex = 9;
            this.txtAccessCode.Visible = false;
            // 
            // lblMediaAbility
            // 
            this.lblMediaAbility.Location = new System.Drawing.Point(-1, 47);
            this.lblMediaAbility.Name = "lblMediaAbility";
            this.lblMediaAbility.Size = new System.Drawing.Size(120, 12);
            this.lblMediaAbility.TabIndex = 2;
            this.lblMediaAbility.Text = "Media Ability:";
            this.lblMediaAbility.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbMediaAbility
            // 
            this.cmbMediaAbility.DisplayMember = "Default";
            this.cmbMediaAbility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMediaAbility.Enabled = false;
            this.cmbMediaAbility.FormattingEnabled = true;
            this.cmbMediaAbility.Items.AddRange(new object[] {
            "Audio",
            "Video",
            "Default"});
            this.cmbMediaAbility.Location = new System.Drawing.Point(126, 43);
            this.cmbMediaAbility.Name = "cmbMediaAbility";
            this.cmbMediaAbility.Size = new System.Drawing.Size(147, 20);
            this.cmbMediaAbility.TabIndex = 10;
            // 
            // frmDial
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(322, 202);
            this.Controls.Add(this.cmbMediaAbility);
            this.Controls.Add(this.txtAccessCode);
            this.Controls.Add(this.labAccessCode);
            this.Controls.Add(this.cboWirelessType);
            this.Controls.Add(this.lblWirelessType);
            this.Controls.Add(this.cboCallType);
            this.Controls.Add(this.lblMediaAbility);
            this.Controls.Add(this.lblCallType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDial";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dial";
            this.Load += new System.EventHandler(this.frmDial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblCallType;
        private System.Windows.Forms.ComboBox cboCallType;
        private System.Windows.Forms.Label lblWirelessType;
        private System.Windows.Forms.ComboBox cboWirelessType;
        private System.Windows.Forms.Label labAccessCode;
        private System.Windows.Forms.TextBox txtAccessCode;
        private System.Windows.Forms.Label lblMediaAbility;
        private System.Windows.Forms.ComboBox cmbMediaAbility;
    }
}
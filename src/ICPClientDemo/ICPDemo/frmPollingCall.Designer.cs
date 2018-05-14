namespace ICPDemo
{
    partial class frmPollingCall
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
            this.cboWirelessType = new System.Windows.Forms.ComboBox();
            this.lblWirelessType = new System.Windows.Forms.Label();
            this.cboCallType = new System.Windows.Forms.ComboBox();
            this.lblCallType = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.listBoxCall = new System.Windows.Forms.ListBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.labAccessCode = new System.Windows.Forms.Label();
            this.txtAccessCode = new System.Windows.Forms.TextBox();
            this.lblMediaAbility = new System.Windows.Forms.Label();
            this.cmbMediaAbility = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cboWirelessType.Location = new System.Drawing.Point(114, 99);
            this.cboWirelessType.Name = "cboWirelessType";
            this.cboWirelessType.Size = new System.Drawing.Size(130, 20);
            this.cboWirelessType.TabIndex = 11;
            // 
            // lblWirelessType
            // 
            this.lblWirelessType.Location = new System.Drawing.Point(6, 102);
            this.lblWirelessType.Name = "lblWirelessType";
            this.lblWirelessType.Size = new System.Drawing.Size(106, 12);
            this.lblWirelessType.TabIndex = 10;
            this.lblWirelessType.Text = "Wireless Type:";
            this.lblWirelessType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboCallType
            // 
            this.cboCallType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCallType.FormattingEnabled = true;
            this.cboCallType.Items.AddRange(new object[] {
            "Normal",
            "Wireless Group",
            "Wireless P2P"});
            this.cboCallType.Location = new System.Drawing.Point(114, 71);
            this.cboCallType.Name = "cboCallType";
            this.cboCallType.Size = new System.Drawing.Size(130, 20);
            this.cboCallType.TabIndex = 9;
            // 
            // lblCallType
            // 
            this.lblCallType.Location = new System.Drawing.Point(14, 74);
            this.lblCallType.Name = "lblCallType";
            this.lblCallType.Size = new System.Drawing.Size(98, 12);
            this.lblCallType.TabIndex = 8;
            this.lblCallType.Text = "Call Type:";
            this.lblCallType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(114, 12);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(130, 21);
            this.textPhoneNumber.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 15);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(100, 12);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone Number:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(71, 282);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(114, 225);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(130, 21);
            this.txtTimeOut.TabIndex = 14;
            // 
            // lblTimeout
            // 
            this.lblTimeout.Location = new System.Drawing.Point(12, 228);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(100, 12);
            this.lblTimeout.TabIndex = 15;
            this.lblTimeout.Text = "timeout:";
            this.lblTimeout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listBoxCall
            // 
            this.listBoxCall.FormattingEnabled = true;
            this.listBoxCall.ItemHeight = 12;
            this.listBoxCall.Location = new System.Drawing.Point(114, 155);
            this.listBoxCall.Name = "listBoxCall";
            this.listBoxCall.Size = new System.Drawing.Size(130, 64);
            this.listBoxCall.TabIndex = 16;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(182, 125);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(62, 23);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // labAccessCode
            // 
            this.labAccessCode.Location = new System.Drawing.Point(0, 252);
            this.labAccessCode.Name = "labAccessCode";
            this.labAccessCode.Size = new System.Drawing.Size(112, 12);
            this.labAccessCode.TabIndex = 18;
            this.labAccessCode.Text = "AccessCode:";
            this.labAccessCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labAccessCode.Visible = false;
            // 
            // txtAccessCode
            // 
            this.txtAccessCode.Location = new System.Drawing.Point(114, 249);
            this.txtAccessCode.Name = "txtAccessCode";
            this.txtAccessCode.Size = new System.Drawing.Size(130, 21);
            this.txtAccessCode.TabIndex = 19;
            this.txtAccessCode.Visible = false;
            // 
            // lblMediaAbility
            // 
            this.lblMediaAbility.Location = new System.Drawing.Point(14, 47);
            this.lblMediaAbility.Name = "lblMediaAbility";
            this.lblMediaAbility.Size = new System.Drawing.Size(98, 12);
            this.lblMediaAbility.TabIndex = 8;
            this.lblMediaAbility.Text = "Media Ability:";
            this.lblMediaAbility.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbMediaAbility
            // 
            this.cmbMediaAbility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMediaAbility.FormattingEnabled = true;
            this.cmbMediaAbility.Items.AddRange(new object[] {
            "Audio",
            "Video",
            "Default"});
            this.cmbMediaAbility.Location = new System.Drawing.Point(114, 44);
            this.cmbMediaAbility.Name = "cmbMediaAbility";
            this.cmbMediaAbility.Size = new System.Drawing.Size(130, 20);
            this.cmbMediaAbility.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPollingCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAccessCode);
            this.Controls.Add(this.labAccessCode);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.listBoxCall);
            this.Controls.Add(this.lblTimeout);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboWirelessType);
            this.Controls.Add(this.lblWirelessType);
            this.Controls.Add(this.cmbMediaAbility);
            this.Controls.Add(this.cboCallType);
            this.Controls.Add(this.lblMediaAbility);
            this.Controls.Add(this.lblCallType);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Name = "frmPollingCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPollingCall";
            this.Load += new System.EventHandler(this.frmPollingCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboWirelessType;
        private System.Windows.Forms.Label lblWirelessType;
        private System.Windows.Forms.ComboBox cboCallType;
        private System.Windows.Forms.Label lblCallType;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.ListBox listBoxCall;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label labAccessCode;
        private System.Windows.Forms.TextBox txtAccessCode;
        private System.Windows.Forms.Label lblMediaAbility;
        private System.Windows.Forms.ComboBox cmbMediaAbility;
        private System.Windows.Forms.Button btnCancel;
    }
}
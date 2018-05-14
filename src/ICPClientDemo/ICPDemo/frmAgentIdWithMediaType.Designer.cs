namespace ICPDemo
{
    partial class frmAgentIdWithMediaType
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
            this.tbAgentId = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbMediaAbility = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbAgentId = new System.Windows.Forms.Label();
            this.lbMediaAbility = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAgentId
            // 
            this.tbAgentId.Location = new System.Drawing.Point(109, 34);
            this.tbAgentId.Name = "tbAgentId";
            this.tbAgentId.Size = new System.Drawing.Size(136, 20);
            this.tbAgentId.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(109, 70);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(136, 20);
            this.tbPhoneNumber.TabIndex = 4;
            // 
            // tbMediaAbility
            // 
            this.tbMediaAbility.Location = new System.Drawing.Point(109, 107);
            this.tbMediaAbility.Name = "tbMediaAbility";
            this.tbMediaAbility.Size = new System.Drawing.Size(136, 20);
            this.tbMediaAbility.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(38, 162);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(170, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.Location = new System.Drawing.Point(5, 73);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(96, 13);
            this.lbPhoneNumber.TabIndex = 8;
            this.lbPhoneNumber.Text = "Phone Number:";
            this.lbPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbAgentId
            // 
            this.lbAgentId.Location = new System.Drawing.Point(9, 37);
            this.lbAgentId.Name = "lbAgentId";
            this.lbAgentId.Size = new System.Drawing.Size(92, 13);
            this.lbAgentId.TabIndex = 10;
            this.lbAgentId.Text = "Agent ID:";
            this.lbAgentId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbMediaAbility
            // 
            this.lbMediaAbility.Location = new System.Drawing.Point(9, 110);
            this.lbMediaAbility.Name = "lbMediaAbility";
            this.lbMediaAbility.Size = new System.Drawing.Size(92, 13);
            this.lbMediaAbility.TabIndex = 11;
            this.lbMediaAbility.Text = "Media Ability:";
            this.lbMediaAbility.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmAgentIdWithMediaType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.lbMediaAbility);
            this.Controls.Add(this.lbAgentId);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbMediaAbility);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbAgentId);
            this.Name = "frmAgentIdWithMediaType";
            this.Text = "frmAgentIdWithMediaType";
            this.Load += new System.EventHandler(this.frmAgentIdWithMediaType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAgentId;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbMediaAbility;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbAgentId;
        private System.Windows.Forms.Label lbMediaAbility;
    }
}
namespace ICPDemo
{
    partial class FrmQueryCallList
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
            this.btnOK = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.lblCallId = new System.Windows.Forms.Label();
            this.lstCall = new System.Windows.Forms.ListBox();
            this.btnDisconnectCall = new System.Windows.Forms.Button();
            this.btnStopQuery = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCallID = new System.Windows.Forms.TextBox();
            this.lCallId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(243, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(96, 12);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(130, 21);
            this.textId.TabIndex = 13;
            // 
            // lblCallId
            // 
            this.lblCallId.Location = new System.Drawing.Point(0, 15);
            this.lblCallId.Name = "lblCallId";
            this.lblCallId.Size = new System.Drawing.Size(90, 12);
            this.lblCallId.TabIndex = 12;
            this.lblCallId.Text = "CallId:";
            this.lblCallId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstCall
            // 
            this.lstCall.FormattingEnabled = true;
            this.lstCall.ItemHeight = 12;
            this.lstCall.Location = new System.Drawing.Point(27, 55);
            this.lstCall.Name = "lstCall";
            this.lstCall.Size = new System.Drawing.Size(199, 208);
            this.lstCall.TabIndex = 15;
            // 
            // btnDisconnectCall
            // 
            this.btnDisconnectCall.Location = new System.Drawing.Point(243, 55);
            this.btnDisconnectCall.Name = "btnDisconnectCall";
            this.btnDisconnectCall.Size = new System.Drawing.Size(113, 23);
            this.btnDisconnectCall.TabIndex = 16;
            this.btnDisconnectCall.Text = "DisconnectCall";
            this.btnDisconnectCall.UseVisualStyleBackColor = true;
            this.btnDisconnectCall.Click += new System.EventHandler(this.btnDisconnectCall_Click);
            // 
            // btnStopQuery
            // 
            this.btnStopQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStopQuery.Location = new System.Drawing.Point(243, 107);
            this.btnStopQuery.Name = "btnStopQuery";
            this.btnStopQuery.Size = new System.Drawing.Size(113, 23);
            this.btnStopQuery.TabIndex = 17;
            this.btnStopQuery.Text = "StopQuery";
            this.btnStopQuery.UseVisualStyleBackColor = true;
            this.btnStopQuery.Click += new System.EventHandler(this.btnStopQuery_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "DisconnectCall";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCallID
            // 
            this.txtCallID.Location = new System.Drawing.Point(96, 288);
            this.txtCallID.Name = "txtCallID";
            this.txtCallID.Size = new System.Drawing.Size(130, 21);
            this.txtCallID.TabIndex = 22;
            // 
            // lCallId
            // 
            this.lCallId.Location = new System.Drawing.Point(2, 291);
            this.lCallId.Name = "lCallId";
            this.lCallId.Size = new System.Drawing.Size(88, 12);
            this.lCallId.TabIndex = 21;
            this.lCallId.Text = "CallId:";
            this.lCallId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmQueryCallList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCallID);
            this.Controls.Add(this.lCallId);
            this.Controls.Add(this.btnStopQuery);
            this.Controls.Add(this.btnDisconnectCall);
            this.Controls.Add(this.lstCall);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.lblCallId);
            this.MaximumSize = new System.Drawing.Size(379, 359);
            this.MinimumSize = new System.Drawing.Size(379, 359);
            this.Name = "FrmQueryCallList";
            this.Text = "FrmQueryCallList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label lblCallId;
        private System.Windows.Forms.ListBox lstCall;
        private System.Windows.Forms.Button btnDisconnectCall;
        private System.Windows.Forms.Button btnStopQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCallID;
        private System.Windows.Forms.Label lCallId;
    }
}
namespace ICPDemo
{
    partial class frmMultiMediaChatForTest
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
            this.rtbChatContent = new System.Windows.Forms.RichTextBox();
            this.rtbSendContent = new System.Windows.Forms.RichTextBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.tbLocalPath = new System.Windows.Forms.TextBox();
            this.tbRemotePath = new System.Windows.Forms.TextBox();
            this.lbLocalPath = new System.Windows.Forms.Label();
            this.lbRemotePath = new System.Windows.Forms.Label();
            this.btnReceiveFile = new System.Windows.Forms.Button();
            this.lbTargetAgentId = new System.Windows.Forms.Label();
            this.tbTargetAgentId = new System.Windows.Forms.TextBox();
            this.cbxNeedConfirm = new System.Windows.Forms.CheckBox();
            this.btnSendMediaContent = new System.Windows.Forms.Button();
            this.rtbEventContent = new System.Windows.Forms.RichTextBox();
            this.tbFileMediaType = new System.Windows.Forms.TextBox();
            this.lbFileMediaType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCallId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbChatContent
            // 
            this.rtbChatContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbChatContent.BackColor = System.Drawing.Color.White;
            this.rtbChatContent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbChatContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChatContent.Location = new System.Drawing.Point(12, 17);
            this.rtbChatContent.Name = "rtbChatContent";
            this.rtbChatContent.ReadOnly = true;
            this.rtbChatContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbChatContent.Size = new System.Drawing.Size(597, 190);
            this.rtbChatContent.TabIndex = 0;
            this.rtbChatContent.Text = "";
            this.rtbChatContent.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtbChatContent_ContentsResized);
            // 
            // rtbSendContent
            // 
            this.rtbSendContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSendContent.Location = new System.Drawing.Point(12, 216);
            this.rtbSendContent.Name = "rtbSendContent";
            this.rtbSendContent.Size = new System.Drawing.Size(597, 77);
            this.rtbSendContent.TabIndex = 1;
            this.rtbSendContent.Text = "";
            // 
            // btnSendFile
            // 
            this.btnSendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendFile.Location = new System.Drawing.Point(519, 331);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(90, 26);
            this.btnSendFile.TabIndex = 2;
            this.btnSendFile.Text = "SendFile";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.Location = new System.Drawing.Point(518, 390);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(91, 25);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // tbLocalPath
            // 
            this.tbLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLocalPath.Location = new System.Drawing.Point(106, 333);
            this.tbLocalPath.Name = "tbLocalPath";
            this.tbLocalPath.Size = new System.Drawing.Size(245, 20);
            this.tbLocalPath.TabIndex = 4;
            // 
            // tbRemotePath
            // 
            this.tbRemotePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbRemotePath.Location = new System.Drawing.Point(106, 364);
            this.tbRemotePath.Name = "tbRemotePath";
            this.tbRemotePath.Size = new System.Drawing.Size(404, 20);
            this.tbRemotePath.TabIndex = 5;
            // 
            // lbLocalPath
            // 
            this.lbLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbLocalPath.AutoSize = true;
            this.lbLocalPath.Location = new System.Drawing.Point(16, 338);
            this.lbLocalPath.Name = "lbLocalPath";
            this.lbLocalPath.Size = new System.Drawing.Size(55, 13);
            this.lbLocalPath.TabIndex = 6;
            this.lbLocalPath.Text = "LocalPath";
            // 
            // lbRemotePath
            // 
            this.lbRemotePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRemotePath.AutoSize = true;
            this.lbRemotePath.Location = new System.Drawing.Point(16, 369);
            this.lbRemotePath.Name = "lbRemotePath";
            this.lbRemotePath.Size = new System.Drawing.Size(66, 13);
            this.lbRemotePath.TabIndex = 7;
            this.lbRemotePath.Text = "RemotePath";
            // 
            // btnReceiveFile
            // 
            this.btnReceiveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceiveFile.Location = new System.Drawing.Point(519, 361);
            this.btnReceiveFile.Name = "btnReceiveFile";
            this.btnReceiveFile.Size = new System.Drawing.Size(90, 26);
            this.btnReceiveFile.TabIndex = 8;
            this.btnReceiveFile.Text = "ReceiveFile";
            this.btnReceiveFile.UseVisualStyleBackColor = true;
            this.btnReceiveFile.Click += new System.EventHandler(this.btnReceiveFile_Click);
            // 
            // lbTargetAgentId
            // 
            this.lbTargetAgentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTargetAgentId.AutoSize = true;
            this.lbTargetAgentId.Location = new System.Drawing.Point(15, 398);
            this.lbTargetAgentId.Name = "lbTargetAgentId";
            this.lbTargetAgentId.Size = new System.Drawing.Size(75, 13);
            this.lbTargetAgentId.TabIndex = 10;
            this.lbTargetAgentId.Text = "TargetAgentId";
            // 
            // tbTargetAgentId
            // 
            this.tbTargetAgentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbTargetAgentId.Location = new System.Drawing.Point(106, 393);
            this.tbTargetAgentId.Name = "tbTargetAgentId";
            this.tbTargetAgentId.Size = new System.Drawing.Size(404, 20);
            this.tbTargetAgentId.TabIndex = 9;
            // 
            // cbxNeedConfirm
            // 
            this.cbxNeedConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNeedConfirm.AutoSize = true;
            this.cbxNeedConfirm.Location = new System.Drawing.Point(417, 302);
            this.cbxNeedConfirm.Name = "cbxNeedConfirm";
            this.cbxNeedConfirm.Size = new System.Drawing.Size(87, 17);
            this.cbxNeedConfirm.TabIndex = 12;
            this.cbxNeedConfirm.Text = "NeedConfirm";
            this.cbxNeedConfirm.UseVisualStyleBackColor = true;
            // 
            // btnSendMediaContent
            // 
            this.btnSendMediaContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMediaContent.Location = new System.Drawing.Point(526, 299);
            this.btnSendMediaContent.Name = "btnSendMediaContent";
            this.btnSendMediaContent.Size = new System.Drawing.Size(83, 24);
            this.btnSendMediaContent.TabIndex = 11;
            this.btnSendMediaContent.Text = "Send";
            this.btnSendMediaContent.UseVisualStyleBackColor = true;
            this.btnSendMediaContent.Click += new System.EventHandler(this.btnSendMediaContent_Click);
            // 
            // rtbEventContent
            // 
            this.rtbEventContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbEventContent.Location = new System.Drawing.Point(13, 424);
            this.rtbEventContent.Name = "rtbEventContent";
            this.rtbEventContent.Size = new System.Drawing.Size(592, 103);
            this.rtbEventContent.TabIndex = 13;
            this.rtbEventContent.Text = "";
            this.rtbEventContent.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtbEventContent_ContentsResized);
            // 
            // tbFileMediaType
            // 
            this.tbFileMediaType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFileMediaType.Location = new System.Drawing.Point(445, 333);
            this.tbFileMediaType.Name = "tbFileMediaType";
            this.tbFileMediaType.Size = new System.Drawing.Size(64, 20);
            this.tbFileMediaType.TabIndex = 14;
            // 
            // lbFileMediaType
            // 
            this.lbFileMediaType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbFileMediaType.AutoSize = true;
            this.lbFileMediaType.Location = new System.Drawing.Point(357, 338);
            this.lbFileMediaType.Name = "lbFileMediaType";
            this.lbFileMediaType.Size = new System.Drawing.Size(76, 13);
            this.lbFileMediaType.TabIndex = 15;
            this.lbFileMediaType.Text = "FileMediaType";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "CallId";
            // 
            // tbCallId
            // 
            this.tbCallId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCallId.Location = new System.Drawing.Point(253, 299);
            this.tbCallId.Name = "tbCallId";
            this.tbCallId.Size = new System.Drawing.Size(98, 20);
            this.tbCallId.TabIndex = 17;
            // 
            // frmMultiMediaChatForTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 536);
            this.Controls.Add(this.tbCallId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbFileMediaType);
            this.Controls.Add(this.tbFileMediaType);
            this.Controls.Add(this.rtbEventContent);
            this.Controls.Add(this.cbxNeedConfirm);
            this.Controls.Add(this.btnSendMediaContent);
            this.Controls.Add(this.lbTargetAgentId);
            this.Controls.Add(this.tbTargetAgentId);
            this.Controls.Add(this.btnReceiveFile);
            this.Controls.Add(this.lbRemotePath);
            this.Controls.Add(this.lbLocalPath);
            this.Controls.Add(this.tbRemotePath);
            this.Controls.Add(this.tbLocalPath);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.rtbSendContent);
            this.Controls.Add(this.rtbChatContent);
            this.Name = "frmMultiMediaChatForTest";
            this.Text = "frmMultiMedaChatForTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMultiMediaChatForTest_FormClosed);
            this.Load += new System.EventHandler(this.frmMultiMedaChatForTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbChatContent;
        private System.Windows.Forms.RichTextBox rtbSendContent;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox tbLocalPath;
        private System.Windows.Forms.TextBox tbRemotePath;
        private System.Windows.Forms.Label lbLocalPath;
        private System.Windows.Forms.Label lbRemotePath;
        private System.Windows.Forms.Button btnReceiveFile;
        private System.Windows.Forms.Label lbTargetAgentId;
        private System.Windows.Forms.TextBox tbTargetAgentId;
        private System.Windows.Forms.CheckBox cbxNeedConfirm;
        private System.Windows.Forms.Button btnSendMediaContent;
        private System.Windows.Forms.RichTextBox rtbEventContent;
        private System.Windows.Forms.TextBox tbFileMediaType;
        private System.Windows.Forms.Label lbFileMediaType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCallId;
    }
}
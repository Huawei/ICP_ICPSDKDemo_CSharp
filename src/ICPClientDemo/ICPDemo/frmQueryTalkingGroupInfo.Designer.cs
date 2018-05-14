namespace ICPDemo
{
    partial class frmQueryTalkingGroupInfo
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
            this.label_TalkingGroupID = new System.Windows.Forms.Label();
            this.label_QueryType = new System.Windows.Forms.Label();
            this.label_PageNumber = new System.Windows.Forms.Label();
            this.label_CountPerPage = new System.Windows.Forms.Label();
            this.textBox_TalkingGroupID = new System.Windows.Forms.TextBox();
            this.textBox_QueryType = new System.Windows.Forms.TextBox();
            this.textBox_PageNumber = new System.Windows.Forms.TextBox();
            this.textBox_CountPerPage = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_TalkingGroupID
            // 
            this.label_TalkingGroupID.Location = new System.Drawing.Point(15, 109);
            this.label_TalkingGroupID.Name = "label_TalkingGroupID";
            this.label_TalkingGroupID.Size = new System.Drawing.Size(107, 12);
            this.label_TalkingGroupID.TabIndex = 0;
            this.label_TalkingGroupID.Text = "Talking Group ID:";
            this.label_TalkingGroupID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_QueryType
            // 
            this.label_QueryType.Location = new System.Drawing.Point(51, 33);
            this.label_QueryType.Name = "label_QueryType";
            this.label_QueryType.Size = new System.Drawing.Size(71, 12);
            this.label_QueryType.TabIndex = 1;
            this.label_QueryType.Text = "Query Type:";
            this.label_QueryType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_PageNumber
            // 
            this.label_PageNumber.Location = new System.Drawing.Point(2, 107);
            this.label_PageNumber.Name = "label_PageNumber";
            this.label_PageNumber.Size = new System.Drawing.Size(120, 12);
            this.label_PageNumber.TabIndex = 2;
            this.label_PageNumber.Text = "Page Number:";
            this.label_PageNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_CountPerPage
            // 
            this.label_CountPerPage.Location = new System.Drawing.Point(27, 70);
            this.label_CountPerPage.Name = "label_CountPerPage";
            this.label_CountPerPage.Size = new System.Drawing.Size(95, 12);
            this.label_CountPerPage.TabIndex = 3;
            this.label_CountPerPage.Text = "Count Per Page:";
            this.label_CountPerPage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_TalkingGroupID
            // 
            this.textBox_TalkingGroupID.Location = new System.Drawing.Point(128, 106);
            this.textBox_TalkingGroupID.Name = "textBox_TalkingGroupID";
            this.textBox_TalkingGroupID.Size = new System.Drawing.Size(144, 21);
            this.textBox_TalkingGroupID.TabIndex = 4;
            // 
            // textBox_QueryType
            // 
            this.textBox_QueryType.Location = new System.Drawing.Point(128, 30);
            this.textBox_QueryType.Name = "textBox_QueryType";
            this.textBox_QueryType.Size = new System.Drawing.Size(144, 21);
            this.textBox_QueryType.TabIndex = 5;
            this.textBox_QueryType.Text = "1";
            // 
            // textBox_PageNumber
            // 
            this.textBox_PageNumber.Location = new System.Drawing.Point(128, 104);
            this.textBox_PageNumber.Name = "textBox_PageNumber";
            this.textBox_PageNumber.Size = new System.Drawing.Size(144, 21);
            this.textBox_PageNumber.TabIndex = 6;
            this.textBox_PageNumber.Tag = "";
            // 
            // textBox_CountPerPage
            // 
            this.textBox_CountPerPage.Location = new System.Drawing.Point(128, 67);
            this.textBox_CountPerPage.Name = "textBox_CountPerPage";
            this.textBox_CountPerPage.Size = new System.Drawing.Size(144, 21);
            this.textBox_CountPerPage.TabIndex = 7;
            this.textBox_CountPerPage.Text = "5";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(103, 187);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 8;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // frmQueryTalkingGroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_CountPerPage);
            this.Controls.Add(this.textBox_PageNumber);
            this.Controls.Add(this.textBox_QueryType);
            this.Controls.Add(this.textBox_TalkingGroupID);
            this.Controls.Add(this.label_CountPerPage);
            this.Controls.Add(this.label_PageNumber);
            this.Controls.Add(this.label_QueryType);
            this.Controls.Add(this.label_TalkingGroupID);
            this.Name = "frmQueryTalkingGroupInfo";
            this.Text = "frmQueryTalkingGroupInfo";
            this.Load += new System.EventHandler(this.frmQueryTalkingGroupInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TalkingGroupID;
        private System.Windows.Forms.Label label_QueryType;
        private System.Windows.Forms.Label label_PageNumber;
        private System.Windows.Forms.Label label_CountPerPage;
        private System.Windows.Forms.TextBox textBox_TalkingGroupID;
        private System.Windows.Forms.TextBox textBox_QueryType;
        private System.Windows.Forms.TextBox textBox_PageNumber;
        private System.Windows.Forms.TextBox textBox_CountPerPage;
        private System.Windows.Forms.Button button_OK;
    }
}
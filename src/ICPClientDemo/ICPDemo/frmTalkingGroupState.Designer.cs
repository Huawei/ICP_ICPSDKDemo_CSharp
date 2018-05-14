namespace ICPDemo
{
    partial class frmTalkingGroupState
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
            this.textBox_TalkingGroupID = new System.Windows.Forms.TextBox();
            this.textBox_Expire = new System.Windows.Forms.TextBox();
            this.label_TalkingGroupID = new System.Windows.Forms.Label();
            this.label_Expire = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label_IsAutoAubscribe = new System.Windows.Forms.Label();
            this.radioButton_True = new System.Windows.Forms.RadioButton();
            this.radioButton_False = new System.Windows.Forms.RadioButton();
            this.radioButton_defualt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_TalkingGroupID
            // 
            this.textBox_TalkingGroupID.Location = new System.Drawing.Point(147, 42);
            this.textBox_TalkingGroupID.Name = "textBox_TalkingGroupID";
            this.textBox_TalkingGroupID.Size = new System.Drawing.Size(192, 21);
            this.textBox_TalkingGroupID.TabIndex = 0;
            // 
            // textBox_Expire
            // 
            this.textBox_Expire.Location = new System.Drawing.Point(147, 117);
            this.textBox_Expire.Name = "textBox_Expire";
            this.textBox_Expire.Size = new System.Drawing.Size(107, 21);
            this.textBox_Expire.TabIndex = 1;
            this.textBox_Expire.Text = "3600";
            // 
            // label_TalkingGroupID
            // 
            this.label_TalkingGroupID.Location = new System.Drawing.Point(22, 45);
            this.label_TalkingGroupID.Name = "label_TalkingGroupID";
            this.label_TalkingGroupID.Size = new System.Drawing.Size(107, 12);
            this.label_TalkingGroupID.TabIndex = 2;
            this.label_TalkingGroupID.Text = "Talking Group ID:";
            this.label_TalkingGroupID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_Expire
            // 
            this.label_Expire.Location = new System.Drawing.Point(69, 120);
            this.label_Expire.Name = "label_Expire";
            this.label_Expire.Size = new System.Drawing.Size(60, 12);
            this.label_Expire.TabIndex = 3;
            this.label_Expire.Text = "Expire:";
            this.label_Expire.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(148, 178);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label_IsAutoAubscribe
            // 
            this.label_IsAutoAubscribe.Location = new System.Drawing.Point(5, 82);
            this.label_IsAutoAubscribe.Name = "label_IsAutoAubscribe";
            this.label_IsAutoAubscribe.Size = new System.Drawing.Size(124, 12);
            this.label_IsAutoAubscribe.TabIndex = 5;
            this.label_IsAutoAubscribe.Text = "Is Auto Subscribe:";
            this.label_IsAutoAubscribe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_IsAutoAubscribe.Visible = false;
            // 
            // radioButton_True
            // 
            this.radioButton_True.AutoSize = true;
            this.radioButton_True.Location = new System.Drawing.Point(218, 78);
            this.radioButton_True.Name = "radioButton_True";
            this.radioButton_True.Size = new System.Drawing.Size(47, 16);
            this.radioButton_True.TabIndex = 6;
            this.radioButton_True.Text = "True";
            this.radioButton_True.UseVisualStyleBackColor = true;
            this.radioButton_True.Visible = false;
            // 
            // radioButton_False
            // 
            this.radioButton_False.AutoSize = true;
            this.radioButton_False.Location = new System.Drawing.Point(271, 78);
            this.radioButton_False.Name = "radioButton_False";
            this.radioButton_False.Size = new System.Drawing.Size(53, 16);
            this.radioButton_False.TabIndex = 7;
            this.radioButton_False.Text = "False";
            this.radioButton_False.UseVisualStyleBackColor = true;
            this.radioButton_False.Visible = false;
            // 
            // radioButton_defualt
            // 
            this.radioButton_defualt.AutoSize = true;
            this.radioButton_defualt.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton_defualt.Checked = true;
            this.radioButton_defualt.Location = new System.Drawing.Point(147, 78);
            this.radioButton_defualt.Name = "radioButton_defualt";
            this.radioButton_defualt.Size = new System.Drawing.Size(65, 16);
            this.radioButton_defualt.TabIndex = 8;
            this.radioButton_defualt.TabStop = true;
            this.radioButton_defualt.Text = "Default";
            this.radioButton_defualt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioButton_defualt.UseVisualStyleBackColor = true;
            this.radioButton_defualt.Visible = false;
            // 
            // frmTalkingGroupState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 213);
            this.Controls.Add(this.radioButton_defualt);
            this.Controls.Add(this.radioButton_False);
            this.Controls.Add(this.radioButton_True);
            this.Controls.Add(this.label_IsAutoAubscribe);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label_Expire);
            this.Controls.Add(this.label_TalkingGroupID);
            this.Controls.Add(this.textBox_Expire);
            this.Controls.Add(this.textBox_TalkingGroupID);
            this.Name = "frmTalkingGroupState";
            this.Load += new System.EventHandler(this.frmTalkingGroupState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TalkingGroupID;
        private System.Windows.Forms.TextBox textBox_Expire;
        private System.Windows.Forms.Label label_TalkingGroupID;
        private System.Windows.Forms.Label label_Expire;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label_IsAutoAubscribe;
        internal System.Windows.Forms.RadioButton radioButton_True;
        internal System.Windows.Forms.RadioButton radioButton_False;
        internal System.Windows.Forms.RadioButton radioButton_defualt;
    }
}
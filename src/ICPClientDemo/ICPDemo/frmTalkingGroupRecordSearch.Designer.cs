namespace ICPDemo
{
    partial class frmTalkingGroupRecordSearch
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
            this.textBox_StartTime = new System.Windows.Forms.TextBox();
            this.label_textBox_StartTime = new System.Windows.Forms.Label();
            this.textBox_EndTime = new System.Windows.Forms.TextBox();
            this.label_textBox_EndTime = new System.Windows.Forms.Label();
            this.label_textBox_PageIndex = new System.Windows.Forms.Label();
            this.label_textBox_PageSize = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.textBox_PageIndex = new System.Windows.Forms.NumericUpDown();
            this.textBox_TalkingGroupID = new System.Windows.Forms.TextBox();
            this.textBox_PageSize = new System.Windows.Forms.NumericUpDown();
            this.label_radio_OnlyLocalRecord = new System.Windows.Forms.Label();
            this.label_radio_IsConfRecord = new System.Windows.Forms.Label();
            this.radioBtn_OnlyLocalRecord_False = new System.Windows.Forms.RadioButton();
            this.radioBtn_OnlyLocalRecord_True = new System.Windows.Forms.RadioButton();
            this.radioBtn_IsConfRecord_False = new System.Windows.Forms.RadioButton();
            this.radioBtn_IsConfRecord_True = new System.Windows.Forms.RadioButton();
            this.OnlyLocalRecordGroup = new System.Windows.Forms.GroupBox();
            this.isConfRecordGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_PageIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_PageSize)).BeginInit();
            this.OnlyLocalRecordGroup.SuspendLayout();
            this.isConfRecordGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_TalkingGroupID
            // 
            this.label_TalkingGroupID.Location = new System.Drawing.Point(22, 28);
            this.label_TalkingGroupID.Name = "label_TalkingGroupID";
            this.label_TalkingGroupID.Size = new System.Drawing.Size(107, 12);
            this.label_TalkingGroupID.TabIndex = 2;
            this.label_TalkingGroupID.Text = "Dispatch Number:";
            this.label_TalkingGroupID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_StartTime
            // 
            this.textBox_StartTime.Location = new System.Drawing.Point(147, 61);
            this.textBox_StartTime.Name = "textBox_StartTime";
            this.textBox_StartTime.Size = new System.Drawing.Size(192, 21);
            this.textBox_StartTime.TabIndex = 0;
            // 
            // label_textBox_StartTime
            // 
            this.label_textBox_StartTime.Location = new System.Drawing.Point(22, 64);
            this.label_textBox_StartTime.Name = "label_textBox_StartTime";
            this.label_textBox_StartTime.Size = new System.Drawing.Size(107, 12);
            this.label_textBox_StartTime.TabIndex = 2;
            this.label_textBox_StartTime.Text = "Start Time:";
            this.label_textBox_StartTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_EndTime
            // 
            this.textBox_EndTime.Location = new System.Drawing.Point(147, 95);
            this.textBox_EndTime.Name = "textBox_EndTime";
            this.textBox_EndTime.Size = new System.Drawing.Size(192, 21);
            this.textBox_EndTime.TabIndex = 0;
            // 
            // label_textBox_EndTime
            // 
            this.label_textBox_EndTime.Location = new System.Drawing.Point(22, 100);
            this.label_textBox_EndTime.Name = "label_textBox_EndTime";
            this.label_textBox_EndTime.Size = new System.Drawing.Size(107, 12);
            this.label_textBox_EndTime.TabIndex = 2;
            this.label_textBox_EndTime.Text = "End Time:";
            this.label_textBox_EndTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_textBox_PageIndex
            // 
            this.label_textBox_PageIndex.Location = new System.Drawing.Point(22, 136);
            this.label_textBox_PageIndex.Name = "label_textBox_PageIndex";
            this.label_textBox_PageIndex.Size = new System.Drawing.Size(107, 12);
            this.label_textBox_PageIndex.TabIndex = 2;
            this.label_textBox_PageIndex.Text = "Page Index:";
            this.label_textBox_PageIndex.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_textBox_PageSize
            // 
            this.label_textBox_PageSize.Location = new System.Drawing.Point(22, 172);
            this.label_textBox_PageSize.Name = "label_textBox_PageSize";
            this.label_textBox_PageSize.Size = new System.Drawing.Size(107, 12);
            this.label_textBox_PageSize.TabIndex = 2;
            this.label_textBox_PageSize.Text = "Page Size:";
            this.label_textBox_PageSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(147, 294);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // textBox_PageIndex
            // 
            this.textBox_PageIndex.Location = new System.Drawing.Point(147, 134);
            this.textBox_PageIndex.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.textBox_PageIndex.Name = "textBox_PageIndex";
            this.textBox_PageIndex.Size = new System.Drawing.Size(192, 21);
            this.textBox_PageIndex.TabIndex = 5;
            this.textBox_PageIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBox_PageIndex.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox_TalkingGroupID
            // 
            this.textBox_TalkingGroupID.Location = new System.Drawing.Point(147, 25);
            this.textBox_TalkingGroupID.Name = "textBox_TalkingGroupID";
            this.textBox_TalkingGroupID.Size = new System.Drawing.Size(192, 21);
            this.textBox_TalkingGroupID.TabIndex = 0;
            // 
            // textBox_PageSize
            // 
            this.textBox_PageSize.Location = new System.Drawing.Point(147, 170);
            this.textBox_PageSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.textBox_PageSize.Name = "textBox_PageSize";
            this.textBox_PageSize.Size = new System.Drawing.Size(192, 21);
            this.textBox_PageSize.TabIndex = 6;
            this.textBox_PageSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_radio_OnlyLocalRecord
            // 
            this.label_radio_OnlyLocalRecord.Location = new System.Drawing.Point(22, 217);
            this.label_radio_OnlyLocalRecord.Name = "label_radio_OnlyLocalRecord";
            this.label_radio_OnlyLocalRecord.Size = new System.Drawing.Size(107, 12);
            this.label_radio_OnlyLocalRecord.TabIndex = 2;
            this.label_radio_OnlyLocalRecord.Text = "OnlyLocalRecord:";
            this.label_radio_OnlyLocalRecord.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_radio_IsConfRecord
            // 
            this.label_radio_IsConfRecord.Location = new System.Drawing.Point(22, 261);
            this.label_radio_IsConfRecord.Name = "label_radio_IsConfRecord";
            this.label_radio_IsConfRecord.Size = new System.Drawing.Size(107, 12);
            this.label_radio_IsConfRecord.TabIndex = 2;
            this.label_radio_IsConfRecord.Text = "IsConfRecord:";
            this.label_radio_IsConfRecord.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioBtn_OnlyLocalRecord_False
            // 
            this.radioBtn_OnlyLocalRecord_False.AutoSize = true;
            this.radioBtn_OnlyLocalRecord_False.Location = new System.Drawing.Point(59, 17);
            this.radioBtn_OnlyLocalRecord_False.Name = "radioBtn_OnlyLocalRecord_False";
            this.radioBtn_OnlyLocalRecord_False.Size = new System.Drawing.Size(53, 16);
            this.radioBtn_OnlyLocalRecord_False.TabIndex = 9;
            this.radioBtn_OnlyLocalRecord_False.Text = "False";
            this.radioBtn_OnlyLocalRecord_False.UseVisualStyleBackColor = true;
            this.radioBtn_OnlyLocalRecord_False.CheckedChanged += new System.EventHandler(this.radioBtn_OnlyLocalRecord_False_CheckedChanged);
            // 
            // radioBtn_OnlyLocalRecord_True
            // 
            this.radioBtn_OnlyLocalRecord_True.AutoSize = true;
            this.radioBtn_OnlyLocalRecord_True.Checked = true;
            this.radioBtn_OnlyLocalRecord_True.Location = new System.Drawing.Point(6, 17);
            this.radioBtn_OnlyLocalRecord_True.Name = "radioBtn_OnlyLocalRecord_True";
            this.radioBtn_OnlyLocalRecord_True.Size = new System.Drawing.Size(47, 16);
            this.radioBtn_OnlyLocalRecord_True.TabIndex = 8;
            this.radioBtn_OnlyLocalRecord_True.TabStop = true;
            this.radioBtn_OnlyLocalRecord_True.Text = "True";
            this.radioBtn_OnlyLocalRecord_True.UseVisualStyleBackColor = true;
            this.radioBtn_OnlyLocalRecord_True.CheckedChanged += new System.EventHandler(this.radioBtn_OnlyLocalRecord_True_CheckedChanged);
            // 
            // radioBtn_IsConfRecord_False
            // 
            this.radioBtn_IsConfRecord_False.AutoSize = true;
            this.radioBtn_IsConfRecord_False.Location = new System.Drawing.Point(59, 16);
            this.radioBtn_IsConfRecord_False.Name = "radioBtn_IsConfRecord_False";
            this.radioBtn_IsConfRecord_False.Size = new System.Drawing.Size(53, 16);
            this.radioBtn_IsConfRecord_False.TabIndex = 11;
            this.radioBtn_IsConfRecord_False.Text = "False";
            this.radioBtn_IsConfRecord_False.UseVisualStyleBackColor = true;
            this.radioBtn_IsConfRecord_False.CheckedChanged += new System.EventHandler(this.radioBtn_IsConfRecord_False_CheckedChanged);
            // 
            // radioBtn_IsConfRecord_True
            // 
            this.radioBtn_IsConfRecord_True.AutoSize = true;
            this.radioBtn_IsConfRecord_True.Checked = true;
            this.radioBtn_IsConfRecord_True.Location = new System.Drawing.Point(6, 16);
            this.radioBtn_IsConfRecord_True.Name = "radioBtn_IsConfRecord_True";
            this.radioBtn_IsConfRecord_True.Size = new System.Drawing.Size(47, 16);
            this.radioBtn_IsConfRecord_True.TabIndex = 10;
            this.radioBtn_IsConfRecord_True.TabStop = true;
            this.radioBtn_IsConfRecord_True.Text = "True";
            this.radioBtn_IsConfRecord_True.UseVisualStyleBackColor = true;
            // 
            // OnlyLocalRecordGroup
            // 
            this.OnlyLocalRecordGroup.Controls.Add(this.radioBtn_OnlyLocalRecord_True);
            this.OnlyLocalRecordGroup.Controls.Add(this.radioBtn_OnlyLocalRecord_False);
            this.OnlyLocalRecordGroup.Location = new System.Drawing.Point(147, 197);
            this.OnlyLocalRecordGroup.Name = "OnlyLocalRecordGroup";
            this.OnlyLocalRecordGroup.Size = new System.Drawing.Size(192, 42);
            this.OnlyLocalRecordGroup.TabIndex = 12;
            this.OnlyLocalRecordGroup.TabStop = false;
            // 
            // isConfRecordGroup
            // 
            this.isConfRecordGroup.Controls.Add(this.radioBtn_IsConfRecord_True);
            this.isConfRecordGroup.Controls.Add(this.radioBtn_IsConfRecord_False);
            this.isConfRecordGroup.Location = new System.Drawing.Point(147, 245);
            this.isConfRecordGroup.Name = "isConfRecordGroup";
            this.isConfRecordGroup.Size = new System.Drawing.Size(192, 42);
            this.isConfRecordGroup.TabIndex = 13;
            this.isConfRecordGroup.TabStop = false;
            // 
            // frmTalkingGroupRecordSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 329);
            this.Controls.Add(this.textBox_PageSize);
            this.Controls.Add(this.textBox_PageIndex);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label_TalkingGroupID);
            this.Controls.Add(this.textBox_TalkingGroupID);
            this.Controls.Add(this.label_textBox_StartTime);
            this.Controls.Add(this.textBox_StartTime);
            this.Controls.Add(this.label_textBox_EndTime);
            this.Controls.Add(this.label_radio_IsConfRecord);
            this.Controls.Add(this.textBox_EndTime);
            this.Controls.Add(this.label_radio_OnlyLocalRecord);
            this.Controls.Add(this.label_textBox_PageSize);
            this.Controls.Add(this.label_textBox_PageIndex);
            this.Controls.Add(this.isConfRecordGroup);
            this.Controls.Add(this.OnlyLocalRecordGroup);
            this.Name = "frmTalkingGroupRecordSearch";
            this.Text = "frmTalkingGroupRecordSearch";
            this.Load += new System.EventHandler(this.frmTalkingGroupRecordSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBox_PageIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_PageSize)).EndInit();
            this.OnlyLocalRecordGroup.ResumeLayout(false);
            this.OnlyLocalRecordGroup.PerformLayout();
            this.isConfRecordGroup.ResumeLayout(false);
            this.isConfRecordGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TalkingGroupID;
        private System.Windows.Forms.TextBox textBox_StartTime;
        private System.Windows.Forms.Label label_textBox_StartTime;
        private System.Windows.Forms.TextBox textBox_EndTime;
        private System.Windows.Forms.Label label_textBox_EndTime;
        private System.Windows.Forms.Label label_textBox_PageSize;
        private System.Windows.Forms.Label label_textBox_PageIndex;
        
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.NumericUpDown textBox_PageIndex;
        private System.Windows.Forms.TextBox textBox_TalkingGroupID;
        private System.Windows.Forms.NumericUpDown textBox_PageSize;
        private System.Windows.Forms.Label label_radio_OnlyLocalRecord;
        private System.Windows.Forms.Label label_radio_IsConfRecord;
        internal System.Windows.Forms.RadioButton radioBtn_OnlyLocalRecord_True;
        internal System.Windows.Forms.RadioButton radioBtn_IsConfRecord_False;
        internal System.Windows.Forms.RadioButton radioBtn_IsConfRecord_True;
        public System.Windows.Forms.RadioButton radioBtn_OnlyLocalRecord_False;
        private System.Windows.Forms.GroupBox OnlyLocalRecordGroup;
        private System.Windows.Forms.GroupBox isConfRecordGroup;
    }
}
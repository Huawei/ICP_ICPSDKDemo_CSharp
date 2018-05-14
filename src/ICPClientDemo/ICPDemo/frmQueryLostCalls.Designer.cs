namespace ICPDemo
{
    partial class frmQueryLostCalls
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
            this.beginTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblBeginTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnQueryCallsCount = new System.Windows.Forms.Button();
            this.lblStartPosition = new System.Windows.Forms.Label();
            this.lblEndPosition = new System.Windows.Forms.Label();
            this.txtStartPosition = new System.Windows.Forms.TextBox();
            this.txtEndPosition = new System.Windows.Forms.TextBox();
            this.btnQueryLostCalls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beginTimePicker
            // 
            this.beginTimePicker.Checked = false;
            this.beginTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.beginTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginTimePicker.Location = new System.Drawing.Point(104, 15);
            this.beginTimePicker.Name = "beginTimePicker";
            this.beginTimePicker.Size = new System.Drawing.Size(159, 21);
            this.beginTimePicker.TabIndex = 0;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Checked = false;
            this.endTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(104, 60);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(159, 21);
            this.endTimePicker.TabIndex = 0;
            // 
            // lblBeginTime
            // 
            this.lblBeginTime.Location = new System.Drawing.Point(0, 21);
            this.lblBeginTime.Name = "lblBeginTime";
            this.lblBeginTime.Size = new System.Drawing.Size(101, 12);
            this.lblBeginTime.TabIndex = 2;
            this.lblBeginTime.Text = "BeginTime:";
            this.lblBeginTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(2, 63);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(99, 12);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "EneTime:";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnQueryCallsCount
            // 
            this.btnQueryCallsCount.Location = new System.Drawing.Point(271, 57);
            this.btnQueryCallsCount.Name = "btnQueryCallsCount";
            this.btnQueryCallsCount.Size = new System.Drawing.Size(134, 24);
            this.btnQueryCallsCount.TabIndex = 4;
            this.btnQueryCallsCount.Text = "QueryLostCallsCount";
            this.btnQueryCallsCount.UseVisualStyleBackColor = true;
            this.btnQueryCallsCount.Click += new System.EventHandler(this.btnQueryCallsCount_Click);
            // 
            // lblStartPosition
            // 
            this.lblStartPosition.Location = new System.Drawing.Point(2, 105);
            this.lblStartPosition.Name = "lblStartPosition";
            this.lblStartPosition.Size = new System.Drawing.Size(99, 12);
            this.lblStartPosition.TabIndex = 5;
            this.lblStartPosition.Text = "StartPosition:";
            this.lblStartPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEndPosition
            // 
            this.lblEndPosition.Location = new System.Drawing.Point(2, 143);
            this.lblEndPosition.Name = "lblEndPosition";
            this.lblEndPosition.Size = new System.Drawing.Size(96, 12);
            this.lblEndPosition.TabIndex = 6;
            this.lblEndPosition.Text = "EndPosition:";
            this.lblEndPosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtStartPosition
            // 
            this.txtStartPosition.Location = new System.Drawing.Point(106, 102);
            this.txtStartPosition.Name = "txtStartPosition";
            this.txtStartPosition.Size = new System.Drawing.Size(157, 21);
            this.txtStartPosition.TabIndex = 7;
            // 
            // txtEndPosition
            // 
            this.txtEndPosition.Location = new System.Drawing.Point(106, 140);
            this.txtEndPosition.Name = "txtEndPosition";
            this.txtEndPosition.Size = new System.Drawing.Size(157, 21);
            this.txtEndPosition.TabIndex = 8;
            // 
            // btnQueryLostCalls
            // 
            this.btnQueryLostCalls.Location = new System.Drawing.Point(271, 137);
            this.btnQueryLostCalls.Name = "btnQueryLostCalls";
            this.btnQueryLostCalls.Size = new System.Drawing.Size(134, 24);
            this.btnQueryLostCalls.TabIndex = 9;
            this.btnQueryLostCalls.Text = "QueryLostCalls";
            this.btnQueryLostCalls.UseVisualStyleBackColor = true;
            this.btnQueryLostCalls.Click += new System.EventHandler(this.btnQueryLostCalls_Click);
            // 
            // frmQueryLostCalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 198);
            this.Controls.Add(this.btnQueryLostCalls);
            this.Controls.Add(this.txtEndPosition);
            this.Controls.Add(this.txtStartPosition);
            this.Controls.Add(this.lblEndPosition);
            this.Controls.Add(this.lblStartPosition);
            this.Controls.Add(this.btnQueryCallsCount);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblBeginTime);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.beginTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQueryLostCalls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQueryLostCalls";
            this.Load += new System.EventHandler(this.frmQueryLostCalls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker beginTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label lblBeginTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Button btnQueryCallsCount;
        private System.Windows.Forms.Label lblStartPosition;
        private System.Windows.Forms.Label lblEndPosition;
        private System.Windows.Forms.TextBox txtStartPosition;
        private System.Windows.Forms.TextBox txtEndPosition;
        private System.Windows.Forms.Button btnQueryLostCalls;
    }
}
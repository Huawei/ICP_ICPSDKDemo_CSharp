﻿namespace ICPDemo
{
    partial class frmLocalVideo
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
            this.SuspendLayout();
            // 
            // frmLocalVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "frmLocalVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmLocalVideo";
            this.Load += new System.EventHandler(this.frmLocalVideo_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLocalVideo_formClosing);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
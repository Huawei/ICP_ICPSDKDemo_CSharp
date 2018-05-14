namespace ICPDemo
{
    partial class frmRemoteVideo
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
            // frmRemoteVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "frmRemoteVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmRemoteVideo";
            this.Load += new System.EventHandler(this.frmRemoteVideo_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRemoteVideo_formClosing);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
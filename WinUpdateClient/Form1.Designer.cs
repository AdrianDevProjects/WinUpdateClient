namespace WinUpdateClient
{
    partial class download_window
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.download_label = new System.Windows.Forms.Label();
            this.download_progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // download_label
            // 
            this.download_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.download_label.AutoSize = true;
            this.download_label.Location = new System.Drawing.Point(353, 185);
            this.download_label.Name = "download_label";
            this.download_label.Size = new System.Drawing.Size(79, 13);
            this.download_label.TabIndex = 0;
            this.download_label.Text = "downloadLabel";
            this.download_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // download_progress
            // 
            this.download_progress.Location = new System.Drawing.Point(178, 201);
            this.download_progress.Name = "download_progress";
            this.download_progress.Size = new System.Drawing.Size(426, 23);
            this.download_progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.download_progress.TabIndex = 1;
            // 
            // download_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.download_progress);
            this.Controls.Add(this.download_label);
            this.Name = "download_window";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "WinUpdateClient";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.download_window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label download_label;
        private System.Windows.Forms.ProgressBar download_progress;
    }
}


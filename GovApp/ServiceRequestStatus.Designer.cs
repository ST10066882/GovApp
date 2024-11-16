namespace GovApp
{
    partial class ServiceRequestStatus
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
            this.windowHeader = new System.Windows.Forms.Panel();
            this.ServiceLbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.windowHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowHeader
            // 
            this.windowHeader.BackColor = System.Drawing.SystemColors.Window;
            this.windowHeader.Controls.Add(this.ServiceLbl);
            this.windowHeader.Controls.Add(this.BackBtn);
            this.windowHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowHeader.Location = new System.Drawing.Point(0, 0);
            this.windowHeader.Name = "windowHeader";
            this.windowHeader.Size = new System.Drawing.Size(800, 100);
            this.windowHeader.TabIndex = 0;
            // 
            // ServiceLbl
            // 
            this.ServiceLbl.AutoSize = true;
            this.ServiceLbl.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLbl.Location = new System.Drawing.Point(297, 29);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(205, 31);
            this.ServiceLbl.TabIndex = 1;
            this.ServiceLbl.Text = "Service Finder";
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::GovApp.Properties.Resources.ReturnBtn;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(94, 72);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 100);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(800, 350);
            this.ContentPanel.TabIndex = 1;
            // 
            // ServiceRequestStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.windowHeader);
            this.Name = "ServiceRequestStatus";
            this.Text = "ServiceRequestStatus";
            this.windowHeader.ResumeLayout(false);
            this.windowHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel windowHeader;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label ServiceLbl;
        private System.Windows.Forms.Panel ContentPanel;
    }
}
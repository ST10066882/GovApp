namespace GovApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowSelectorcComboBox = new System.Windows.Forms.ComboBox();
            this.MainHeadingLbl = new System.Windows.Forms.Label();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pagesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitAppToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitAppToolStripMenuItem.Text = "Exit App";
            this.exitAppToolStripMenuItem.Click += new System.EventHandler(this.exitAppToolStripMenuItem_Click);
            // 
            // pagesToolStripMenuItem
            // 
            this.pagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportIssueToolStripMenuItem,
            this.eventsToolStripMenuItem});
            this.pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            this.pagesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pagesToolStripMenuItem.Text = "Pages";
            // 
            // ReportIssueToolStripMenuItem
            // 
            this.ReportIssueToolStripMenuItem.Name = "ReportIssueToolStripMenuItem";
            this.ReportIssueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReportIssueToolStripMenuItem.Text = "Report Issue";
            this.ReportIssueToolStripMenuItem.Click += new System.EventHandler(this.ReportIssueToolStripMenuItem_Click);
            // 
            // WindowSelectorcComboBox
            // 
            this.WindowSelectorcComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowSelectorcComboBox.FormattingEnabled = true;
            this.WindowSelectorcComboBox.Location = new System.Drawing.Point(218, 188);
            this.WindowSelectorcComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WindowSelectorcComboBox.MaximumSize = new System.Drawing.Size(264, 0);
            this.WindowSelectorcComboBox.Name = "WindowSelectorcComboBox";
            this.WindowSelectorcComboBox.Size = new System.Drawing.Size(186, 21);
            this.WindowSelectorcComboBox.TabIndex = 3;
            this.WindowSelectorcComboBox.SelectedIndexChanged += new System.EventHandler(this.WindowSelectorcComboBox_SelectedIndexChanged);
            // 
            // MainHeadingLbl
            // 
            this.MainHeadingLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainHeadingLbl.AutoSize = true;
            this.MainHeadingLbl.BackColor = System.Drawing.SystemColors.Window;
            this.MainHeadingLbl.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainHeadingLbl.Location = new System.Drawing.Point(117, 45);
            this.MainHeadingLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainHeadingLbl.Name = "MainHeadingLbl";
            this.MainHeadingLbl.Size = new System.Drawing.Size(484, 31);
            this.MainHeadingLbl.TabIndex = 5;
            this.MainHeadingLbl.Text = "South African Municipality Services";
            this.MainHeadingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(614, 405);
            this.Controls.Add(this.MainHeadingLbl);
            this.Controls.Add(this.WindowSelectorcComboBox);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox WindowSelectorcComboBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportIssueToolStripMenuItem;
        private System.Windows.Forms.Label MainHeadingLbl;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
    }
}


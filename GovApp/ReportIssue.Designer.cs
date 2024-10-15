namespace GovApp
{
    partial class ReportIssue
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
            this.components = new System.ComponentModel.Container();
            this.IssueHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.LocationTxtBox = new System.Windows.Forms.TextBox();
            this.DescriptionTxtbox = new System.Windows.Forms.RichTextBox();
            this.MediaBtn = new System.Windows.Forms.Button();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyProgressBar = new System.Windows.Forms.ProgressBar();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.ProgressStatusLbl = new System.Windows.Forms.Label();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeButton = new System.Windows.Forms.Button();
            this.DisplayArea = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayArea)).BeginInit();
            this.SuspendLayout();
            // 
            // IssueHeading
            // 
            this.IssueHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IssueHeading.AutoSize = true;
            this.IssueHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueHeading.Location = new System.Drawing.Point(319, 30);
            this.IssueHeading.MinimumSize = new System.Drawing.Size(171, 50);
            this.IssueHeading.Name = "IssueHeading";
            this.IssueHeading.Size = new System.Drawing.Size(171, 50);
            this.IssueHeading.TabIndex = 0;
            this.IssueHeading.Text = "Report Issue";
            this.IssueHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(106, 143);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(76, 20);
            this.categoryLbl.TabIndex = 2;
            this.categoryLbl.Text = "Category";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.IntegralHeight = false;
            this.CategoryComboBox.Location = new System.Drawing.Point(112, 165);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(224, 24);
            this.CategoryComboBox.TabIndex = 3;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // LocationTxtBox
            // 
            this.LocationTxtBox.Location = new System.Drawing.Point(110, 91);
            this.LocationTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocationTxtBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.LocationTxtBox.Name = "LocationTxtBox";
            this.LocationTxtBox.Size = new System.Drawing.Size(224, 35);
            this.LocationTxtBox.TabIndex = 4;
            this.LocationTxtBox.Leave += new System.EventHandler(this.LocationTxtBox_Leave);
            // 
            // DescriptionTxtbox
            // 
            this.DescriptionTxtbox.Location = new System.Drawing.Point(110, 230);
            this.DescriptionTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionTxtbox.Name = "DescriptionTxtbox";
            this.DescriptionTxtbox.Size = new System.Drawing.Size(368, 165);
            this.DescriptionTxtbox.TabIndex = 5;
            this.DescriptionTxtbox.Text = "";
            this.DescriptionTxtbox.TextChanged += new System.EventHandler(this.DescriptionTxtbox_TextChanged);
            this.DescriptionTxtbox.Leave += new System.EventHandler(this.DescriptionTxtbox_Leave);
            // 
            // MediaBtn
            // 
            this.MediaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MediaBtn.BackColor = System.Drawing.Color.Turquoise;
            this.MediaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.MediaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaBtn.Location = new System.Drawing.Point(350, 400);
            this.MediaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MediaBtn.Name = "MediaBtn";
            this.MediaBtn.Size = new System.Drawing.Size(136, 45);
            this.MediaBtn.TabIndex = 6;
            this.MediaBtn.Text = "AttachPicture";
            this.MediaBtn.UseVisualStyleBackColor = false;
            this.MediaBtn.Click += new System.EventHandler(this.MediaBtn_Click);
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(106, 205);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(140, 20);
            this.descriptionLbl.TabIndex = 7;
            this.descriptionLbl.Text = "Issue Description";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(856, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "myMenuStrip";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem});
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.navigationToolStripMenuItem.Text = "Navigation";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backToMenuToolStripMenuItem.Text = "Back To Menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // MyProgressBar
            // 
            this.MyProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MyProgressBar.Location = new System.Drawing.Point(119, 497);
            this.MyProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyProgressBar.Name = "MyProgressBar";
            this.MyProgressBar.Size = new System.Drawing.Size(333, 42);
            this.MyProgressBar.TabIndex = 9;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SubmitBtn.BackColor = System.Drawing.Color.Turquoise;
            this.SubmitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(110, 401);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(111, 44);
            this.SubmitBtn.TabIndex = 10;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ProgressStatusLbl
            // 
            this.ProgressStatusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressStatusLbl.AutoSize = true;
            this.ProgressStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressStatusLbl.Location = new System.Drawing.Point(185, 465);
            this.ProgressStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgressStatusLbl.Name = "ProgressStatusLbl";
            this.ProgressStatusLbl.Size = new System.Drawing.Size(192, 20);
            this.ProgressStatusLbl.TabIndex = 12;
            this.ProgressStatusLbl.Text = "Progress Of Submission";
            this.ProgressStatusLbl.Click += new System.EventHandler(this.ProgressStatusLbl_Click);
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HomeButton.BackColor = System.Drawing.Color.Turquoise;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Location = new System.Drawing.Point(218, 551);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(116, 48);
            this.HomeButton.TabIndex = 13;
            this.HomeButton.Text = "Return";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // DisplayArea
            // 
            this.DisplayArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayArea.Location = new System.Drawing.Point(504, 205);
            this.DisplayArea.Name = "DisplayArea";
            this.DisplayArea.Size = new System.Drawing.Size(318, 341);
            this.DisplayArea.TabIndex = 14;
            this.DisplayArea.TabStop = false;
            // 
            // ReportIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(856, 628);
            this.Controls.Add(this.DisplayArea);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.ProgressStatusLbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.MyProgressBar);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.MediaBtn);
            this.Controls.Add(this.DescriptionTxtbox);
            this.Controls.Add(this.LocationTxtBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IssueHeading);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportIssue";
            this.Text = "ReportIssue";
            this.Load += new System.EventHandler(this.ReportIssue_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IssueHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox LocationTxtBox;
        private System.Windows.Forms.RichTextBox DescriptionTxtbox;
        private System.Windows.Forms.Button MediaBtn;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.ProgressBar MyProgressBar;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label ProgressStatusLbl;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.PictureBox DisplayArea;
    }
}
namespace GovApp.UserControls
{
    partial class IssueReporting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.Heading = new System.Windows.Forms.Label();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.LocationTxt = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.MyProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressStatusLbl = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.MediaBtn = new System.Windows.Forms.Button();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.MyPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBtn.BackColor = System.Drawing.Color.Bisque;
            this.ReturnBtn.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.ReturnBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReturnBtn.Location = new System.Drawing.Point(3, 3);
            this.ReturnBtn.MaximumSize = new System.Drawing.Size(178, 70);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(178, 46);
            this.ReturnBtn.TabIndex = 0;
            this.ReturnBtn.Text = "Back";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // Heading
            // 
            this.Heading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(316, 20);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(237, 31);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Reporting Issues";
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.LocationLbl.Location = new System.Drawing.Point(25, 96);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(82, 22);
            this.LocationLbl.TabIndex = 2;
            this.LocationLbl.Text = "Location";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.CategoryLbl.Location = new System.Drawing.Point(25, 162);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(86, 22);
            this.CategoryLbl.TabIndex = 3;
            this.CategoryLbl.Text = "Category";
            // 
            // LocationTxt
            // 
            this.LocationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationTxt.BackColor = System.Drawing.Color.AliceBlue;
            this.LocationTxt.Location = new System.Drawing.Point(138, 97);
            this.LocationTxt.MaximumSize = new System.Drawing.Size(271, 50);
            this.LocationTxt.Name = "LocationTxt";
            this.LocationTxt.Size = new System.Drawing.Size(250, 22);
            this.LocationTxt.TabIndex = 4;
            this.LocationTxt.TextChanged += new System.EventHandler(this.LocationTxt_TextChanged);
            this.LocationTxt.Leave += new System.EventHandler(this.LocationTxt_Leave);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.BackColor = System.Drawing.Color.AliceBlue;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(138, 163);
            this.CategoryComboBox.MaximumSize = new System.Drawing.Size(271, 0);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(250, 24);
            this.CategoryComboBox.TabIndex = 5;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.DescriptionLbl.Location = new System.Drawing.Point(28, 220);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(104, 22);
            this.DescriptionLbl.TabIndex = 6;
            this.DescriptionLbl.Text = "Description";
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTxt.BackColor = System.Drawing.Color.AliceBlue;
            this.DescriptionTxt.Location = new System.Drawing.Point(29, 254);
            this.DescriptionTxt.MaximumSize = new System.Drawing.Size(380, 160);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(380, 160);
            this.DescriptionTxt.TabIndex = 7;
            this.DescriptionTxt.Text = "";
            this.DescriptionTxt.Leave += new System.EventHandler(this.DescriptionTxt_Leave);
            // 
            // MyProgressBar
            // 
            this.MyProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyProgressBar.Location = new System.Drawing.Point(29, 531);
            this.MyProgressBar.Name = "MyProgressBar";
            this.MyProgressBar.Size = new System.Drawing.Size(380, 30);
            this.MyProgressBar.TabIndex = 9;
            // 
            // ProgressStatusLbl
            // 
            this.ProgressStatusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressStatusLbl.AutoSize = true;
            this.ProgressStatusLbl.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressStatusLbl.ForeColor = System.Drawing.Color.Bisque;
            this.ProgressStatusLbl.Location = new System.Drawing.Point(28, 494);
            this.ProgressStatusLbl.Name = "ProgressStatusLbl";
            this.ProgressStatusLbl.Size = new System.Drawing.Size(53, 21);
            this.ProgressStatusLbl.TabIndex = 10;
            this.ProgressStatusLbl.Text = "label5";
            this.ProgressStatusLbl.Click += new System.EventHandler(this.ProgressStatusLbl_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitBtn.BackColor = System.Drawing.Color.Bisque;
            this.SubmitBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SubmitBtn.Location = new System.Drawing.Point(643, 474);
            this.SubmitBtn.MaximumSize = new System.Drawing.Size(178, 47);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(178, 47);
            this.SubmitBtn.TabIndex = 11;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // MediaBtn
            // 
            this.MediaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaBtn.BackColor = System.Drawing.Color.Bisque;
            this.MediaBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.MediaBtn.Location = new System.Drawing.Point(29, 420);
            this.MediaBtn.MaximumSize = new System.Drawing.Size(178, 48);
            this.MediaBtn.Name = "MediaBtn";
            this.MediaBtn.Size = new System.Drawing.Size(178, 48);
            this.MediaBtn.TabIndex = 12;
            this.MediaBtn.Text = "Attach File / Image";
            this.MediaBtn.UseVisualStyleBackColor = false;
            this.MediaBtn.Click += new System.EventHandler(this.MediaBtn_Click);
            // 
            // MyTimer
            // 
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(440, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Image Preview";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MyPictureBox
            // 
            this.MyPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyPictureBox.BackColor = System.Drawing.Color.White;
            this.MyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MyPictureBox.Location = new System.Drawing.Point(444, 119);
            this.MyPictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 5, 3);
            this.MyPictureBox.Name = "MyPictureBox";
            this.MyPictureBox.Size = new System.Drawing.Size(377, 349);
            this.MyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MyPictureBox.TabIndex = 8;
            this.MyPictureBox.TabStop = false;
            // 
            // IssueReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MediaBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.ProgressStatusLbl);
            this.Controls.Add(this.MyProgressBar);
            this.Controls.Add(this.MyPictureBox);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.LocationTxt);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.LocationLbl);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.ReturnBtn);
            this.Name = "IssueReporting";
            this.Size = new System.Drawing.Size(836, 583);
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.TextBox LocationTxt;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.RichTextBox DescriptionTxt;
        private System.Windows.Forms.PictureBox MyPictureBox;
        private System.Windows.Forms.ProgressBar MyProgressBar;
        private System.Windows.Forms.Label ProgressStatusLbl;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button MediaBtn;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.Label label1;
    }
}

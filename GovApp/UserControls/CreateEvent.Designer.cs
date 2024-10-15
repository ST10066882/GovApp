namespace GovApp.UserControls
{
    partial class CreateEvent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeadingLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.MyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.HeadingLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 85);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HeadingLbl
            // 
            this.HeadingLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HeadingLbl.AutoSize = true;
            this.HeadingLbl.Font = new System.Drawing.Font("Elephant", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLbl.Location = new System.Drawing.Point(318, 28);
            this.HeadingLbl.Name = "HeadingLbl";
            this.HeadingLbl.Size = new System.Drawing.Size(239, 41);
            this.HeadingLbl.TabIndex = 0;
            this.HeadingLbl.Text = "Create Event";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CreateBtn);
            this.panel2.Controls.Add(this.MyDatePicker);
            this.panel2.Controls.Add(this.categoryField);
            this.panel2.Controls.Add(this.nameField);
            this.panel2.Controls.Add(this.DateLbl);
            this.panel2.Controls.Add(this.CategoryLbl);
            this.panel2.Controls.Add(this.NameLbl);
            this.panel2.Location = new System.Drawing.Point(170, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 453);
            this.panel2.TabIndex = 1;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateBtn.BackColor = System.Drawing.Color.Bisque;
            this.CreateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.CreateBtn.FlatAppearance.BorderSize = 2;
            this.CreateBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateBtn.Location = new System.Drawing.Point(178, 327);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(144, 67);
            this.CreateBtn.TabIndex = 7;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // MyDatePicker
            // 
            this.MyDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MyDatePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyDatePicker.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyDatePicker.Location = new System.Drawing.Point(237, 239);
            this.MyDatePicker.Name = "MyDatePicker";
            this.MyDatePicker.Size = new System.Drawing.Size(226, 32);
            this.MyDatePicker.TabIndex = 5;
            // 
            // categoryField
            // 
            this.categoryField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryField.Location = new System.Drawing.Point(237, 151);
            this.categoryField.Multiline = true;
            this.categoryField.Name = "categoryField";
            this.categoryField.Size = new System.Drawing.Size(226, 30);
            this.categoryField.TabIndex = 4;
            // 
            // nameField
            // 
            this.nameField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(237, 69);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(226, 30);
            this.nameField.TabIndex = 3;
            // 
            // DateLbl
            // 
            this.DateLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.White;
            this.DateLbl.Location = new System.Drawing.Point(75, 239);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(74, 29);
            this.DateLbl.TabIndex = 2;
            this.DateLbl.Text = "Date:";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.CategoryLbl.ForeColor = System.Drawing.Color.White;
            this.CategoryLbl.Location = new System.Drawing.Point(63, 151);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(115, 26);
            this.CategoryLbl.TabIndex = 1;
            this.CategoryLbl.Text = "Category:";
            // 
            // NameLbl
            // 
            this.NameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.NameLbl.ForeColor = System.Drawing.Color.White;
            this.NameLbl.Location = new System.Drawing.Point(75, 69);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(79, 26);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name:";
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.Location = new System.Drawing.Point(454, 133);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 22);
            this.errorLbl.TabIndex = 2;
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreateEvent";
            this.Size = new System.Drawing.Size(836, 612);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.DateTimePicker MyDatePicker;
        private System.Windows.Forms.TextBox categoryField;
        private System.Windows.Forms.Label HeadingLbl;
        private System.Windows.Forms.Label errorLbl;
    }
}

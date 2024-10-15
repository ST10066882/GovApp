namespace GovApp.UserControls
{
    partial class ViewEvents
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reccomendBox = new System.Windows.Forms.RichTextBox();
            this.DateSelectionBox = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.EventCategorySelection = new System.Windows.Forms.ComboBox();
            this.EventDateLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EventBox = new System.Windows.Forms.RichTextBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 85);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "View Events";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.reccomendBox);
            this.panel2.Controls.Add(this.DateSelectionBox);
            this.panel2.Controls.Add(this.SearchBtn);
            this.panel2.Controls.Add(this.EventCategorySelection);
            this.panel2.Controls.Add(this.EventDateLbl);
            this.panel2.Controls.Add(this.CategoryLbl);
            this.panel2.Location = new System.Drawing.Point(19, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 422);
            this.panel2.TabIndex = 1;
            // 
            // reccomendBox
            // 
            this.reccomendBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reccomendBox.Location = new System.Drawing.Point(26, 287);
            this.reccomendBox.Name = "reccomendBox";
            this.reccomendBox.Size = new System.Drawing.Size(362, 114);
            this.reccomendBox.TabIndex = 7;
            this.reccomendBox.Text = "";
            // 
            // DateSelectionBox
            // 
            this.DateSelectionBox.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.DateSelectionBox.FormattingEnabled = true;
            this.DateSelectionBox.Location = new System.Drawing.Point(189, 149);
            this.DateSelectionBox.Name = "DateSelectionBox";
            this.DateSelectionBox.Size = new System.Drawing.Size(199, 29);
            this.DateSelectionBox.TabIndex = 6;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Bisque;
            this.SearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Bisque;
            this.SearchBtn.FlatAppearance.BorderSize = 2;
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(132, 215);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(129, 50);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // EventCategorySelection
            // 
            this.EventCategorySelection.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventCategorySelection.FormattingEnabled = true;
            this.EventCategorySelection.Location = new System.Drawing.Point(189, 56);
            this.EventCategorySelection.Name = "EventCategorySelection";
            this.EventCategorySelection.Size = new System.Drawing.Size(199, 29);
            this.EventCategorySelection.TabIndex = 2;
            // 
            // EventDateLbl
            // 
            this.EventDateLbl.AutoSize = true;
            this.EventDateLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDateLbl.ForeColor = System.Drawing.Color.White;
            this.EventDateLbl.Location = new System.Drawing.Point(39, 145);
            this.EventDateLbl.Name = "EventDateLbl";
            this.EventDateLbl.Size = new System.Drawing.Size(74, 26);
            this.EventDateLbl.TabIndex = 1;
            this.EventDateLbl.Text = "Date: ";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLbl.ForeColor = System.Drawing.Color.White;
            this.CategoryLbl.Location = new System.Drawing.Point(21, 59);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(115, 26);
            this.CategoryLbl.TabIndex = 0;
            this.CategoryLbl.Text = "Category:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.EventBox);
            this.panel3.Location = new System.Drawing.Point(464, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(467, 422);
            this.panel3.TabIndex = 2;
            // 
            // EventBox
            // 
            this.EventBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EventBox.Location = new System.Drawing.Point(26, 26);
            this.EventBox.Name = "EventBox";
            this.EventBox.Size = new System.Drawing.Size(408, 365);
            this.EventBox.TabIndex = 0;
            this.EventBox.Text = "";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.Location = new System.Drawing.Point(149, 97);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 22);
            this.errorLbl.TabIndex = 3;
            // 
            // ViewEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewEvents";
            this.Size = new System.Drawing.Size(961, 568);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ComboBox EventCategorySelection;
        private System.Windows.Forms.Label EventDateLbl;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DateSelectionBox;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.RichTextBox EventBox;
        private System.Windows.Forms.RichTextBox reccomendBox;
    }
}

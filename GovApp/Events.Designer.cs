namespace GovApp
{
    partial class Events
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
            this.NavPanel = new System.Windows.Forms.Panel();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.MenuLbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NavPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavPanel.Controls.Add(this.ViewBtn);
            this.NavPanel.Controls.Add(this.CreateBtn);
            this.NavPanel.Controls.Add(this.MenuLbl);
            this.NavPanel.Controls.Add(this.BackBtn);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(151, 658);
            this.NavPanel.TabIndex = 0;
            // 
            // ViewBtn
            // 
            this.ViewBtn.Image = global::GovApp.Properties.Resources.View;
            this.ViewBtn.Location = new System.Drawing.Point(22, 370);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(113, 83);
            this.ViewBtn.TabIndex = 3;
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Image = global::GovApp.Properties.Resources.CreateBtn;
            this.CreateBtn.Location = new System.Drawing.Point(22, 221);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(113, 84);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // MenuLbl
            // 
            this.MenuLbl.AutoSize = true;
            this.MenuLbl.Font = new System.Drawing.Font("Elephant", 24.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLbl.Location = new System.Drawing.Point(23, 146);
            this.MenuLbl.Name = "MenuLbl";
            this.MenuLbl.Size = new System.Drawing.Size(115, 42);
            this.MenuLbl.TabIndex = 1;
            this.MenuLbl.Text = "Menu";
            // 
            // BackBtn
            // 
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Image = global::GovApp.Properties.Resources.ReturnBtn;
            this.BackBtn.Location = new System.Drawing.Point(22, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(113, 85);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(151, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(894, 658);
            this.ContentPanel.TabIndex = 1;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 658);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "Events";
            this.Text = "Events";
            this.NavPanel.ResumeLayout(false);
            this.NavPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label MenuLbl;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Panel ContentPanel;
    }
}
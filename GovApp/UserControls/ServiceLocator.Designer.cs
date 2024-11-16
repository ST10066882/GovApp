namespace GovApp.UserControls
{
    partial class ServiceLocator
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
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceStorage = new System.Windows.Forms.ListBox();
            this.RequestArea = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.TypeData = new System.Windows.Forms.Label();
            this.StatusData = new System.Windows.Forms.Label();
            this.DateData = new System.Windows.Forms.Label();
            this.RequestNameLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.RequestArea.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ServiceStorage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 410);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MinimumSize = new System.Drawing.Size(200, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Inventory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceStorage
            // 
            this.ServiceStorage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ServiceStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceStorage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceStorage.ForeColor = System.Drawing.Color.White;
            this.ServiceStorage.FormattingEnabled = true;
            this.ServiceStorage.ItemHeight = 19;
            this.ServiceStorage.Location = new System.Drawing.Point(0, 0);
            this.ServiceStorage.Name = "ServiceStorage";
            this.ServiceStorage.Size = new System.Drawing.Size(200, 410);
            this.ServiceStorage.TabIndex = 0;
            this.ServiceStorage.SelectedIndexChanged += new System.EventHandler(this.ServiceStorage_SelectedIndexChanged);
            // 
            // RequestArea
            // 
            this.RequestArea.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RequestArea.Controls.Add(this.tableLayoutPanel1);
            this.RequestArea.Controls.Add(this.RequestNameLbl);
            this.RequestArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestArea.Location = new System.Drawing.Point(200, 0);
            this.RequestArea.Name = "RequestArea";
            this.RequestArea.Size = new System.Drawing.Size(724, 410);
            this.RequestArea.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.63889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.36111F));
            this.tableLayoutPanel1.Controls.Add(this.TypeLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StatusLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DateLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TypeData, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.StatusData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DateData, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(128, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 204);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TypeLbl
            // 
            this.TypeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.TypeLbl.Location = new System.Drawing.Point(40, 22);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(64, 25);
            this.TypeLbl.TabIndex = 1;
            this.TypeLbl.Text = "Type:";
            this.TypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLbl
            // 
            this.StatusLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.StatusLbl.Location = new System.Drawing.Point(34, 89);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(77, 25);
            this.StatusLbl.TabIndex = 2;
            this.StatusLbl.Text = "Status:";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLbl
            // 
            this.DateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.DateLbl.Location = new System.Drawing.Point(41, 156);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(63, 25);
            this.DateLbl.TabIndex = 3;
            this.DateLbl.Text = "Date:";
            this.DateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeData
            // 
            this.TypeData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeData.AutoSize = true;
            this.TypeData.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeData.ForeColor = System.Drawing.SystemColors.Window;
            this.TypeData.Location = new System.Drawing.Point(262, 24);
            this.TypeData.Name = "TypeData";
            this.TypeData.Size = new System.Drawing.Size(53, 21);
            this.TypeData.TabIndex = 4;
            this.TypeData.Text = "label5";
            this.TypeData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusData
            // 
            this.StatusData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusData.AutoSize = true;
            this.StatusData.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusData.ForeColor = System.Drawing.SystemColors.Window;
            this.StatusData.Location = new System.Drawing.Point(262, 91);
            this.StatusData.Name = "StatusData";
            this.StatusData.Size = new System.Drawing.Size(53, 21);
            this.StatusData.TabIndex = 5;
            this.StatusData.Text = "label6";
            this.StatusData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateData
            // 
            this.DateData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateData.AutoSize = true;
            this.DateData.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateData.ForeColor = System.Drawing.SystemColors.Window;
            this.DateData.Location = new System.Drawing.Point(262, 158);
            this.DateData.Name = "DateData";
            this.DateData.Size = new System.Drawing.Size(53, 21);
            this.DateData.TabIndex = 6;
            this.DateData.Text = "label7";
            this.DateData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RequestNameLbl
            // 
            this.RequestNameLbl.AutoSize = true;
            this.RequestNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RequestNameLbl.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestNameLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.RequestNameLbl.Location = new System.Drawing.Point(255, 8);
            this.RequestNameLbl.MinimumSize = new System.Drawing.Size(200, 40);
            this.RequestNameLbl.Name = "RequestNameLbl";
            this.RequestNameLbl.Size = new System.Drawing.Size(200, 40);
            this.RequestNameLbl.TabIndex = 0;
            this.RequestNameLbl.Text = "Request Name";
            this.RequestNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServiceLocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RequestArea);
            this.Controls.Add(this.panel1);
            this.Name = "ServiceLocator";
            this.Size = new System.Drawing.Size(924, 410);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RequestArea.ResumeLayout(false);
            this.RequestArea.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ServiceStorage;
        private System.Windows.Forms.Panel RequestArea;
        private System.Windows.Forms.Label RequestNameLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label TypeData;
        private System.Windows.Forms.Label StatusData;
        private System.Windows.Forms.Label DateData;
    }
}

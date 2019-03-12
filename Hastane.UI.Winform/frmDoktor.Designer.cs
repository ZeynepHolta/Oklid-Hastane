namespace Hastane.UI.Winform
{
    partial class frmDoktor
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMuayene = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lstSeans = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCalismaGunu = new System.Windows.Forms.DateTimePicker();
            this.lstMuayene = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnGunIlerle = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources.white;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(12);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMuayene,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(820, 49);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMuayene
            // 
            this.btnMuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuayene.ForeColor = System.Drawing.Color.Indigo;
            this.btnMuayene.Image = global::Hastane.UI.Winform.Properties.Resources.Checklist_icon;
            this.btnMuayene.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMuayene.Name = "btnMuayene";
            this.btnMuayene.Size = new System.Drawing.Size(147, 46);
            this.btnMuayene.Text = "&Muayenelerim";
            this.btnMuayene.Click += new System.EventHandler(this.btnMuayene_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.Indigo;
            this.toolStripButton1.Image = global::Hastane.UI.Winform.Properties.Resources.Actions_bookmark_new_list_icon;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(269, 46);
            this.toolStripButton1.Text = "&Tamamlanmış Muayenelerim";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // lstSeans
            // 
            this.lstSeans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lstSeans.GridLines = true;
            this.lstSeans.Location = new System.Drawing.Point(39, 161);
            this.lstSeans.Margin = new System.Windows.Forms.Padding(4);
            this.lstSeans.Name = "lstSeans";
            this.lstSeans.Size = new System.Drawing.Size(739, 308);
            this.lstSeans.TabIndex = 7;
            this.lstSeans.UseCompatibleStateImageBehavior = false;
            this.lstSeans.View = System.Windows.Forms.View.Details;
            this.lstSeans.DoubleClick += new System.EventHandler(this.lstSeans_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Seans";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Randevu Tarihi";
            this.columnHeader3.Width = 195;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Detay ";
            this.columnHeader4.Width = 253;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(152, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Çalışılan Gün :";
            // 
            // dtpCalismaGunu
            // 
            this.dtpCalismaGunu.CustomFormat = "dd.MM.yyyy";
            this.dtpCalismaGunu.Enabled = false;
            this.dtpCalismaGunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalismaGunu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCalismaGunu.Location = new System.Drawing.Point(315, 86);
            this.dtpCalismaGunu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCalismaGunu.Name = "dtpCalismaGunu";
            this.dtpCalismaGunu.Size = new System.Drawing.Size(208, 24);
            this.dtpCalismaGunu.TabIndex = 5;
            this.dtpCalismaGunu.ValueChanged += new System.EventHandler(this.dtpCalismaGunu_ValueChanged);
            // 
            // lstMuayene
            // 
            this.lstMuayene.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstMuayene.GridLines = true;
            this.lstMuayene.Location = new System.Drawing.Point(39, 161);
            this.lstMuayene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMuayene.Name = "lstMuayene";
            this.lstMuayene.Size = new System.Drawing.Size(739, 308);
            this.lstMuayene.TabIndex = 8;
            this.lstMuayene.UseCompatibleStateImageBehavior = false;
            this.lstMuayene.View = System.Windows.Forms.View.Details;
            this.lstMuayene.Visible = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Seans No";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hasta Ad/Soyad";
            this.columnHeader5.Width = 146;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Randevu Tarihi";
            this.columnHeader6.Width = 220;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Randevu Saati";
            this.columnHeader7.Width = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(37, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Randevusu olan hastalar";
            // 
            // btnGunIlerle
            // 
            this.btnGunIlerle.BackColor = System.Drawing.Color.Transparent;
            this.btnGunIlerle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGunIlerle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunIlerle.ForeColor = System.Drawing.Color.Indigo;
            this.btnGunIlerle.Location = new System.Drawing.Point(591, 79);
            this.btnGunIlerle.Name = "btnGunIlerle";
            this.btnGunIlerle.Size = new System.Drawing.Size(160, 43);
            this.btnGunIlerle.TabIndex = 27;
            this.btnGunIlerle.Text = "Gün İlerle";
            this.btnGunIlerle.UseVisualStyleBackColor = false;
            this.btnGunIlerle.Click += new System.EventHandler(this.btnGunIlerle_Click);
            // 
            // frmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources.doktor;
            this.ClientSize = new System.Drawing.Size(820, 497);
            this.Controls.Add(this.btnGunIlerle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMuayene);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lstSeans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCalismaGunu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDoktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Muayene İşlem";
            this.Load += new System.EventHandler(this.frmDoktor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMuayene;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListView lstSeans;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCalismaGunu;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ListView lstMuayene;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGunIlerle;
    }
}


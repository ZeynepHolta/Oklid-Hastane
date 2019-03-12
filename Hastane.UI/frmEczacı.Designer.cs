namespace Hastane.UI
{
    partial class frmEczacı
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceteNo = new System.Windows.Forms.TextBox();
            this.lstRecete = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnİslem = new System.Windows.Forms.Button();
            this.btnGecmis = new System.Windows.Forms.Button();
            this.lstHastaGecmis = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 90);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta ilaç sorgulama sistemine hoşgeldiniz.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(137, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reçete Numarası :";
            // 
            // txtReceteNo
            // 
            this.txtReceteNo.Location = new System.Drawing.Point(339, 130);
            this.txtReceteNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReceteNo.Name = "txtReceteNo";
            this.txtReceteNo.Size = new System.Drawing.Size(233, 22);
            this.txtReceteNo.TabIndex = 2;
            // 
            // lstRecete
            // 
            this.lstRecete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstRecete.GridLines = true;
            this.lstRecete.Location = new System.Drawing.Point(44, 187);
            this.lstRecete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstRecete.Name = "lstRecete";
            this.lstRecete.Size = new System.Drawing.Size(528, 176);
            this.lstRecete.TabIndex = 3;
            this.lstRecete.UseCompatibleStateImageBehavior = false;
            this.lstRecete.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TCKN";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hasta Adı";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hasta Soyadı";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İlaçlar";
            this.columnHeader4.Width = 118;
            // 
            // btnİslem
            // 
            this.btnİslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİslem.ForeColor = System.Drawing.Color.Brown;
            this.btnİslem.Location = new System.Drawing.Point(455, 386);
            this.btnİslem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnİslem.Name = "btnİslem";
            this.btnİslem.Size = new System.Drawing.Size(119, 36);
            this.btnİslem.TabIndex = 4;
            this.btnİslem.Text = "İşlemi Bitir";
            this.btnİslem.UseVisualStyleBackColor = true;
            // 
            // btnGecmis
            // 
            this.btnGecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGecmis.ForeColor = System.Drawing.Color.Brown;
            this.btnGecmis.Location = new System.Drawing.Point(277, 386);
            this.btnGecmis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(148, 36);
            this.btnGecmis.TabIndex = 4;
            this.btnGecmis.Text = "Hasta Geçmişi";
            this.btnGecmis.UseVisualStyleBackColor = true;
            // 
            // lstHastaGecmis
            // 
            this.lstHastaGecmis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader7});
            this.lstHastaGecmis.GridLines = true;
            this.lstHastaGecmis.Location = new System.Drawing.Point(44, 474);
            this.lstHastaGecmis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstHastaGecmis.Name = "lstHastaGecmis";
            this.lstHastaGecmis.Size = new System.Drawing.Size(528, 219);
            this.lstHastaGecmis.TabIndex = 5;
            this.lstHastaGecmis.UseCompatibleStateImageBehavior = false;
            this.lstHastaGecmis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TCKN";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Reçete No";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "İlaçlar";
            this.columnHeader8.Width = 129;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tarih";
            this.columnHeader7.Width = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(40, 452);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta Geçmişi";
            // 
            // frmEczacı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(617, 709);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstHastaGecmis);
            this.Controls.Add(this.btnGecmis);
            this.Controls.Add(this.btnİslem);
            this.Controls.Add(this.lstRecete);
            this.Controls.Add(this.txtReceteNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEczacı";
            this.Text = "Eczacı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceteNo;
        private System.Windows.Forms.ListView lstRecete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnİslem;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.ListView lstHastaGecmis;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        protected System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label3;
    }
}
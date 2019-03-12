namespace Hastane.UI.Winform
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
            this.label3 = new System.Windows.Forms.Label();
            this.lstHastaGecmis = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGecmis = new System.Windows.Forms.Button();
            this.btnİslem = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstRecete = new System.Windows.Forms.ListView();
            this.txtReceteNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlReceteID = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlHasta = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHastaTCKN = new System.Windows.Forms.TextBox();
            this.rdbDetay = new System.Windows.Forms.RadioButton();
            this.rdbReceteler = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlReceteID.SuspendLayout();
            this.pnlHasta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasta Geçmişi";
            // 
            // lstHastaGecmis
            // 
            this.lstHastaGecmis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lstHastaGecmis.FullRowSelect = true;
            this.lstHastaGecmis.GridLines = true;
            this.lstHastaGecmis.Location = new System.Drawing.Point(11, 133);
            this.lstHastaGecmis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstHastaGecmis.Name = "lstHastaGecmis";
            this.lstHastaGecmis.Size = new System.Drawing.Size(625, 392);
            this.lstHastaGecmis.TabIndex = 13;
            this.lstHastaGecmis.UseCompatibleStateImageBehavior = false;
            this.lstHastaGecmis.View = System.Windows.Forms.View.Details;
            this.lstHastaGecmis.Click += new System.EventHandler(this.lstHastaGecmis_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Reçete No";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ad Soyad";
            this.columnHeader10.Width = 125;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tarih";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "İlaç Ayrıntısı";
            this.columnHeader12.Width = 80;
            // 
            // btnGecmis
            // 
            this.btnGecmis.BackColor = System.Drawing.Color.Transparent;
            this.btnGecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGecmis.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGecmis.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGecmis.Location = new System.Drawing.Point(439, 78);
            this.btnGecmis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(185, 34);
            this.btnGecmis.TabIndex = 11;
            this.btnGecmis.Text = "Geçmis Reçeteleri Göster";
            this.btnGecmis.UseVisualStyleBackColor = false;
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // btnİslem
            // 
            this.btnİslem.BackColor = System.Drawing.Color.Transparent;
            this.btnİslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİslem.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİslem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnİslem.Location = new System.Drawing.Point(441, 80);
            this.btnİslem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnİslem.Name = "btnİslem";
            this.btnİslem.Size = new System.Drawing.Size(185, 34);
            this.btnİslem.TabIndex = 22;
            this.btnİslem.Text = "Reçete Görüntüle";
            this.btnİslem.UseVisualStyleBackColor = false;
            this.btnİslem.Click += new System.EventHandler(this.btnİslem_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Açıklama";
            this.columnHeader4.Width = 172;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            this.columnHeader3.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İlaç Adı";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reçete No";
            this.columnHeader1.Width = 75;
            // 
            // lstRecete
            // 
            this.lstRecete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstRecete.GridLines = true;
            this.lstRecete.Location = new System.Drawing.Point(19, 135);
            this.lstRecete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstRecete.Name = "lstRecete";
            this.lstRecete.Size = new System.Drawing.Size(607, 389);
            this.lstRecete.TabIndex = 20;
            this.lstRecete.UseCompatibleStateImageBehavior = false;
            this.lstRecete.View = System.Windows.Forms.View.Details;
            // 
            // txtReceteNo
            // 
            this.txtReceteNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtReceteNo.Location = new System.Drawing.Point(409, 36);
            this.txtReceteNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReceteNo.Name = "txtReceteNo";
            this.txtReceteNo.Size = new System.Drawing.Size(216, 22);
            this.txtReceteNo.TabIndex = 23;
            this.txtReceteNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceteNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(204, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Reçete Numarası :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(121, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta ilaç sorgulama sistemine hosgeldiniz.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 90);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane.UI.Winform.Properties.Resources.hap2;
            this.pictureBox1.Location = new System.Drawing.Point(15, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlReceteID
            // 
            this.pnlReceteID.BackColor = System.Drawing.Color.Transparent;
            this.pnlReceteID.Controls.Add(this.label5);
            this.pnlReceteID.Controls.Add(this.label2);
            this.pnlReceteID.Controls.Add(this.txtReceteNo);
            this.pnlReceteID.Controls.Add(this.lstRecete);
            this.pnlReceteID.Controls.Add(this.btnİslem);
            this.pnlReceteID.Location = new System.Drawing.Point(13, 158);
            this.pnlReceteID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlReceteID.Name = "pnlReceteID";
            this.pnlReceteID.Size = new System.Drawing.Size(651, 537);
            this.pnlReceteID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(17, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Reçete Detayları";
            // 
            // pnlHasta
            // 
            this.pnlHasta.BackColor = System.Drawing.Color.Transparent;
            this.pnlHasta.Controls.Add(this.label4);
            this.pnlHasta.Controls.Add(this.txtHastaTCKN);
            this.pnlHasta.Controls.Add(this.btnGecmis);
            this.pnlHasta.Controls.Add(this.lstHastaGecmis);
            this.pnlHasta.Controls.Add(this.label3);
            this.pnlHasta.Location = new System.Drawing.Point(4, 158);
            this.pnlHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHasta.Name = "pnlHasta";
            this.pnlHasta.Size = new System.Drawing.Size(645, 534);
            this.pnlHasta.TabIndex = 16;
            this.pnlHasta.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(309, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "TCKN:";
            // 
            // txtHastaTCKN
            // 
            this.txtHastaTCKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaTCKN.ForeColor = System.Drawing.Color.DimGray;
            this.txtHastaTCKN.Location = new System.Drawing.Point(405, 33);
            this.txtHastaTCKN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaTCKN.MaxLength = 11;
            this.txtHastaTCKN.Name = "txtHastaTCKN";
            this.txtHastaTCKN.Size = new System.Drawing.Size(217, 23);
            this.txtHastaTCKN.TabIndex = 15;
            this.txtHastaTCKN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHastaTCKN_KeyPress);
            // 
            // rdbDetay
            // 
            this.rdbDetay.AutoSize = true;
            this.rdbDetay.BackColor = System.Drawing.Color.Transparent;
            this.rdbDetay.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDetay.ForeColor = System.Drawing.Color.Maroon;
            this.rdbDetay.Location = new System.Drawing.Point(336, 111);
            this.rdbDetay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDetay.Name = "rdbDetay";
            this.rdbDetay.Size = new System.Drawing.Size(156, 26);
            this.rdbDetay.TabIndex = 26;
            this.rdbDetay.TabStop = true;
            this.rdbDetay.Text = "Reçete Detayları";
            this.rdbDetay.UseVisualStyleBackColor = false;
            this.rdbDetay.CheckedChanged += new System.EventHandler(this.rdbDetay_CheckedChanged);
            // 
            // rdbReceteler
            // 
            this.rdbReceteler.AutoSize = true;
            this.rdbReceteler.BackColor = System.Drawing.Color.Transparent;
            this.rdbReceteler.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReceteler.ForeColor = System.Drawing.Color.Maroon;
            this.rdbReceteler.Location = new System.Drawing.Point(47, 111);
            this.rdbReceteler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbReceteler.Name = "rdbReceteler";
            this.rdbReceteler.Size = new System.Drawing.Size(241, 26);
            this.rdbReceteler.TabIndex = 25;
            this.rdbReceteler.TabStop = true;
            this.rdbReceteler.Text = "Hastanın Geçmis Reçeteleri";
            this.rdbReceteler.UseVisualStyleBackColor = false;
            this.rdbReceteler.CheckedChanged += new System.EventHandler(this.rdbReceteler_CheckedChanged);
            // 
            // frmEczacı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources.eczback;
            this.ClientSize = new System.Drawing.Size(665, 702);
            this.Controls.Add(this.rdbReceteler);
            this.Controls.Add(this.rdbDetay);
            this.Controls.Add(this.pnlHasta);
            this.Controls.Add(this.pnlReceteID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmEczacı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eczacı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEczacı_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlReceteID.ResumeLayout(false);
            this.pnlReceteID.PerformLayout();
            this.pnlHasta.ResumeLayout(false);
            this.pnlHasta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstHastaGecmis;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.Button btnİslem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstRecete;
        private System.Windows.Forms.TextBox txtReceteNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlReceteID;
        private System.Windows.Forms.Panel pnlHasta;
        private System.Windows.Forms.TextBox txtHastaTCKN;
        private System.Windows.Forms.RadioButton rdbDetay;
        private System.Windows.Forms.RadioButton rdbReceteler;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
namespace Hastane.UI.Winform
{
    partial class frmMain
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
            this.tsHasta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRandevuH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRandevularımH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDoktor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDoktorIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRandevuD = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRecete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMuayene = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEczacı = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIlac = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHasta,
            this.tsDoktor,
            this.tsEczacı});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsHasta
            // 
            this.tsHasta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRandevuH,
            this.tsRandevularımH});
            this.tsHasta.Name = "tsHasta";
            this.tsHasta.Size = new System.Drawing.Size(49, 20);
            this.tsHasta.Text = "Hasta";
            this.tsHasta.Click += new System.EventHandler(this.tsHasta_Click);
            // 
            // tsRandevuH
            // 
            this.tsRandevuH.Name = "tsRandevuH";
            this.tsRandevuH.Size = new System.Drawing.Size(180, 22);
            this.tsRandevuH.Text = "Randevu Al";
            this.tsRandevuH.Click += new System.EventHandler(this.tsRandevuH_Click);
            // 
            // tsRandevularımH
            // 
            this.tsRandevularımH.Name = "tsRandevularımH";
            this.tsRandevularımH.Size = new System.Drawing.Size(180, 22);
            this.tsRandevularımH.Text = "Randevularım";
            this.tsRandevularımH.Click += new System.EventHandler(this.tsRandevularımH_Click);
            // 
            // tsDoktor
            // 
            this.tsDoktor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDoktorIslem,
            this.tsRandevuD,
            this.tsRecete,
            this.tsMuayene});
            this.tsDoktor.Name = "tsDoktor";
            this.tsDoktor.Size = new System.Drawing.Size(55, 20);
            this.tsDoktor.Text = "Doktor";
            this.tsDoktor.Click += new System.EventHandler(this.tsDoktor_Click);
            // 
            // tsDoktorIslem
            // 
            this.tsDoktorIslem.Name = "tsDoktorIslem";
            this.tsDoktorIslem.Size = new System.Drawing.Size(180, 22);
            this.tsDoktorIslem.Text = "Hasta Kontrol";
            this.tsDoktorIslem.Click += new System.EventHandler(this.tsDoktorIslem_Click);
            // 
            // tsRandevuD
            // 
            this.tsRandevuD.Name = "tsRandevuD";
            this.tsRandevuD.Size = new System.Drawing.Size(180, 22);
            this.tsRandevuD.Text = "Randevu";
            this.tsRandevuD.Click += new System.EventHandler(this.tsRandevuD_Click);
            // 
            // tsRecete
            // 
            this.tsRecete.Name = "tsRecete";
            this.tsRecete.Size = new System.Drawing.Size(180, 22);
            this.tsRecete.Text = "Recete";
            this.tsRecete.Click += new System.EventHandler(this.tsRecete_Click);
            // 
            // tsMuayene
            // 
            this.tsMuayene.Name = "tsMuayene";
            this.tsMuayene.Size = new System.Drawing.Size(180, 22);
            this.tsMuayene.Text = "Muayene";
            this.tsMuayene.Click += new System.EventHandler(this.tsMuayene_Click);
            // 
            // tsEczacı
            // 
            this.tsEczacı.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIlac});
            this.tsEczacı.Name = "tsEczacı";
            this.tsEczacı.Size = new System.Drawing.Size(51, 20);
            this.tsEczacı.Text = "Eczacı";
            this.tsEczacı.Click += new System.EventHandler(this.tsEczacı_Click);
            // 
            // tsIlac
            // 
            this.tsIlac.Name = "tsIlac";
            this.tsIlac.Size = new System.Drawing.Size(180, 22);
            this.tsIlac.Text = "İlaç Takip";
            this.tsIlac.Click += new System.EventHandler(this.tsIlac_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsHasta;
        private System.Windows.Forms.ToolStripMenuItem tsRandevuH;
        private System.Windows.Forms.ToolStripMenuItem tsRandevularımH;
        private System.Windows.Forms.ToolStripMenuItem tsDoktor;
        private System.Windows.Forms.ToolStripMenuItem tsDoktorIslem;
        private System.Windows.Forms.ToolStripMenuItem tsRandevuD;
        private System.Windows.Forms.ToolStripMenuItem tsRecete;
        private System.Windows.Forms.ToolStripMenuItem tsMuayene;
        private System.Windows.Forms.ToolStripMenuItem tsEczacı;
        private System.Windows.Forms.ToolStripMenuItem tsIlac;
    }
}
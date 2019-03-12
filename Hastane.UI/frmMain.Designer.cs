namespace Hastane.UI
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
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eczacıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaToolStripMenuItem,
            this.doktorToolStripMenuItem,
            this.eczacıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuToolStripMenuItem1,
            this.randevularımToolStripMenuItem});
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.hastaToolStripMenuItem.Text = "Hasta";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuToolStripMenuItem,
            this.receteToolStripMenuItem,
            this.receteToolStripMenuItem1,
            this.muayeneToolStripMenuItem});
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.doktorToolStripMenuItem.Text = "Doktor";
            // 
            // eczacıToolStripMenuItem
            // 
            this.eczacıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçTakipToolStripMenuItem});
            this.eczacıToolStripMenuItem.Name = "eczacıToolStripMenuItem";
            this.eczacıToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.eczacıToolStripMenuItem.Text = "Eczacı";
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randevuToolStripMenuItem.Text = "Hasta Kontrol";
            // 
            // receteToolStripMenuItem
            // 
            this.receteToolStripMenuItem.Name = "receteToolStripMenuItem";
            this.receteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.receteToolStripMenuItem.Text = "Randevu";
            // 
            // receteToolStripMenuItem1
            // 
            this.receteToolStripMenuItem1.Name = "receteToolStripMenuItem1";
            this.receteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.receteToolStripMenuItem1.Text = "Recete";
            // 
            // muayeneToolStripMenuItem
            // 
            this.muayeneToolStripMenuItem.Name = "muayeneToolStripMenuItem";
            this.muayeneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.muayeneToolStripMenuItem.Text = "Muayene";
            // 
            // ilaçTakipToolStripMenuItem
            // 
            this.ilaçTakipToolStripMenuItem.Name = "ilaçTakipToolStripMenuItem";
            this.ilaçTakipToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ilaçTakipToolStripMenuItem.Text = "İlaç Takip";
            // 
            // randevuToolStripMenuItem1
            // 
            this.randevuToolStripMenuItem1.Name = "randevuToolStripMenuItem1";
            this.randevuToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.randevuToolStripMenuItem1.Text = "Randevu Al";
            // 
            // randevularımToolStripMenuItem
            // 
            this.randevularımToolStripMenuItem.Name = "randevularımToolStripMenuItem";
            this.randevularımToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randevularımToolStripMenuItem.Text = "Randevularım";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "AnaMenü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eczacıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem muayeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçTakipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem randevularımToolStripMenuItem;
    }
}
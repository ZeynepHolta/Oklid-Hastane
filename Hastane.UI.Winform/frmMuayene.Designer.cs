namespace Hastane.UI.Winform
{
    partial class frmMuayene
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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTeshis = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTahlil = new System.Windows.Forms.ListView();
            this.btnRecete = new System.Windows.Forms.Button();
            this.chkHastaOnay = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.btnBitir = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblRand = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Teşhis İsmi";
            this.columnHeader4.Width = 200;
            // 
            // lstTeshis
            // 
            this.lstTeshis.CheckBoxes = true;
            this.lstTeshis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lstTeshis.Location = new System.Drawing.Point(19, 65);
            this.lstTeshis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTeshis.Name = "lstTeshis";
            this.lstTeshis.Size = new System.Drawing.Size(239, 394);
            this.lstTeshis.TabIndex = 17;
            this.lstTeshis.UseCompatibleStateImageBehavior = false;
            this.lstTeshis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tahlil İsmi";
            this.columnHeader2.Width = 200;
            // 
            // lstTahlil
            // 
            this.lstTahlil.CheckBoxes = true;
            this.lstTahlil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lstTahlil.Location = new System.Drawing.Point(281, 65);
            this.lstTahlil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTahlil.Name = "lstTahlil";
            this.lstTahlil.Size = new System.Drawing.Size(239, 393);
            this.lstTahlil.TabIndex = 16;
            this.lstTahlil.UseCompatibleStateImageBehavior = false;
            this.lstTahlil.View = System.Windows.Forms.View.Details;
            // 
            // btnRecete
            // 
            this.btnRecete.BackColor = System.Drawing.Color.White;
            this.btnRecete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecete.ForeColor = System.Drawing.Color.Maroon;
            this.btnRecete.Location = new System.Drawing.Point(555, 422);
            this.btnRecete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecete.Name = "btnRecete";
            this.btnRecete.Size = new System.Drawing.Size(195, 38);
            this.btnRecete.TabIndex = 12;
            this.btnRecete.Text = "Recete Oluştur";
            this.btnRecete.UseVisualStyleBackColor = false;
            this.btnRecete.Click += new System.EventHandler(this.btnRecete_Click);
            // 
            // chkHastaOnay
            // 
            this.chkHastaOnay.AutoSize = true;
            this.chkHastaOnay.BackColor = System.Drawing.Color.Transparent;
            this.chkHastaOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHastaOnay.ForeColor = System.Drawing.Color.CadetBlue;
            this.chkHastaOnay.Location = new System.Drawing.Point(552, 383);
            this.chkHastaOnay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHastaOnay.Name = "chkHastaOnay";
            this.chkHastaOnay.Size = new System.Drawing.Size(306, 28);
            this.chkHastaOnay.TabIndex = 15;
            this.chkHastaOnay.Text = "Hasta randevuya gelmemiştir.";
            this.chkHastaOnay.UseVisualStyleBackColor = false;
            this.chkHastaOnay.CheckedChanged += new System.EventHandler(this.chkHastaOnay_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources.white;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 57);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hastane.UI.Winform.Properties.Resources.Clear_Tick_icon;
            this.pictureBox3.Location = new System.Drawing.Point(552, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hastane.UI.Winform.Properties.Resources.Test_tubes_icon;
            this.pictureBox2.Location = new System.Drawing.Point(281, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane.UI.Winform.Properties.Resources.stethoscope_icon;
            this.pictureBox1.Location = new System.Drawing.Point(21, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(119, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teşhis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(376, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahlil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(632, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genel Durum Muayene Notları ";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(552, 65);
            this.txtNot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(401, 222);
            this.txtNot.TabIndex = 11;
            this.txtNot.Text = "";
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.Color.White;
            this.btnBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitir.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBitir.Location = new System.Drawing.Point(757, 421);
            this.btnBitir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(197, 38);
            this.btnBitir.TabIndex = 18;
            this.btnBitir.Text = "Muayene Bitir";
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHasta.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblHasta.Location = new System.Drawing.Point(561, 345);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(0, 20);
            this.lblHasta.TabIndex = 19;
            // 
            // lblRand
            // 
            this.lblRand.AutoSize = true;
            this.lblRand.BackColor = System.Drawing.Color.Transparent;
            this.lblRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRand.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblRand.Location = new System.Drawing.Point(559, 302);
            this.lblRand.Name = "lblRand";
            this.lblRand.Size = new System.Drawing.Size(0, 20);
            this.lblRand.TabIndex = 19;
            // 
            // frmMuayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources.mbg;
            this.ClientSize = new System.Drawing.Size(999, 487);
            this.Controls.Add(this.lblRand);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.lstTeshis);
            this.Controls.Add(this.lstTahlil);
            this.Controls.Add(this.btnRecete);
            this.Controls.Add(this.chkHastaOnay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMuayene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuayeneIslem";
            this.Load += new System.EventHandler(this.frmMuayene_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lstTeshis;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstTahlil;
        private System.Windows.Forms.Button btnRecete;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkHastaOnay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblRand;
    }
}
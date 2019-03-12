namespace Hastane.UI
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
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkHastaOnay = new System.Windows.Forms.CheckBox();
            this.btnRecete = new System.Windows.Forms.Button();
            this.lstTahlil = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTeshis = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(352, 51);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(264, 181);
            this.txtNot.TabIndex = 1;
            this.txtNot.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teşhis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(256, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahlil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genel Durum Muayene Notları ";
            // 
            // btnRandevu
            // 
            this.btnRandevu.BackColor = System.Drawing.Color.White;
            this.btnRandevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandevu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRandevu.Location = new System.Drawing.Point(519, 294);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(97, 31);
            this.btnRandevu.TabIndex = 4;
            this.btnRandevu.Text = "Randevu Ver";
            this.btnRandevu.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 46);
            this.panel1.TabIndex = 5;
            // 
            // chkHastaOnay
            // 
            this.chkHastaOnay.AutoSize = true;
            this.chkHastaOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHastaOnay.ForeColor = System.Drawing.Color.CadetBlue;
            this.chkHastaOnay.Location = new System.Drawing.Point(376, 253);
            this.chkHastaOnay.Name = "chkHastaOnay";
            this.chkHastaOnay.Size = new System.Drawing.Size(192, 17);
            this.chkHastaOnay.TabIndex = 8;
            this.chkHastaOnay.Text = "Hasta randevuya gelmemiştir.";
            this.chkHastaOnay.UseVisualStyleBackColor = true;
            // 
            // btnRecete
            // 
            this.btnRecete.BackColor = System.Drawing.Color.White;
            this.btnRecete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRecete.Location = new System.Drawing.Point(397, 294);
            this.btnRecete.Name = "btnRecete";
            this.btnRecete.Size = new System.Drawing.Size(105, 31);
            this.btnRecete.TabIndex = 4;
            this.btnRecete.Text = "Recete Oluştur";
            this.btnRecete.UseVisualStyleBackColor = false;
            // 
            // lstTahlil
            // 
            this.lstTahlil.CheckBoxes = true;
            this.lstTahlil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstTahlil.Location = new System.Drawing.Point(182, 51);
            this.lstTahlil.Name = "lstTahlil";
            this.lstTahlil.Size = new System.Drawing.Size(136, 277);
            this.lstTahlil.TabIndex = 9;
            this.lstTahlil.UseCompatibleStateImageBehavior = false;
            this.lstTahlil.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tahlil İsmi";
            this.columnHeader2.Width = 104;
            // 
            // lstTeshis
            // 
            this.lstTeshis.CheckBoxes = true;
            this.lstTeshis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstTeshis.Location = new System.Drawing.Point(12, 51);
            this.lstTeshis.Name = "lstTeshis";
            this.lstTeshis.Size = new System.Drawing.Size(136, 277);
            this.lstTeshis.TabIndex = 10;
            this.lstTeshis.UseCompatibleStateImageBehavior = false;
            this.lstTeshis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 43;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Teşhis İsmi";
            this.columnHeader4.Width = 93;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(354, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(184, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMuayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(631, 337);
            this.Controls.Add(this.lstTeshis);
            this.Controls.Add(this.lstTahlil);
            this.Controls.Add(this.chkHastaOnay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRecete);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.txtNot);
            this.Name = "frmMuayene";
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
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkHastaOnay;
        private System.Windows.Forms.Button btnRecete;
        private System.Windows.Forms.ListView lstTahlil;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstTeshis;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
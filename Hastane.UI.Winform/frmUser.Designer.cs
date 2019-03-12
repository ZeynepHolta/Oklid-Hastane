namespace Hastane.UI.Winform
{
    partial class frmUser
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
            this.btnEczacı = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHasta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEczacı
            // 
            this.btnEczacı.BackColor = System.Drawing.Color.Transparent;
            this.btnEczacı.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources.ecza;
            this.btnEczacı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEczacı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEczacı.ForeColor = System.Drawing.Color.White;
            this.btnEczacı.Location = new System.Drawing.Point(887, 404);
            this.btnEczacı.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEczacı.Name = "btnEczacı";
            this.btnEczacı.Size = new System.Drawing.Size(132, 117);
            this.btnEczacı.TabIndex = 12;
            this.btnEczacı.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEczacı.UseVisualStyleBackColor = false;
            this.btnEczacı.Click += new System.EventHandler(this.btnEczacı_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(921, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasta";
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.Color.Transparent;
            this.btnDoktor.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources.People_Doctor_Male_icon;
            this.btnDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktor.ForeColor = System.Drawing.Color.White;
            this.btnDoktor.Location = new System.Drawing.Point(887, 223);
            this.btnDoktor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(132, 122);
            this.btnDoktor.TabIndex = 7;
            this.btnDoktor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoktor.UseVisualStyleBackColor = false;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(921, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Eczacı";
            // 
            // btnHasta
            // 
            this.btnHasta.BackColor = System.Drawing.Color.Transparent;
            this.btnHasta.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources._513ffab3035252039fe434a9c65aa092;
            this.btnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasta.ForeColor = System.Drawing.Color.White;
            this.btnHasta.Location = new System.Drawing.Point(887, 43);
            this.btnHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(132, 124);
            this.btnHasta.TabIndex = 8;
            this.btnHasta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHasta.UseVisualStyleBackColor = false;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(921, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Doktor";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources.s;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 551);
            this.Controls.Add(this.btnEczacı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHasta);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öklid Randevu Sistemi";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEczacı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Label label1;
    }
}
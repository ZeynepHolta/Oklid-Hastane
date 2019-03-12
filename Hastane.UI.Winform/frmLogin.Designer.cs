namespace Hastane.UI.Winform
{
    partial class frmLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.lblEMail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lnkRandevu = new System.Windows.Forms.LinkLabel();
            this.lnkYeniUye = new System.Windows.Forms.LinkLabel();
            this.lblGirisYapan = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources.logi;
            this.groupBox1.Controls.Add(this.txtCom);
            this.groupBox1.Controls.Add(this.lblEMail);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblKullanici);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(44, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(632, 279);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lütfen aşağıdaki alanları eksiksiz doldurunuz ";
            // 
            // txtCom
            // 
            this.txtCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCom.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtCom.Location = new System.Drawing.Point(443, 70);
            this.txtCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(153, 29);
            this.txtCom.TabIndex = 3;
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.BackColor = System.Drawing.Color.Transparent;
            this.lblEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMail.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblEMail.Location = new System.Drawing.Point(415, 74);
            this.lblEMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(30, 24);
            this.lblEMail.TabIndex = 10;
            this.lblEMail.Text = "@";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Hastane.UI.Winform.Properties.Resources.secrecy_icon;
            this.pictureBox1.Location = new System.Drawing.Point(84, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Teal;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogin.Location = new System.Drawing.Point(463, 208);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 43);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtEmail.Location = new System.Drawing.Point(245, 71);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 29);
            this.txtEmail.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSifre.Location = new System.Drawing.Point(245, 142);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(351, 29);
            this.txtSifre.TabIndex = 4;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Indigo;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(245, 70);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(351, 29);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblMail.Location = new System.Drawing.Point(140, 78);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(81, 24);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "E-Mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(156, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullanici.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblKullanici.Location = new System.Drawing.Point(84, 79);
            this.lblKullanici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(138, 24);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı Adı :";
            // 
            // lnkRandevu
            // 
            this.lnkRandevu.AutoSize = true;
            this.lnkRandevu.BackColor = System.Drawing.Color.Transparent;
            this.lnkRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRandevu.ForeColor = System.Drawing.Color.Indigo;
            this.lnkRandevu.LinkColor = System.Drawing.Color.Indigo;
            this.lnkRandevu.Location = new System.Drawing.Point(109, 271);
            this.lnkRandevu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRandevu.Name = "lnkRandevu";
            this.lnkRandevu.Size = new System.Drawing.Size(466, 31);
            this.lnkRandevu.TabIndex = 8;
            this.lnkRandevu.TabStop = true;
            this.lnkRandevu.Text = "Randevu almak için lütfen tıklayın !";
            this.lnkRandevu.VisitedLinkColor = System.Drawing.Color.CadetBlue;
            this.lnkRandevu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRandevu_LinkClicked);
            // 
            // lnkYeniUye
            // 
            this.lnkYeniUye.AutoSize = true;
            this.lnkYeniUye.BackColor = System.Drawing.Color.Transparent;
            this.lnkYeniUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkYeniUye.LinkColor = System.Drawing.Color.Purple;
            this.lnkYeniUye.Location = new System.Drawing.Point(577, 30);
            this.lnkYeniUye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkYeniUye.Name = "lnkYeniUye";
            this.lnkYeniUye.Size = new System.Drawing.Size(94, 26);
            this.lnkYeniUye.TabIndex = 7;
            this.lnkYeniUye.TabStop = true;
            this.lnkYeniUye.Text = "Üye ol !";
            this.lnkYeniUye.Visible = false;
            this.lnkYeniUye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYeniUye_LinkClicked);
            // 
            // lblGirisYapan
            // 
            this.lblGirisYapan.AutoSize = true;
            this.lblGirisYapan.BackColor = System.Drawing.Color.Transparent;
            this.lblGirisYapan.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYapan.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblGirisYapan.Location = new System.Drawing.Point(396, 208);
            this.lblGirisYapan.Name = "lblGirisYapan";
            this.lblGirisYapan.Size = new System.Drawing.Size(0, 41);
            this.lblGirisYapan.TabIndex = 9;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Hastane.UI.Winform.Properties.Resources.loghos;
            this.ClientSize = new System.Drawing.Size(725, 428);
            this.Controls.Add(this.lblGirisYapan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lnkYeniUye);
            this.Controls.Add(this.lnkRandevu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkRandevu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.LinkLabel lnkYeniUye;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblGirisYapan;
    }
}
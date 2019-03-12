using Hastane.BLL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.UI.Winform
{
    public partial class frmLogin : Form
    {

        Kullanicilar _kullanici;
        int tip;
        bool varMi = false;
        Hasta hasta;
        User user;
        LoginBLL _logBLL;
        HastaBLL _hastaBLL;

        public frmLogin(Kullanicilar kullanici)
        {
            InitializeComponent();

            _kullanici = kullanici;
            hasta = new Hasta();
            user = new User();
            _logBLL = new LoginBLL();
            _hastaBLL = new HastaBLL();
        }

        private void lnkRandevu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hasta acanHasta = new Hasta();
            acanHasta = _hastaBLL.GetHastaByID((int)lblGirisYapan.Tag);

            frmRandevu frm = new frmRandevu(acanHasta);
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            switch (_kullanici)
            {
                case Kullanicilar.Hasta:
                    tip = 1;
                    txtKullaniciAdi.Visible = false;
                    lblKullanici.Visible = false;
                    lnkRandevu.Visible = false;
                    lnkYeniUye.Visible = true;
                    break;
                case Kullanicilar.Eczaci:
                    tip = 3;
                    Unvisible();
                    break;
                case Kullanicilar.Doktor:
                    tip = 2;
                    Unvisible();
                    break;
                default:
                    break;
            }
        }

        private void Unvisible()
        {
            txtEmail.Visible = false;
            txtCom.Visible = false;
            lblMail.Visible = false;
            lblEMail.Visible = false;
            lnkRandevu.Visible = false;
            lnkYeniUye.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _sifre = txtSifre.Text; 
            string _kullaniciAdi;

            if (tip == 1)
            {
                lnkYeniUye.Visible = true;
                _kullaniciAdi = txtEmail.Text + "@" + txtCom.Text;
                HastaGirisFormuAc(_sifre, _kullaniciAdi);
            }
            else if (tip == 2)
            {
                _kullaniciAdi = txtKullaniciAdi.Text;
                DoktorIslemFormuAc(_sifre, _kullaniciAdi);
            }
            else if (tip == 3)
            {
                _kullaniciAdi = txtKullaniciAdi.Text;
                EczaciIslemFormuAc(_sifre, _kullaniciAdi);
            }
        }

        private void EczaciIslemFormuAc(string _sifre, string _kullaniciAdi)
        {
            varMi = _logBLL.KullaniciVarMi(_kullaniciAdi, _sifre, tip);
            if (varMi)
            {
                frmEczacı frm = new frmEczacı();
                frm.Owner = this;
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sistemde kaydınız yoktur.Lütfen gerekli birime durumu bildiriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DoktorIslemFormuAc(string _sifre, string _kullaniciAdi)
        {

            varMi = _logBLL.KullaniciVarMi(_kullaniciAdi, _sifre, tip);
            if (varMi)
            {
                frmDoktor frm = new frmDoktor(_logBLL.DoktoruGetir(_kullaniciAdi));
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sistemde kaydınız yoktur.Lütfen gerekli birime durumu bildiriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HastaGirisFormuAc(string _sifre, string _kullaniciAdi)
        {

            varMi = _logBLL.KullaniciVarMi(_kullaniciAdi, _sifre, tip);
            if (varMi)
            {
                lnkRandevu.Visible = true;
                groupBox1.Visible = false;
                hasta = _logBLL.HastayiGetir(_kullaniciAdi, tip);
                lblGirisYapan.Text = hasta.HastaAdSoyad;
                lblGirisYapan.Tag = hasta.HastaID;
                lnkYeniUye.Visible = false;
            }
            else
            {
                lnkYeniUye.Visible = true;
                MessageBox.Show("Sistemde kayıtlı değilsiniz.Lütfen üye olunuz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnkYeniUye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaUyelik frm = new frmHastaUyelik();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

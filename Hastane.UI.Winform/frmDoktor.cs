using Hastane.BLL;
using Hastane.DTO;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.UI.Winform
{
    public partial class frmDoktor : Form
    {
        Hasta hasta;
        Doktor _doktor;
        Seans _seans;
        SeansBLL _seansBLL;
        HastaBLL _hastaBLL;
        RandevuBLL _randevuBLL;
        List<Seans> seanslar;
        List<Randevu> randevular;
        RandevuSeansDTO _rsDTO;
        GununTarihiBLL _gununTarihiBLL;

        public frmDoktor(Doktor doktor)
        {
            InitializeComponent();

            _doktor = doktor;
            hasta = new Hasta();
            _seans = new Seans();
            _randevuBLL = new RandevuBLL();
            _seansBLL = new SeansBLL();
            _hastaBLL = new HastaBLL();
            randevular = new List<Randevu>();
            _rsDTO = new RandevuSeansDTO();
            _gununTarihiBLL = new GununTarihiBLL();
        }

        private void frmDoktor_Load(object sender, EventArgs e)
        {
            dtpCalismaGunu.MinDate = _gununTarihiBLL.GunGetir();
            dtpCalismaGunu.Value = _gununTarihiBLL.GunGetir();
            dtpCalismaGunu_ValueChanged(null, null);
            btnGunIlerle.Visible = true;
        }

        private void dtpCalismaGunu_ValueChanged(object sender, EventArgs e)
        {
            RandevuSeansDTO rsDTO = new RandevuSeansDTO();
            seanslar = new List<Seans>();
            string selectedDate = dtpCalismaGunu.Value.Date.ToString("yyyy-MM-dd");
            seanslar = _seansBLL.DoktorunDoluSeanslari(_doktor.DoktorID, selectedDate);
            randevular = _randevuBLL.DoktorunYapilmamisMuayeneleri();
            lstSeans.Items.Clear();
            ListViewItem lvi;
            rsDTO.Randevular = randevular;
            rsDTO.Seanslar = seanslar;

            foreach (Seans item in rsDTO.Seanslar)
            {
                foreach (Randevu rand in rsDTO.Randevular)
                {
                    if (item.SeansID == rand.SeansID)
                    {
                        lvi = new ListViewItem();
                        lvi.Text = item.SeansSaati.ToString();
                        lvi.SubItems.Add(item.Tarih.ToShortDateString());
                        lvi.SubItems.Add("Detay için tıklayınız");
                        lvi.Tag = item.SeansID;
                        lstSeans.Items.Add(lvi);
                    }
                }
            }
        }

        private void lstSeans_DoubleClick(object sender, EventArgs e)
        {
            if (lstSeans.SelectedItems.Count > 0)
            {
                _seans = _seansBLL.SeansinDetaylariniGetir((int)lstSeans.SelectedItems[0].Tag);
                Randevu randevu = _randevuBLL.GetBySeanceID(_seans.SeansID);
                Hasta hastamiz = _hastaBLL.GetHastaByID(randevu.HastaID);
                frmMuayene frmMuayene = new frmMuayene(hastamiz, randevu);
                frmMuayene.Owner = this;
                frmMuayene.ShowDialog();
                dtpCalismaGunu_ValueChanged(null, null);
            }
            else
            {
                MessageBox.Show("Listenizde seçili randevu bulunmamaktadır !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dtpCalismaGunu.Visible = false;
            label1.Visible = false;
            lstMuayene.Visible = true;
            lstSeans.Visible = false;
            btnGunIlerle.Visible = false;

            randevular = _randevuBLL.DoktorunYapilmisMuayeneleri();
            lstMuayene.Items.Clear();
            ListViewItem lvi;

            foreach (Randevu rand in randevular)
            {
                if ((int)_seansBLL.GetDoktorIDBySeansID(rand.SeansID)==_doktor.DoktorID)
                {
                    lvi = new ListViewItem();
                    lvi.Text = rand.RandevuID.ToString();
                    lvi.SubItems.Add(_hastaBLL.GetHastaByID(rand.HastaID).HastaAdSoyad);
                    lvi.SubItems.Add(_seansBLL.SeansinDetaylariniGetir(rand.SeansID).Tarih.ToShortDateString());
                    lvi.SubItems.Add(_seansBLL.SeansinDetaylariniGetir(rand.SeansID).SeansSaati.ToString());
                    lvi.Tag = rand.RandevuID;
                    lstMuayene.Items.Add(lvi);
                }
            }
        }

        private void btnMuayene_Click(object sender, EventArgs e)
        {
            dtpCalismaGunu.Visible = true;
            btnGunIlerle.Visible = true;
            label1.Visible = true;
            lstMuayene.Visible = false;
            lstSeans.Visible = true;
        }

        private void btnGunIlerle_Click(object sender, EventArgs e)
        {
            _gununTarihiBLL.GunEkle();
            dtpCalismaGunu.MinDate = _gununTarihiBLL.GunGetir();
            dtpCalismaGunu.Value = _gununTarihiBLL.GunGetir();
            dtpCalismaGunu_ValueChanged(null, null);
        }
    }
}

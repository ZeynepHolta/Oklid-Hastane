using Hastane.BLL;
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
    public partial class frmHastaRandevularım : Form
    {
        Hasta _hasta;
        RandevuBLL _randevuBLL;
        SeansBLL _seansBLL;
        DoktorBLL _doktorBLL;
        HastaneBLL _hastaneBLL;
        DepartmanBLL _departmanBLL;
        
        public frmHastaRandevularım(Hasta hasta)
        {
            InitializeComponent();

            _hasta = new Hasta();
            _hasta = hasta;
            _randevuBLL = new RandevuBLL();
            _seansBLL = new SeansBLL();
            _doktorBLL = new DoktorBLL();
            _hastaneBLL = new HastaneBLL();
            _departmanBLL = new DepartmanBLL();
        }

        private void frmHastaRandevularım_Load(object sender, EventArgs e)
        {
            RandevulariListele();
        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            frmRandevu frm = new frmRandevu(_hasta);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int randevuID = (int)lstRandevularım.SelectedItems[0].Tag;
                Randevu randevu = _randevuBLL.GetByID(randevuID);
                _randevuBLL.Delete(randevu);
                MessageBox.Show("Randevu başarıyla silindi.");
                RandevulariListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir randevu seçiniz.");
            }
        }

        void RandevulariListele()
        {
            List<Randevu>  randevular = _randevuBLL.GetHastaGelecekRandevular(_hasta.HastaID);
            lstRandevularım.Items.Clear();
            ListViewItem lvi;
            int doktorID;
            Doktor doktor;
            Seans seans;
            foreach (Randevu rnd in randevular)
            {
                seans = _seansBLL.SeansinDetaylariniGetir(rnd.SeansID);
                doktorID = _seansBLL.GetDoktorIDBySeansID(rnd.SeansID);
                doktor = _doktorBLL.GetDoktorByID(doktorID);

                lvi = new ListViewItem();
                lvi.Tag = rnd.RandevuID;
                lvi.Text = doktor.DoktorAdSoyad;
                lvi.SubItems.Add(seans.Tarih.ToShortDateString());
                lvi.SubItems.Add(seans.SeansSaati);
                lvi.SubItems.Add(_hastaneBLL.GetHastaneByID(doktor.HastaneID).Ad);
                lvi.SubItems.Add(_departmanBLL.GetByID(doktor.DepartmanID).Ad);

                lstRandevularım.Items.Add(lvi);
            }
        }
    }
}

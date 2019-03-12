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
    public partial class frmMuayene : Form
    {
        TeshisBLL _teshisBLL;
        TahlilBLL _tahlilBLL;
        RandevuBLL _randevuBLL;
        Hasta _hasta;
        Randevu _randevu;
        bool geldiMi = true;
        RandevuTeshisBLL _rtBLL;
        RandevuTahlilBLL _rtahlilBLL;
        SeansBLL _seansBLL;
        HastaBLL _hastaBLL;
        DoktorBLL _doktorBLL;

        public frmMuayene(Hasta hasta, Randevu randevu)
        {
            InitializeComponent();
            _teshisBLL = new TeshisBLL();
            _tahlilBLL = new TahlilBLL();
            _randevuBLL = new RandevuBLL();
            _rtBLL = new RandevuTeshisBLL();
            _hastaBLL = new HastaBLL();
            _rtahlilBLL = new RandevuTahlilBLL();
            _hasta = hasta;
            _randevu = randevu;
            _seansBLL = new SeansBLL();
            _doktorBLL = new DoktorBLL();
        }

        private void frmMuayene_Load(object sender, EventArgs e)
        {
            lblHasta.Text = "İlgilendiğiniz hasta:" + _hasta.HastaAdSoyad;
            lblHasta.Tag = _hasta.HastaID;
            lblRand.Text = "Randevu No:" + _randevu.RandevuID;
            lblRand.Tag = _randevu.RandevuID;
            TeshisGetir();
            TahlilGetir();
        }

        public void TahlilGetir()
        {
            try
            {
                ListViewItem lvi;
                foreach (Tahlil item in _tahlilBLL.GetTahlil())
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.Ad;
                    lvi.Tag = item.TahlilID;
                    lstTahlil.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public void TeshisGetir()
        {
            try
            {
                ListViewItem lvi;
                foreach (Teshis item in _teshisBLL.GetTeshis())
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.Aciklama;
                    lvi.Tag = item.TeshisID;
                    lstTeshis.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (!geldiMi)
            {
                MessageBox.Show("Hasta randevuya gelmedi olarak kaydedilmiştir.");
            }
            else if (!TeshisSecildiMi() && !TahlilSecildiMi())
            {
                MessageBox.Show("Teşhis koyamadıysanız tahlil seçmelisiniz.");
                return;
            }
            else
            {
                TeshisleriKaydet();
                TahlilleriKaydet();
                _randevuBLL.UpdateMuayene(_randevu.RandevuID);

                if (TahlilSecildiMi())
                {
                    MessageBox.Show("Tahlil eklediniz. Randevu sayfasına yönlendiriliyorsunuz.");
                    RandevuFormuAc();
                }
            }
            this.Close();
        }

        private void RandevuFormuAc()
        {
            frmRandevu frm = new frmRandevu(_hastaBLL.GetHastaByID((int)lblHasta.Tag));
            frm.btnRandevular.Visible = false;
            frm.Owner = this.Owner;  
            frm.ShowDialog();
        }

        private void TahlilleriKaydet()
        {
            List<Tahlil> tahliller = new List<Tahlil>();
            foreach (ListViewItem item in lstTahlil.CheckedItems)
            {
                tahliller.Add(_tahlilBLL.GetTahlilByID((int)item.Tag));
            }
            if (tahliller.Count > 0)
            {
                RandevuTahlilDTO randevuTahlil = new RandevuTahlilDTO();
                randevuTahlil.Randevu = _randevu;
                randevuTahlil.Tahliller = tahliller;
                _rtahlilBLL.Add(randevuTahlil);
            }
        }

        private void TeshisleriKaydet()
        {
            List<Teshis> teshisler = new List<Teshis>();
            foreach (ListViewItem item in lstTeshis.CheckedItems)
            {
                teshisler.Add(_teshisBLL.GetTeshisByID((int)item.Tag));
            }
            if (teshisler.Count > 0)
            {
                RandevuTeshisDTO randevuTeshis = new RandevuTeshisDTO();
                randevuTeshis.Randevu = _randevu;
                randevuTeshis.Teshisler = teshisler;
                _rtBLL.Add(randevuTeshis);
            }
        }

        public bool TeshisSecildiMi()
        {
            return lstTeshis.CheckedItems.Count > 0;
        }

        private bool TahlilSecildiMi()
        {
            return lstTahlil.CheckedItems.Count > 0;
        }

        private void chkHastaOnay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHastaOnay.Checked)
            {
                geldiMi = false;
            }
            else
            {
                geldiMi = true;
            }
        }

        private void btnRecete_Click(object sender, EventArgs e)
        {
            int doktorID = _seansBLL.GetDoktorIDBySeansID(_randevu.SeansID);
            Doktor doktor = _doktorBLL.GetDoktorByID(doktorID);

            frmDoktorRecete frmRecete = new frmDoktorRecete(_hasta, doktor);
            frmRecete.Owner = this;
            DialogResult dr = frmRecete.ShowDialog();

            if (dr == DialogResult.Yes)
            {
                chkHastaOnay.Enabled = false;
            }
        }
    }
}

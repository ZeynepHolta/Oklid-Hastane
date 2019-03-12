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
    public partial class frmRandevu : Form
    {
        List<Hastahane> hastaneler;
        List<Departman> departmanlar;
        List<Doktor> doktorlar;
        HastaneBLL _hastaneBLL;
        DepartmanBLL _depBLL;
        DoktorBLL _dokBLL;
        SeansBLL _seansBLL;
        HastaBLL _hastaBLL;
        RandevuBLL _randevuBLL;
        Hasta hasta;
        List<HastaneDepDTO> hdDTO;
        GununTarihiBLL _gununTarihiBLL;
        int seciliDoktorID;

        public frmRandevu(Hasta _hasta)
        {
            InitializeComponent();
            _hastaneBLL = new HastaneBLL();
            hdDTO = new List<HastaneDepDTO>();
            _depBLL = new DepartmanBLL();
            _dokBLL = new DoktorBLL();
            _seansBLL = new SeansBLL();
            _hastaBLL = new HastaBLL();
            _randevuBLL = new RandevuBLL();
            _gununTarihiBLL = new GununTarihiBLL();
            hasta = new Hasta();
            hasta = _hasta;
            hastaneler = _hastaneBLL.GetHastaneler();
            departmanlar = _depBLL.GetDepartmanlar();
        }

        private void frmRandevu_Load(object sender, EventArgs e)
        {
            lblAd.Text = hasta.HastaAdSoyad;
            lblAd.Tag = hasta.HastaID;
            rdbHastane.Checked = true;
            cmbBolum.Enabled = false;
            dtpTarih.MinDate = _gununTarihiBLL.GunGetir();
        }

        private void rdbHastane_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHastane.Checked)
            {
                cmbHastane.Enabled = true;
                cmbHastane.DisplayMember = "Ad";
                cmbHastane.ValueMember = "HastaneID";
                cmbHastane.DataSource = hastaneler;
                cmbHastane.Text = "Hastane seçiniz";
                cmbBolum.Enabled = false;
            }
            else
            {
                cmbBolum.Enabled = true;
                cmbBolum.DisplayMember = "Ad";
                cmbBolum.ValueMember = "DepartmanID";
                cmbBolum.DataSource = departmanlar;
                cmbBolum.Text = "Bir bölüm seçiniz.";
                cmbHastane.Enabled = false;
            }
            cmbDoktor.Enabled = false;
            dtpTarih.Enabled = false;
            lstSeans.Enabled = false;
        }

        private void cmbHastane_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbHastane.SelectedIndex < 0)
            {
                return;
            }
            lstSeans.Items.Clear();
            cmbBolum.Enabled = true;
            List<Departman> hastanDept = _depBLL.DepartmanlariGetir((int)cmbHastane.SelectedValue);
            cmbBolum.DisplayMember = "Ad";
            cmbBolum.ValueMember = "DepartmanID";
            cmbBolum.DataSource = hastanDept;
            cmbBolum.Text = "Bir bölüm seçiniz";
            cmbDoktor.Enabled = false;
            dtpTarih.Enabled = false;
            lstSeans.Enabled = false;
        }

        private void cmbBolum_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBolum.SelectedIndex < 0)
            {
                return;
            }
            lstSeans.Items.Clear();
            cmbDoktor.Enabled = true;
            if (rdbHastane.Checked)
            {
                doktorlar = _dokBLL.SeciliDoktorlarıGetir((int)cmbBolum.SelectedValue, (int)cmbHastane.SelectedValue);
            }
            else
            {
                doktorlar = _dokBLL.DepartmanaGoreDoktorGetir((int)cmbBolum.SelectedValue);
            }
            cmbDoktor.DisplayMember = "DoktorAdSoyad";
            cmbDoktor.ValueMember = "DoktorID";
            cmbDoktor.DataSource = doktorlar;
            cmbDoktor.Text = "Doktor seçiniz";
            dtpTarih.Enabled = false;
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            if (cmbDoktor.SelectedIndex < 0)
            {
                return;
            }

            lstSeans.Items.Clear();
            lstSeans.Enabled = true;
            DateTime selectedDate = dtpTarih.Value;
            _seansBLL.AddTekGunSeanslari(seciliDoktorID, selectedDate);
            List<Seans> seanslar = _seansBLL.GetGunSeanslari(seciliDoktorID, selectedDate);
            if (seanslar.Count == 0)
            {
                lstSeans.Enabled = false;
                lblSeans.ForeColor = Color.Red;
                lblSeans.Text = "Seçilen tarihte seçilen doktorun boş seansı kalmamıştır!";
            }
            else
            {

                ListViewItem lvi;
                foreach (Seans seans in seanslar)
                {
                    lvi = new ListViewItem();
                    lvi.Tag = seans.SeansID;
                    lvi.Text = seans.SeansSaati;
                    lvi.SubItems.Add(seans.BosMu ? "Boş" : "Dolu");
                    lvi.SubItems[0].ForeColor = (seans.BosMu ? Color.Green : Color.Red);
                    lvi.SubItems.Add(seans.Tarih.ToShortDateString());
                    lstSeans.Items.Add(lvi);
                }
            }
        }

        private void cmbDoktor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                seciliDoktorID = (int)cmbDoktor.SelectedValue;
                dtpTarih.Enabled = true;
                dtpTarih_ValueChanged(null, null);
                lstSeans.Enabled = true;
            }
            catch
            {
            }
        }

        private void btnRandevular_Click(object sender, EventArgs e)
        {
            frmHastaRandevularım frm = new frmHastaRandevularım(_hastaBLL.GetHastaByID((int)lblAd.Tag));
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            //ListViewItem selectedLvi = new ListViewItem();
            ListViewItem selectedLvi;
            try
            {
                selectedLvi = lstSeans.SelectedItems[0];
                if (selectedLvi.SubItems[1].Text == "Dolu")
                {
                    MessageBox.Show("Lütfen boş bir seans seçiniz.");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen bir seans seçiniz.");
                return;
            }

            try
            {
                RandevuDTO randevu = new RandevuDTO();
                randevu.HastaID = hasta.HastaID;
                randevu.SeansID = (int)selectedLvi.Tag;
                _randevuBLL.Add(randevu);

                MessageBox.Show("Randevunuz başarıyla eklenmiştir.");
                dtpTarih_ValueChanged(null, null);

            }
            catch (HastaGunDepartmanAyniOlamaz ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

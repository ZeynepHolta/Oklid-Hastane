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
    public partial class frmDoktorRecete : Form
    {
        IlacBLL _ilacBLL;
        ReceteBLL _receteBLL;
        Hasta _hasta;
        Doktor _doktor;
        List<ReceteDetay> _eklenenIlacBilgileri;
        GununTarihiBLL _gununTarihiBLL;
        bool receteOlusturuldu = false;

        public frmDoktorRecete(Hasta hasta, Doktor doktor)
        {
            InitializeComponent();
            _ilacBLL = new IlacBLL();
            _receteBLL = new ReceteBLL();
            _gununTarihiBLL = new GununTarihiBLL();
            _hasta = hasta;
            _doktor = doktor;
            _eklenenIlacBilgileri = new List<ReceteDetay>();
        }

        private void frmDoktorRecete_Load(object sender, EventArgs e)
        {
            List<Ilac> tumIlaclar = _ilacBLL.GetIlaclar();
            cmbIlac.DisplayMember = "IlacAdi";
            cmbIlac.ValueMember = "IlacID";
            cmbIlac.DataSource = tumIlaclar;
            txtTCKN.Text = _hasta.TCKN;
            txtHastaAdSoyad.Text = _hasta.HastaAdSoyad;
            dtpTarih.Value = _gununTarihiBLL.GunGetir();
        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            if (ChecksIlacEkle())
            {
                Ilac ilac = (Ilac)cmbIlac.SelectedItem;

                ReceteDetay receteDetay = new ReceteDetay();
                receteDetay.IlacID = ilac.IlacID;
                receteDetay.Adet = (int)nudAdet.Value;
                receteDetay.Aciklama = txtAciklama.Text;

                _eklenenIlacBilgileri.Add(receteDetay);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = ilac.IlacAdi;
                lvi.Tag = receteDetay;
                lvi.SubItems.Add(receteDetay.Adet.ToString());
                lvi.SubItems.Add(receteDetay.Aciklama.ToString());

                lstIlac.Items.Add(lvi);
            }
        }

        bool ChecksIlacEkle()
        {
            bool returnValue = true;
            string message = "";

            if (cmbIlac.SelectedIndex < 0)
            {
                returnValue = false;
                message += "Lütfen ilaç seçiniz!\n";
            }
            else if (EklendiMi((Ilac)cmbIlac.SelectedItem))
            {
                returnValue = false;
                message += "Bu ilacı daha önce eklediniz!\n";
            }
            if (nudAdet.Value == 0)
            {
                returnValue = false;
                message += "Lütfen en az bir adet giriniz!\n";
            }
            if (string.IsNullOrWhiteSpace(txtAciklama.Text))
            {
                returnValue = false;
                message += "Lütfen ilaç için açıklama girin!";
            }

            if (!returnValue)
            {
                MessageBox.Show(message);
            }

            return returnValue;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstIlac.SelectedItems.Count < 0)
            {
                MessageBox.Show("Lütfen silinecek ilacı seçiniz!");
                return;
            }

            ListViewItem lvi = lstIlac.SelectedItems[0];
            lstIlac.Items.Remove(lvi);
            _eklenenIlacBilgileri.Remove((ReceteDetay)lvi.Tag);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstIlac.Items.Count == 0)
            {
                MessageBox.Show("Lütfen ilaç ekleyiniz");
                return;
            }

            Recete recete = new Recete();
            recete.DoktorID = _doktor.DoktorID;
            recete.HastaID = _hasta.HastaID;
            recete.Tarih = dtpTarih.Value.Date;

            try
            {
                _receteBLL.Add(recete, _eklenenIlacBilgileri);
                MessageBox.Show("Reçete kaydedilmiştir.");
                receteOlusturuldu = true;
                this.Close();
            }
            catch (ReceteZatenEklendi ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool EklendiMi(Ilac ilac)
        {
            foreach (ReceteDetay detay in _eklenenIlacBilgileri)
            {
                if (detay.IlacID == ilac.IlacID)
                {
                    return true;
                }
            }

            return false;
        }

        private void frmDoktorRecete_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = receteOlusturuldu ? DialogResult.Yes : DialogResult.No;
        }
    }
}

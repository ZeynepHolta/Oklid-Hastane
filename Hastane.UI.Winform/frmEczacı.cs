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
    public partial class frmEczacı : Form
    {
        ReceteBLL _receteBLL;
        HastaBLL _hastaBLL;
        List<ReceteDTO> hastaninReceteleri;
        public frmEczacı()
        {
            InitializeComponent();

            _receteBLL = new ReceteBLL();
            _hastaBLL = new HastaBLL();
            hastaninReceteleri = new List<ReceteDTO>();
        }

        private void rdbDetay_CheckedChanged(object sender, EventArgs e)
        {
            pnlHasta.Visible = false;
            pnlReceteID.Visible = true;
        }

        private void rdbReceteler_CheckedChanged(object sender, EventArgs e)
        {
            pnlHasta.Visible = true;
            pnlReceteID.Visible = false;
        }

        private void btnİslem_Click(object sender, EventArgs e)
        {
            lstRecete.Items.Clear();
            List<ReceteDetayDTO> detay = _receteBLL.ButunVerileriGetir(int.Parse(txtReceteNo.Text));

            ListViewItem lvi;

            foreach (ReceteDetayDTO item in detay)
            {
                lvi = new ListViewItem();
                lvi.Text = item.ReceteDetay.ReceteID.ToString();
                lvi.SubItems.Add(item.Ilac.IlacAdi);
                lvi.SubItems.Add(item.ReceteDetay.Adet.ToString());
                lvi.SubItems.Add(item.ReceteDetay.Aciklama);
                lvi.Tag = item.Ilac.IlacID;
                lstRecete.Items.Add(lvi);
            }

            DoluBosYakala();
        }

        private void DoluBosYakala()
        {
            if (lstRecete.Items.Count <= 0)
            {
                MessageBox.Show("Böyle bir reçete bulunmamaktadır !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            try
            {
                Hasta hasta = new Hasta();

                hasta = _hastaBLL.GetHastaByTCKN(txtHastaTCKN.Text);
                hastaninReceteleri = _receteBLL.ButunReceteVerileriniGetir(hasta.HastaID);
                lstHastaGecmis.Items.Clear();

                ListViewItem lvi;

                foreach (ReceteDTO item in hastaninReceteleri)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.Recete.ReceteID.ToString();
                    lvi.SubItems.Add(item.Hasta.HastaAdSoyad);
                    lvi.SubItems.Add(item.Recete.Tarih.ToShortDateString());
                    lvi.SubItems.Add("Detay için tıklayınız");
                    lvi.Tag = item.Recete.ReceteID;
                    lstHastaGecmis.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void frmEczacı_Load(object sender, EventArgs e)
        {
            rdbReceteler.Checked = true;
        }

        private void lstHastaGecmis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHastaTCKN.Text))
            {
                MessageBox.Show("Lütfen bir kimlik numarası giriniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ReceteDetayDTO> detay = _receteBLL.ButunVerileriGetir((int)lstHastaGecmis.SelectedItems[0].Tag);

            ReceteDetayGoster(detay);
        }

        private static void ReceteDetayGoster(List<ReceteDetayDTO> detay)
        {
            string receteDetayMetni = string.Empty;

            foreach (ReceteDetayDTO item in detay)
            {
                receteDetayMetni += item.Ilac.IlacAdi + " --> " + item.ReceteDetay.Adet + "tane --> Kullanım şekli: " + item.ReceteDetay.Aciklama + "\n";
            }
            MessageBox.Show(receteDetayMetni);
        }

        private void txtHastaTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtReceteNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void frmEczacı_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}

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
    public partial class frmHastaUyelik : Form
    {
        HastaBLL _hastaBLL;
        HastaKayitDTO _hkDTO;
        public frmHastaUyelik()
        {
            InitializeComponent();
            _hastaBLL = new HastaBLL();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            bool check = false;
            

            try
            {
                
                if (NullorEmpty(txtTckn.Text, txtSoyad.Text, txtAd.Text, txtEmail.Text, txtCom.Text, txtSifre.Text, txtSifreTekrar.Text))
                {
                    if (txtTckn.Text.Length != 11)
                    {
                        MessageBox.Show("TC 11 haneli olmalıdır.");
                        return;
                    }
                    if (txtSifre.Text != txtSifreTekrar.Text)
                    {
                        MessageBox.Show("Şifreler uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    _hastaBLL.CheckSifreGecerliMi(txtSifre.Text);
                    _hkDTO = new HastaKayitDTO(txtTckn.Text, txtAd.Text, txtSoyad.Text, txtEmail.Text + "@" + txtCom.Text, txtSifre.Text);
                    check = _hastaBLL.Add(_hkDTO);

                    if (check)
                    {
                        MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Boş alan geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }



        }

        private void txtTckn_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        bool NullorEmpty(params string[] text)
        {
            foreach (string item in text)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

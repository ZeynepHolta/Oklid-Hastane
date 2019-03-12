using Hastane.BLL;
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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin(Kullanicilar.Doktor);
            frm.Owner = this;
            this.Hide();
            frm.ShowDialog();
            
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin(Kullanicilar.Hasta);
            frm.Owner = this;
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEczacı_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin(Kullanicilar.Eczaci);
            frm.Owner = this;
            this.Hide();
            frm.ShowDialog();

        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }
    }
}

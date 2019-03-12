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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void tsHasta_Click(object sender, EventArgs e)
        {
            if (true)
            {
                tsDoktor.Enabled = false;
                tsEczacı.Enabled = false;
            }
        }

        private void tsDoktor_Click(object sender, EventArgs e)
        {
            if (true)
            {
                tsHasta.Enabled = false;
                tsEczacı.Enabled = false;
            }
        }

        private void tsEczacı_Click(object sender, EventArgs e)
        {
            if (true)
            {
                tsDoktor.Enabled = false;
                tsHasta.Enabled = false;
            }
        }

        private void tsRandevuH_Click(object sender, EventArgs e)
        {
            //frmRandevu frm = new frmRandevu();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void tsRandevularımH_Click(object sender, EventArgs e)
        {
            //frmHastaRandevularım frm = new frmHastaRandevularım();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void tsDoktorIslem_Click(object sender, EventArgs e)
        {
            //frmDoktor frm = new frmDoktor();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void tsRandevuD_Click(object sender, EventArgs e)
        {
            //frmRandevu frm = new frmRandevu();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void tsRecete_Click(object sender, EventArgs e)
        {
            //frmDoktorRecete frm = new frmDoktorRecete();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void tsMuayene_Click(object sender, EventArgs e)
        {
        //    frmMuayene frm = new frmMuayene();
        //    frm.MdiParent = this;
        //    frm.Show();
        }

        private void tsIlac_Click(object sender, EventArgs e)
        {
            //frmEczacı frm = new frmEczacı();
            //frm.MdiParent = this;
            //frm.Show();
        }
    }
}

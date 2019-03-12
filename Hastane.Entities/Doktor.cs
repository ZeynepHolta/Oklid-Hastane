using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    public class Doktor
    {
        public int DoktorID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string DoktorAdSoyad
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }

        //public string KullaniciAdi { get; set; }

        //public string Sifre  { get; set; }

        public int DepartmanID { get; set; }

        public int HastaneID { get; set; }

        public int UserID { get; set; }

    }
}

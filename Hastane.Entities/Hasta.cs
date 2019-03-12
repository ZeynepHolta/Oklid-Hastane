using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    public class Hasta
    {
        public int HastaID { get; set; }

        public string TCKN { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        //public string Email { get; set; }

        //public string Sifre { get; set; }
        public string HastaAdSoyad
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }

        public int UserID { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad; 
        }
    }
}

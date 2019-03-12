using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
   public class Eczaci
    {

        public int EczaciID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        // public string KullaniciAdi { get; set; }

        // public string Sifre { get; set; }
        public int UserID { get; set; }
    }
}

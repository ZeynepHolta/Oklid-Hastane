using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public int Tip { get; set; }
    }
}

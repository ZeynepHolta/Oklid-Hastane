using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    public class Randevu
    {
        public int RandevuID { get; set; }
        public int HastaID { get; set; }
        public int  SeansID { get; set; }
        public bool MuayeneYapildiMi { get; set; }
        public string Notlar { get; set; }

    }
}

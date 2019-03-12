using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    public class ReceteDetay
    {
        public int ReceteID { get; set; }

        public int IlacID { get; set; }

        public int Adet { get; set; }

        public string Aciklama { get; set; }

    }
}

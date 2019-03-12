using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    public class Recete
    {
        public int ReceteID { get; set; }

        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public DateTime Tarih { get; set; }
        public string ReceteNo { get; set; }

    }
}

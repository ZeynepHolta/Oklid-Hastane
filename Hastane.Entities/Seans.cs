using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entities
{
    public class Seans
    {
        public int SeansID { get; set; }

        public int DoktorID { get; set; }

        public DateTime Tarih { get; set; }

        public string SeansSaati { get; set; }

        public bool BosMu { get; set; }
    }
}

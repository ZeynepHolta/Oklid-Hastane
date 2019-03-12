using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DTO
{
    public class RandevuSeansDTO
    {
        public List<Randevu> Randevular{ get; set; }

        public List<Seans> Seanslar{ get; set; }
    }
}

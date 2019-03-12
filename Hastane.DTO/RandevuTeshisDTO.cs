using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DTO
{
    public  class RandevuTeshisDTO
    {
        public Randevu Randevu { get; set; }

        public List<Teshis> Teshisler { get; set; }
    }
}

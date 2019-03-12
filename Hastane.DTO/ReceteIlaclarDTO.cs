using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DTO
{
    public class ReceteIlaclarDTO
    {
        public Recete Recete { get; set; }
        public List<ReceteDetay> ReceteIlaclari { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public static class SeansSaatleri
    {
        public static int SeansSuresi { get; set; } = 30;
        public static string MesaiBaslangic { get; set; } = "08:30";
        public static string MesaiBitis { get; set; } = "17:00";
        public static string OgleBaslangic { get; set; } = "12:30";
        public static string OgleBitis { get; set; } = "13:30";
    }
}

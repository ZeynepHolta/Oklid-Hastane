using Hastane.DAL;
using Hastane.DTO;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class RandevuTahlilBLL
    {
        RandevuTahlilDAL _randevuTahlilDAL;
        TahlilDAL _tahlilDAL;

        public RandevuTahlilBLL()
        {
            _randevuTahlilDAL = new RandevuTahlilDAL();
            _tahlilDAL = new TahlilDAL();
        }

        public bool Add(RandevuTahlilDTO randevuTahlil)
        {
            Randevu randevu = randevuTahlil.Randevu;
            List<Tahlil> tahliller = randevuTahlil.Tahliller;
            try
            {
                foreach (Tahlil tahlil in tahliller)
                {
                    _randevuTahlilDAL.Add(randevu.RandevuID, tahlil.TahlilID);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

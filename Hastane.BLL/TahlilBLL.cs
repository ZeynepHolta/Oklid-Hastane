using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class TahlilBLL
    {

        TahlilDAL _tahlilDAL;

        public TahlilBLL()
        {
            _tahlilDAL = new TahlilDAL();
        }

        public List<Tahlil> GetTahlil()
        {
            return _tahlilDAL.GetAllAnalyses();
        }

        public Tahlil GetTahlilByID(int tahlilID)
        {
            Tahlil tahlil = _tahlilDAL.GetAnalysisByID(tahlilID);

            if (tahlil == null)
            {
                throw new IDBulunamadi("Tahlil");
            }

            return tahlil;
            
        }
    }
}

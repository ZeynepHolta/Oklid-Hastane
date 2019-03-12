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
    public class TeshisBLL
    {
        TeshisDAL _teshisDAL;
        RandevuTeshisDTO _rtDTO;
        public TeshisBLL()
        {
            _teshisDAL = new TeshisDAL();
        }

        public List<Teshis> GetTeshis()
        {
            return _teshisDAL.GetAllDiagnostics();
        }

        public Teshis GetTeshisByID(int teshisID)
        {
            Teshis teshis = _teshisDAL.GetDiagnosticByID(teshisID);

            if (teshis == null)
            {
                throw new IDBulunamadi("Teshis");
            }

            return teshis;
        }
        

    }
}

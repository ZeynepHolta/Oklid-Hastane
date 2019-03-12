using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class IlacBLL
    {

        IlacDAL _ilacDAL;

        public IlacBLL()
        {
            _ilacDAL = new IlacDAL();
        }

        public List<Ilac> GetIlaclar()
        {
            return _ilacDAL.GetPills();
        }

        public Ilac GetIlacByID(int ilacID)
        {
            Ilac ilac = _ilacDAL.GetPillByID(ilacID);

            if (ilac == null)
            {
                throw new IDBulunamadi("Ilac");
            }

            return ilac;
        }

    }
}

using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class EczaciBLL
    {
        EczaciDAL _eczaciDAL;

        public EczaciBLL()
        {
            _eczaciDAL = new EczaciDAL();
        }

        //public List<Eczaci> GetEczacilar()
        //{
        //    return _eczaciDAL.GetAllPharmacists();
        //}

        //public Eczaci GetEczaciByID(int eczaciID)
        //{
        //    Eczaci eczaci = _eczaciDAL.GetPharmacistByID(eczaciID);

        //    if (eczaci == null)
        //    {
        //        throw new IDBulunamadi("Eczaci");
        //    }

        //    return eczaci;
        //}
    }
}

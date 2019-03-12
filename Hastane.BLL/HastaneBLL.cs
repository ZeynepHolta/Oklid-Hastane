using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class HastaneBLL
    {
        HastaneDAL _hastaneDAL;

        public HastaneBLL()
        {
            _hastaneDAL = new HastaneDAL();
        }

        public List<Hastahane> GetHastaneler()
        {
            return _hastaneDAL.GetAllHospitals();
        }

        public Hastahane GetHastaneByID(int hastaneID)
        {
            Hastahane hastane = _hastaneDAL.GetHospitalById(hastaneID);

            if (hastane == null)
            {
                throw new IDBulunamadi("Hastane");
            }

            return hastane;
        }
    }
}

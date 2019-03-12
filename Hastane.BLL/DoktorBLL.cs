using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class DoktorBLL
    {
        DoktorDAL _doktorDAL;

        public DoktorBLL()
        {
            _doktorDAL = new DoktorDAL();
        }

        public List<Doktor> ButunDoktorlarıGetir()
        {
            return _doktorDAL.GetAllDoctors();
        }

        public Doktor GetDoktorByID(int doktorID)
        {
            Doktor doktor = _doktorDAL.GetDoctorByID(doktorID);

            if (doktor == null)
            {
                throw new IDBulunamadi("Doktor");
            }

            return doktor;
        }

        public List<Doktor> SeciliDoktorlarıGetir(int depID,int hastaneID)
        {
            return _doktorDAL.GetDoctorByDepandHospital(hastaneID,depID);
        }

        public List<Doktor> DepartmanaGoreDoktorGetir(int depID)
        {
            List<Doktor> tumDoktorlar = _doktorDAL.GetAllDoctors();
            List<Doktor> depDoktorlari = new List<Doktor>();

            foreach (Doktor dok in tumDoktorlar)
            {
                if (dok.DepartmanID == depID)
                {
                    depDoktorlari.Add(dok);
                }
            }

            return depDoktorlari;
        }
    }
}

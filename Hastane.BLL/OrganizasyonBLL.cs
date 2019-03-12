using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class OrganizasyonBLL
    {
        //
        HastaneDAL _hastaneDAL;
        DepartmanDAL _departmanDAL;
        DoktorDAL _doktorDAL;
        SeansDAL _seansDAL;

        public OrganizasyonBLL()
        {
            _hastaneDAL = new HastaneDAL();
            _departmanDAL = new DepartmanDAL();
            _doktorDAL = new DoktorDAL();
            _seansDAL = new SeansDAL();
        }

        public List<Hastahane> GetHastaneler()
        {
            return _hastaneDAL.GetAllHospitals();
        }

        public List<Departman> GetDepartmanlar(int hastaneID)
        {
            List<Doktor> doktorlar = new List<Doktor>();
            List<Departman> departmanlar = new List<Departman>();

            Departman departman;
            foreach (Doktor doktor in doktorlar)
            {
                if (doktor.HastaneID == hastaneID)
                {
                    departman = _departmanDAL.GetDepartmentByID(doktor.DepartmanID);
                    departmanlar.Add(departman);
                }
            }

            return departmanlar;
        }

        public List<Doktor> GetDoktorlar(int hastaneID, int departmanID)
        {
            List<Doktor> tumDoktorlar = new List<Doktor>();
            List<Doktor> returnDoktorlar = new List<Doktor>();
            
            foreach (Doktor doktor in tumDoktorlar)
            {
                if (doktor.HastaneID == hastaneID && doktor.DepartmanID == departmanID)
                {
                    returnDoktorlar.Add(doktor);
                }
            }

            return returnDoktorlar;
        }

        public List<Seans> GetSeanslar(int hastaneID, int departmanID, int doktorID, DateTime tarih)
        {
            List<Doktor> tumDoktorlar = new List<Doktor>();

            Doktor buDoktor = null;
            foreach (Doktor doktor in tumDoktorlar)
            {
                if (doktor.HastaneID == hastaneID && doktor.DepartmanID == departmanID && doktor.DoktorID == doktorID)
                {
                    buDoktor = doktor;
                }
            }

            if (buDoktor == null)
            {
                throw new IDBulunamadi("Doktor");
            }

            List<Seans> tumSeanslar = _seansDAL.GetAllSeances();
            List<Seans> seanslar = new List<Seans>();
            foreach (Seans seans in tumSeanslar)
            {
                if (seans.DoktorID == buDoktor.DoktorID && seans.Tarih == tarih)
                {
                    seanslar.Add(seans);
                }
            }

            return seanslar;
        }
    }
}

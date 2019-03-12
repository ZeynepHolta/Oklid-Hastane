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
    public class RandevuBLL
    {
        RandevuDAL _randevuDAL;
        SeansDAL _seansDAL;
        DoktorDAL _doktorDal;
        HastaDAL _hastaDAL;
        GununTarihiDAL _gununTarihiDAL;

        public RandevuBLL()
        {
            _randevuDAL = new RandevuDAL();
            _seansDAL = new SeansDAL();
            _doktorDal = new DoktorDAL();
            _hastaDAL = new HastaDAL();
            _gununTarihiDAL = new GununTarihiDAL();
        }

        public bool Add(RandevuDTO randevuDTO)
        {
            CheckHastaGunDepartmanAyniOlamaz(randevuDTO.HastaID, randevuDTO.SeansID);

            Randevu randevu = new Randevu();
            randevu.HastaID = randevuDTO.HastaID;
            randevu.SeansID = randevuDTO.SeansID;
            randevu.MuayeneYapildiMi = false;
            randevu.Notlar = "";

            bool randevuEklendi = _randevuDAL.Add(randevu) > 0;

            Seans seans = _seansDAL.GetSeanceByID(randevu.SeansID);
            seans.BosMu = false;

            bool bosYapildi = _seansDAL.Update(seans) > 0;

            return randevuEklendi && bosYapildi;
        }

        public bool Delete(Randevu randevu)
        {
            bool silindi = _randevuDAL.Delete(randevu) > 0;
            if (!silindi)
            {
                throw new IDBulunamadi("Randevu");
            }
            Seans seans = _seansDAL.GetSeanceByID(randevu.SeansID);
            seans.BosMu = true;
            bool bosYapildi = _seansDAL.Update(seans) > 0;

            return silindi && bosYapildi;
        }

        public Randevu GetByID(int randevuID)
        {
            Randevu randevu = _randevuDAL.GetAppointmentByID(randevuID);
            if (randevu == null)
            {
                throw new IDBulunamadi("Randevu");
            }
            return _randevuDAL.GetAppointmentByID(randevuID);
        }

        public Randevu GetBySeanceID(int seanceID)
        {
            return _randevuDAL.GetAppointmentBySeanceID(seanceID);
        }

        public bool UpdateMuayene(int randevuID)
        {
            int i = _randevuDAL.UpdateMuayeneOlduMu(randevuID);

            if (i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Randevu> GetHastaGelecekRandevular(int hastaID)
        {
            List<Randevu> gelecekRandevular = new List<Randevu>();
            List<Randevu> butunRandevular = _randevuDAL.GetAllAppointments();
            Seans seans;

            foreach (Randevu randevu in butunRandevular)
            {
                if (randevu.HastaID == hastaID)
                {
                    seans = _seansDAL.GetSeanceByID(randevu.SeansID);
                    if (seans.Tarih >= _gununTarihiDAL.GunGetir())
                    {
                        gelecekRandevular.Add(randevu);
                    }
                }
            }

            return gelecekRandevular;
        }

        public List<Randevu> GetDoktorGununRandevulari(int doktorID)
        {
            List<Randevu> gununRandevulari = new List<Randevu>();
            List<Randevu> butunRandevular = _randevuDAL.GetAllAppointments();
            Seans seans;

            foreach (Randevu randevu in butunRandevular)
            {
                seans = _seansDAL.GetSeanceByID(randevu.SeansID);
                if (seans.DoktorID == doktorID && seans.Tarih == _gununTarihiDAL.GunGetir())
                {
                    gununRandevulari.Add(randevu);
                }
            }

            return gununRandevulari;
        }

        public void CheckHastaGunDepartmanAyniOlamaz(int hastaID, int seansID)
        {
            List<Randevu> tumRandevular = _randevuDAL.GetAllAppointments();
            Seans seansGelen = _seansDAL.GetSeanceByID(seansID);
            Doktor doktorGelen = _doktorDal.GetDoctorByID(seansGelen.DoktorID);
            Seans seansInDB;
            Doktor doktorInDB;
            foreach (Randevu item in tumRandevular)
            {
                if (item.HastaID == hastaID)
                {
                    seansInDB = _seansDAL.GetSeanceByID(item.SeansID);
                    if (seansInDB.Tarih == seansGelen.Tarih)
                    {
                        doktorInDB = _doktorDal.GetDoctorByID(seansInDB.DoktorID);
                        if (doktorInDB.HastaneID == doktorGelen.HastaneID && doktorInDB.DepartmanID == doktorGelen.DepartmanID)
                        {
                            throw new HastaGunDepartmanAyniOlamaz(_hastaDAL.GetPatientById(hastaID).HastaAdSoyad);
                        }
                    }
                }
            }
        }

        public List<Randevu> DoktorunYapilmamisMuayeneleri()
        {
            return _randevuDAL.GetAppointmentsNotExamination();
        }
        public List<Randevu> DoktorunYapilmisMuayeneleri()
        {
            return _randevuDAL.GetAppointmentsExamination();
        }

    }
}

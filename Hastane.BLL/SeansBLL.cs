using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class SeansBLL
    {
        SeansDAL _seansDAL;
        

        public SeansBLL()
        {
            _seansDAL = new SeansDAL();
        }

        // Zaten bu doktorun bu tarihteki seansları eklenmiş ise false döndürür.
        public bool AddTekGunSeanslari(int doktorID, DateTime tarih)
        {
            List<Seans> tumSeanslar = _seansDAL.GetAllSeances();
            foreach (Seans seans in tumSeanslar)
            {
                if (seans.DoktorID == doktorID && seans.Tarih.Date == tarih.Date)
                {
                    return false;
                }
            }

            int result = _seansDAL.AddSeans(doktorID, tarih, SeansSaatleri.MesaiBaslangic, SeansSaatleri.MesaiBitis, SeansSaatleri.OgleBaslangic, SeansSaatleri.OgleBitis, SeansSaatleri.SeansSuresi);

            return result > 0;
        }

        public List<Seans> GetGunSeanslari(int doktorID, DateTime tarih)
        {
            List<Seans> ilgiliSeanslar = new List<Seans>();
            List<Seans> tumSeanslar = _seansDAL.GetAllSeances();
            foreach (Seans seans in tumSeanslar)
            {
                if (seans.DoktorID == doktorID && seans.Tarih.Date == tarih.Date)
                {
                    ilgiliSeanslar.Add(seans);
                }
            }

            return ilgiliSeanslar;
        }

        public List<Seans> DoktorunDoluSeanslari(int doktorID,string tarih)
        {
            
            return _seansDAL.GetDoctorsSeances(doktorID,DateTime.Parse(tarih));
        } 

        public Seans SeansinDetaylariniGetir(int seansID)
        {
            return _seansDAL.GetSeanceByID(seansID);
        }

        public int GetDoktorIDBySeansID(int seansID)
        {
            List<Seans> tumSeanslar = _seansDAL.GetAllSeances();
            foreach (Seans seans in tumSeanslar)
            {
                if (seans.SeansID == seansID)
                {
                    return seans.DoktorID;
                }
            }

            throw new IDBulunamadi("Seans");
        }
    }
}

using Hastane.DAL;
using Hastane.DTO;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class HastaBLL
    {
        HastaDAL _hastaDAL;
        UserDAL _userDAL;

        public HastaBLL()
        {
            _hastaDAL = new HastaDAL();
            _userDAL = new UserDAL();
        }

        public bool Add(HastaKayitDTO hastaKayit)
        {
            CheckHastaVarMi(hastaKayit.HastaBilgileri);
            CheckKullaniciAdiVarMi(hastaKayit.GirisBilgileri.KullaniciAdi);
            CheckSifreGecerliMi(hastaKayit.GirisBilgileri.Sifre);
            bool hastaKaydedildi = false;
            bool userKaydedildi = _userDAL.Add(hastaKayit.GirisBilgileri) > 0;
            int userID = 0;
            if (userKaydedildi)
            {
                userID = _userDAL.GetUserID(hastaKayit.GirisBilgileri);
                hastaKayit.HastaBilgileri.UserID = userID;
                hastaKaydedildi = _hastaDAL.Add(hastaKayit.HastaBilgileri) > 0;
            }

            return hastaKaydedildi;
        }

        public void CheckKullaniciAdiVarMi(string kullaniciAdi)
        {
            List<User> users = _userDAL.GetAllUsers();
            foreach (User user in users)
            {
                if (user.KullaniciAdi == kullaniciAdi)
                {
                    throw new EmailZatenVar();
                }
            }
        }



        public void CheckSifreGecerliMi(string sifre)
        {
            Regex regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (!(sifre.Length > 7 && sifre.Length < 17) || !regexItem.IsMatch(sifre))
            {
                throw new HataliSifre();
            }
        }

        public void CheckHastaVarMi(Hasta hasta)
        {
            List<Hasta> tumHastalar = GetHastalar();
            foreach (Hasta item in tumHastalar)
            {
                if (item.TCKN == hasta.TCKN)
                {
                    throw new HastaZatenVar();
                }
            }
        }

        public List<Hasta> GetHastalar()
        {
            return _hastaDAL.GetAllPatients();
        }

        public Hasta GetHastaByID(int hastaID)
        {
            Hasta hasta = _hastaDAL.GetPatientById(hastaID);

            if (hasta == null)
            {
                throw new IDBulunamadi("Hasta");
            }

            return hasta;
        }

        public Hasta GetHastaByTCKN(string tckn)
        {
            try
            {
                Hasta hasta = _hastaDAL.GetPatientByTCKN(tckn);
                return hasta;
            }
            catch
            {
                 throw  new IDBulunamadi("Hasta");
            }
        
        }
    }
}

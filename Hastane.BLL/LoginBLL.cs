using Hastane.DAL;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class LoginBLL
    {
        User user;
        UserDAL _userDAL;
        HastaDAL _hastaDAL;
        DoktorDAL _doktorDAL;

        public LoginBLL()
        {
            user = new User();
            _userDAL = new UserDAL();
            _hastaDAL = new HastaDAL();
            _doktorDAL = new DoktorDAL();
        }

        public List<User> GetKullaniciByTip(int tip)
        {
            List<User> butunKullanicilar = _userDAL.GetAllUsers();
            List<User> tiptekiKullanicilar = new List<User>();

            foreach (User item in butunKullanicilar)
            {
                if (item.Tip == tip)
                {
                    tiptekiKullanicilar.Add(item);
                }
            }
            if (tiptekiKullanicilar != null)
            {

                return tiptekiKullanicilar;
            }
            else
            {
                throw new Exception();
            }

        }
        

        public bool KullaniciVarMi(string ad, string sifre, int tip)
        {
            foreach (User item in GetKullaniciByTip(tip))
            {
                if (item.KullaniciAdi == ad && item.Sifre == sifre)
                {
                    return true;
                }
            }
            return false;

        }

       

        public Hasta HastayiGetir(string mail, int tip)
        {
            int hastaUser = 0;
            List<Hasta> hastalar = new List<Hasta>();
            Hasta hasta = new Hasta();
            hastalar = _hastaDAL.GetAllPatients();
            foreach (User item in GetKullaniciByTip(tip))
            {
                if (item.KullaniciAdi == mail)
                {
                    hastaUser = item.UserID;
                    break;
                }
            }

            foreach (Hasta hst in hastalar)
            {
                if (hst.UserID == hastaUser)
                {
                    hasta = hst;
                    break;
                }
            }
            return hasta;
        }
        
        public Doktor DoktoruGetir(string kullaniciAdi)
        {
            int doktorUser = 0;
            Doktor doktor = null;
            List<Doktor> doktorlar = _doktorDAL.GetAllDoctors();
            foreach (User item in GetKullaniciByTip(2))
            {
                if (item.KullaniciAdi == kullaniciAdi)
                {
                    doktorUser = item.UserID;
                    break;
                }
            }

            foreach (Doktor dok in doktorlar)
            {
                if (dok.UserID == doktorUser)
                {
                    doktor = dok;
                    break;
                }
            }
            return doktor;
        }
    }
}

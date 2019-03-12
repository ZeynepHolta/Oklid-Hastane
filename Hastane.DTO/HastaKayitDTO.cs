using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DTO
{
    public class HastaKayitDTO
    {
        public Hasta HastaBilgileri { get; set; }
        public User GirisBilgileri { get; set; }

        public HastaKayitDTO(string tckn, string ad, string soyad, string kullaniciAdi, string sifre)
        {
            HastaBilgileri = new Hasta();
            HastaBilgileri.Ad = ad;
            HastaBilgileri.Soyad = soyad;
            HastaBilgileri.TCKN = tckn;

            GirisBilgileri = new User();
            GirisBilgileri.KullaniciAdi = kullaniciAdi;
            GirisBilgileri.Sifre = sifre;
            GirisBilgileri.Tip = 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class HastaGunDepartmanAyniOlamaz : Exception
    {
        string _hastaAdi;
        public override string Message
        {
            get
            {
                return _hastaAdi + " isimli hasta aynı gün, aynı hastaneden, aynı departmandan randevu almıştır. Tekrar alamaz.";
            }
        }

        public HastaGunDepartmanAyniOlamaz(string hastaAdi)
        {
            _hastaAdi = hastaAdi;
        }
    }

    public class IDBulunamadi : Exception
    {
        string _tabloAdi;
        public override string Message
        {
            get
            {
                return _tabloAdi + " tablosunda verilen no bulunamamıştır.";
            }
        }

        public IDBulunamadi(string tabloAdi)
        {
            _tabloAdi = tabloAdi;
        }
    }

    public class HastaZatenVar : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu hasta zaten daha önce kayıt olmuştur.";
            }
        }
    }

    public class EmailZatenVar : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu e-mail daha önce kaydedilmiştir.";
            }
        }
    }

    public class HataliSifre : Exception
    {
        public override string Message
        {
            get
            {
                return "Şifre en az 8 ve en fazla 16 karakter olmalı. Özel karakter içermemeli.";
            }
        }
    }

    public class ReceteZatenEklendi : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu hastaya daha önce reçete verilmiştir.";
            }
        }
    }
}

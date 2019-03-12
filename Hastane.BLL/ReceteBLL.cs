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
    public class ReceteBLL
    {
        ReceteDAL _receteDAL;
        ReceteDetayDAL _rdDAL;
        IlacDAL _ilacDAL;
        HastaBLL _hastaBLL;

        public ReceteBLL()
        {
            _rdDAL = new ReceteDetayDAL();
            _ilacDAL = new IlacDAL();
            _receteDAL = new ReceteDAL();
            _hastaBLL = new HastaBLL();
        }
        

        public bool Add(Recete recete, List<ReceteDetay> receteDetays)
        {
            int receteID = _receteDAL.GetIDOfObject(recete);
            if (receteID > 0)
            {
                throw new ReceteZatenEklendi();
            }

            int result = _receteDAL.Add(recete);
            recete.ReceteID = _receteDAL.GetIDOfObject(recete);

            foreach (ReceteDetay detay in receteDetays)
            {
                detay.ReceteID = recete.ReceteID;
                _rdDAL.Add(detay);
            }

            return result > 0;
        }

        public List<ReceteDetay> ReceteDetayıGetir(int receteID)
        {
            return _rdDAL.GetDetailsByID(receteID);
        }
        public Ilac IlacBilgileriniGetir(int ilacID)
        {
            return _ilacDAL.GetPillByID(ilacID);
        }

        public List<ReceteDetayDTO> ButunVerileriGetir(int receteID)
        {
            List<ReceteDetayDTO> veriler = new List<ReceteDetayDTO>();
            ReceteDetayDTO isteneveri = null;
            foreach (ReceteDetay item in ReceteDetayıGetir(receteID))
            {
                isteneveri = new ReceteDetayDTO();
                isteneveri.ReceteDetay = item;
                isteneveri.Ilac = IlacBilgileriniGetir(item.IlacID);
                veriler.Add(isteneveri);
            }
            return veriler;
        }

        //Burada hastanın tcknisine göre onun aldığı reçeteleri gösterecek biir metod lazım
        //ID'ye göre aldığı reçeteleri getiren metod var.Şimdi sırada DTO ile tcknisini getirmek.
        public List<Recete> HastaninReceteleriniGetir(int hastaID)
        {
            return _receteDAL.GetRecipesByHastaID(hastaID);
        }


        public List<ReceteDTO> ButunReceteVerileriniGetir(int hastaID)
        {
            List<ReceteDTO> veriler = new List<ReceteDTO>();
            ReceteDTO istenenReceteVerisi = null;
            foreach (Recete item in HastaninReceteleriniGetir(hastaID))
            {
                istenenReceteVerisi = new ReceteDTO();
                istenenReceteVerisi.Hasta = _hastaBLL.GetHastaByID(hastaID);
                istenenReceteVerisi.Recete = item;
                veriler.Add(istenenReceteVerisi);
            }
            return veriler;
        }

    }
}

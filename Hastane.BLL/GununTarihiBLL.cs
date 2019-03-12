using Hastane.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class GununTarihiBLL
    {
        GununTarihiDAL _gununTarihiDAL;

        public GununTarihiBLL()
        {
            _gununTarihiDAL = new GununTarihiDAL();
        }

        public void GunEkle()
        {
            _gununTarihiDAL.GunEkle();
        }

        public DateTime GunGetir()
        {
            return _gununTarihiDAL.GunGetir();
        }
    }
}

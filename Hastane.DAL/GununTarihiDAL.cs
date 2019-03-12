using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class GununTarihiDAL
    {
        DBHelper _helper;

        public GununTarihiDAL()
        {
            _helper = new DBHelper();
        }

        public void GunEkle()
        {
            DateTime today = GunGetir();
            today = today.AddDays(1);
            string query = "DELETE FROM BugunTarih";
            _helper.ExecuteNonQuery(query);
            query = string.Format("INSERT INTO BugunTarih VALUES(@today)");
            SqlParameter bugun = new SqlParameter("@today", today);
            _helper.AddParameter(bugun);
            _helper.ExecuteNonQuery(query);
        }

        public DateTime GunGetir()
        {
            string query = "SELECT * FROM BugunTarih";
            DataTable dt = _helper.FillDataTable(query);
            DateTime today;
            try
            {
                today = (DateTime)dt.Rows[0][0];
            }
            catch
            {
                query = string.Format("INSERT INTO BugunTarih VALUES(@today)");
                SqlParameter bugun = new SqlParameter("@today", DateTime.Now);
                _helper.AddParameter(bugun);
                _helper.ExecuteNonQuery(query);
                query = "SELECT * FROM BugunTarih";
                dt = _helper.FillDataTable(query);
                today = (DateTime)dt.Rows[0][0];
            }

            return today;
        }
    }
}

using Hastane.DTO;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class RandevuTahlilDAL
    {
        DBHelper _helper;

        public RandevuTahlilDAL()
        {
            _helper = new DBHelper();
        }

        public int Add(int randevuID, int tahlilID)
        {
            string query = "INSERT INTO RandevuTahlil(RandevuID, TahlilID) VALUES(@randevuID, @tahlilID)";
            SqlParameter rndID = new SqlParameter("@randevuID", randevuID);
            SqlParameter tahID = new SqlParameter("@tahlilID", tahlilID);
            _helper.AddMultiParameters(new List<SqlParameter>() { rndID, tahID});

            return _helper.ExecuteNonQuery(query);
        }
    }
}

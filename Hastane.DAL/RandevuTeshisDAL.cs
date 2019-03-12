using Hastane.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class RandevuTeshisDAL
    {

        string query;
        DBHelper helper;

        public RandevuTeshisDAL()
        {
            helper = new DBHelper();
        }

        public int Add(int randevuID, int teshisID)
        {
            query = "INSERT INTO RandevuTeshis(RandevuID,TeshisID) VALUES(@randevuID,@teshisID)";
            SqlParameter rID = new SqlParameter("@randevuID", randevuID);
            SqlParameter tID = new SqlParameter("@teshisID", teshisID);
            List<SqlParameter> parameters = new List<SqlParameter>() { rID, tID };
            helper.AddMultiParameters(parameters);

            return helper.ExecuteNonQuery(query);
        }

    }
}

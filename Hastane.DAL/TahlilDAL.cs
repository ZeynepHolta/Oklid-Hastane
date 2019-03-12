using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class TahlilDAL
    {
        //Tahlilde ekleme silme program üzerinden olmayacak.Hazır karşısına çıkacak.

        string query;
        DBHelper helper;

        public TahlilDAL()
        {
            helper = new DBHelper();
        }

        public List<Tahlil> GetAllAnalyses()
        {
            List<Tahlil> analyzes = new List<Tahlil>();
            query = "SELECT *FROM Tahlil";
            Tahlil analysis = null;
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                analysis = new Tahlil();
                analysis.TahlilID = (int)item["TahlilID"];
                analysis.Ad = item["TahlilAd"].ToString();
                analyzes.Add(analysis);
            }
            return analyzes;
        }

        public Tahlil GetAnalysisByID(int tahlilID)
        {
            Tahlil analysis = new Tahlil();
            query = "SELECT *FROM Tahlil WHERE TahlilID=@tahlilID";
            SqlParameter id = new SqlParameter("@tahlilID", tahlilID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            analysis.TahlilID = (int)row["TahlilID"];
            analysis.Ad = row["TahlilAd"].ToString();

            return analysis;
        }
    }
}

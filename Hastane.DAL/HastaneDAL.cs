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
    public class HastaneDAL
    {
        string query;
        DBHelper helper;

        public HastaneDAL()
        {
            helper = new DBHelper();
        }

        public List<Hastahane> GetAllHospitals()
        {
            List<Hastahane> departmens = new List<Hastahane>();
            query = "SELECT *FROM Hastane";
            Hastahane hastane = null;

            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                hastane = new Hastahane();
                hastane.HastaneID = (int)item["HastaneID"];
                hastane.Ad = item["Ad"].ToString();
                hastane.Sehir = item["Sehir"].ToString();
                departmens.Add(hastane);
            }
            return departmens;
        }
        public Hastahane GetHospitalById(int hastaneID)
        {
            Hastahane hst = new Hastahane();
            query = "SELECT *FROM Hastane WHERE HastaneID=@hastaneID";
            SqlParameter id = new SqlParameter("@hastaneID", hastaneID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            hst.HastaneID = (int)row["HastaneID"];
            hst.Ad = row["Ad"].ToString();
            hst.Sehir = row["Sehir"].ToString();

            return hst;
        }

    }
}

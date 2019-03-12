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
    public class HastaDAL
    {
        string query;
        DBHelper helper;

        public HastaDAL()
        {
            helper = new DBHelper();
        }
        
        public int Add(Hasta hasta)
        {
            query = "INSERT INTO Hasta(Ad,Soyad,TCKN,UserID) VALUES(@ad,@soyad,@tckn,@userID)";
            SqlParameter ad = new SqlParameter("@ad", hasta.Ad);
            SqlParameter soyad = new SqlParameter("@soyad", hasta.Soyad);
            SqlParameter tckn = new SqlParameter("@tckn", hasta.TCKN);
            SqlParameter userID = new SqlParameter("@userID", hasta.UserID);
            List<SqlParameter> sqlParams = new List<SqlParameter> { ad, soyad, tckn, userID};
            helper.AddMultiParameters(sqlParams);

            return helper.ExecuteNonQuery(query);
        }
        

        public List<Hasta> GetAllPatients()
        {
            List<Hasta> departmens = new List<Hasta>();
            query = "SELECT *FROM Hasta";
            Hasta hasta = null;

            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                hasta = new Hasta();
                hasta.HastaID= (int)item["HastaID"];
                hasta.Ad = item["Ad"].ToString();
                hasta.Soyad = item["Soyad"].ToString();
                hasta.TCKN = item["TCKN"].ToString();
                hasta.UserID = (int)item["UserID"];
                departmens.Add(hasta);
            }
            return departmens;
        }

        public Hasta GetPatientById(int hastaID)
        {
            Hasta hasta = new Hasta();
            query = "SELECT *FROM Hasta WHERE HastaID=@hastaID";
            SqlParameter id = new SqlParameter("@hastaID", hastaID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            hasta.HastaID = hastaID;
            hasta.Ad = row["Ad"].ToString();
            hasta.Soyad = row["Soyad"].ToString();
            hasta.TCKN = row["TCKN"].ToString();
            hasta.UserID =(int) row["UserID"];

            return hasta;
        }

        public Hasta GetPatientByTCKN(string tckn)
        {
            Hasta hasta = new Hasta();
            query = "SELECT *FROM Hasta WHERE TCKN=@tckn";
            SqlParameter tc = new SqlParameter("@tckn", tckn);
            helper.AddParameter(tc);
            DataRow row = helper.FillDataTable(query).Rows[0];
            hasta.TCKN = tckn;
            hasta.Ad = row["Ad"].ToString();
            hasta.Soyad = row["Soyad"].ToString();
            hasta.HastaID = (int)row["HastaID"];
            hasta.UserID = (int)row["UserID"];


            return hasta;
        }
    }
}

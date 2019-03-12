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
    public class IlacDAL
    {      //Tahlilde ekleme silme program üzerinden olmayacak.Hazır karşısına çıkacak.

        string query;
        DBHelper helper;

        public IlacDAL()
        {
            helper = new DBHelper();
        }

        public List<Ilac> GetPills()
        {
            List<Ilac> pills = new List<Ilac>();
            query = "SELECT *FROM Ilac";
            Ilac pill = null;
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                pill = new Ilac();
                pill.IlacID = (int)item["IlacID"];
                pill.IlacAdi = item["IlacAdi"].ToString();
                pills.Add(pill);
            }
            return pills;
        }

        public Ilac GetPillByID(int ilacID)
        {
            Ilac pill = new Ilac();
            query = "SELECT *FROM Ilac WHERE IlacID=@ilacID";
            SqlParameter id = new SqlParameter("@ilacID", ilacID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            pill.IlacID = (int)row["IlacID"];
            pill.IlacAdi = row["IlacAdi"].ToString();

            return pill;
        }

        public int Add(Ilac ilac)
        {
            Ilac pill = new Ilac();
            query = "INSERT INTO Ilac(IlacAdi) VALUES(@ad)";
            SqlParameter ilacAdi = new SqlParameter("@ad", ilac.IlacAdi);
            helper.AddParameter(ilacAdi);

            return helper.ExecuteNonQuery(query);
        }

        public int Delete(Ilac ilac)
        {
            query = "DELETE FROM Ilac WHERE IlacID=@ilacID";
            SqlParameter ilacID = new SqlParameter("@randevuID", ilac.IlacID);
            helper.AddParameter(ilacID);

            return helper.ExecuteNonQuery(query);

        }

        public List<Ilac> GetAllPills()
        {
            List<Ilac> ilaclar = new List<Ilac>();
            query = "SELECT *FROM Ilac";
            Ilac ilc = new Ilac();
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                ilc = new Ilac();
                ilc.IlacID = (int)item["IlacID"];
                ilc.IlacAdi = item["IlacAdi"].ToString();
                ilaclar.Add(ilc);
            }
            return ilaclar;
        }

     

    }
}

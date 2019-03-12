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
    public class EczaciDAL
    {

        string query;
        DBHelper helper;
        public EczaciDAL()
        {
            helper = new DBHelper();
        }

        //public List<Eczaci> GetAllPharmacists()
        //{
        //    List<Eczaci> pharmacists = new List<Eczaci>();
        //    query = "SELECT *FROM Eczaci";
        //    Eczaci pharmacist = null;

        //    foreach (DataRow item in helper.FillDataTable(query).Rows)
        //    {
        //        pharmacist = new Eczaci();
        //        pharmacist.EczaciID = (int)item["EczaciID"];
        //        pharmacist.Ad = item["Ad"].ToString();
        //        pharmacist.Soyad = item["Soyad"].ToString();
        //        pharmacist.UserID =(int) item["UserID"];
        //        pharmacists.Add(pharmacist);
        //    }
        //    return pharmacists;
        //}

        //public Eczaci GetPharmacistByID(int eczaciID)
        //{
        //    Eczaci pharmacist = new Eczaci();
        //    query = "SELECT *FROM Eczaci WHERE EczaciID=@eczaciID";
        //    SqlParameter id = new SqlParameter("@eczaciID", eczaciID);
        //    helper.AddParameter(id);
        //    DataRow row = helper.FillDataTable(query).Rows[0];
        //    pharmacist.EczaciID = eczaciID;
        //    pharmacist.Ad = row["Ad"].ToString();
        //    pharmacist.Soyad = row["Soyad"].ToString();
        //    pharmacist.UserID =(int)row["UserID"];

        //    return pharmacist;
        //}


    }
}

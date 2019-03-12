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
    //Bir sıkıntı çıkmasını diye  pasif hale getirdim
    class PoliklinikDAL
    {


        //string query;
        //DBHelper helper;

        //public PoliklinikDAL()
        //{
        //    helper = new DBHelper();
        //}

        //public List<Poliklinik> GetAllPolyclinics()
        //{
        //    List<Poliklinik> _poli = new List<Poliklinik>();
        //    query = "SELECT  *FROM Poliklinik";
        //    Poliklinik p = null;
        //    foreach (DataRow  item in helper.FillDataTable(query).Rows)
        //    {
        //        p = new Poliklinik();
        //        p.PoliklinikID = (int)item["PoliklinikID"];
        //        p.Ad = item["Ad"].ToString();
        //        p.Ilce = item["Ilce"].ToString();
        //        _poli.Add(p);

        //    }

        //    return _poli;
        //}

        //public Poliklinik GetPolyclinicById(int poliID)
        //{
        //    Poliklinik p = new Poliklinik();
        //    query = "SELECT *FROM Poliklinik WHERE PoliklinikID=@poliID";
        //    SqlParameter id = new SqlParameter("poliID", poliID);
        //    DataRow row = helper.FillDataTable(query).Rows[0];
        //    p.PoliklinikID= (int)row["PoliklinikID"];
        //    p.Ad= row["Ad"].ToString();
        //    p.Ilce= row["Ilce"].ToString();
            

        //    return p;
        //}


    }
}

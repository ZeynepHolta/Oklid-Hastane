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
    public class TeshisDAL
    {
        //Teşhiste ekleme silme program üzerinden olmayacak.Hazır karşısına çıkacak.
   
        string query;
        DBHelper helper;

        public TeshisDAL()
        {
            helper = new DBHelper();
          
        }

        public List<Teshis> GetAllDiagnostics()
        {
            List<Teshis> diagnostics = new List<Teshis>();
            query = "SELECT * FROM Teshis";
            Teshis diagnostic = null;
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                diagnostic = new Teshis();
                diagnostic.TeshisID = (int)item["TeshisID"];
                diagnostic.Aciklama = item["TeshisAdi"].ToString();
                diagnostics.Add(diagnostic);
            }
            return diagnostics;
        }

        public Teshis GetDiagnosticByID(int teshisID)
        {
            Teshis  diagnostic = new Teshis();
            query = "SELECT * FROM Teshis WHERE teshisID=@teshisID";
            SqlParameter id = new SqlParameter("@teshisID", teshisID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            diagnostic.TeshisID = teshisID;
            diagnostic.Aciklama = row["TeshisAdi"].ToString();

            return diagnostic;
        }

  
    }
}

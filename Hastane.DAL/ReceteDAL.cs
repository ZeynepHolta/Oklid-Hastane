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
    //TODO:Yarın konuşalım

    public class ReceteDAL
    {
        //Reçete ekelenbilir,all çekilebbilir,
        string query;
        DBHelper helper;

        public ReceteDAL()
        {
            helper = new DBHelper();
        }

        public int Add(Recete recete)
        {
            query = "INSERT INTO Recete(HastaID,Tarih,DoktorID) VALUES(@hastaID,@tarih,@doktorID)";
            SqlParameter hastaID = new SqlParameter("@hastaID", recete.HastaID);
            SqlParameter tarih = new SqlParameter("@tarih", recete.Tarih.Date);
            SqlParameter doktorID = new SqlParameter("@doktorID", recete.DoktorID);
            List<SqlParameter> sqlParams = new List<SqlParameter> { hastaID, tarih, doktorID };
            helper.AddMultiParameters(sqlParams);

            return helper.ExecuteNonQuery(query);
        }
        public List<Recete> GetAllRecipes()
        {
            List<Recete> recipes = new List<Recete>();
            query = "SELECT *FROM Recete ";
            Recete recipe = null;
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                recipe = new Recete();
                recipe.ReceteID = (int)item["ReceteID"];
                recipe.HastaID = (int)item["HastaID"];
                recipe.DoktorID = (int)item["DoktorID"];
                recipe.Tarih = (DateTime)item["Notlar"];
                recipes.Add(recipe);
            }
            return recipes;
        }

        public Recete GetRecipeByReceteID(int receteID)
        {
            Recete recipe = new Recete();
            query = "SELECT *FROM Recete WHERE ReceteID=@receteID";
            SqlParameter id = new SqlParameter("@receteID", receteID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            recipe.ReceteID = receteID;
            recipe.DoktorID = (int)row["DoktorID"];
            recipe.HastaID = (int)row["HastaID"];
            recipe.Tarih = (DateTime)row["Tarih"];

            return recipe;
        }

        public List<Recete> GetRecipesByHastaID(int hastaID)
        {
            List<Recete> recipes = new List<Recete>();
            query = "SELECT * FROM Recete WHERE HastaID=@hastaID";
            SqlParameter hasta = new SqlParameter("@hastaID", hastaID);
            helper.AddParameter(hasta);
            Recete recipe = null;
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                recipe = new Recete();
                recipe.ReceteID = (int)item["ReceteID"];
                recipe.HastaID = hastaID;
                recipe.DoktorID = (int)item["DoktorID"];
                recipe.Tarih = ((DateTime)item["Tarih"]).Date;
                recipes.Add(recipe);
            }
            return recipes;
        }

        public int GetIDOfObject(Recete recete)
        {
            query = "SELECT * FROM Recete WHERE HastaID = @hastaID AND Tarih = @tarih AND DoktorID = @doktorID";
            SqlParameter hastaID = new SqlParameter("@hastaID", recete.HastaID);
            SqlParameter tarih = new SqlParameter("@tarih", recete.Tarih.Date);
            SqlParameter doktorID = new SqlParameter("@doktorID", recete.DoktorID);
            List<SqlParameter> sqlParams = new List<SqlParameter> { hastaID, tarih, doktorID };
            helper.AddMultiParameters(sqlParams);

            DataTable dt = helper.FillDataTable(query);
            int receteID = 0;
            if (dt.Rows.Count > 0)
            {
                receteID = (int)dt.Rows[0]["ReceteID"];
            }
            
            return receteID;
        }
    }
}

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
    public class ReceteDetayDAL
    {
        string query;
        DBHelper helper;
        public ReceteDetayDAL()
        {
            helper = new DBHelper();
        }
        public int Add(ReceteDetay receteDetay)
        {
            query = "INSERT INTO ReceteDetay(ReceteID,IlacID,Adet,Aciklama) VALUES(@receteID,@ilacID,@adet,@aciklama)";
            SqlParameter receteID = new SqlParameter("@receteID", receteDetay.ReceteID);
            SqlParameter ilacID = new SqlParameter("@ilacID", receteDetay.IlacID);
            SqlParameter adet = new SqlParameter("@adet", receteDetay.Adet);
            SqlParameter aciklama = new SqlParameter("@aciklama", receteDetay.Aciklama);
            List<SqlParameter> sqlParams = new List<SqlParameter> { receteID, ilacID, adet, aciklama };
            helper.AddMultiParameters(sqlParams);

            return helper.ExecuteNonQuery(query);
        }

        public List<ReceteDetay> GetAllRecipeDetails()
        {
            List<ReceteDetay> recipes = new List<ReceteDetay>();
            query = "SELECT *FROM ReceteDetay ";
            ReceteDetay recipe = null;
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                 recipe = new ReceteDetay();
                recipe.ReceteID= (int)item["ReceteID"];
                recipe.IlacID= (int)item["IlacID"];
                recipe.Adet= (int)item["Adet"];
                recipe.Aciklama = item["Aciklama"].ToString();
                recipes.Add(recipe);
            }
            return recipes;
        }

        public List<ReceteDetay> GetDetailsByID(int receteID)
        {
            List<ReceteDetay> recipes = new List<ReceteDetay>();
            ReceteDetay recipe = new ReceteDetay();
            query = "SELECT *FROM ReceteDetay WHERE ReceteID=@receteID";
            SqlParameter id = new SqlParameter("@receteID", receteID);
            helper.AddParameter(id);
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                recipe = new ReceteDetay();;
                recipe.ReceteID = receteID;
                recipe.IlacID = (int)item["IlacID"];
                recipe.Adet = (int)item["Adet"];
                recipe.Aciklama = item["Aciklama"].ToString();
                recipes.Add(recipe);
            }
            return recipes;

        }

    }
}

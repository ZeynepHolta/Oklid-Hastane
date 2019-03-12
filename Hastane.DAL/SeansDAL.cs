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
    public class SeansDAL
    {
        string query;
        DBHelper helper;

        public SeansDAL()
        {
            helper = new DBHelper();
        }

        public int Add(Seans seans)
        {
            string query = "INSERT INTO Seans(DoktorID, Tarih, SeansSaati, BosMu) VALUES(@doktorID, @tarih, @seansSaati, @bosMu)";
            SqlParameter doktorID = new SqlParameter("@doktorID", seans.DoktorID);
            SqlParameter tarih = new SqlParameter("@tarih", seans.Tarih);
            SqlParameter seansSaati = new SqlParameter("@seansSaati", seans.SeansSaati);
            SqlParameter bosMu = new SqlParameter("@bosMu", seans.BosMu);
            helper.AddMultiParameters(new List<SqlParameter>() { doktorID, tarih, seansSaati, bosMu });

            return helper.ExecuteNonQuery(query);
        }

        public int Update(Seans seans)
        {
            string query = "UPDATE Seans SET  Bosmu= @bosMu WHERE SeansID=@seansID";
            SqlParameter id = new SqlParameter("@seansID", seans.SeansID);
            SqlParameter bosmu = new SqlParameter("@bosMu", seans.BosMu);
            helper.AddMultiParameters(new List<SqlParameter>() { id, bosmu});

            return helper.ExecuteNonQuery(query);
        }

        public Seans GetSeanceByID(int seansID)
        {
            Seans seans = new Seans();
            query = "SELECT *FROM Seans WHERE SeansID=@seansID";
            SqlParameter id = new SqlParameter("@seansID", seansID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            seans.SeansID = seansID;
            seans.DoktorID = (int)row["DoktorID"];
            seans.Tarih = (DateTime)row["Tarih"];
            seans.SeansSaati = row["SeansSaati"].ToString();
            seans.BosMu = (bool)row["BosMu"];

            return seans;
        }

        public List<Seans> GetAllSeances()
        {
            List<Seans> seances = new List<Seans>();
            query = "SELECT *FROM Seans";
            Seans seance = null;

            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                seance = new Seans();
                seance.SeansID = (int)item["SeansID"];
                seance.DoktorID = (int)item["DoktorID"];
                seance.Tarih = (DateTime)item["Tarih"];
                seance.SeansSaati = (string)item["SeansSaati"].ToString();
                seance.BosMu = (bool)item["BosMu"];
                seances.Add(seance);
            }
            return seances;
        }

        public int AddSeans(int doktorID, DateTime tarih, string mesaiBaslangic, string mesaiBitis, string oglenBaslangic, string oglenBitis, int seansSuresi)
        {
            string query = "SP_SeanslariOlustur";
            SqlParameter dokID = new SqlParameter("@doktorID", doktorID);
            SqlParameter tarihParam = new SqlParameter("@tarih", tarih);
            SqlParameter mesaiBas = new SqlParameter("@mesaiBaslangicSaati", mesaiBaslangic);
            SqlParameter mesaiBit = new SqlParameter("@mesaiBitisSaati", mesaiBitis);
            SqlParameter oglenBas = new SqlParameter("@oglenTatiliBaslangicSaati", oglenBaslangic);
            SqlParameter oglenBit = new SqlParameter("@oglenTatiliBitisSaati", oglenBitis);
            SqlParameter seansSur = new SqlParameter("@seansSuresiDakika", seansSuresi);
            List<SqlParameter> parameters = new List<SqlParameter>() { dokID, tarihParam, mesaiBas, mesaiBit, oglenBas, oglenBit, seansSur };
            helper.AddMultiParameters(parameters);

            return helper.ExecuteNonQuery(query, CommandType.StoredProcedure);
        }

        public List<Seans> GetDoctorsSeances(int doktorID, DateTime tarih)
        {
            List<Seans> seances = new List<Seans>();
            query = "SELECT *FROM Seans WHERE DoktorID=@doktorID AND Tarih=@tarih AND BosMu=0";
            Seans seance = null;
            SqlParameter id = new SqlParameter("@doktorID", doktorID);
            SqlParameter _tarih = new SqlParameter("@tarih", tarih);
            // helper.AddParameter(id);
            helper.AddMultiParameters(new List<SqlParameter>() { _tarih, id });

            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                seance = new Seans();
                seance.SeansID = (int)item["SeansID"];
                seance.DoktorID = doktorID;
                seance.Tarih = tarih;
                seance.SeansSaati = (string)item["SeansSaati"].ToString();
                seance.BosMu = (bool)item["BosMu"];
                seances.Add(seance);
            }
            return seances;
        }

    }
}

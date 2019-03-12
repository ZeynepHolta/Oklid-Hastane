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
    public class RandevuDAL
    {
        string query;
        DBHelper helper;

        public RandevuDAL()
        {
            helper = new DBHelper();
        }

        public int Add(Randevu randevu)
        {
            query = "INSERT INTO Randevu(HastaID,SeansID,MuayeneYapildiMi,Notlar) VALUES(@hastaID,@seansID,@muayene,@notlar)";
            SqlParameter hastaID = new SqlParameter("@hastaID", randevu.HastaID);
            SqlParameter seansID = new SqlParameter("@seansID", randevu.SeansID);
            SqlParameter muayene = new SqlParameter("@muayene", randevu.MuayeneYapildiMi);
            SqlParameter notlar = new SqlParameter("@notlar", randevu.Notlar);
            List<SqlParameter> sqlParams = new List<SqlParameter> { hastaID, seansID, muayene, notlar };
            helper.AddMultiParameters(sqlParams);

            return helper.ExecuteNonQuery(query);
        }

        public int UpdateMuayeneOlduMu(int randevuID)//randevuID
        {
            string query = "UPDATE Randevu SET  MuayeneYapildiMi= 1 WHERE RandevuID =@randevuID";
            SqlParameter _randevuID = new SqlParameter("@randevuID", randevuID);
            helper.AddParameter(_randevuID);
            return helper.ExecuteNonQuery(query);
        }
        public int Delete(Randevu randevu)
        {
            query = "DELETE FROM Randevu WHERE RandevuID=@randevuID";
            SqlParameter randevuID = new SqlParameter("@randevuID", randevu.RandevuID);
            helper.AddParameter(randevuID);
            return helper.ExecuteNonQuery(query);

        }

        public List<Randevu> GetAllAppointments()
        {
            List<Randevu> appointments = new List<Randevu>();
            query = "SELECT *FROM Randevu";
            Randevu appointment = new Randevu();
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                appointment = new Randevu();
                appointment.RandevuID = (int)item["RandevuID"];
                appointment.HastaID = (int)item["HastaID"];
                appointment.SeansID = (int)item["SeansID"];
                appointment.MuayeneYapildiMi = (bool)item["MuayeneYapildiMi"];
                appointment.Notlar = item["Notlar"].ToString();
                appointments.Add(appointment);
            }
            return appointments;
        }

        public Randevu GetAppointmentByID(int randevuID)
        {
            Randevu appointment = new Randevu();
            query = "SELECT *FROM Randevu WHERE RandevuID=@randevuID";
            SqlParameter id = new SqlParameter("@randevuID", randevuID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            appointment.RandevuID = randevuID;
            appointment.HastaID = (int)row["HastaID"];
            appointment.SeansID = (int)row["SeansID"];
            appointment.MuayeneYapildiMi = (bool)row["MuayeneYapildiMi"];
            appointment.Notlar = row["Notlar"].ToString();

            return appointment;
        }
        public Randevu GetAppointmentBySeanceID(int seansID)
        {
            Randevu appointment = new Randevu();
            query = "SELECT *FROM Randevu WHERE SeansID=@seansID";
            SqlParameter id = new SqlParameter("@seansID", seansID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            appointment.RandevuID = (int)row["RandevuID"];
            appointment.HastaID = (int)row["HastaID"];
            appointment.SeansID = seansID;
            appointment.MuayeneYapildiMi = (bool)row["MuayeneYapildiMi"];
            appointment.Notlar = row["Notlar"].ToString();

            return appointment;
        }

        public List<Randevu> GetAppointmentsNotExamination()
        {
            List<Randevu> appointments = new List<Randevu>();
            query = "SELECT *FROM Randevu WHERE MuayeneYapildiMi=0";
            Randevu appointment = new Randevu();
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                appointment = new Randevu();
                appointment.RandevuID = (int)item["RandevuID"];
                appointment.HastaID = (int)item["HastaID"];
                appointment.SeansID = (int)item["SeansID"];
                appointment.MuayeneYapildiMi = (bool)item["MuayeneYapildiMi"];
                appointment.Notlar = item["Notlar"].ToString();
                appointments.Add(appointment);
            }
            return appointments;
        }
        public List<Randevu> GetAppointmentsExamination()
        {
            List<Randevu> appointments = new List<Randevu>();
            query = "SELECT *FROM Randevu WHERE MuayeneYapildiMi=1 ";
            Randevu appointment = new Randevu();
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                appointment = new Randevu();
                appointment.RandevuID = (int)item["RandevuID"];
                appointment.HastaID = (int)item["HastaID"];
                appointment.SeansID = (int)item["SeansID"];
                appointment.MuayeneYapildiMi = (bool)item["MuayeneYapildiMi"];
                appointment.Notlar = item["Notlar"].ToString();
                appointments.Add(appointment);
            }
            return appointments;
        }
    }

}

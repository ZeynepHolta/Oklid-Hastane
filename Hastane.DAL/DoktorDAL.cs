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

    public class DoktorDAL
    {
        string query;
        DBHelper helper;
        public DoktorDAL()
        {
            helper = new DBHelper();
        }

        public List<Doktor> GetAllDoctors()
        {
            List<Doktor> doctors = new List<Doktor>();
            query = "SELECT *FROM Doktor";
            Doktor doctor = null;

            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                doctor = new Doktor();
                doctor.DoktorID = (int)item["DoktorID"];
                doctor.Ad = item["Ad"].ToString();
                doctor.Soyad = item["Soyad"].ToString();
                //doctor.KullaniciAdi = item["KullaniciAdi"].ToString();
                //doctor.Sifre = item["Sifre"].ToString();
                doctor.DepartmanID = (int)item["DepartmanID"];
                doctor.HastaneID = (int)item["HastaneID"];
                doctor.UserID = (int)item["UserID"];
                doctors.Add(doctor);
            }
            return doctors;
        }

        public Doktor GetDoctorByID(int doktorID)
        {
            Doktor doctor = new Doktor();
            query = "SELECT *FROM Doktor WHERE DoktorID=@doktorID";
            SqlParameter id = new SqlParameter("@doktorID", doktorID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            doctor.DoktorID = doktorID;
            doctor.Ad = row["Ad"].ToString();
            doctor.Soyad = row["Soyad"].ToString();
            doctor.DepartmanID = (int)row["DepartmanID"];
            doctor.HastaneID = (int)row["HastaneID"];
            doctor.UserID = (int)row["UserID"];
            //doctor.KullaniciAdi = row["KullaniciAdi"].ToString();
            //doctor.Sifre = row["Sifre"].ToString();

            return doctor;
        }

        public List<Doktor> GetDoctorByDepandHospital(int hastaneID, int depID)
        {
            List<Doktor> doctors = new List<Doktor>();
            query = "SELECT *FROM Doktor WHERE DepartmanID=@depID and HastaneID=@hastaneID";
            SqlParameter hid = new SqlParameter("@hastaneID", hastaneID);
            SqlParameter did = new SqlParameter("@depID", depID);
            List<SqlParameter> parameters = new List<SqlParameter>() { hid, did};
            helper.AddMultiParameters(parameters);
            Doktor doctor = null;

            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                doctor = new Doktor();
                doctor.DoktorID = (int)item["DoktorID"];
                doctor.Ad = item["Ad"].ToString();
                doctor.Soyad = item["Soyad"].ToString();
                doctor.DepartmanID = (int)item["DepartmanID"];
                doctor.HastaneID = (int)item["HastaneID"];
               // doctor.UserID = (int)item["UserID"];
                doctors.Add(doctor);
            }
            return doctors;
        }

    }
}

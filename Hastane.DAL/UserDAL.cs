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
    public class UserDAL
    {

        string query;
        DBHelper helper;

        public UserDAL()
        {
            helper = new DBHelper();
        }
        
        public int Add(User user)
        {
            query = "INSERT INTO [User](KullaniciAdi, Sifre, Tip) VALUES(@kullaniciAdi, @sifre, @tip)";
            SqlParameter kullaniciAdi = new SqlParameter("@kullaniciAdi", user.KullaniciAdi);
            SqlParameter sifre = new SqlParameter("@sifre", user.Sifre);
            SqlParameter tip = new SqlParameter("@tip", user.Tip);

            List<SqlParameter> parameters = new List<SqlParameter>() { kullaniciAdi, sifre, tip};
            helper.AddMultiParameters(parameters);

            return helper.ExecuteNonQuery(query);
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            User user = null;

            query = "SELECT * FROM [User]";

            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                user = new User();
                user.UserID = (int)item["UserID"];
                user.KullaniciAdi = item["KullaniciAdi"].ToString();
                user.Sifre = item["Sifre"].ToString();
                user.Tip = (int)item["Tip"];
                users.Add(user);
            }
            return users;
        }


        //public User GetUserByID(int userID)
        //{
        //    User usr = new User();
        //    query = "SELECT * FROM [User] WHERE UserID=@userID";
        //    SqlParameter id = new SqlParameter("@userID", userID);
        //    helper.AddParameter(id);
        //    DataRow row = helper.FillDataTable(query).Rows[0];
        //    usr.UserID = userID;
        //    usr.KullaniciAdi = row["KullaniciAdi"].ToString();
        //    usr.Tip = (int)row["Tip"];

        //    return usr;
        //}

        public int GetUserID(User user)
        {
            query = "SELECT UserID FROM [User] WHERE KullaniciAdi = @kullaniciAdi AND  Sifre = @sifre AND Tip = @tip";
            SqlParameter kullaniciAdi = new SqlParameter("@kullaniciAdi", user.KullaniciAdi);
            SqlParameter sifre = new SqlParameter("@sifre", user.Sifre);
            SqlParameter tip = new SqlParameter("@tip", user.Tip);

            List<SqlParameter> parameters = new List<SqlParameter>() { kullaniciAdi, sifre, tip };
            helper.AddMultiParameters(parameters);

            DataTable userIDTable = helper.FillDataTable(query);
            int userID = 0;

            foreach (DataRow row in userIDTable.Rows)
            {
                userID = (int)row[0];
            }

            return userID;
        }
    }
}

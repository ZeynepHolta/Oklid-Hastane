using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL
{
    public class DBHelper
    {
        SqlConnection conn;
        SqlCommand cmd;

        public DBHelper()
        {
            //Burasını lütfen kendi dbnize göre düzeltin.
            //OZGUR
            //conn = new SqlConnection("Data Source=OZGURKAHRAMAN\\SQLEXPRESS;Initial Catalog=OklidHastane;Integrated Security=True");
            //BEYZA
            conn = new SqlConnection(@"Data Source=DESKTOP-ILBNPMH\MSSQLSERVER1;Initial Catalog=OklidHastane;User ID=sa;Password=12345");
            //ZEYNEP
            //conn = new SqlConnection("Data Source=LAPTOP-85N8TAAV;Initial Catalog=OklidHastane;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;

        }
        /// <summary>
        /// Bu komut ile tabloyu çekebilirsiniz.
        /// </summary>
        /// <param name="commandText">Sql komutunu parametere olarak vermelisiniz.</param>
        /// <returns></returns>
        public DataTable FillDataTable(string commandText)
        {
            DataTable dataTable = new DataTable();
            cmd.CommandText = commandText;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);

            return dataTable;
        }
        /// <summary>
        /// Tabloya bir şey eklerken,silerken ve ya güncellerken bu metodu kullanabilirsiniz
        /// </summary>
        /// <param name="commandText">Sql komutunu parametere olarak vermelisiniz.</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string commandText, CommandType commandType = CommandType.Text)
        {
            cmd.CommandText = commandText;
            cmd.CommandType = commandType;
            OpenConnection();
            int result = cmd.ExecuteNonQuery();
            CloseConnection();
            cmd.CommandType = CommandType.Text;
            return result;
        }

        //TODO:Execute scalar metodu gerekirse yazılacak.


        /// <summary>
        /// Birden çok parametre alacaksa sorgu bu metodu kullanabilirsiniz.
        /// </summary>
        /// <param name="parameters">parametre listeniz</param>
        public void AddMultiParameters(List<SqlParameter> parameters)
        {
            cmd.Parameters.Clear();
            foreach (SqlParameter item in parameters)
            {
                cmd.Parameters.Add(item);
            }
        }

        /// <summary>
        /// Tek parametre yollayacaksanız bu metodu kullanabilirsiniz.
        /// </summary>
        /// <param name="parameter">Parametren</param>
        public void AddParameter(SqlParameter parameter)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add(parameter);
        }



        /// <summary>
        /// Bağlantı aç
        /// </summary>
        void OpenConnection()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Bağlantı kapa
        /// </summary>
        void CloseConnection()
        {
            conn.Close();
        }


    }
}

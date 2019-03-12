using Hastane.DTO;
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
    public class DepartmanDAL
    {
        string query;
        DBHelper helper;
        HastaneDAL _hastaneDAL;
        public DepartmanDAL()
        {
            helper = new DBHelper();
            _hastaneDAL = new HastaneDAL();
        }

        /// <summary>
        /// Departmanları listelemek için bu metodu kullanabilirsiniz.
        /// </summary>
        /// <returns></returns>
        public List<Departman> GetAllDepartments()
        {
            List<Departman> departmens = new List<Departman>();
            query = "SELECT * FROM Departman";
            Departman departman = null;

            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                departman = new Departman();
                departman.DepartmanID = (int)item["DepartmanID"];
                departman.Ad = item["Ad"].ToString();
                departmens.Add(departman);
            }
            return departmens;
        }

        public Departman GetDepartmentByID(int departmentID)
        {
            Departman dep = new Departman();
            query = "SELECT * FROM Departman WHERE DepartmanID=@depID";
            SqlParameter id = new SqlParameter("@depID", departmentID);
            helper.AddParameter(id);
            DataRow row = helper.FillDataTable(query).Rows[0];
            dep.DepartmanID = (int)row["DepartmanID"];
            dep.Ad = row["Ad"].ToString();

            return dep;
        }

        public List<HastaneDepDTO> GetDepandHospitalInfoByHospitalID(int hospitalID)
        {
            int value = 0;
            HastaneDepDTO hdDto = null;
            List<HastaneDepDTO> hastaneDepDTO = new List<HastaneDepDTO>();
            query = "SELECT * FROM HastaneDepartman WHERE HastaneID=@hastaneID";
            SqlParameter id = new SqlParameter("@hastaneID", hospitalID);
            helper.AddParameter(id);
            foreach (DataRow item in helper.FillDataTable(query).Rows)
            {
                hdDto = new HastaneDepDTO();
                value = (int)item["DepartmanID"];
                hdDto.Hastahane = _hastaneDAL.GetHospitalById(hospitalID);
                hdDto.Departman = GetDepartmentByID(value);
                hastaneDepDTO.Add(hdDto);
            }
            return hastaneDepDTO;
        }
    }
}

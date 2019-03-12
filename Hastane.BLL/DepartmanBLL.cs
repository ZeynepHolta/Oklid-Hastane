using Hastane.DAL;
using Hastane.DTO;
using Hastane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL
{
    public class DepartmanBLL
    {
        DepartmanDAL _departmanDAL;
        HastaneBLL _hastaneBLL;
        List<HastaneDepDTO> hastaneDepDTO;
        public DepartmanBLL()
        {
            _departmanDAL = new DepartmanDAL();
            _hastaneBLL = new HastaneBLL();
           
        }

        public List<Departman> GetDepartmanlar()
        {
            return _departmanDAL.GetAllDepartments();
        }

        public Departman GetByID(int departmanID)
        {
            Departman departman = _departmanDAL.GetDepartmentByID(departmanID);
            if (departman == null)
            {
                throw new IDBulunamadi("Departman");
            }

            return departman;
        }

        

        public List<HastaneDepDTO> HastaneninDepartmanIDleriniGetir(int hastaneID)
        {
          return  _departmanDAL.GetDepandHospitalInfoByHospitalID(hastaneID);

        }

        public List<Departman> DepartmanlariGetir(int hastaneID)
        {
            List<Departman> departmanlar = new List<Departman>();
            List<HastaneDepDTO> hdDTO = new List<HastaneDepDTO>();
            hdDTO = HastaneninDepartmanIDleriniGetir(hastaneID);
            Departman dep = null;
            foreach (HastaneDepDTO item in hdDTO)
            {
                dep = new Departman();
                dep = GetByID(item.Departman.DepartmanID);
                departmanlar.Add(dep);
            }
            return departmanlar;
        }
    }
}

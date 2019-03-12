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
    
    public class RandevuTeshisBLL
    {
        RandevuTeshisDAL _rtDAL;

        public RandevuTeshisBLL()
        {
            _rtDAL = new RandevuTeshisDAL();
        }    
        
        public bool Add(RandevuTeshisDTO rdDTO)
        {
            Randevu randevu=rdDTO.Randevu;
            try
            {
                foreach (Teshis teshis in rdDTO.Teshisler)
                {
                    _rtDAL.Add(randevu.RandevuID, teshis.TeshisID);
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}

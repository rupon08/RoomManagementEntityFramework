using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_CountryMasterService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_CountryMaster> GetAllData()
        {
            return context.Tbl_CountryMaster.ToList();
        }


        public void InsertCountry(Tbl_CountryMaster objTbl_CountryMaster)
        {
            context.Tbl_CountryMaster.AddObject(objTbl_CountryMaster);
            context.SaveChanges();
        }
        public void UpdateCountry(Tbl_CountryMaster objTbl_CountryMaster)
        {

            context.Tbl_CountryMaster.ApplyChanges(objTbl_CountryMaster);
            context.SaveChanges();
        
         
        }
        public void DeleteCountry(Tbl_CountryMaster objTbl_CountryMaster)
        {
            context.Tbl_CountryMaster.DeleteObject(objTbl_CountryMaster);
            context.SaveChanges();
        }
    }
}

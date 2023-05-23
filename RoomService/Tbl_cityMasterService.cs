using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_cityMasterService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_cityMaster> GetAllData()
        {
            return context.Tbl_cityMaster.ToList();
        }


        public void InsertCity(Tbl_cityMaster objTbl_cityMaster)
        {
            context.Tbl_cityMaster.AddObject(objTbl_cityMaster);
            context.SaveChanges();
        }
        public void UpdateCity(Tbl_cityMaster objTbl_cityMaster)
        {

            context.Tbl_cityMaster.ApplyChanges(objTbl_cityMaster);
            context.SaveChanges();
        
         
        }
        public void DeleteCity(Tbl_cityMaster objTbl_cityMaster)
        {
            context.Tbl_cityMaster.DeleteObject(objTbl_cityMaster);
            context.SaveChanges();
        }
    }
}

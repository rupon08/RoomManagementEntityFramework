using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_maritalStatusMasterService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_maritalStatusMaster> GetAllData()
        {
            return context.Tbl_maritalStatusMaster.ToList();
        }


        public void InsertMaritalStatus(Tbl_maritalStatusMaster objTbl_maritalStatusMaster)
        {
            context.Tbl_maritalStatusMaster.AddObject(objTbl_maritalStatusMaster);
            context.SaveChanges();
        }
        public void UpdateMaritalStatus(Tbl_maritalStatusMaster objTbl_maritalStatusMaster)
        {

            context.Tbl_maritalStatusMaster.ApplyChanges(objTbl_maritalStatusMaster);
            context.SaveChanges();
        
         
        }
        public void DeleteMaritalStatus(Tbl_maritalStatusMaster objTbl_maritalStatusMaster)
        {
            context.Tbl_maritalStatusMaster.DeleteObject(objTbl_maritalStatusMaster);
            context.SaveChanges();
        }
    }
}

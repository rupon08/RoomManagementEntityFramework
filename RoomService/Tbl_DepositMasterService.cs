using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_DepositMasterService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_DepositMaster> GetAllData()
        {
            return context.Tbl_DepositMaster.ToList();
        }


        public void InsertDepositMaster(Tbl_DepositMaster objTbl_DepositMaster)
        {
            context.Tbl_DepositMaster.AddObject(objTbl_DepositMaster);
            context.SaveChanges();
        }
        public void UpdateDepositMaster(Tbl_DepositMaster objTbl_DepositMaster)
        {

            context.Tbl_DepositMaster.ApplyChanges(objTbl_DepositMaster);
            context.SaveChanges();
        
         
        }
        public void DeleteDepositMaster(Tbl_DepositMaster objTbl_DepositMaster)
        {
            context.Tbl_DepositMaster.DeleteObject(objTbl_DepositMaster);
            context.SaveChanges();
        }
    }
}

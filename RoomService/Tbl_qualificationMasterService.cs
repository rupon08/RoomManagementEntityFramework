using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_qualificationMasterService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_qualificationMaster> GetAllData()
        {
            return context.Tbl_qualificationMaster.ToList();
        }


        public void InsertQualification(Tbl_qualificationMaster objTbl_qualificationMaster)
        {
            context.Tbl_qualificationMaster.AddObject(objTbl_qualificationMaster);
            context.SaveChanges();
        }
        public void UpdateQualification(Tbl_qualificationMaster objTbl_qualificationMaster)
        {

            context.Tbl_qualificationMaster.ApplyChanges(objTbl_qualificationMaster);
            context.SaveChanges();
        
         
        }
        public void DeleteQualification(Tbl_qualificationMaster objTbl_qualificationMaster)
        {
            context.Tbl_qualificationMaster.DeleteObject(objTbl_qualificationMaster);
            context.SaveChanges();
        }
    }
}

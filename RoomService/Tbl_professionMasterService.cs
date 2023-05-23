using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_professionMasterService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_professionMaster> GetAllData()
        {
            return context.Tbl_professionMaster.ToList();
        }


        public void InsertProfession(Tbl_professionMaster objTbl_professionMaster)
        {
            context.Tbl_professionMaster.AddObject(objTbl_professionMaster);
            context.SaveChanges();
        }
        public void UpdateProfession(Tbl_professionMaster objTbl_professionMaster)
        {

            context.Tbl_professionMaster.ApplyChanges(objTbl_professionMaster);
            context.SaveChanges();
        
         
        }
        public void DeleteProfession(Tbl_professionMaster objTbl_qualificationMaster)
        {
            context.Tbl_professionMaster.DeleteObject(objTbl_qualificationMaster);
            context.SaveChanges();
        }
    }
}

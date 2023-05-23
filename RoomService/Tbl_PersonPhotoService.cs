using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_PersonPhotoService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_PersonPhoto> GetAllData()
        {
            return context.Tbl_PersonPhoto.ToList();
        }


        public void InsertPhoto(Tbl_PersonPhoto objTbl_PersonPhoto)
        {
            context.Tbl_PersonPhoto.AddObject(objTbl_PersonPhoto);
            context.SaveChanges();
        }
        public void UpdatePhoto(Tbl_PersonPhoto objTbl_PersonPhoto)
        {

            context.Tbl_PersonPhoto.ApplyChanges(objTbl_PersonPhoto);
            context.SaveChanges();
        
         
        }
        public void DeleteCity(Tbl_cityMaster objTbl_cityMaster)
        {
            context.Tbl_cityMaster.DeleteObject(objTbl_cityMaster);
            context.SaveChanges();
        }
    }
}

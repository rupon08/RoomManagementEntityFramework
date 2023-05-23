using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_LoginService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_Login> GetAllData()
        {
            return context.Tbl_Login.ToList();
        }


        public void InsertLogIn(Tbl_Login objTbl_Login)
        {
            context.Tbl_Login.AddObject(objTbl_Login);
            context.SaveChanges();
        }
        public void UpdateLogIn(Tbl_Login objTbl_Login)
        {

            context.Tbl_Login.ApplyChanges(objTbl_Login);
            context.SaveChanges();
        
         
        }
        public void DeleteLogIn(Tbl_Login objTbl_Login)
        {
            context.Tbl_Login.DeleteObject(objTbl_Login);
            context.SaveChanges();
        }
        public void DeleteLogInSelectByID(int rowID)
        {

            try
            {
                Expression<Func<Tbl_Login, bool>> where = x =>
                    x.rowID == rowID;

                context.DeleteObject(where);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

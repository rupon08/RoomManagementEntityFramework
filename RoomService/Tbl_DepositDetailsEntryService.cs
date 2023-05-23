using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_DepositDetailsEntryService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_DepositDetailsEntry> GetAllData()
        {
            return context.Tbl_DepositDetailsEntry.ToList();
        }


        public void InsertDeposit(Tbl_DepositDetailsEntry objTbl_DepositDetailsEntry)
        {
            context.Tbl_DepositDetailsEntry.AddObject(objTbl_DepositDetailsEntry);
            context.SaveChanges();
        }
        public void UpdateDeposit(Tbl_DepositDetailsEntry objTbl_DepositDetailsEntry)
        {

            context.Tbl_DepositDetailsEntry.ApplyChanges(objTbl_DepositDetailsEntry);
            context.SaveChanges();
        
         
        }
        public void DeleteDeposit(Tbl_DepositDetailsEntry objTbl_DepositDetailsEntry)
        {
            context.Tbl_DepositDetailsEntry.DeleteObject(objTbl_DepositDetailsEntry);
            context.SaveChanges();
        }
        public void DeleteIncomeExpensesSelectByID(int rowID)
        {

            try
            {
                Expression<Func<Tbl_DepositDetailsEntry, bool>> where = x =>
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

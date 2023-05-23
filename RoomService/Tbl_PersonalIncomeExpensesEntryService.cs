using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_PersonalIncomeExpensesEntryService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_PersonalIncomeExpensesEntry> GetAllData()
        {
            return context.Tbl_PersonalIncomeExpensesEntry.ToList();
        }


        public void InsertIncomeExpenses(Tbl_PersonalIncomeExpensesEntry objTbl_PersonalIncomeExpensesEntry)
        {
            context.Tbl_PersonalIncomeExpensesEntry.AddObject(objTbl_PersonalIncomeExpensesEntry);
            context.SaveChanges();
        }
        public void UpdateIncomeExpenses(Tbl_PersonalIncomeExpensesEntry objTbl_PersonalIncomeExpensesEntry)
        {

            context.Tbl_PersonalIncomeExpensesEntry.ApplyChanges(objTbl_PersonalIncomeExpensesEntry);
            context.SaveChanges();
        
         
        }
        public void DeleteIncomeExpenses(Tbl_PersonalIncomeExpensesEntry objTbl_PersonalIncomeExpensesEntry)
        {
            context.Tbl_PersonalIncomeExpensesEntry.DeleteObject(objTbl_PersonalIncomeExpensesEntry);
            context.SaveChanges();
        }
        public void DeleteIncomeExpensesSelectByID(int rowID)
        {

            try
            {
                Expression<Func<Tbl_PersonalIncomeExpensesEntry, bool>> where = x =>x.rowID == rowID;

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

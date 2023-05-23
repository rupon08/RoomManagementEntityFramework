using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Tbl_extraExpensesMstService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_ExpensesMst> GetAllData()
        {
            return context.Tbl_ExpensesMst.ToList();
        }


        public void InsertExtraExpenses(Tbl_ExpensesMst objTbl_extraExpensesMst)
        {
            context.Tbl_ExpensesMst.AddObject(objTbl_extraExpensesMst);
            context.SaveChanges();
        }
        public void UpdateExtraExpenses(Tbl_ExpensesMst objTbl_extraExpensesMst)
        {

            context.Tbl_ExpensesMst.ApplyChanges(objTbl_extraExpensesMst);
            context.SaveChanges();
        
         
        }
        public void DeleteExtraExpenses(Tbl_ExpensesMst objTbl_extraExpensesMst)
        {
            context.Tbl_ExpensesMst.DeleteObject(objTbl_extraExpensesMst);
            context.SaveChanges();
        }
    }
}

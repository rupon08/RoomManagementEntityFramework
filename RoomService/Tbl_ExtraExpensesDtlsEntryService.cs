using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{

    public class Tbl_ExtraExpensesDtlsEntryService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_ExtraExpensesDtlsEntry> GetAllData()
        {
            return context.Tbl_ExtraExpensesDtlsEntry.ToList();
        }


        public void InsertExtraExpensesDetail(Tbl_ExtraExpensesDtlsEntry objTbl_ExtraExpensesDtlsEntry)
        {
            context.Tbl_ExtraExpensesDtlsEntry.AddObject(objTbl_ExtraExpensesDtlsEntry);
            context.SaveChanges();
        }
        public void UpdateExtraExpensesDetail(Tbl_ExtraExpensesDtlsEntry objTbl_ExtraExpensesDtlsEntry)
        {

            context.Tbl_ExtraExpensesDtlsEntry.ApplyChanges(objTbl_ExtraExpensesDtlsEntry);
            context.SaveChanges();
        
         
        }
        public void DeleteExtraExpensesDetail(Tbl_ExtraExpensesDtlsEntry objTbl_ExtraExpensesDtlsEntry)
        {
            context.Tbl_ExtraExpensesDtlsEntry.DeleteObject(objTbl_ExtraExpensesDtlsEntry);
            context.SaveChanges();
        }
    }
}

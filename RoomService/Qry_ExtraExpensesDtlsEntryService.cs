using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Qry_ExtraExpensesDtlsEntryService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Qry_ExtraExpensesDtlsEntry> GetQryAllData()
        {
            return context.Qry_ExtraExpensesDtlsEntry.ToList();
        }


    }
}

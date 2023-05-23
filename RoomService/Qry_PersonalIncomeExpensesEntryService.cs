using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;

namespace RoomService
{
    public class Qry_PersonalIncomeExpensesEntryService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Qry_PersonalIncomeExpensesEntry> GetQryAllData()
        {
            return context.Qry_PersonalIncomeExpensesEntry.ToList();
        }
    }
}

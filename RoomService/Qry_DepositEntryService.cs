using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;

namespace RoomService
{
    public class Qry_DepositEntryService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Qry_DepositEntry > GetQryAllData()
        {
            return context.Qry_DepositEntry.ToList();
        }
    }
}

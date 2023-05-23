using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
    public class Qry_CityMasterService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Qry_CityMaster> GetQryAllData()
        {
            return context.Qry_CityMaster.ToList();
        }


    }
}

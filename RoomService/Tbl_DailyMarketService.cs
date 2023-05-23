using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
   public class Tbl_DailyMarketService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_DailyMarketEntry> GetAllData()
        {
            return context.Tbl_DailyMarketEntry.ToList();
        }
        public List<Qry_DailyMarketEntry> GetAllMarket()
        {
            return context.Qry_DailyMarketEntry.ToList();
        }
       
        public void  InsertMarket(Tbl_DailyMarketEntry objTbl_DailyMarketEntry)
        {
            context.Tbl_DailyMarketEntry.AddObject(objTbl_DailyMarketEntry);
            context.SaveChanges();
        }
       
        public void UpdateMarket(Tbl_DailyMarketEntry objTbl_DailyMarketEntry)
        {
            
            context.Tbl_DailyMarketEntry.ApplyChanges(objTbl_DailyMarketEntry);
            context.SaveChanges();
        
         
        }
        public void DeleteMarket(Tbl_DailyMarketEntry objTbl_DailyMarketEntry)
        {
            context.Tbl_DailyMarketEntry.DeleteObject (objTbl_DailyMarketEntry);
            context.SaveChanges();
        }
        public List<Tbl_DailyMarketEntry> MarketSelectByID(int RowID)
        {
            try
            {
                return context.Tbl_DailyMarketEntry.Where(x => x.rowID == RowID).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

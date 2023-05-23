using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;
using System.Linq.Expressions;


namespace RoomService
{
   public class Tbl_DailyMealService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_DailyMealEntry > GetAllData()
        {
            return context.Tbl_DailyMealEntry.ToList();
        }
        public List<Qry_DailyMealEntry> GetAllMeal()
        {
            return context.Qry_DailyMealEntry.ToList();
        }
        public void InsertMeal(Tbl_DailyMealEntry objTbl_DailyMealEntry)
        {
            context.Tbl_DailyMealEntry.AddObject(objTbl_DailyMealEntry);
            context.SaveChanges();
        }
        public void InsertMealList(List<Tbl_DailyMealEntry> lstMealList)
        {
            try
            {
                foreach (Tbl_DailyMealEntry objTbl_DailyMealEntry in lstMealList)
                {

                    context.Tbl_DailyMealEntry.AddObject(objTbl_DailyMealEntry);
                   
                }
                context.SaveChanges();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateMeal(Tbl_DailyMealEntry objTbl_DailyMealEntry)
        {
            context.Tbl_DailyMealEntry.ApplyChanges(objTbl_DailyMealEntry);
            context.SaveChanges();
        }
    }
}

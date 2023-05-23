using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoomData;

namespace RoomService
{
    public class Tbl_PersonDetailEntryService
    {
        RoomManagementNewEntities context = new RoomManagementNewEntities();
        public List<Tbl_PersonDetailsEntry> GetAllData()
        {
            return context.Tbl_PersonDetailsEntry.ToList();
        }
        public void InsertPerson(Tbl_PersonDetailsEntry objTbl_PersonDetailsEntry)
        {
            context.Tbl_PersonDetailsEntry.AddObject(objTbl_PersonDetailsEntry);
            context.SaveChanges();
        }
        public void UpdatePerson(Tbl_PersonDetailsEntry objTbl_PersonDetailsEntry)
        {

            context.Tbl_PersonDetailsEntry.ApplyChanges(objTbl_PersonDetailsEntry);
            context.SaveChanges();


        }
    }
}

using EventPlanner.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventPlanner.Mvc.App_Start
{
    public class DatabaseFactory  
    {
        static DatabaseFactory()
        {

            var db = new DatabaseFactory();

            IEnumerable<ScheduledEvent> GetAll()
            {
                return GetAll();
            }


            Database = Database;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsPublic { get; set; }

        private DatabaseFactory()
        { }

        //The only instance
        public static IEventDatabase Database { get; }
    }
}

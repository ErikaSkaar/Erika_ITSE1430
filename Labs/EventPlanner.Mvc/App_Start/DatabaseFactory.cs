using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

       
        private DatabaseFactory()
        { }
    
        //The only instance
        public static IEventDatabase Database { get; }
    }
}

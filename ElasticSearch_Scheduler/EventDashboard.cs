using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearchScheduler
{
    public class EventDashboard
    {
        public int EventCategoryID { get; set; }
        public int EventActionID { get; set; }
        public int TotalEvents { get; set; }
        public int UniqueEvents { get; set; }
        public int EventValue { get; set; }
        public double AvgEventValue { get; set; }
        public int SessionsWithEvent { get; set; }
        public double EventsPerSessionWithEvent { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        //public int DateTime { get; set; }
      
    }
}

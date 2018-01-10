using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearchScheduler
{
    public class AnalyticsModel
    {
        public string eventcategory { get; set; }
        public string eventaction { get; set; }
        public List<Analytics_value> list { get; set; }

    }

    public class Analytics_value
    {
        public string name { get; set; }
        public string value { get; set; }

    }

    public class AnalyticsModel_innerdetails
    {
        public int sessions { get; set; }
        public int users { get; set; }
        public int pageviews { get; set; }
        public int bounceRate { get; set; }
        public int visits { get; set; }
        public int pageValue { get; set; }
        public int totalEvent { get; set; }
        public int uniqueEvents { get; set; }
        public int avgEventValue { get; set; }
        public int sessionsWithEvent { get; set; }
        public int pageLoadTime { get; set; }
        public int pageDownloadTime { get; set; }
        public string eventcategory { get; set; }


    }
}

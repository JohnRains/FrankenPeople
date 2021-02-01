using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrankenPeople
{
    class __Date
    {
        public DateTime Past { get; set; }
        public DateTimeOffset PastOffset { get; set; }
        public DateTime Soon { get; set; }
        public DateTimeOffset SoonOffset { get; set; }
        public DateTime Future { get; set; }
        public DateTimeOffset FutureOffset { get; set; }
        public DateTime Between { get; set; }
        public DateTimeOffset BetweenOffset { get; set; }
        public DateTime Recent { get; set; }
        public DateTimeOffset RecentOffset { get; set; }
        public TimeSpan Timespan { get; set; }
        public string Month { get; set; }
        public string Weekday { get; set; }
    }
}

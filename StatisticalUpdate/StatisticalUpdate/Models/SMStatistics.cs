using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatisticalUpdate.Models
{
    public class SMStatistics
    {
        public int Id { get; set; }
        public int CBOType { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public int ActivityType { get; set; }
        public Double ActivityValue { get; set; }
        public int DistrictID { get; set; }

    }
}
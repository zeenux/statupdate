using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatisticalUpdate.Models
{
    public class SM
    {
        public int id { get; set; }
        public DateTime period_from { get; set; }
        public DateTime period_to { get; set; }
        public int cbo_type { get; set; }
        public int number_of_cbo_for_period { get; set; }
        public double cbo_savings { get; set; }
        public int districtId { get; set; }
        public virtual Districts districts { get; set; }

    }
}
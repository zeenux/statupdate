using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatisticalUpdate.Models
{
    public class Cbo
    {
        public int Id { get; set; }
        public String CboType { get; set; }

        public virtual ICollection<SM> SM { get; set; }
    }
}
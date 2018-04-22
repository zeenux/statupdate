using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatisticalUpdate.Models
{
    public class Users
    {
        public int id { get; set; }
        public String Username { get; set; }
        public String Pwd { get; set; }
        public int DistrictId { get; set; }
        public virtual Districts District { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatisticalUpdate.Models
{
    public class Users
    {
        public int id { get; set; }
        public String username { get; set; }
        public String pwd { get; set; }
        public int districtId { get; set; }

        public virtual Districts districts { get; set; }


    }
}
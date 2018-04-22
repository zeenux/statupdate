using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatisticalUpdate.Models
{
    public class Districts
    {
        public Districts()
        {
            this.SMs = new HashSet<SM>();
            this.users = new HashSet<Users>();
        }
        public int id { get; set; }
        public String DistrictName { get; set; }
        public virtual ICollection<SM> SMs { get; set; }

        public virtual ICollection<Users> users { get; set; }
        
    }
}
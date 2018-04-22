using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatisticalUpdate.Models.FprmModels
{
    public class LoginForm
    {
        [Display(Name ="Enter Username")]
        public String username { get; set; }
        [Display(Name ="Enter your Password")]
        public String pwd { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatisticalUpdate.Models.ViewModels
{
    public class LoginView
    {
        [Display(Name ="Username")]
        public String Username { get; set; }
        [Display(Name = "Password")]
        public String Pass { get; set; }
    }
}
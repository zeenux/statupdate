using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StatisticalUpdate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Login");//  View();
        }
        public ActionResult Login()
        {
            return View(); 
        }
        
        public void CheckLogin(StatisticalUpdate.Models.ViewModels.LoginView lv)
        {

            Response.Write(lv.Username);
            Response.Write("=====" + lv.Pass);
        }
        public ActionResult AddDistrict()
        {
            return View();
        }

        public ActionResult ShowDistricts()
        {
            return View();
        }

        public ActionResult AddSMInfo()
        {
            return View();
        }

        public ActionResult EditSMInfo()
        {
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "SRSP Statistical Update Solution";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Visit SRSP Website at http://www.srsp.org.pk";

            return View();
        }
    }
}
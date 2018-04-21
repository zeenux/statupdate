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
        public void CheckLogin()
        {
            Response.Write("Hello World");
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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
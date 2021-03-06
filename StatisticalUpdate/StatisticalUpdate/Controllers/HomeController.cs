﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StatisticalUpdate.Models;
namespace StatisticalUpdate.Controllers
{
    public class HomeController : Controller
    {
        ER db = new ER();
        public ActionResult Index()
        {
            //Districts d = new Districts { DistrictName = "Peshawar" };
            //db.districtList.Add(d);
            
            //Users u = new Users { Username = "zeenux", Pwd = "NONE123", DistrictID=1 };
            //db.User.Add(u);
            //db.SaveChanges();
            return RedirectToAction("Login");//  View();
        }
        public ActionResult Login()
        {
            return View(); 
        }
        
        public void CheckLogin(StatisticalUpdate.Models.ViewModels.LoginView lv)
        {
            var rst = db.User.Select((i) => i.Username == lv.Username && i.Pwd == lv.Pass);
            if(rst.Count()>0)
            {
                Response.Write("Found user");
            }
            else
            {
                Response.Write("Not Found");
            }
            
            
        }
        public ActionResult AddDistrict()
        {
            return View();
        }
        public ActionResult ListDistricts()
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
﻿using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TollFree = "123-123-123";
            return View();
        }

    }
}




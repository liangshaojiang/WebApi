﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string UserName,string Ticket)
        {

            ViewBag.UserName = UserName;
            ViewBag.Ticket = Ticket;

            return View();
        }

        // GET: Home
        public ActionResult Login()
        {
            return View();
        }


    }
}
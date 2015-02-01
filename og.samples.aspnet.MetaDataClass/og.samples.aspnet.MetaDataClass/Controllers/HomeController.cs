// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="ozkary.com">
//   Copyright (c) under http://opensource.org/licenses/MIT
// </copyright>
// <summary>
//   asp.net project samples for the ozkary.com blog
// <remarks>
//  http://ozkary.com
// </remarks>
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace og.samples.aspnet.Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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
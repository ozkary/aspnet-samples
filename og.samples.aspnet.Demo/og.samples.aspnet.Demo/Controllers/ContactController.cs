// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactController.cs" company="ozkary.com">
//   Copyright (c) under http://opensource.org/licenses/MIT
// </copyright>
// <summary>
//   extends enum types
// </summary>
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
    /// <summary>
    /// contact controller
    /// </summary>
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}
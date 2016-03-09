using og.samples.library.EnumTypes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace og.samples.aspnet.Demo.Controllers
{
    public class EnumProjectTypeController : Controller
    {
        // GET: EnumProjectType
        public ActionResult Index()
        {
            ViewBag.Message = "Enum Project Type Demo";
            ProjectTypeList list = ProjectTypeList.BuildList();          
            return View(list);
        }
       
    }
}
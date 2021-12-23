using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PermissionPersonal.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateRequest()
        {
            return View();
        }
        public ActionResult UsedDates()
        {
            return View();
        }
    }
}
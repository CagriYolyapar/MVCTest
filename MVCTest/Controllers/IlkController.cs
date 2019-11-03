using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class IlkController : Controller
    {
        // GET: Ilk
        public ActionResult Index()
        {
            return View();
        }
    }
}
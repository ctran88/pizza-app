using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pizza_App.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult Index()
        {
            return PartialView ();
        }
    }
}

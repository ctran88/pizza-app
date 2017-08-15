using System.Web.Mvc;

namespace PizzaApp.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult Index()
        {
            return PartialView ();
        }
    }
}

using System.Web.Mvc;

namespace PizzaApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}
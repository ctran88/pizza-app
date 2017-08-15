using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using PizzaApp.DAL.Models;

namespace PizzaApp.Controllers.Api
{
    public class PizzasController : ApiController
    {
        private PizzaAppContext db = new PizzaAppContext();

		protected override void Dispose(bool disposing)
		{
			if (db != null)
			{
				db.Dispose();
			}

			base.Dispose(disposing);
		}

        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
            var typeList = db.Pizzas.ToList();
            return typeList;
        }
    }
}

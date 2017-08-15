using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using PizzaApp.DAL.Models;

namespace PizzaApp.Controllers.Api
{
    public class OrdersController : ApiController
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
        public IEnumerable<CustomerOrder> Get()
        {
            var orderList = db.CustomerOrders
                              .OrderByDescending(o => o.CustomerOrderId)
                              .ToList();

            return orderList;
        }

        [HttpPost]
        public IHttpActionResult Post(CustomerOrder order)
        {
            if (ModelState.IsValid)
            {
                string result = "Order submitted successfully.";
                db.CustomerOrders.Add(order);
                db.SaveChanges();
                
                return Ok(result);
            }
            else
            {
                string error = "Invalid order submission.";

                return Content(System.Net.HttpStatusCode.BadRequest, error); 
            }
        }
    }
}

﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Pizza_App.Models;
using System.Web.Mvc;

namespace Pizza_App.Controllers.Api
{
    public class OrdersController : ApiController
    {
        private AceOfSpadesDb db = new AceOfSpadesDb();

		protected override void Dispose(bool disposing)
		{
			if (db != null)
			{
				db.Dispose();
			}

			base.Dispose(disposing);
		}

        [System.Web.Http.HttpGet]
        public IEnumerable<CustomerOrder> Get()
        {
            var orderList = db.CustomerOrders.ToList();
            return orderList;
        }

        [System.Web.Http.HttpPost]
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

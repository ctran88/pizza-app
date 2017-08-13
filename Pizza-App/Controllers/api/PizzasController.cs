﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Pizza_App.Models;
using System.Web.Mvc;

namespace Pizza_App.Controllers.Api
{
    public class PizzasController : ApiController
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
        public IEnumerable<Pizza> Get()
        {
            var typeList = db.Pizzas.ToList();
            return typeList;
        }
    }
}

﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Pizza_App.Models;
using System.Web.Mvc;

namespace Pizza_App.Controllers.Api
{
    public class PizzaTypesController : ApiController
    {
        private Pizza_AppDb db = new Pizza_AppDb();

		protected override void Dispose(bool disposing)
		{
			if (db != null)
			{
				db.Dispose();
			}

			base.Dispose(disposing);
		}

        [System.Web.Http.HttpGet]
        public IEnumerable<PizzaType> Get()
        {
            var typeList = db.PizzaTypes.ToList();
            return typeList;
        }
    }
}

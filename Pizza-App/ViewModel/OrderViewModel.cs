using Pizza_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza_App.ViewModel
{
    public class OrderViewModel
    {
        public CustomerOrder CustomerOrder { get; set; }
        public IEnumerable<Pizza> Pizza { get; set; }
    }
}
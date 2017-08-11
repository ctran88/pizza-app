using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace Pizza_App
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "GetPizzaTypes",
                routeTemplate: "api/pizza-types",
                defaults: new { controller = "PizzaTypes", action = "Get" }
            );

            config.Routes.MapHttpRoute(
                name: "GetOrder",
                routeTemplate: "api/orders",
                defaults: new { controller = "Orders", action = "Get" }
            );

            config.Routes.MapHttpRoute(
                name: "PostOrder",
                routeTemplate: "api/orders",
                defaults: new { controller = "Orders", action = "Post" }
            );
        }
    }
}

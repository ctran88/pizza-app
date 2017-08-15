using System.Web.Http;

namespace PizzaApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Pizzas",
                routeTemplate: "api/pizzas",
                defaults: new { controller = "Pizzas", action = "Get" }
            );

            config.Routes.MapHttpRoute(
                name: "ApiOrders",
                routeTemplate: "api/orders",
                defaults: new { controller = "Orders" }
            );
        }
    }
}

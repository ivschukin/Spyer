using System.Web.Mvc;
using System.Web.Routing;

namespace Spyer
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.LowercaseUrls = true;

            routes.MapRoute("Partials", "partials/{controller}/{action}", new { controller = "Home", action = "Index" });
            routes.MapRoute("Default", "{*url}", new { controller = "Main", action = "Index" });
        }
    }
}

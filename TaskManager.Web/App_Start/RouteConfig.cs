using System.Web.Mvc;
using System.Web.Routing;
using TaskManager.Infrastructure.Constants;
using TaskManager.Web.Controllers;

namespace TaskManager.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Base",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = LoginController.Name, action = Actions.Index, id = UrlParameter.Optional }
            );
        }
    }
}
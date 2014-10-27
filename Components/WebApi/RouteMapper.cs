using System.Web.Http;
using DotNetNuke.Web.Api;

namespace CompanyName.ModuleName.Components.WebApi
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("CompanyName/ModuleName", "Default", "{controller}/{action}/{id}", new
            {
                id = RouteParameter.Optional,
                action = "Get"
            }, new string[] { "CompanyName.ModuleName.Components.WebApi" });
        }
    }
}
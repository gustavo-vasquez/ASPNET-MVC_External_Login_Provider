using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_External_Login_Provider
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

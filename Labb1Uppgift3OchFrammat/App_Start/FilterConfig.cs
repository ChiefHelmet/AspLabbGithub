using System.Web;
using System.Web.Mvc;

namespace Labb1Uppgift3OchFrammat
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

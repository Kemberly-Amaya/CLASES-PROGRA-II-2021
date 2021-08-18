using System.Web;
using System.Web.Mvc;

namespace AplicacionWebASP.NetClase02
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

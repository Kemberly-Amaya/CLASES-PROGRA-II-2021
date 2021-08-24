using System.Web;
using System.Web.Mvc;

namespace Practica_ClaseSemana4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

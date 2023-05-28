using System.Web;
using System.Web.Mvc;

namespace Prueba_Tecnica_Sistran
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace BTL_Nhom2_TTCNTKPM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

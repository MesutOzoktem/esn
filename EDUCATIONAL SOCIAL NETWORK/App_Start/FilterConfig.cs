using System.Web;
using System.Web.Mvc;

namespace EDUCATIONAL_SOCIAL_NETWORK
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

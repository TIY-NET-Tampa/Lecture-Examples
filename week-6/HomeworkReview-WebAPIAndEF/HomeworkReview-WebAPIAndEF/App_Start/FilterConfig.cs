using System.Web;
using System.Web.Mvc;

namespace HomeworkReview_WebAPIAndEF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

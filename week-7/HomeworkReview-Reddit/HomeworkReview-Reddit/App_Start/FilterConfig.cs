using System.Web;
using System.Web.Mvc;

namespace HomeworkReview_Reddit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

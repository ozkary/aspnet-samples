using System.Web;
using System.Web.Mvc;

namespace og.samples.aspnet.MetaDataClass
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

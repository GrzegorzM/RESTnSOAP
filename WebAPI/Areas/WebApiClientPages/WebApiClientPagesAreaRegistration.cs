using System.Web.Mvc;

namespace WebAPI.Areas.WebApiClientPages
{
    public class WebApiClientPagesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "WebApiClientPages";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "WebApiClientPages_default",
                "WebApiClientPages/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
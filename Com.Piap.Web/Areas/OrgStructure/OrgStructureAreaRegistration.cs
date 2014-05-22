using System.Web.Mvc;

namespace Com.Piap.Web.Areas.OrgStructure
{
    public class OrgStructureAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "OrgStructure";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "OrgStructure_default",
                "OrgStructure/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
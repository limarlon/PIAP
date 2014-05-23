using System.Web.Mvc;

namespace Com.Piap.Web.Areas.DataMigration
{
    public class DataMigrationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "DataMigration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "DataMigration_default",
                "DataMigration/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
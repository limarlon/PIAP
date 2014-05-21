using System.Web.Mvc;

namespace Com.Piap.Web.Areas.IndexManage {
    public class IndexManageAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "IndexManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "IndexManage_default",
                "IndexManage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
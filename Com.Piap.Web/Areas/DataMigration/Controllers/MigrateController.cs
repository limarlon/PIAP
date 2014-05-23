using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Com.Piap.Web.Areas.DataMigration.Controllers {
    public class MigrateController : Controller {
        //
        // GET: /DataMigration/Migrate/
        public ActionResult Index() {
            return View();
        }

        public ActionResult DataImport() {
            return View();
        }
    }
}
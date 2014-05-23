using System;
using System.Collections.Generic;
using System.IO;
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

        /// <summary>
        /// GET html
        /// </summary>
        /// <returns></returns>
        public ActionResult DataImport() {
            return View();
        }

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public ActionResult Submit(IEnumerable<HttpPostedFileBase> files) {
            foreach (var file in files) {
                file.SaveAs(this.Server.MapPath("../../")+"/Upload/" + file.FileName);
            }
            return RedirectToAction("DataImport");
        }
        public ActionResult Result() {
            return View();
        }
        private IEnumerable<string> GetFileInfo(IEnumerable<HttpPostedFileBase> files) {
            return
                from a in files
                where a != null
                select string.Format("{0} ({1} bytes)", Path.GetFileName(a.FileName), a.ContentLength);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Model = Com.Piap.IndexManage.Model;
using IService = Com.Piap.IndexManage.IService;
using Service = Com.Piap.IndexManage.Service;

namespace Com.Piap.Web.Areas.IndexManage.Controllers
{
    public class DirectionController : Controller
    {
        public IService.IDirectionService direction_service = new Service.DirectionService();
        //
        // GET: /IndexManage/Direction/
        public ActionResult Index() {
            return View();
        }

        public JsonResult All() {
            List<Model.Direction> list = direction_service.GetAll();
            return Json(list,JsonRequestBehavior.AllowGet);
        }

	}
}
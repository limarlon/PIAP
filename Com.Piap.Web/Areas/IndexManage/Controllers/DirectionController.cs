using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Model = Com.Piap.IndexManage.Model;
using IService = Com.Piap.IndexManage.IService;
using Service = Com.Piap.IndexManage.Service;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace Com.Piap.Web.Areas.IndexManage.Controllers
{
    public class DirectionController : Controller
    {
        public IService.IDirectionService directionService = new Service.DirectionService();
        //
        // GET: /IndexManage/Direction/
        public ActionResult Index() {
            return View();
        }

        // GET: /IndexManage/Direction/All
        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult All([DataSourceRequest]DataSourceRequest request) {
            List<Model.Direction> list = directionService.GetAll();
            return Json(list.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="request"></param>
        /// <param name="directions"></param>
        /// <returns></returns>
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(
            [DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<Model.Direction> directions) {
            if (directions != null && ModelState.IsValid) {
                foreach (var direction in directions) {
                    directionService.Create(direction);
                }
            }
            return Json(directions.ToDataSourceResult(request, ModelState));
        }
        
        /// <summary>
        /// 批量移除
        /// </summary>
        /// <param name="request"></param>
        /// <param name="directions"></param>
        /// <returns></returns>
        public ActionResult Remove([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<Model.Direction> directions) {
            if (directions != null && ModelState.IsValid) {
                foreach (var direction in directions) {
                    directionService.Remove(direction);
                }
            }
            return Json(directions.ToDataSourceResult(request, ModelState));
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="request"></param>
        /// <param name="directions"></param>
        /// <returns></returns>
        public ActionResult Delete([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<Model.Direction> directions) {
            if (directions != null && ModelState.IsValid) {
                foreach (var direction in directions) {
                    directionService.Delete(direction);
                }
            }
            return Json(directions.ToDataSourceResult(request, ModelState));
        }

        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="request"></param>
        /// <param name="directions"></param>
        /// <returns></returns>
        public ActionResult Modify([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<Model.Direction> directions) {
            if (directions != null && ModelState.IsValid) {
                foreach (var direction in directions) {
                    directionService.Modify(direction);
                }
            }
            return Json(directions.ToDataSourceResult(request, ModelState));
        }

	}
}
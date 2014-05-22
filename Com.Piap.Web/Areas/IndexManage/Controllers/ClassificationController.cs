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

namespace Com.Piap.Web.Areas.IndexManage.Controllers {
    public class ClassificationController : Controller {
        public IService.IClassificationService classificationService = new Service.ClassificationService();

        //
        // GET: /IndexManage/Classification/
        public ActionResult Index() {
            return View();
        }

        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult All([DataSourceRequest]DataSourceRequest request) {
            List<Model.Classification> list = classificationService.GetAll();
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
            [Bind(Prefix = "models")]IEnumerable<Model.Classification> classifications) {
                if (classifications != null && ModelState.IsValid) {
                    foreach (var classification in classifications) {
                        classificationService.Create(classification);
                }
            }
            return Json(classifications.ToDataSourceResult(request, ModelState));
        }

        /// <summary>
        /// 批量移除
        /// </summary>
        /// <param name="request"></param>
        /// <param name="directions"></param>
        /// <returns></returns>
        public ActionResult Remove([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<Model.Classification> classifications) {
                if (classifications != null && ModelState.IsValid) {
                    foreach (var classification in classifications) {
                        classificationService.Remove(classification);
                }
            }
            return Json(classifications.ToDataSourceResult(request, ModelState));
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="request"></param>
        /// <param name="directions"></param>
        /// <returns></returns>
        public ActionResult Delete([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<Model.Classification> classifications) {
                if (classifications != null && ModelState.IsValid) {
                    foreach (var classification in classifications) {
                        classificationService.Delete(classification);
                }
            }
                return Json(classifications.ToDataSourceResult(request, ModelState));
        }

        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="request"></param>
        /// <param name="directions"></param>
        /// <returns></returns>
        public ActionResult Modify([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<Model.Classification> classifications) {
                if (classifications != null && ModelState.IsValid) {
                    foreach (var classification in classifications) {
                        classificationService.Modify(classification);
                }
            }
                return Json(classifications.ToDataSourceResult(request, ModelState));
        }
    }
}
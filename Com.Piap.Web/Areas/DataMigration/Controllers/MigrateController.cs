using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NPOI.HSSF;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using model = Com.Piap.IndexManage.Model;
using service = Com.Piap.IndexManage.Service;

namespace Com.Piap.Web.Areas.DataMigration.Controllers {
    public class MigrateController : Controller {
        service.ClassificationService classificationService = new service.ClassificationService();
        service.CategoryService categoryService = new service.CategoryService();
        service.IndexService indexService = new service.IndexService();
        service.IndexValueService indexValueService = new service.IndexValueService();
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


        /// <summary>
        /// 导入分类
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public ActionResult ImportClassification(IEnumerable<HttpPostedFileBase> files) {
            List<string> filespanth = new List<string>();
            foreach (var file in files) {
                string filepath = this.Server.MapPath("../../") + "/Upload/" + file.FileName;
                filespanth.Add(filepath);
                file.SaveAs(filepath);
            }
            foreach (var filepath in filespanth) {
                using (FileStream fs = System.IO.File.OpenRead(filepath)) {
                    HSSFWorkbook wk = new HSSFWorkbook(fs);
                    ISheet sheet = wk.GetSheetAt(0);
                    List<model.Classification> classifications = new List<model.Classification>();
                    for (int rn = 1; rn <= sheet.LastRowNum; rn++) {
                        IRow row = sheet.GetRow(rn);
                        if (row.GetCell(2) != null && row.GetCell(2).ToString() != "") {
                            model.Classification classification = new model.Classification();
                            classification.Id = Guid.NewGuid().ToString();
                            classification.Code = row.GetCell(1).ToString();
                            classification.Name = row.GetCell(2).ToString();
                            classification.DirectionId = row.GetCell(0).ToString();
                            classification.Remarks = row.GetCell(3).ToString();
                            classification.Enable = true;
                            classification.Deleted = false;
                            classifications.Add(classification);
                        }
                    }

                    foreach (var classification in classifications) {
                        classificationService.Create(classification);
                    }
                    System.IO.File.Delete(filepath);
                }
            }



            return RedirectToAction("DataImport");
        }

        /// <summary>
        /// 导入类目
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public ActionResult ImportCategory(IEnumerable<HttpPostedFileBase> files) {
            List<string> filespanth = new List<string>();
            foreach (var file in files) {
                string filepath = this.Server.MapPath("../../") + "/Upload/" + file.FileName;
                filespanth.Add(filepath);
                file.SaveAs(filepath);
            }
            foreach (var filepath in filespanth) {
                using (FileStream fs = System.IO.File.OpenRead(filepath)) {
                    HSSFWorkbook wk = new HSSFWorkbook(fs);
                    ISheet sheet = wk.GetSheetAt(0);
                    List<model.Category> categorys = new List<model.Category>();
                    for (int rn = 1; rn <= sheet.LastRowNum; rn++) {
                        IRow row = sheet.GetRow(rn);
                        if (row.GetCell(2) != null && row.GetCell(2).ToString() != "") {
                            model.Category category = new model.Category();
                            category.Id = Guid.NewGuid().ToString();
                            category.Code = row.GetCell(1).ToString();
                            category.Name = row.GetCell(2).ToString();
                            category.ClassificationId = row.GetCell(0).ToString();
                            category.DirectionId = "01";
                            category.Remarks = row.GetCell(3).ToString();
                            category.Enable = true;
                            category.Deleted = false;
                            categorys.Add(category);
                        }
                    }

                    foreach (var category in categorys) {
                        categoryService.Create(category);
                    }
                    System.IO.File.Delete(filepath);
                }
            }



            return RedirectToAction("DataImport");
        }

        /// <summary>
        /// 导入指标定义
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public ActionResult ImportIndexs(IEnumerable<HttpPostedFileBase> files) {
            List<string> filespanth = new List<string>();
            foreach (var file in files) {
                string filepath = this.Server.MapPath("../../") + "/Upload/" + file.FileName;
                filespanth.Add(filepath);
                file.SaveAs(filepath);
            }
            foreach (var filepath in filespanth) {
                using (FileStream fs = System.IO.File.OpenRead(filepath)) {
                    HSSFWorkbook wk = new HSSFWorkbook(fs);
                    ISheet sheet = wk.GetSheetAt(0);
                    List<model.Indexs> indexss = new List<model.Indexs>();
                    for (int rn = 1; rn <= sheet.LastRowNum; rn++) {
                        IRow row = sheet.GetRow(rn);
                        if (row.GetCell(2) != null && row.GetCell(2).ToString() != "") {
                            model.Indexs indexs = new model.Indexs();
                            indexs.Id = Guid.NewGuid().ToString();
                            indexs.Code = row.GetCell(1).ToString();
                            indexs.Name = row.GetCell(2).ToString();
                            indexs.ClassificationId = row.GetCell(0).ToString();
                            indexs.Unit = row.GetCell(3).ToString();
                            indexs.Space = row.GetCell(4).ToString();
                            indexs.Remarks = row.GetCell(5).ToString();
                            indexs.Enable = true;
                            indexs.Deleted = false;
                            indexss.Add(indexs);
                        }
                    }

                    foreach (var indexs in indexss) {
                        indexService.Create(indexs);
                    }
                    System.IO.File.Delete(filepath);
                }
            }



            return RedirectToAction("DataImport");
        }

        /// <summary>
        /// 导入指标值
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public ActionResult ImportIndexValue(IEnumerable<HttpPostedFileBase> files) {
            List<string> filespanth = new List<string>();
            foreach (var file in files) {
                string filepath = this.Server.MapPath("../../") + "/Upload/" + file.FileName;
                filespanth.Add(filepath);
                file.SaveAs(filepath);
            }
            foreach (var filepath in filespanth) {
                using (FileStream fs = System.IO.File.OpenRead(filepath)) {
                    HSSFWorkbook wk = new HSSFWorkbook(fs);
                    ISheet sheet = wk.GetSheetAt(0);
                    List<model.IndexInstance> indexvalues = new List<model.IndexInstance>();
                    for (int rn = 1; rn <= sheet.LastRowNum; rn++) {
                        IRow row = sheet.GetRow(rn);
                        if (row.GetCell(2) != null && row.GetCell(2).ToString() != "") {
                            model.IndexInstance indexvalue = new model.IndexInstance();
                            indexvalue.Id = Guid.NewGuid().ToString();
                            indexvalue.Code = row.GetCell(0).ToString();
                            indexvalue.Time = row.GetCell(1).ToString();
                            indexvalue.Value = Convert.ToDecimal(row.GetCell(2).ToString());
                            indexvalue.Remarks = row.GetCell(3).ToString();
                            indexvalues.Add(indexvalue);
                        }
                    }

                    foreach (var indexvalue in indexvalues) {
                        indexValueService.Create(indexvalue);
                    }
                    System.IO.File.Delete(filepath);
                }
            }



            return RedirectToAction("DataImport");
        }

    }
}
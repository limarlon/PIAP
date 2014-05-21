/****************************
 * limt create 2014.5.20
 * 指标管理-
 ****************************/
namespace Com.Piap.IndexManage.Model {
    /// <summary>
    /// 分类方向
    /// </summary>
    public class Direction {
        /// <summary>
        /// GUID
        /// </summary>
        public string Id { set; get; }
        /// <summary>
        /// 分类方向代码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 分类方向名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { set; get; }
        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { set; get; }
        /// <summary>
        /// 逻辑删除
        /// </summary>
        public bool Deleted { set; get; }
    }
}

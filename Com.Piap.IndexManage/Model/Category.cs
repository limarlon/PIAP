using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Piap.IndexManage.Model {
    /// <summary>
    /// 指标库类目
    /// </summary>
    public class Category {
        /// <summary>
        /// 分类编号
        /// </summary>
        public string Id { set; get; }
        /// <summary>
        /// 代码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 分类方向
        /// </summary>
        public string DirectionId { set; get; }

        /// <summary>
        /// 分类
        /// </summary>
        public string ClassificationId { set; get; }
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

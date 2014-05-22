using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Piap.IndexManage.Model {
    /// <summary>
    /// 指标
    /// </summary>
    public class Index {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { set; get; }
        /// <summary>
        /// 指标代码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 指标名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 计量单位
        /// </summary>
        public string Unit { set; get; }
        /// <summary>
        /// 分类
        /// </summary>
        public string ClassificationId { set; get; }
        /// <summary>
        /// 空间
        /// </summary>
        public string Space { set; get; }
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

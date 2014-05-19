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
        /// 
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
    }
}

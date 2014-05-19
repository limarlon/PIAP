using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Piap.IndexManage.Model {
    /// <summary>
    /// 指标实例
    /// </summary>
    public class IndexInstance {
        /// <summary>
        /// 
        /// </summary>
        public string Id { set; get; }
        /// <summary>
        /// 指标代码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 时间
        /// </summary>
        public string Time { set; get; }
        /// <summary>
        /// 指标值
        /// </summary>
        public Decimal Value { set; get; }
    }
}

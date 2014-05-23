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
        /// 编号
        /// </summary>
        public string Id { set; get; }
        /// <summary>
        /// 指标代码
        /// </summary>
        public string Code { set; get; }
        /// <summary>
        /// 时间点
        /// </summary>
        public string Time { set; get; }
        /// <summary>
        /// 指标值
        /// </summary>
        public Decimal Value { set; get; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { set; get; }
    }
}

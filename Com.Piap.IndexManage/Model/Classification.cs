using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Piap.IndexManage.Model {
    /// <summary>
    /// 指标分类
    /// </summary>
    public class Classification {
        /// <summary>
        /// 
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Piap.Security.Model
{
    /// <summary>
    /// 资源类型
    /// </summary>
    public class ResourceType
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { set; get; }

        /// <summary>
        /// 具体资源表名
        /// </summary>
        public string RefTableName { set; get; }
    }
}

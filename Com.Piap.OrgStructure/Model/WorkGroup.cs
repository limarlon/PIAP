using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Piap.OrgStructure.Model
{
    /// <summary>
    /// 工作组
    /// </summary>
    public class WorkGroup
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
    }
}

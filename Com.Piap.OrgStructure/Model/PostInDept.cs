using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Piap.OrgStructure.Model
{
    /// <summary>
    /// 部门岗位
    /// </summary>
    public class PostInDept
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
        /// 职务编号
        /// </summary>
        public string PostId { set; get; }

        /// <summary>
        /// 部门编号
        /// </summary>
        public string DeptId { set; get; }

    }
}

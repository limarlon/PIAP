using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Piap.OrgStructure.Model
{
    /// <summary>
    /// 用户部门关系
    /// </summary>
    public class UserInDept
    {
        /// <summary>
        /// 部门编号
        /// </summary>
        public string DeptId { set; get; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserId { set; get; }

        /// <summary>
        /// 默认
        /// </summary>
        public string Default { set; get; }
    }
}

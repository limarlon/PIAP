using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Piap.OrgStructure.Model
{
    /// <summary>
    /// 部门组织关联
    /// </summary>
    public class DeptInOrg
    {
        /// <summary>
        /// 部门编号
        /// </summary>
        public string DeptId { set; get; }

        /// <summary>
        /// 组织编号
        /// </summary>
        public string OrgId { set; get; }

        /// <summary>
        /// 默认
        /// </summary>
        public string Default { set; get; }

        public DeptInOrg() { 
        }
    }
}

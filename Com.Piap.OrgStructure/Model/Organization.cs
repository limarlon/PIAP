using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Piap.OrgStructure.Model
{
    public class Organization : BaseTable
    {
        /// <summary>
        /// 组织编号
        /// </summary>
        public string Id { set; get; }

        /// <summary>
        /// 父级编号
        /// </summary>
        public string ParentId { set; get; }
        
        /// <summary>
        /// 层级
        /// </summary>
        public int Layer { set; get; }

        /// <summary>
        /// 叶子
        /// </summary>
        public bool Leaf { set; get; }

        /// <summary>
        /// 分类
        /// </summary>
        public string Category { set; get; }

        /// <summary>
        /// 组织名称
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { set; get; }

        /// <summary>
        /// 简称
        /// </summary>
        public string ShortName { set; get; }

        /// <summary>
        /// 全称
        /// </summary>
        public string FullName { set; get; }

        public Organization() {

        }

    }
}

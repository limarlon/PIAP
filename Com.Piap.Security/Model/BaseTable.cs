using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Piap.Security.Model
{
    /// <summary>
    /// 基表
    /// </summary>
    public class BaseTable
    {
        /// <summary>
        /// 行唯一键值
        /// </summary>
        public string guid { set; get; }

        /// <summary>
        /// 行插入时间
        /// </summary>
        public DateTime InsertTime { set; get; }

        /// <summary>
        /// 行插入用户
        /// </summary>
        public string InsertByUser { set; get; }

        /// <summary>
        /// 行更新时间
        /// </summary>
        public DateTime UpdateTime { set; get; }

        /// <summary>
        /// 行更新用户
        /// </summary>
        public string UpdateByUser { set; get; }

        /// <summary>
        /// 行删除时间
        /// </summary>
        public DateTime DeleteTime { set; get; }

        /// <summary>
        /// 行删除用户
        /// </summary>
        public string DeleteByUser { set; get; }

        /// <summary>
        /// 逻辑删除
        /// </summary>
        public string Deleted { set; get; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int SortNumber { set; get; }

    }
}

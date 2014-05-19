using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Piap.IndexManage.Model;
/**/
namespace Com.Piap.IndexManage.IPersist {
    /// <summary>
    /// 指标持久化接口
    /// </summary>
    interface IIndexPersist {
        /// <summary>
        /// 创建新指标
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        Boolean CreateIndex(Index index);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        Boolean Modify(Index index);

        /// <summary>
        /// 移除指标
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        Boolean Remove(Index index);
    }
}

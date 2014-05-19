using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Piap.IndexManage.Model;
/**/
namespace Com.Piap.IndexManage.IService {
    /// <summary>
    /// 指标领域接口
    /// </summary>
    interface IIndexService {

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = Com.Piap.IndexManage.Model;
/**/
namespace Com.Piap.IndexManage.IPersist {
    /// <summary>
    /// 指标持久化接口
    /// </summary>
    public interface IIndexPersist {
        /// <summary>
        /// 创建类目
        /// </summary>
        /// <param name="direction">创建对象</param>
        /// <returns></returns>
        bool Create(model.Index index);

        /// <summary>
        /// 修改类目
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool Modify(model.Index index);

        /// <summary>
        /// 移除类目
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool Remove(model.Index index);

        /// <summary>
        /// 删除类目
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool Delete(model.Index index);

        /// <summary>
        /// 获取某类目
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        model.Index GetByCode(string code);

        /// <summary>
        /// 获取所有类目
        /// </summary>
        /// <returns></returns>
        List<model.Index> GetAll();
    }
}

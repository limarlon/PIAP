using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = Com.Piap.IndexManage.Model;

namespace Com.Piap.IndexManage.IPersist {
    public interface IIndexValuePersist {

            /// <summary>
            /// 创建指标值
            /// </summary>
            /// <param name="direction">创建对象</param>
            /// <returns></returns>
            bool Create(model.IndexInstance instance);

            /// <summary>
            /// 修改指标值
            /// </summary>
            /// <param name="direction"></param>
            /// <returns></returns>
            bool Modify(model.IndexInstance instance);

            /// <summary>
            /// 移除指标值
            /// </summary>
            /// <param name="direction"></param>
            /// <returns></returns>
            bool Remove(model.IndexInstance instance);

            /// <summary>
            /// 删除指标值
            /// </summary>
            /// <param name="direction"></param>
            /// <returns></returns>
            bool Delete(model.IndexInstance instance);

            /// <summary>
            /// 获取某指标值
            /// </summary>
            /// <param name="Code"></param>
            /// <returns></returns>
            model.IndexInstance GetByCode(string code);

            /// <summary>
            /// 获取所有指标值
            /// </summary>
            /// <returns></returns>
            List<model.IndexInstance> GetAll();
    }
}

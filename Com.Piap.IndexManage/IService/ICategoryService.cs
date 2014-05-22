using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = Com.Piap.IndexManage.Model;

namespace Com.Piap.IndexManage.IService {
    public interface ICategoryService {
        /// <summary>
        /// 创建类目
        /// </summary>
        /// <param name="direction">创建对象</param>
        /// <returns></returns>
        bool Create(model.Category category);

        /// <summary>
        /// 修改类目
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool Modify(model.Category category);

        /// <summary>
        /// 移除类目
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool Remove(model.Category category);

        /// <summary>
        /// 删除类目
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool Delete(model.Category category);

        /// <summary>
        /// 获取某类目
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        model.Category GetByCode(string code);

        /// <summary>
        /// 获取所有类目
        /// </summary>
        /// <returns></returns>
        List<model.Category> GetAll();
    }
}

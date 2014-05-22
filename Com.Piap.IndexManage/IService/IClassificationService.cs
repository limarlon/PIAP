using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = Com.Piap.IndexManage.Model;

namespace Com.Piap.IndexManage.IService {
    
    public interface IClassificationService {
        /// <summary>
        /// 创建分类
        /// </summary>
        /// <param name="direction">创建对象</param>
        /// <returns></returns>
        bool Create(model.Classification classification);

        /// <summary>
        /// 修改分类
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool Modify(model.Classification classification);

        /// <summary>
        /// 移除分类
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool Remove(model.Classification classification);

        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        bool Delete(model.Classification classification);

        /// <summary>
        /// 获取某分类
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        model.Classification GetByCode(string code);

        /// <summary>
        /// 获取所有分类方向
        /// </summary>
        /// <returns></returns>
        List<model.Classification> GetAll();
    }
}

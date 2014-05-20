/****************************
 * limt create 2014.5.20
 * 指标管理-
 ****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using model = Com.Piap.IndexManage.Model;

namespace Com.Piap.IndexManage.IService {

    /// <summary>
    /// 业务接口
    /// 分类方向
    /// </summary>
    interface IDirectionService {

        /// <summary>
        /// 创建一个分类方向
        /// </summary>
        /// <param name="direction">创建对象</param>
        /// <returns></returns>
        public bool Create(model.Direction direction);

        /// <summary>
        /// 修改一个分类方向
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool Modify(model.Direction direction);

        /// <summary>
        /// 移除一个分类方向
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool Remove(model.Direction direction);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public model.Direction GetByCode(string Code);

        /// <summary>
        /// 获取所有分类方向
        /// </summary>
        /// <returns></returns>
        public List<model.Direction> GetAll();
    }
}

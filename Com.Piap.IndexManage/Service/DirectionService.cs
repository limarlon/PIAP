/*******************************************************
 * limt create 2014.5.20
 * 指标管理-
 *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Piap.IndexManage.IService;
using Com.Piap.IndexManage.Model;
using Com.Piap.IndexManage.IPersist;
using Com.Piap.IndexManage.Persist;

namespace Com.Piap.IndexManage.Service {
    
    /// <summary>
    /// 分类方向
    /// 业务实现
    /// </summary>
    public class DirectionService : IDirectionService {
        
        /// <summary>
        /// 持久层接口依赖
        /// </summary>
        public IDirectionPersist persist = new DirectionPersist();

        public bool Create(Direction direction) {
            return persist.Create(direction);
        }

        public bool Modify(Direction direction) {
            return persist.Modify(direction);
        }

        public bool Remove(Direction direction) {
            return persist.Remove(direction);
        }
        public bool Delete(Direction direction) {
            return persist.Delete(direction);
        }

        public Direction GetByCode(string code) {
            return persist.GetByCode(code);
        }


        public List<Direction> GetAll() {
            return persist.GetAll();
        }
    }
}

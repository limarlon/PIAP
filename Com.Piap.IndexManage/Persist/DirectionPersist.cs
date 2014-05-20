using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Com.Piap.IndexManage.Model;
using Com.Piap.IndexManage.IPersist;

namespace Com.Piap.IndexManage.Persist {
    
    /// <summary>
    /// 持久化层实现
    /// 分类方向
    /// </summary>
    public class DirectionPersist : IDirectionPersist {

        public bool Create(Direction direction) {
            throw new NotImplementedException();
        }

        public bool Modify(Direction direction) {
            throw new NotImplementedException();
        }

        public bool Remove(Direction direction) {
            throw new NotImplementedException();
        }

        public Direction GetByCode(string Code) {
            throw new NotImplementedException();
        }

        public List<Direction> GetAll() {
            throw new NotImplementedException();
        }
    }
}

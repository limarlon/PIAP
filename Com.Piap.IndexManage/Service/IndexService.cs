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
    /// 指标领域类
    /// </summary>
    public class IndexService : IIndexService {
        private IIndexPersist persist = new IndexPersist();


        public bool Create(Index index) {
            return persist.Create(index);
        }

        public bool Modify(Index index) {
            return persist.Modify(index);
        }

        public bool Remove(Index index) {
            return persist.Remove(index);
        }

        public bool Delete(Index index) {
            return persist.Delete(index);
        }

        public Index GetByCode(string code) {
            return persist.GetByCode(code);
        }

        public List<Index> GetAll() {
            return persist.GetAll();
        }
    }
}

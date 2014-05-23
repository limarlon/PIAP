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
    /// 指标值
    /// 领域类
    /// </summary>
    public class IndexValueService : IIndexValueService {
        private IIndexValuePersist persist = new IndexValuePersist();


        public bool Create(IndexInstance instance) {
            return persist.Create(instance);
        }

        public bool Modify(IndexInstance instance) {
            return persist.Modify(instance);
        }

        public bool Remove(IndexInstance instance) {
            return persist.Remove(instance);
        }

        public bool Delete(IndexInstance instance) {
            return persist.Delete(instance);
        }

        public IndexInstance GetByCode(string code) {
            return persist.GetByCode(code);
        }

        public List<IndexInstance> GetAll() {
            return persist.GetAll();
        }
    }
}

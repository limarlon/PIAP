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


        public bool Create(Indexs index) {
            return persist.Create(index);
        }

        public bool Modify(Indexs index) {
            return persist.Modify(index);
        }

        public bool Remove(Indexs index) {
            return persist.Remove(index);
        }

        public bool Delete(Indexs index) {
            return persist.Delete(index);
        }

        public Indexs GetByCode(string code) {
            return persist.GetByCode(code);
        }

        public List<Indexs> GetAll() {
            return persist.GetAll();
        }
    }
}

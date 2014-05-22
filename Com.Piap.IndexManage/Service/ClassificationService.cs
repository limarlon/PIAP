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
    public class ClassificationService : IClassificationService {
        private IClassificationPersist persist = new ClassificationPersist();



        public bool Create(Classification classification) {
            return persist.Create(classification);
        }

        public bool Modify(Classification classification) {
            return persist.Modify(classification);
        }

        public bool Remove(Classification classification) {
            return persist.Remove(classification);
        }

        public bool Delete(Classification classification) {
            return persist.Delete(classification);
        }

        public Classification GetByCode(string code) {
            return persist.GetByCode(code);
        }

        public List<Classification> GetAll() {
            return persist.GetAll();
        }
    }
}

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
    public class CategoryService : ICategoryService {
        private ICategoryPersist persist = new CategoryPersist();

        public bool Create(Category category) {
            return persist.Create(category);
        }

        public bool Modify(Category category) {
            return persist.Modify(category);
        }

        public bool Remove(Category category) {
            return persist.Remove(category);
        }

        public bool Delete(Category category) {
            return persist.Delete(category);
        }

        public Category GetByCode(string code) {
            return persist.GetByCode(code);
        }

        public List<Category> GetAll() {
            return persist.GetAll();
        }
    }
}

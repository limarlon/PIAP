using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Com.Piap.IndexManage.Model;
using Com.Piap.IndexManage.IPersist;
using PetaPoco;

namespace Com.Piap.IndexManage.Persist {
    public class CategoryPersist : ICategoryPersist {
        private PetaPoco.Database db = new Database("database");
        private readonly string TableName = "Category";
        private readonly string PKName = "Code";

        public bool Create(Category category) {
            bool SUCESS = true;
            try {
                db.Insert(category);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Modify(Category category) {
            bool SUCESS = true;
            try {
                db.Update(TableName, PKName, category);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Remove(Category category) {
            bool SUCESS = true;
            try {
                category.Enable = false;
                category.Deleted = true;
                db.Update(TableName, PKName, category);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Delete(Category category) {
            bool SUCESS = true;
            try {
                db.Delete<Category>(category);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public Category GetByCode(string code) {
            return db.Query<Category>("SELECT * FROM " + TableName + " WHERE " + PKName + "='" + code + "' ").SingleOrDefault<Category>();
        }

        public List<Category> GetAll() {
            return db.Query<Category>("SELECT * FROM " + TableName + " ").ToList<Category>();
        }
    }
}

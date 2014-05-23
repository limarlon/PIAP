using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Com.Piap.IndexManage.Model;
using Com.Piap.IndexManage.IPersist;
using PetaPoco;

namespace Com.Piap.IndexManage.Persist {
    public class IndexValuePersist : IIndexValuePersist {
        private PetaPoco.Database db = new Database("database");
        private readonly string TableName = "[IndexInstance]";
        private readonly string PKName = "Code";

        public bool Create(IndexInstance instance) {
            bool SUCESS = true;
            try {
                db.Insert(instance);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Modify(IndexInstance instance) {
            bool SUCESS = true;
            try {
                db.Update(TableName, PKName, instance);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Remove(IndexInstance instance) {
            bool SUCESS = true;
            try {
                //instance.Enable = false;
                //instance.Deleted = true;
                db.Update(TableName, PKName, instance);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Delete(IndexInstance instance) {
            bool SUCESS = true;
            try {
                db.Delete<IndexInstance>(instance);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public IndexInstance GetByCode(string code) {
            return db.Query<IndexInstance>("SELECT * FROM " + TableName + " WHERE " + PKName + "='" + code + "' ").SingleOrDefault<IndexInstance>();
        }

        public List<IndexInstance> GetAll() {
            return db.Query<IndexInstance>("SELECT * FROM dbo." + TableName + " ").ToList<IndexInstance>();
        }
    }
}

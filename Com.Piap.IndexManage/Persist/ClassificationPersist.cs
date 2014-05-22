using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Piap.IndexManage.Model;
using Com.Piap.IndexManage.IPersist;
using PetaPoco;

namespace Com.Piap.IndexManage.Persist {
    public class ClassificationPersist : IClassificationPersist {
        private PetaPoco.Database db = new Database("database");
        private readonly string TableName = "Classification";
        private readonly string PKName = "Code";

        public bool Create(Classification classification) {
            bool SUCESS = true;
            try {
                db.Insert(classification);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Modify(Classification classification) {
            bool SUCESS = true;
            try {
                db.Update(TableName, PKName, classification);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Remove(Classification classification) {
            bool SUCESS = true;
            try {
                classification.Enable = false;
                classification.Deleted = true;
                db.Update(TableName, PKName, classification);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Delete(Classification classification) {
            bool SUCESS = true;
            try {
                db.Delete<Classification>(classification);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public Classification GetByCode(string code) {
            return db.Query<Classification>("SELECT * FROM " + TableName + " WHERE " + PKName + "='" + code + "' ").SingleOrDefault<Classification>();
        }

        public List<Classification> GetAll() {
            return db.Query<Classification>("SELECT * FROM " + TableName + " ").ToList<Classification>();
        }
    }
}

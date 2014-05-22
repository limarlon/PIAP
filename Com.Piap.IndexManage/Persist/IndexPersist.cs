using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Com.Piap.IndexManage.Model;
using Com.Piap.IndexManage.IPersist;
using PetaPoco;

namespace Com.Piap.IndexManage.Persist {
    public class IndexPersist : IIndexPersist {
        private PetaPoco.Database db = new Database("database");
        private readonly string TableName = "Indexs";
        private readonly string PKName = "Code";

        public bool Create(Indexs index) {
            bool SUCESS = true;
            try {
                db.Insert(index);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Modify(Indexs index) {
            bool SUCESS = true;
            try {
                db.Update(TableName, PKName, index);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Remove(Indexs index) {
            bool SUCESS = true;
            try {
                index.Enable = false;
                index.Deleted = true;
                db.Update(TableName, PKName, index);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public bool Delete(Indexs index) {
            bool SUCESS = true;
            try {
                db.Delete<Indexs>(index);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        public Indexs GetByCode(string code) {
            return db.Query<Indexs>("SELECT * FROM " + TableName + " WHERE " + PKName + "='" + code + "' ").SingleOrDefault<Indexs>();
        }

        public List<Indexs> GetAll() {
            return db.Query<Indexs>("SELECT * FROM dbo.[" + TableName + "] ").ToList<Indexs>();
        }
    }
}

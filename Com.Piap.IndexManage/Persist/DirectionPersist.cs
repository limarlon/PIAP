using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Piap.IndexManage.Model;
using Com.Piap.IndexManage.IPersist;
using PetaPoco;

namespace Com.Piap.IndexManage.Persist {
    
    /// <summary>
    /// 持久化层实现
    /// 分类方向
    /// </summary>
    public class DirectionPersist : IDirectionPersist {
        private PetaPoco.Database db = new Database("database");
        
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool Create(Direction direction) {
            bool SUCESS = true;
            try {
                db.Insert(direction);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool Modify(Direction direction) {
            bool SUCESS = true;
            try {
                db.Update("Direction", "Code", direction);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool Remove(Direction direction) {
            bool SUCESS = true;
            try {
                direction.Enable = false;
                direction.Deleted = true;
                db.Update("Direction", "Code", direction);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool Delete(Direction direction) {
            bool SUCESS = true;
            try {
                db.Delete<Direction>(direction);
            }
            catch {
                SUCESS = false;
            }
            return SUCESS;
        }


        /// <summary>
        /// 根据主键获取对象
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Direction GetByCode(string code) {
            return db.Query<Direction>("SELECT * FROM Direction WHERE Code='" + code + "'").SingleOrDefault<Direction>();
        }

        /// <summary>
        /// 获取所有 的对象
        /// </summary>
        /// <returns></returns>
        public List<Direction> GetAll() {
            return db.Query<Direction>("SELECT * FROM Direction ").ToList<Direction>();
        }
    }
}

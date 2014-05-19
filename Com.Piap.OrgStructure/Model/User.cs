using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;
using Dapper;

namespace Com.Piap.OrgStructure.Model {
    public class User : BaseTable {
        #region 属性
        /// <summary>
        /// 编号
        /// </summary>
        public string Id {
            set;
            get;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name {
            set;
            get;
        }

        /// <summary>
        /// 口令
        /// </summary>
        public string Password {
            set;
            get;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string RealName {
            set;
            get;
        }
        #endregion

        public User() {
        }

        #region 方法
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public bool Add(ORG.Model.User user) {
            bool SUCCESS = true;
            try {
                using (var db = new PetaPoco.Database("hawkeye")) {
                    user.guid = Guid.NewGuid().ToString();
                    user.InsertByUser = "";
                    user.InsertTime = DateTime.Now;
                    db.Insert(user);
                }
            }
            catch {
                SUCCESS = false;
            }
            return SUCCESS;
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <returns></returns>
        public bool Add() {
            bool SUCCESS = true;
            try {
                using (var db = new PetaPoco.Database("hawkeye")) {
                    this.guid = Guid.NewGuid().ToString();
                    this.InsertByUser = "";
                    this.InsertTime = DateTime.Now;
                    this.UpdateTime = DateTime.Now;
                    this.DeleteTime = DateTime.Now;
                    this.Deleted = "0";
                    db.Insert(this);
                }
            }
            catch {
                SUCCESS = false;
            }
            return SUCCESS;
        }
        /// <summary>
        /// 逻辑删除用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Remove(ORG.Model.User user) {
            bool SUCCESS = true;
            try {
                using (var db = new PetaPoco.Database("hawkeye")) {
                    user.DeleteByUser = "";
                    user.DeleteTime = DateTime.Now;
                    user.Deleted = "1";
                    db.Update(user);
                }
            }
            catch {
                SUCCESS = false;
            }
            return SUCCESS;
        }
        /// <summary>
        /// 逻辑删除用户
        /// </summary>
        public bool Remove() {
            bool SUCCESS = true;
            try {
                using (var db = new PetaPoco.Database("hawkeye")) {
                    this.DeleteByUser = "";
                    this.DeleteTime = DateTime.Now;
                    this.Deleted = "1";
                    db.Update(this);
                }
            }
            catch {
                SUCCESS = false;
            }
            return SUCCESS;
        }
        /// <summary>
        /// 物理删除用户
        /// （参数）
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Delete(ORG.Model.User user) {
            bool SUCCESS = true;
            try {
                using (var db = new PetaPoco.Database("hawkeye")) {
                    db.Delete(user);
                }
            }
            catch {
                SUCCESS = false;
            }
            return SUCCESS;
        }
        /// <summary>
        /// 物理删除用户
        /// （实例）
        /// </summary>
        public bool Delete() {
            bool SUCCESS = true;
            try {
                using (var db = new PetaPoco.Database("hawkeye")) {
                    db.Delete(this);
                }
            }
            catch {
                SUCCESS = false;
            }
            return SUCCESS;
        }
        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Modify(ORG.Model.User user) {
            bool SUCCESS = true;
            try {
                using (var db = new PetaPoco.Database("hawkeye")) {
                    user.UpdateByUser = "";
                    user.UpdateTime = DateTime.Now;
                    db.Update(user);
                }
            }
            catch {
                SUCCESS = false;
            }
            return SUCCESS;
        }
        /// <summary>
        /// 更新用户
        /// （实例）
        /// </summary>
        public bool Modify() {
            bool SUCCESS = true;
            try {
                using (var db = new PetaPoco.Database("hawkeye")) {
                    this.UpdateByUser = "";
                    this.UpdateTime = DateTime.Now;
                    db.Update(this);
                }
            }
            catch {
                SUCCESS = false;
            }
            return SUCCESS;
        }

        /// <summary>
        /// 按行guid返回用户
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public ORG.Model.User GetUserByGuid(string guid) {
            ORG.Model.User ret = null;
            using (var conn = ConnectionFactory.GetSqlConnection("hawkeye")) {
                conn.Open();
                ret = conn.Query<ORG.Model.User>("SELECT * FROM [User] WHERE guid = @guid", new {
                    guid = guid
                }).SingleOrDefault<ORG.Model.User>();
            }
            return ret;
        }
        /// <summary>
        /// 按行用户id返回用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ORG.Model.User GetUserById(string id) {
            ORG.Model.User ret = null;
            using (var conn = ConnectionFactory.GetSqlConnection("hawkeye")) {
                conn.Open();
                ret = conn.Query<ORG.Model.User>("SELECT * FROM [User] WHERE Id = @id", new {
                    Id = id
                }).SingleOrDefault<ORG.Model.User>();
            }
            return ret;
        }
        #endregion


    }
}

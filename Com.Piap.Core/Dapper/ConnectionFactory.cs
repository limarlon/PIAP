using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Dapper {
    public class ConnectionFactory {
        /// <summary>
        /// 返回sqlconnection实例
        /// </summary>
        /// <param name="connectionStringName">连接字符串名</param>
        /// <returns></returns>
        public static IDbConnection GetSqlConnection(string connectionStringName) {
            return new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString);
        }
    }
}

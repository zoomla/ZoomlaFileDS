using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2ExcelDX
{
    class DBUtils
    {
        public DataTable Query(string connectionString, string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(sql, connection);
                    command.Fill(ds, "ds");
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                return ds.Tables[0];
            }
        }

        public static string GetConnetionString(string ip,string user,string pwd,string dbName = "master")
        {
            string dbIp = ip;
            string dbUser = user;
            string dbPassword = pwd;

            var connStr = new SqlConnectionStringBuilder()
            {
                DataSource = dbIp,
                InitialCatalog = dbName,
                IntegratedSecurity = false,
                UserID = dbUser,
                Password = dbPassword,

                Pooling = true, //开启连接池
                MinPoolSize = 0,//设置最小连接数为0
                MaxPoolSize = 2000, //设置最大连接数为50             
                ConnectTimeout = 15, //设置超时时间为15秒
            };
            return connStr.ConnectionString;
        }

        public static DataTable execSql(SqlConnection con, string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter command = new SqlDataAdapter(sql, con);
                command.Fill(ds, "ds");
            }
            catch(Exception e)
            {
                throw e;
            }
            return ds.Tables[0];
        }
    }
}

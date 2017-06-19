using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using AniSuki.Model;
using Neetsonic.Tool.Database;

namespace AniSuki.Util
{
    public static class DataAccess
    {
        private const string ConnectionString = @"server=.;database=anime;user=sa;pwd=qjsj8888";

        public static bool ConnectSucceed()
        {
            return SqlExecutor.ConnectSucceed(ConnectionString);
        }

        private static void ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            SqlExecutor.ExecuteNonQuery(ConnectionString, sql, parameters);
        }

        private static object ExecuteScalar(string sql, SqlParameter[] parameters = null)
        {
            return SqlExecutor.ExecuteScalar(ConnectionString, sql, parameters);
        }

        private static DataSet ExecuteQuery(string sql, SqlParameter[] parameters = null)
        {
            return SqlExecutor.ExecuteQuery(ConnectionString, sql, parameters);
        }

        public static IEnumerable<Producer> GetProducer()
        {
            return from DataRow dr in ExecuteQuery(@"SELECT * FROM Producer").Tables[0].Rows select Producer.FromDataRow(dr);
        }

        public static void Test(string name)
        {
            ExecuteNonQuery(@"INSERT INTO Producer(Name) VALUES(@name)", new []{new SqlParameter(nameof(name), SqlDbType.NVarChar)});
        }
    }
}
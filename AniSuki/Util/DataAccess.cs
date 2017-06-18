using System.Collections.Generic;
using System.Data;
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

        private static void ExecuteNonQuery(string sql)
        {
            SqlExecutor.ExecuteNonQuery(ConnectionString, sql);
        }

        private static object ExecuteScalar(string sql)
        {
            return SqlExecutor.ExecuteScalar(ConnectionString, sql);
        }

        private static DataSet ExecuteQuery(string sql)
        {
            return SqlExecutor.ExecuteQuery(ConnectionString, sql);
        }

        public static IEnumerable<Producer> GetProducer()
        {
            return from DataRow dr in ExecuteQuery(@"SELECT * FROM Producer").Tables[0].Rows select Producer.FromDataRow(dr);
        }
    }
}
using System.Data;
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
    }
}
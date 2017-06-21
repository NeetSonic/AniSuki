﻿using System;
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

        public static int NewProducer(Producer producer)
        {
            return Convert.ToInt32(ExecuteScalar(@"INSERT INTO Producer(Name, Website) VALUES(@Name, @Website) SELECT MAX(ID) FROM Producer", new []{new SqlParameter(@"@Name", SqlDbType.NVarChar){Value = producer.Name}, new SqlParameter(@"@Website", SqlDbType.NVarChar){Value = producer.Website} }));
        }

        public static void UpdateProducer(Producer producer)
        {
            ExecuteNonQuery(@"UPDATE Producer SET Name = @Name, Website = @Website WHERE ID = @ID", new []{new SqlParameter(@"@Name", SqlDbType.NVarChar){Value = producer.Name}, new SqlParameter(@"@Website", SqlDbType.NVarChar){Value = producer.Website}, new SqlParameter(@"@ID", SqlDbType.Int){Value = producer.ID} });
        }

        public static void DeleteProducer(Producer producer)
        {
            ExecuteNonQuery(@"DELETE FROM Producer WHERE ID = @ID", new []{new SqlParameter(@"@ID", SqlDbType.Int){Value = producer.ID} });
        }

        public static IEnumerable<Resolution> GetResolution()
        {
            return from DataRow dr in ExecuteQuery(@"SELECT * FROM Resolution").Tables[0].Rows select Resolution.FromDataRow(dr);
        }

        public static int NewResolutionr(Resolution resolution)
        {
            return Convert.ToInt32(ExecuteScalar(@"INSERT INTO Resolution(Width, Height) VALUES(@Width, @Height) SELECT MAX(ID) FROM Resolution", new []{new SqlParameter(@"@Width", SqlDbType.SmallInt){Value = resolution.Width}, new SqlParameter(@"@Height", SqlDbType.SmallInt){Value = resolution.Height} }));
        }

        public static void UpdateResolution(Resolution resolution)
        {
            ExecuteNonQuery(@"UPDATE Resolution SET Width = @Width, Height = @Height WHERE ID = @ID", new []{new SqlParameter(@"@Width", SqlDbType.SmallInt){Value = resolution.Width}, new SqlParameter(@"@Height", SqlDbType.SmallInt){Value = resolution.Height}, new SqlParameter(@"@ID", SqlDbType.Int){Value = resolution.ID} });
        }

        public static void DeleteResolution(Resolution resolution)
        {
            ExecuteNonQuery(@"DELETE FROM Resolution WHERE ID = @ID", new []{new SqlParameter(@"@ID", SqlDbType.Int){Value = resolution.ID} });
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using AniSuki.Model;
using Neetsonic.Tool;
using Neetsonic.Tool.Database;

namespace AniSuki.Util
{
    public static class DataAccess
    {
        private const string ConnectionString = @"server=.;database=anime;user=sa;pwd=qjsj8888";

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

        public static bool ConnectSucceed()
        {
            return SqlExecutor.ConnectSucceed(ConnectionString);
        }
        public static IEnumerable<Producer> GetProducer()
        {
            return from DataRow dr in ExecuteQuery(@"SELECT * FROM Producer ORDER BY Name ASC").Tables[0].Rows select Producer.FromDataRow(dr);
        }
        public static int NewProducer(Producer producer)
        {
            return Convert.ToInt32(ExecuteScalar(@"INSERT INTO Producer(Name, Website) VALUES(@Name, @Website) SELECT MAX(ID) FROM Producer", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = producer.Name}, new SqlParameter(@"@Website", SqlDbType.NVarChar) {Value = producer.Website}}));
        }
        public static void UpdateProducer(Producer producer)
        {
            ExecuteNonQuery(@"UPDATE Producer SET Name = @Name, Website = @Website WHERE ID = @ID", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = producer.Name}, new SqlParameter(@"@Website", SqlDbType.NVarChar) {Value = producer.Website}, new SqlParameter(@"@ID", SqlDbType.Int) {Value = producer.ID}});
        }
        public static void DeleteProducer(Producer producer)
        {
            ExecuteNonQuery(@"DELETE FROM Producer WHERE ID = @ID", new[] {new SqlParameter(@"@ID", SqlDbType.Int) {Value = producer.ID}});
        }
        public static IEnumerable<Resolution> GetResolution()
        {
            return from DataRow dr in ExecuteQuery(@"SELECT * FROM Resolution").Tables[0].Rows select Resolution.FromDataRow(dr);
        }
        public static int NewResolution(Resolution resolution)
        {
            return Convert.ToInt32(ExecuteScalar(@"INSERT INTO Resolution(Width, Height) VALUES(@Width, @Height) SELECT MAX(ID) FROM Resolution", new[] {new SqlParameter(@"@Width", SqlDbType.SmallInt) {Value = resolution.Width}, new SqlParameter(@"@Height", SqlDbType.SmallInt) {Value = resolution.Height}}));
        }
        public static void UpdateResolution(Resolution resolution)
        {
            ExecuteNonQuery(@"UPDATE Resolution SET Width = @Width, Height = @Height WHERE ID = @ID", new[] {new SqlParameter(@"@Width", SqlDbType.SmallInt) {Value = resolution.Width}, new SqlParameter(@"@Height", SqlDbType.SmallInt) {Value = resolution.Height}, new SqlParameter(@"@ID", SqlDbType.Int) {Value = resolution.ID}});
        }
        public static void DeleteResolution(Resolution resolution)
        {
            ExecuteNonQuery(@"DELETE FROM Resolution WHERE ID = @ID", new[] {new SqlParameter(@"@ID", SqlDbType.Int) {Value = resolution.ID}});
        }
        public static IEnumerable<Tag> GetTag()
        {
            return from DataRow dr in ExecuteQuery(@"SELECT * FROM Tag ORDER BY Name ASC").Tables[0].Rows select Tag.FromDataRow(dr);
        }
        public static int NewTag(Tag tag)
        {
            return Convert.ToInt32(ExecuteScalar(@"INSERT INTO Tag(Name) VALUES(@Name) SELECT MAX(ID) FROM Tag", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = tag.Name}}));
        }
        public static void UpdateTag(Tag tag)
        {
            ExecuteNonQuery(@"UPDATE Tag SET Name = @Name WHERE ID = @ID", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = tag.Name}, new SqlParameter(@"@ID", SqlDbType.Int) {Value = tag.ID}});
        }
        public static void DeleteTag(Tag tag)
        {
            ExecuteNonQuery(@"DELETE FROM Tag WHERE ID = @ID", new[] {new SqlParameter(@"@ID", SqlDbType.Int) {Value = tag.ID}});
        }
        public static IEnumerable<VoiceActor> GetVoiceActor()
        {
            return from DataRow dr in ExecuteQuery(@"SELECT * FROM VoiceActor ORDER BY Name ASC").Tables[0].Rows select VoiceActor.FromDataRow(dr);
        }
        public static int NewVoiceActor(VoiceActor VoiceActor)
        {
            return Convert.ToInt32(ExecuteScalar(@"INSERT INTO VoiceActor(Name) VALUES(@Name) SELECT MAX(ID) FROM VoiceActor", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = VoiceActor.Name}}));
        }
        public static void UpdateVoiceActor(VoiceActor VoiceActor)
        {
            ExecuteNonQuery(@"UPDATE VoiceActor SET Name = @Name WHERE ID = @ID", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = VoiceActor.Name}, new SqlParameter(@"@ID", SqlDbType.Int) {Value = VoiceActor.ID}});
        }
        public static void DeleteVoiceActor(VoiceActor VoiceActor)
        {
            ExecuteNonQuery(@"DELETE FROM VoiceActor WHERE ID = @ID", new[] {new SqlParameter(@"@ID", SqlDbType.Int) {Value = VoiceActor.ID}});
        }
        public static void NewAnime(Anime anime)
        {
            IEnumerable<Tag> tags = anime.Tags;
            IEnumerable<Cast> casts = anime.Casts;
            int animeID = Convert.ToInt32(ExecuteScalar(@" 
            INSERT INTO Anime([Name],[Comment],[SaleDate],[ProducerID],[Producer],[ResolutionID],[Resolution])
            VALUES(@Name, @Comment, @SaleDate, @ProducerID, @Producer, @ResolutionID, @Resolution) 
            SELECT MAX(ID) FROM Anime",
                                                        new[]
                                                        {
                                                            new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = anime.Name},
                                                            new SqlParameter(@"@Comment", SqlDbType.NVarChar) {Value = SqlParameterEx.NullableString(anime.Comment)},
                                                            new SqlParameter(@"@SaleDate", SqlDbType.DateTime) {Value = anime.SaleDate},
                                                            new SqlParameter(@"@ProducerID", SqlDbType.Int) {Value = anime.ProducerID},
                                                            new SqlParameter(@"@Producer", SqlDbType.NVarChar) {Value = anime.Producer},
                                                            new SqlParameter(@"@ResolutionID", SqlDbType.Int) {Value = anime.ResolutionID},
                                                            new SqlParameter(@"@Resolution", SqlDbType.NVarChar) {Value = anime.Resolution}
                                                        }));
            if(tags.Any())
            {
                ExecuteNonQuery(string.Format($@"INSERT INTO AnimeTag(AnimeID, TagID, Tag) VALUES {string.Join(",", tags.Select(tag => string.Format($@"({animeID}, {tag.ID}, N'{tag.Name}')")))}"));
            }
            if(casts.Any())
            {
                ExecuteNonQuery(string.Format($@"INSERT INTO [Cast](AnimeID, VoiceActorID, VoiceActor, CharaName) VALUES {string.Join(",", casts.Select(cast => string.Format($@"({animeID}, {cast.VoiceActorID}, N'{cast.VoiceActor}', N'{cast.CharaName}')")))}"));
            }
        }
        public static IEnumerable<Anime> GetAnime(string filter)
        {
            string sql = @"	
            SELECT ID, Name, Comment, SaleDate, ProducerID, Producer, ResolutionID, Resolution FROM Anime 
	        WHERE 
	        Name LIKE N'%萨%' AND 
	        DATEDIFF(dd, SaleDate, '1999-01-01')<=0 AND 
	        DATEDIFF(dd, SaleDate, '2999-01-01')>=0 AND 
	        ProducerID = 1 AND
	        ResolutionID = 1 AND
	        ID IN
	        (
		        SELECT AnimeID FROM AnimeTag WHERE TagID IN(1,2) GROUP BY AnimeID HAVING COUNT(*) = 2
	        ) AND
	        ID IN
	        (
		        SELECT DISTINCT AnimeID FROM AnimeTag WHERE TagID IN(1,2,3)
	        ) AND
	        ID IN
	        (
		        SELECT AnimeID FROM [Cast] WHERE VoiceActorID IN (1,2) GROUP BY AnimeID HAVING COUNT(*) = 2
	        ) AND 
	        ID IN
	        (
		        SELECT DISTINCT AnimeID FROM [Cast] WHERE VoiceActorID IN (1,2,3)
	        ) ";
            sql = @"SELECT ID, Name, Comment, SaleDate, ProducerID, Producer, ResolutionID, Resolution FROM Anime";
            IEnumerable <Anime> animes = from DataRow row in ExecuteQuery(sql).Tables[0].Rows select Anime.FromDataRow(row);
            foreach(Anime anime in animes)
            {
                sql = @"SELECT TagID AS ID, Tag AS Name FROM AnimeTag WHERE AnimeID = @AnimeID";
                anime.Tags = from DataRow row in ExecuteQuery(sql, new[] {new SqlParameter(@"@AnimeID", SqlDbType.Int) {Value = anime.ID}}).Tables[0].Rows select Tag.FromDataRow(row);
                sql = @"SELECT VoiceActorID, VoiceActor, CharaName FROM Cast WHERE AnimeID = @AnimeID";
                anime.Casts = from DataRow row in ExecuteQuery(sql, new[] { new SqlParameter(@"@AnimeID", SqlDbType.Int) { Value = anime.ID } }).Tables[0].Rows select Cast.FromDataRow(row);
            }
            return animes;
        }
    }
}
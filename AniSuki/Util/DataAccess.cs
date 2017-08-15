using System;
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

        public static bool ConnectSucceed() => SqlExecutor.ConnectSucceed(ConnectionString);
        public static IEnumerable<Producer> GetProducer() => from DataRow dr in ExecuteQuery(@"SELECT * FROM Producer ORDER BY Name ASC").Tables[0].Rows select Producer.FromDataRow(dr);
        public static int NewProducer(Producer producer) => Convert.ToInt32(ExecuteScalar(@"INSERT INTO Producer(Name, Website) VALUES(@Name, @Website) SELECT MAX(ID) FROM Producer", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = producer.Name}, new SqlParameter(@"@Website", SqlDbType.NVarChar) {Value = producer.Website}}));
        public static void UpdateProducer(Producer producer) => ExecuteNonQuery(@"UPDATE Producer SET Name = @Name, Website = @Website WHERE ID = @ID", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = producer.Name}, new SqlParameter(@"@Website", SqlDbType.NVarChar) {Value = producer.Website}, new SqlParameter(@"@ID", SqlDbType.Int) {Value = producer.ID}});
        public static void DeleteProducer(Producer producer) => ExecuteNonQuery(@"DELETE FROM Producer WHERE ID = @ID", new[] {new SqlParameter(@"@ID", SqlDbType.Int) {Value = producer.ID}});
        public static IEnumerable<Resolution> GetResolution() => from DataRow dr in ExecuteQuery(@"SELECT * FROM Resolution").Tables[0].Rows select Resolution.FromDataRow(dr);
        public static int NewResolution(Resolution resolution) => Convert.ToInt32(ExecuteScalar(@"INSERT INTO Resolution(Width, Height) VALUES(@Width, @Height) SELECT MAX(ID) FROM Resolution", new[] {new SqlParameter(@"@Width", SqlDbType.SmallInt) {Value = resolution.Width}, new SqlParameter(@"@Height", SqlDbType.SmallInt) {Value = resolution.Height}}));
        public static void UpdateResolution(Resolution resolution) => ExecuteNonQuery(@"UPDATE Resolution SET Width = @Width, Height = @Height WHERE ID = @ID", new[] {new SqlParameter(@"@Width", SqlDbType.SmallInt) {Value = resolution.Width}, new SqlParameter(@"@Height", SqlDbType.SmallInt) {Value = resolution.Height}, new SqlParameter(@"@ID", SqlDbType.Int) {Value = resolution.ID}});
        public static void DeleteResolution(Resolution resolution) => ExecuteNonQuery(@"DELETE FROM Resolution WHERE ID = @ID", new[] {new SqlParameter(@"@ID", SqlDbType.Int) {Value = resolution.ID}});
        public static IEnumerable<Tag> GetTag() => from DataRow dr in ExecuteQuery(@"SELECT * FROM Tag ORDER BY Name ASC").Tables[0].Rows select Tag.FromDataRow(dr);
        public static int NewTag(Tag tag) => Convert.ToInt32(ExecuteScalar(@"INSERT INTO Tag(Name) VALUES(@Name) SELECT MAX(ID) FROM Tag", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = tag.Name}}));
        public static void UpdateTag(Tag tag) => ExecuteNonQuery(@"UPDATE Tag SET Name = @Name WHERE ID = @ID", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = tag.Name}, new SqlParameter(@"@ID", SqlDbType.Int) {Value = tag.ID}});
        public static void DeleteTag(Tag tag) => ExecuteNonQuery(@"DELETE FROM Tag WHERE ID = @ID", new[] {new SqlParameter(@"@ID", SqlDbType.Int) {Value = tag.ID}});
        public static IEnumerable<VoiceActor> GetVoiceActor() => from DataRow dr in ExecuteQuery(@"SELECT * FROM VoiceActor ORDER BY Name ASC").Tables[0].Rows select VoiceActor.FromDataRow(dr);
        public static int NewVoiceActor(VoiceActor VoiceActor) => Convert.ToInt32(ExecuteScalar(@"INSERT INTO VoiceActor(Name) VALUES(@Name) SELECT MAX(ID) FROM VoiceActor", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = VoiceActor.Name}}));
        public static void UpdateVoiceActor(VoiceActor VoiceActor) => ExecuteNonQuery(@"UPDATE VoiceActor SET Name = @Name WHERE ID = @ID", new[] {new SqlParameter(@"@Name", SqlDbType.NVarChar) {Value = VoiceActor.Name}, new SqlParameter(@"@ID", SqlDbType.Int) {Value = VoiceActor.ID}});
        public static void DeleteVoiceActor(VoiceActor VoiceActor) => ExecuteNonQuery(@"DELETE FROM VoiceActor WHERE ID = @ID", new[] {new SqlParameter(@"@ID", SqlDbType.Int) {Value = VoiceActor.ID}});
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
            if(tags.Any()) ExecuteNonQuery(string.Format($@"INSERT INTO AnimeTag(AnimeID, TagID, Tag) VALUES {string.Join(",", tags.Select(tag => string.Format($@"({animeID}, {tag.ID}, N'{tag.Name}')")))}"));
            if(casts.Any()) ExecuteNonQuery(string.Format($@"INSERT INTO [Cast](AnimeID, VoiceActorID, VoiceActor, CharaName) VALUES {string.Join(",", casts.Select(cast => string.Format($@"({animeID}, {cast.VoiceActorID}, N'{cast.VoiceActor}', N'{cast.CharaName}')")))}"));
        }
        public static IEnumerable<Anime> GetAnime(IEnumerable<string> filters)
        {
            string filter = filters.Any() ? string.Concat(@" WHERE ", string.Join(@" AND ", filters)) : string.Empty;
            string sql = string.Format($@"SELECT ID, Name, Comment, SaleDate, ProducerID, Producer, ResolutionID, Resolution FROM Anime{filter}");
            List<Anime> animes = new List<Anime>();
            using(DataSet ds = ExecuteQuery(sql))
            {
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    Anime anime = Anime.FromDataRow(row);
                    sql = string.Format($@"SELECT TagID AS ID, Tag AS Name FROM AnimeTag WHERE AnimeID = {anime.ID}  SELECT VoiceActorID, VoiceActor, CharaName FROM Cast WHERE AnimeID = {anime.ID}");
                    using(DataSet dataSet = ExecuteQuery(sql))
                    {
                        anime.Tags = from DataRow dr in dataSet.Tables[0].Rows select Tag.FromDataRow(dr);
                        anime.Casts = from DataRow dr in dataSet.Tables[1].Rows select Cast.FromDataRow(dr);
                    }
                    animes.Add(anime);
                }
            }
            return animes;
        }
        public static Resolution UpdateAnimeResolution(Resolution resolution, int animeID)
        {
            const string sql = @"DECLARE @ResID INT
                                                SELECT @ResID = ID FROM Resolution WHERE Width=@Width AND Height = @Height
                                                IF(@ResID IS NULL) 
                                                BEGIN
	                                                INSERT INTO Resolution(Width, Height) VALUES(@Width, @Height)
	                                                SELECT @ResID = MAX(ID) FROM Resolution
                                                END
                                                UPDATE Anime SET ResolutionID = @ResID, Resolution = @ResString WHERE ID = @AnimeID
                                                SELECT * FROM Resolution WHERE ID = @ResID";
            using(DataSet ds = ExecuteQuery(sql, new[]
            {
                new SqlParameter(@"@Width", SqlDbType.SmallInt) {Value = resolution.Width},
                new SqlParameter(@"@Height", SqlDbType.SmallInt) {Value = resolution.Height},
                new SqlParameter(@"@AnimeID", SqlDbType.Int) {Value = animeID},
                new SqlParameter(@"@ResString", SqlDbType.NVarChar) {Value = resolution.ResolutionString}
            }))
            {
                return Resolution.FromDataRow(ds.Tables[0].Rows[0]);
            }
        }
        public static void UpdateAnimeComment(string comment, int animeID) => ExecuteNonQuery(@"UPDATE Anime SET Comment = @Comment WHERE ID = @ID", new[]
        {
            new SqlParameter(@"@Comment", SqlDbType.NVarChar) {Value = SqlParameterEx.NullableString(comment)},
            new SqlParameter(@"@ID", SqlDbType.Int) {Value = animeID}
        });
        public static void UpdateAnimeTag(IEnumerable<Tag> tags, int animeID)
        {
            ExecuteNonQuery(@" DELETE FROM AnimeTag WHERE AnimeID = @AnimeID", new[] {new SqlParameter(@"@AnimeID", SqlDbType.Int) {Value = animeID}});
            if(tags.Any()) ExecuteNonQuery(string.Format($@"INSERT INTO AnimeTag(AnimeID, TagID, Tag) VALUES {string.Join(",", tags.Select(tag => string.Format($@"({animeID}, {tag.ID}, N'{tag.Name}')")))}"));
        }
        public static void UpdateAnimeCast(IEnumerable<Cast> casts, int animeID)
        {
            ExecuteNonQuery(@" DELETE FROM Cast WHERE AnimeID = @AnimeID", new[] {new SqlParameter(@"@AnimeID", SqlDbType.Int) {Value = animeID}});
            if(casts.Any()) ExecuteNonQuery(string.Format($@"INSERT INTO [Cast](AnimeID, VoiceActorID, VoiceActor, CharaName) VALUES {string.Join(",", casts.Select(cast => string.Format($@"({animeID}, {cast.VoiceActorID}, N'{cast.VoiceActor}', N'{cast.CharaName}')")))}"));
        }
        public static void UpdateAnimeSaleDate(DateTime date, int animeID) => ExecuteNonQuery(@"UPDATE Anime SET SaleDate = @SaleDate WHERE ID = @ID", new[]
        {
            new SqlParameter(@"@SaleDate", SqlDbType.DateTime) {Value = date},
            new SqlParameter(@"@ID", SqlDbType.Int) {Value = animeID}
        });

        private static void ExecuteNonQuery(string sql, SqlParameter[] parameters = null) => SqlExecutor.ExecuteNonQuery(ConnectionString, sql, parameters);
        private static object ExecuteScalar(string sql, SqlParameter[] parameters = null) => SqlExecutor.ExecuteScalar(ConnectionString, sql, parameters);
        private static DataSet ExecuteQuery(string sql, SqlParameter[] parameters = null) => SqlExecutor.ExecuteQuery(ConnectionString, sql, parameters);
    }
}
using System;
using System.Collections.Generic;
using MusicList.Models;
using Microsoft.Data.Sqlite;

namespace MusicList.DAO
{
    class MusicADODAO : IMusicDAO
    {

        private static readonly string conn_string = @"Data Source=..\Database\music.db;";

        public bool AddMusic(MusicView music)
        {
            using(SqliteConnection conn = new SqliteConnection(conn_string))
            {
                //SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());
                conn.Open();                
                SqliteCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO Music " +
                "(Title, Artist, PublishYear, MusicLength, Priority) VALUES " +
                "(@title, @artist, @publishyear, @length, @priority)";
                //paraméterek megadása
                command.Parameters
                    .Add("title", (SqliteType)System.Data.DbType.String).Value = music.title;
                command.Parameters
                    .Add("artist", (SqliteType)System.Data.DbType.String).Value = music.artist;
                command.Parameters
                    .Add("publishyear", (SqliteType)System.Data.DbType.Int32).Value = music.publishYear;
                command.Parameters
                    .Add("length", (SqliteType)System.Data.DbType.Int32).Value = music.length;
                command.Parameters
                    .Add("priority", (SqliteType)System.Data.DbType.Int32).Value = music.priority;
                if (command.ExecuteNonQuery() != 1)
                    return false;
            }
            return true;

        }
        public List<Music> GetAllMusic()
        {
            List<Music> musicList = new List<Music>();
            using (SqliteConnection conn = new SqliteConnection(conn_string))
            {
                conn.Open();
                SqliteCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM Music ORDER BY Priority DESC";
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        musicList.Add(
                        new Music
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            title = reader.GetString(reader.GetOrdinal("Title")),
                            artist = reader.GetString(reader.GetOrdinal("Artist")),
                            publishYear = reader.GetInt32(reader.GetOrdinal("PublishYear")),
                            length = reader.GetInt32(reader.GetOrdinal("Length")),
                            priority = reader.GetInt32(reader.GetOrdinal("Priority"))
                        }
                        );
                    }
                }
            }
            return musicList;
        }
        public Music GetMusicById(int ID)
        {
            Music music = null; 
            using (SqliteConnection conn = new SqliteConnection(conn_string))
            {
                conn.Open();
                SqliteCommand command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM Music WHERE ID=@id";
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        music = new Music
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("ID")),
                            title = reader.GetString(reader.GetOrdinal("Title")),
                            artist = reader.GetString(reader.GetOrdinal("Artist")),
                            publishYear = reader.GetInt32(reader.GetOrdinal("PublishYear")),
                            length = reader.GetInt32(reader.GetOrdinal("Length")),
                            priority = reader.GetInt32(reader.GetOrdinal("Priority"))
                        };
                    }
                }
            }
            return music;
        }

        public bool ModifyMusic(Music music)
        {
            using (SqliteConnection conn = new SqliteConnection(conn_string))
            {
                conn.Open();
                SqliteCommand command = conn.CreateCommand();
                command.CommandText = "UPDATE Music SET " +
                "(Title=@title, Artist=@artist, PublishYear=@publishYear, MusicLength=@length, Priority=@Priority) WHERE ID=@id";
                //paraméterek megadása
                command.Parameters
                    .Add("title", (SqliteType)System.Data.DbType.String).Value = music.title;
                command.Parameters
                    .Add("artist", (SqliteType)System.Data.DbType.String).Value = music.artist;
                command.Parameters
                    .Add("publishyear", (SqliteType)System.Data.DbType.Int32).Value = music.publishYear;
                command.Parameters
                    .Add("length", (SqliteType)System.Data.DbType.Int32).Value = music.length;
                command.Parameters
                    .Add("priority", (SqliteType)System.Data.DbType.Int32).Value = music.priority;
                command.Parameters
                    .Add("id", (SqliteType)System.Data.DbType.Int32).Value = music.ID;
                if (command.ExecuteNonQuery() != 1)
                    return false;
            }
            return true;
        }
    }
}

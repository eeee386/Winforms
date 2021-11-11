using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicList.Models;

namespace MusicList.DAO
{
    class EFContext : DbContext
    {
        public EFContext() : base("EFContext") { }
        public DbSet<Music> Music { get; set; }
    }

    class MusicEFDAO : IMusicDAO
    {
        public bool AddMusic(MusicView music)
        {
            using (var db = new EFContext())
            {
                Music musicToAdd = new Music(music);
                db.Music.Add(musicToAdd);
                db.SaveChanges();
            }
            return true;

        }

        public List<Music> GetAllMusic()
        {
            using (var db = new EFContext())
            {
                return db.Music.ToList();
            }

        }

        public Music GetMusicById(int ID)
        {
            using (var db = new EFContext())
            {
                return db.Music.SingleOrDefault(h => h.ID == ID);
            }
        }

        public bool ModifyMusic(Music music)
        {
            using (var db = new EFContext())
            {
                var sh = db.Music.SingleOrDefault(h => h.ID == music.ID);
                if (sh != null)
                {
                    sh.title = music.title;
                    sh.artist = music.artist;
                    sh.publishYear = music.publishYear;
                    sh.length = music.length;
                    sh.priority = music.priority;
                    db.SaveChanges();
                }
            }
            return true;
        }
    }
}

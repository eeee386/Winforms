using Microsoft.EntityFrameworkCore;
using MusicListASP.Models;

namespace MusicListASP.Context
{
    public class EFContext : DbContext
    {
        public DbSet<Music> Music { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Context\music.db");
        }

    }
}

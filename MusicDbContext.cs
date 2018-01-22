using Microsoft.EntityFrameworkCore;
using music.Models;

namespace music
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options)
            : base(options)
        {
        }
        public DbSet<Track> Track { get; set; }
    }    
}
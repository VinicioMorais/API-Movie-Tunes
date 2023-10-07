using Microsoft.EntityFrameworkCore;

namespace API_Movie_Tunes.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<TrilhasSonoras> TrilhasSonoras { get; set; }
    }
}

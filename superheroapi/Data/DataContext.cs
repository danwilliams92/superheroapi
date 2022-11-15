using Microsoft.EntityFrameworkCore;

namespace superheroapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Superhero> Superheroes { get; set; }
    }
}

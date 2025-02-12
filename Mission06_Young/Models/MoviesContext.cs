using Microsoft.EntityFrameworkCore;

namespace Mission06_Young.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base (options) { }

        public DbSet<Form> Movies { get; set; }
    }
}

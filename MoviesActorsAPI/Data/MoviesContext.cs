using Microsoft.EntityFrameworkCore;

    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesActorsAPI.Movie> Movie { get; set; }
    }

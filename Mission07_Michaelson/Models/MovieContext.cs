using Microsoft.EntityFrameworkCore;

namespace Mission07_Michaelson.Models
{
  public class MoviesContext : DbContext
  {
    public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) 
    {

    }
    public DbSet<Movie> Movies {get; set;}
  }
}
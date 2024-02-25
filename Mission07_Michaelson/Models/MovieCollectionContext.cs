using Microsoft.EntityFrameworkCore;

namespace Mission07_Michaelson.Models
{
  public class MovieCollectionContext : DbContext
  {
    public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options) 
    {

    }
    public DbSet<Movie> Movies {get; set;}

    public DbSet<Category> Categories {get; set;}
  }
}
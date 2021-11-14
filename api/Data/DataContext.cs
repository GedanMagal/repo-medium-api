using api.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieCategory> MovieCategory { get; set; }
    }
}
#nullable disable
using Microsoft.EntityFrameworkCore;
using GenericProjectAPI.Models;

namespace GenericProjectAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<OneModel> OneModels { get; set; }
        public DbSet<AnotherModel> AnotherModels { get; set; }
    }
}

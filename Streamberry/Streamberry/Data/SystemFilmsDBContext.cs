using Microsoft.EntityFrameworkCore;
using Streamberry.Data.Map;
using Streamberry.Models;

namespace Streamberry.Data
{
    public class SystemFilmsDBContext : DbContext
    {
        public SystemFilmsDBContext(DbContextOptions<SystemFilmsDBContext> options)
            :base(options)
        {
        }
        public DbSet<FilmModel> Film {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmMap());
            modelBuilder.ApplyConfiguration(new GenderMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}

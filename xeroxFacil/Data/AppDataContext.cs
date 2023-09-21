using Microsoft.EntityFrameworkCore;
using xeroxFacil.Data.Mappings;
using xeroxFacil.Models;

namespace xeroxFacil.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Salesman> Salesmans { get; set; }
        public DbSet<Xerox> Xeroxs { get; set; }
        public DbSet<HomeWork> HomeWorks { get; set; }

        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMap());
            modelBuilder.ApplyConfiguration(new SalesManMap());
            modelBuilder.ApplyConfiguration(new XeroxMap());
            modelBuilder.ApplyConfiguration(new HomeWorkMap());
        }
    }
}
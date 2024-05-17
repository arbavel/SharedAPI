using Microsoft.EntityFrameworkCore;
using Shared.Common.Entities;

namespace Shared.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Client> Clients { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasIndex(x=>x.Email).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique();

            modelBuilder.Entity<Employee>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<Supplier>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<Client>().HasIndex(x => x.Name).IsUnique();

        }
    }
}
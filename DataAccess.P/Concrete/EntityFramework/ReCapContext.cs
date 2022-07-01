using Entities.P.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.P.Concrete.EntityFramework
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ReCapProject;Integrated Security=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}

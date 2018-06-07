using SportsStore2.Domain.Entities;
using System.Data.Entity;

namespace SportsStore2.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}

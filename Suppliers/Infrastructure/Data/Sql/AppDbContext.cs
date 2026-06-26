using Microsoft.EntityFrameworkCore;
using Suppliers.Infrastructure.Data.Model;

namespace Suppliers.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Products1.Infrastucture.Data.Models;

namespace Products1.Infrastucture.Data.Sql
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}

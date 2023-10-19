using DrugStorePrices.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DrugStorePrices.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<DrugStore> DrugStores { get; set; }
    }
}

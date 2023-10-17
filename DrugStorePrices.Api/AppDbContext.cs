using DrugStorePrices.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DrugStorePrices.Api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<DrugStore> DrugStores { get; set; }
    }
}



using DrugStorePrices.Domain.Interfaces.Repositories;
using DrugStorePrices.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DrugStorePrices.Infra.Data
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseModel
    {
        protected readonly AppDbContext Db;

        public BaseRepository(AppDbContext context)
        {
            Db = context;
        }

        public DbSet<T> DbSet => Db.Set<T>();


        public async Task Commit()
        {
            await Db.SaveChangesAsync();
        }


        public async Task<List<T>> GetAll()
        {
            return await DbSet.ToListAsync(); ;
        }

        public async Task<T?> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }
    }
}

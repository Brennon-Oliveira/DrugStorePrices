using System.Collections.Generic;
using System;
using DrugStorePrices.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DrugStorePrices.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        public DbSet<T> DbSet { get; }

        public Task Commit();
        public Task<List<T>> GetAll();
        public Task<T?> GetById(Guid id);
    }
}
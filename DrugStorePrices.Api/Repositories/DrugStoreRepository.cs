using DrugStorePrices.Api.Interfaces.Repositories;
using DrugStorePrices.Api.Models;
using DrugStorePrices.Api.ViewModels.DrugStore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DrugStorePrices.Api.Repositories
{
    public class DrugStoreRepository : IDrugStoreRepository
    {

        private readonly AppDbContext Db;
        private readonly DbSet<DrugStore> DbSet;

        public DrugStoreRepository(AppDbContext context)
        {
            Db = context;
            DbSet = Db.DrugStores;
        }

        public void Commit()
        {
            Db.SaveChanges();
        }

        public Guid Create(DrugStoreCreateViewModel drugStoreCreateViewModel)
        {
            DrugStore drugStore = new DrugStore()
            {
                Name = drugStoreCreateViewModel.Name,
                StoreUrl = drugStoreCreateViewModel.StoreUrl,
                LogoUrl = drugStoreCreateViewModel.LogoUrl
            };
            DbSet.Add(drugStore);
            return drugStore.Id;

        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DrugStore>> GetAll()
        {
            List<DrugStore> drugStores = await DbSet.ToListAsync();
            return drugStores;
        }

        public DrugStore GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Update(DrugStore drugStore)
        {
            throw new NotImplementedException();
        }
    }
}

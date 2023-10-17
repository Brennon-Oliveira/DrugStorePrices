using DrugStorePrices.Api.Models;
using DrugStorePrices.Api.ViewModels.DrugStore;

namespace DrugStorePrices.Api.Interfaces.Repositories
{
    public interface IDrugStoreRepository
    {
        public Task<List<DrugStore>> GetAll();
        public DrugStore GetById(Guid id);
        public Guid Create(DrugStoreCreateViewModel drugStore);
        public Guid Update(DrugStore drugStore);
        public void Delete(Guid id);
        public void Commit();
    }
}

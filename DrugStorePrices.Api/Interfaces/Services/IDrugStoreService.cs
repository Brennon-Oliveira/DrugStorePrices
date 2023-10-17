using DrugStorePrices.Api.Models;
using DrugStorePrices.Api.ViewModels.DrugStore;

namespace DrugStorePrices.Api.Interfaces.Services
{
    public interface IDrugStoreService
    {
        public Task<List<DrugStore>> GetAll();
        public DrugStore GetById(Guid id);
        public Guid Create(DrugStoreCreateViewModel drugStore);
        public Guid Update(DrugStore drugStore);
        public void Delete(Guid id);

    }
}

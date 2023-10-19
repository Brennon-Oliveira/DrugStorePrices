

using DrugStorePrices.Application.ViewModels.DrougStore;
using DrugStorePrices.Domain.Models;

namespace DrugStorePrices.Application.Interfaces.Repositories
{
    public interface IDrugStoreService
    {
        public Task<List<DrugStore>> GetAll();
        public Task<DrugStore> GetById(Guid id);
        public Guid Create(DrugStoreCreateViewModel drugStoreViewModel);
        public void Update(DrugStoreUpdateViewModel drugStore);
        public void Delete(Guid id);

    }
}

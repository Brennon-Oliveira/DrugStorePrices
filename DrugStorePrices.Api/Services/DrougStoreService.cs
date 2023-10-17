using DrugStorePrices.Api.Interfaces.Repositories;
using DrugStorePrices.Api.Interfaces.Services;
using DrugStorePrices.Api.Models;
using DrugStorePrices.Api.ViewModels.DrugStore;

namespace DrugStorePrices.Api.Services
{
    public class DrugStoreService : IDrugStoreService
    {
        private readonly IDrugStoreRepository _drugStoreRepository;
        public DrugStoreService 
        (
            IDrugStoreRepository drugStoreRepository
        )
        {
            _drugStoreRepository = drugStoreRepository;
        }

        public Guid Create(DrugStoreCreateViewModel drugStore)
        {
            Guid drugStoreId = _drugStoreRepository.Create(drugStore);
            _drugStoreRepository.Commit();
            return drugStoreId;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DrugStore>> GetAll()
        {
            return await _drugStoreRepository.GetAll();
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


using DrugStorePrices.Application.Interfaces.Repositories;
using DrugStorePrices.Application.ViewModels.DrougStore;
using DrugStorePrices.CrossCutting.ServiceLocator;
using DrugStorePrices.Domain.Actions;
using DrugStorePrices.Domain.Interfaces.Actions;
using DrugStorePrices.Domain.Interfaces.Mappers;
using DrugStorePrices.Domain.Interfaces.Repositories;
using DrugStorePrices.Domain.Models;
using DrugStorePrices.Domain.VO.DrugStore;

namespace DrugStorePrices.Domain.Services
{
    public class DrugStoreService : IDrugStoreService
    {
        private readonly IDrugStoreRepository _drugStoreRepository = ServiceLocator.GetService<IDrugStoreRepository>();
        private readonly IDrugStoreActions _drugStoreActions;
        public DrugStoreService 
        ( )
        {}

        public Guid Create(DrugStoreCreateViewModel drugStoreViewModel)
        {
            return _drugStoreActions.Create(drugStoreViewModel.ToDrugStoreCreateVO());
        }

        public void Delete(Guid id)
        {
            _drugStoreActions.Delete(id);
        }

        public async Task<List<DrugStore>> GetAll()
        {
            return await _drugStoreRepository.GetAll();
        }

        public async Task<DrugStore> GetById(Guid id)
        {
            return await _drugStoreRepository.GetById(id);
        }

        public void Update(DrugStoreUpdateViewModel drugStore)
        {
            _drugStoreActions.Update(drugStore.ToDrugStoreUpdateVO());
        }
    }
}

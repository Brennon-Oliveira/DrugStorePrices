using DrugStorePrices.Application.Interfaces.Repositories;
using DrugStorePrices.CrossCutting.Mapper;
using DrugStorePrices.CrossCutting.ServiceLocator;
using DrugStorePrices.Domain.Actions;
using DrugStorePrices.Domain.Interfaces.Actions;
using DrugStorePrices.Domain.Interfaces.Mappers;
using DrugStorePrices.Domain.Interfaces.Repositories;
using DrugStorePrices.Domain.Repositories;
using DrugStorePrices.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DrugStorePrices.Domain;

public static class NativeInjectorBootstrapper
{
    public static void RegisterServices(IServiceCollection services)
    {

        #region Repositories

        services.AddScoped<IDrugStoreRepository, DrugStoreRepository>();

        #endregion Repositories

        #region Services

        services.AddScoped<IDrugStoreService, DrugStoreService>();

        #endregion Services

        #region Actions

        services.AddScoped<IDrugStoreActions, DrugStoreActions>();
        
        #endregion Actions

        #region Mappers

        services.AddSingleton<IModelMapper, ModelMapper>();

        #endregion Mappers

        ServiceLocator.SetProvider(services.BuildServiceProvider());

    }
}

using DrugStorePrices.Api.Interfaces.Repositories;
using DrugStorePrices.Api.Interfaces.Services;
using DrugStorePrices.Api.Repositories;
using DrugStorePrices.Api.Services;

namespace DrugStorePrices.Api;

public static class NativeInjectorBootstrapper
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IDrugStoreRepository, DrugStoreRepository>();
        services.AddScoped<IDrugStoreService, DrugStoreService>();
    }
}


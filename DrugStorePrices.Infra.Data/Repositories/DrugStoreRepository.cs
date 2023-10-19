

using DrugStorePrices.Domain.Interfaces.Repositories;
using DrugStorePrices.Domain.Models;
using DrugStorePrices.Domain.VO.DrugStore;
using DrugStorePrices.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace DrugStorePrices.Domain.Repositories
{
    public class DrugStoreRepository : BaseRepository<DrugStore>, IDrugStoreRepository
    {

        public DrugStoreRepository(AppDbContext context) : base(context)
        {

        }

        
    }
}

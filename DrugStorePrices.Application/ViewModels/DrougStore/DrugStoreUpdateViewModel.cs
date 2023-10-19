using DrugStorePrices.Domain.VO.DrugStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStorePrices.Application.ViewModels.DrougStore
{
    public class DrugStoreUpdateViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? StoreUrl { get; set; }
        public string? LogoUrl { get; set; }

        public DrugStoreUpdateVO ToDrugStoreUpdateVO()
        {
            return new DrugStoreUpdateVO
            {
                Id = this.Id,
                Name = this.Name,
                StoreUrl = this.StoreUrl,
                LogoUrl = this.LogoUrl
            };
        }
    }
}

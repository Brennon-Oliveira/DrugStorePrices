using DrugStorePrices.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStorePrices.Domain.ModelsBuilders
{

    internal class DrugStoreBuilder : BaseModelBuilder<DrugStore>
    {
        public DrugStoreBuilder WithName(string name)
        {
            _instance.Name = name;
            return this;
        }

        public DrugStoreBuilder WithStoreUrl(string storeUrl)
        {
            _instance.StoreUrl = storeUrl;
            return this;
        }

        public DrugStoreBuilder WithLogoUrl(string logoUrl)
        {
            _instance.LogoUrl = logoUrl;
            return this;
        }
    }
}

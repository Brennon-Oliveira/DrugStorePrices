using DrugStorePrices.Domain.Interfaces.Actions;
using DrugStorePrices.Domain.Interfaces.Repositories;
using DrugStorePrices.Domain.Models;
using DrugStorePrices.Domain.ModelsBuilders;
using DrugStorePrices.Domain.VO.DrugStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStorePrices.Domain.Actions
{
    public class DrugStoreActions : IDrugStoreActions
    {

        public Guid Create(DrugStoreCreateVO drugStoreCreateVO)
        {
            DrugStore drugStore = new DrugStoreBuilder()
                .WithName(drugStoreCreateVO.Name)
                .WithStoreUrl(drugStoreCreateVO.StoreUrl)
                .WithLogoUrl(drugStoreCreateVO.LogoUrl)
                .Build();
            drugStore.Create();
            return drugStore.Id;
        }

        public void Update(DrugStoreUpdateVO drugStoreUpdateVO)
        {
            DrugStore drugStore = new DrugStoreBuilder()
                .WithId(drugStoreUpdateVO.Id)
                .FindSelf()
                .Build();

            if(drugStoreUpdateVO.Name != null)
            {
                drugStore.Name = drugStoreUpdateVO.Name;
            }

            if (drugStoreUpdateVO.StoreUrl != null)
            {
                drugStore.StoreUrl = drugStoreUpdateVO.StoreUrl;
            }

            if (drugStoreUpdateVO.LogoUrl != null)
            {
                drugStore.LogoUrl = drugStoreUpdateVO.LogoUrl;
            }
            
            drugStore.Update();
        }
        public void Delete(Guid id)
        {
            DrugStore drugStore = new DrugStoreBuilder()
                .WithId(id)
                .FindSelf()
                .Build();

            drugStore.Delete();
        }
    }
}

using DrugStorePrices.Domain.VO.DrugStore;

namespace DrugStorePrices.Application.ViewModels.DrougStore
{
    public class DrugStoreCreateViewModel
    {
        public DrugStoreCreateViewModel(string name, string storeUrl, string logoUrl)
        {
            Name = name;
            StoreUrl = storeUrl;
            LogoUrl = logoUrl;
        }

        public string Name { get; set; }
        public string StoreUrl { get; set; }
        public string LogoUrl { get; set; }

        public DrugStoreCreateVO ToDrugStoreCreateVO()
        {
            DrugStoreCreateVO drugStoreCreateVO = new()
            {
                Name = Name,
                StoreUrl = StoreUrl,
                LogoUrl = LogoUrl
            };
            return drugStoreCreateVO;
        }
    }
}

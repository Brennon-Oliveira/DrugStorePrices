namespace DrugStorePrices.Application.ViewModels.DrougStore
{
    public class DrugStoreGetViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string StoreUrl { get; set; }
        public string LogoUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}

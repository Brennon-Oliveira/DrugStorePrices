using System.ComponentModel.DataAnnotations;

namespace DrugStorePrices.Api.Models;

public class DrugStore
{

    public DrugStore()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
    }

    public Guid Id { get; set; }

    [MaxLength(255)]
    public string Name { get; set; }

    [MaxLength(255)]
    public string StoreUrl { get; set; }

    [MaxLength(255)]
    public string LogoUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}
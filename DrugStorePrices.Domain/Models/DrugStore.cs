using DrugStorePrices.CrossCutting.ServiceLocator;
using DrugStorePrices.Domain.Interfaces.Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace DrugStorePrices.Domain.Models;

public class DrugStore : BaseModel
{
    
    private readonly IDrugStoreRepository _drugStoreRepository;

    public DrugStore()
    {
        _drugStoreRepository = ServiceLocator.GetService<IDrugStoreRepository>();
        
        if(Id == Guid.Empty || Id == null)
        {
            Id = Guid.NewGuid();
        }
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

    public override void Create()
    {
        CreateValidation();
        _drugStoreRepository.DbSet.Add(this);
        _drugStoreRepository.Commit();
    }


    public override async void Refresh()
    {
        var updated =  await _drugStoreRepository.GetById(Id);

        if (updated is null)
        {
            throw new Exception("DrugStore not found");
        }

        _modelMapper.Map(updated, this);
    }

    public override async void Delete()
    {
        Refresh();
        DeletedAt = DateTime.UtcNow;
        await _drugStoreRepository.Commit();
    }

    public override void Update()
    {
        UpdateValidation();
        _drugStoreRepository.DbSet.Update(this);
    }

    private void CreateValidation()
    {
        ValidateName();
        ValidateStoreUrl();
        ValidateLogoUrl();
    }

    private void UpdateValidation()
    {
        ValidateName();
        ValidateStoreUrl();
        ValidateLogoUrl();
    }


    private void ValidateName()
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name is required");
        }
    }

    private void ValidateStoreUrl()
    {
        if (string.IsNullOrEmpty(StoreUrl))
        {
            throw new Exception("StoreUrl is required");
        }
    }

    private void ValidateLogoUrl()
    {
        if (string.IsNullOrEmpty(LogoUrl))
        {
            throw new Exception("LogoUrl is required");
        }
    }

}

using DrugStorePrices.Api.Interfaces.Services;
using DrugStorePrices.Api.Models;
using DrugStorePrices.Api.ViewModels.DrugStore;
using Microsoft.AspNetCore.Mvc;

namespace DrugStorePrices.Api.Controllers
{
    [Route("DrugStore")]
    [ApiController]
    public class DrugStoreController
    {
        private readonly IDrugStoreService _drugStoreService;
        public DrugStoreController
        (
            IDrugStoreService drugStoreService
        )
        {
            _drugStoreService = drugStoreService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return new OkObjectResult(await _drugStoreService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Create(DrugStoreCreateViewModel drugStore)
        {
            return new OkObjectResult(_drugStoreService.Create(drugStore));
        }

        [HttpPut]
        public IActionResult Update(DrugStore drugStore)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            throw new NotImplementedException();
        }   
    }
}

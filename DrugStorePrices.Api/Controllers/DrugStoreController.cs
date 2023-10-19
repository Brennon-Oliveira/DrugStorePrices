
using DrugStorePrices.Application.Interfaces.Repositories;
using DrugStorePrices.Application.ViewModels.DrougStore;
using Microsoft.AspNetCore.Mvc;

namespace DrugStorePrices.Domain.Controllers
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
            return new OkObjectResult(_drugStoreService.GetById(id));
        }

        [HttpPost]
        public IActionResult Create(DrugStoreCreateViewModel drugStore)
        {
            return new OkObjectResult(new
            {
                Id = _drugStoreService.Create(drugStore),
                Message = "Farmácia criada com sucesso!"
            });
        }

        [HttpPut]
        public IActionResult Update(DrugStoreUpdateViewModel drugStore)
        {
            _drugStoreService.Update(drugStore);
            return new OkObjectResult(new
            {
                Message = "Farmácia atualizada com sucesso!"
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _drugStoreService.Delete(id);
            return new OkObjectResult(new
            {
                Message = "Farmácia deletada com sucesso!"
            });
        }   
    }
}

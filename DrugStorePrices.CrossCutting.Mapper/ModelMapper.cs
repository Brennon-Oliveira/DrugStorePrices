using AutoMapper;
using DrugStorePrices.Domain.Interfaces.Mappers;
using DrugStorePrices.Domain.Models;
using DrugStorePrices.Infra.Data.Migrations;

namespace DrugStorePrices.CrossCutting.Mapper
{
    public class ModelMapper : IModelMapper
    {
        private readonly IMapper _mapper;
        public ModelMapper()
        {
            MapperConfiguration mapperConfiguration = new(cfg =>
            {

                #region Models

                cfg.CreateMap<DrugStore, DrugStore>();

                #endregion Models

            });
            _mapper = mapperConfiguration.CreateMapper();
        }

        public void Map(object source, object destination)
        {
            _mapper.Map(source, destination);
        }
    }
}
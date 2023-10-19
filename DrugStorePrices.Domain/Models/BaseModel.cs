using DrugStorePrices.CrossCutting.ServiceLocator;
using DrugStorePrices.Domain.Interfaces.Mappers;
using DrugStorePrices.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStorePrices.Domain.Models
{
    public abstract class BaseModel
    {
        protected IModelMapper _modelMapper = ServiceLocator.GetService<IModelMapper>();
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastUpdateAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public abstract void Refresh();
        public abstract void Create();
        public abstract void Update();
        public abstract void Delete();
    }
}

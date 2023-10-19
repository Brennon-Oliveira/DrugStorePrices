using DrugStorePrices.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStorePrices.Domain.ModelsBuilders
{
    internal class BaseModelBuilder<T> where T : BaseModel
    {
        protected T _instance;

        public BaseModelBuilder()
        {
            _instance = Activator.CreateInstance<T>();
        }

        public BaseModelBuilder<T> WithId(Guid id)
        {
            _instance.Id = id;
            return this;
        }

        public BaseModelBuilder<T> FindSelf()
        {
            if (_instance.Id == null)
            {
                throw new Exception("Id is required");
            }
            _instance.Refresh();
            return this;
        }

        public T Build()
        {
            return _instance;
        }
    }
}

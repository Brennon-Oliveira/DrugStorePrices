using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStorePrices.Domain.Interfaces.Mappers
{
    public interface IModelMapper
    {
        void Map(object source, object destination);
    }
}

using DrugStorePrices.Domain.VO.DrugStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStorePrices.Domain.Interfaces.Actions
{
    public interface IDrugStoreActions
    {
        public Guid Create(DrugStoreCreateVO drugStoreCreateVO);
        public void Update(DrugStoreUpdateVO drugStoreUpdateVO);
        public void Delete(Guid id);
    }
}

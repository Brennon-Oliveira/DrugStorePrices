using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStorePrices.Domain.VO.DrugStore
{
    public class DrugStoreUpdateVO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? StoreUrl { get; set; }
        public string? LogoUrl { get; set; }
    }
}

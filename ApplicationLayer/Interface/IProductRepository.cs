using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Interface
{
    public interface IProductRepository
    {
        public SearchProductResponse FilterProductBasedOnData(ProductSearchData criteria);
    }
}

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
        public Task<SearchProductResponse> FilterProductBasedOnData(ProductSearchData criteria);
    }
}

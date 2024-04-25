
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace ApplicationLayer.Interface
{
    public interface ISearchHistory
      {
        void Add(SearchHistory product);
    }
}

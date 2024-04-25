using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Models;
using ApplicationLayer.Interface;
 namespace Infrastructure
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Domain;
    using Inframodel=Infrastructure.Models;
    using Microsoft.EntityFrameworkCore;
    using SearchHistory = SearchHistory;

    public class SearchHistoryRepository: ISearchHistory
{
        protected readonly AppDbContext _context;
            // Constructor
          
        public SearchHistoryRepository(AppDbContext context)
        {     
            _context = context;
              
        }
     
public void Add(Domain.SearchHistory SearchHistory)

        {
            SearchHistory objHistory = new Inframodel.SearchHistory()
            {
                Query = SearchHistory.Query,
                Timestamp = SearchHistory.Timestamp,
                UserId = SearchHistory.UserId
            };

            
          _context.SearchHistories.Add(objHistory);
            _context.SaveChanges();
        }
        // Filter product based on attribute
    }

}

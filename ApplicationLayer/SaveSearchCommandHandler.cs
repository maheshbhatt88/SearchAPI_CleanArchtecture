
using ApplicationLayer.Interface;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{

    public class SaveSearchHistoryCommand : IRequest<bool>
    {
        public int? UserId { get; set; }

        public string? Query { get; set; }

        public DateTime? Timestamp { get; set; }
    }
    public class SaveSearchHistoryCommandHandler :IRequestHandler<SaveSearchHistoryCommand, bool>
    {
        private readonly ISearchHistory _repositorygen;

        public SaveSearchHistoryCommandHandler(ISearchHistory repositorygen)
        {
            _repositorygen = repositorygen;
          
        }

        public  async Task<bool> Handle(SaveSearchHistoryCommand command,CancellationToken ct)
        {
            var searchHistory = new SearchHistory
            {
                Query = command.Query,
                Timestamp = command.Timestamp,
                UserId=1
            };
             _repositorygen.Add(searchHistory);
            return true;
             
                
        }
    }

}

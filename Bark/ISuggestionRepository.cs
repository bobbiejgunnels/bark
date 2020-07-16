using System;
using Bark.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Bark
{
    public interface ISuggestionRepository
    {
      public void InsertSuggestion(Suggestion suggestion);
      public IEnumerable<Suggestion> GetAllSuggestions();
    }
}

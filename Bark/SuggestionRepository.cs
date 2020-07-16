using System;
using System.Data;
using Bark.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace Bark
{
    public class SuggestionRepository : ISuggestionRepository
    {
        private readonly IDbConnection _conn;

        public SuggestionRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void InsertSuggestion(Suggestion suggestion)
        {
            _conn.Execute("INSERT INTO suggestions (Name, Size, Temperment, Life_Expectancy, Hair_Type) " +
                "VALUES (@name, @size, @temperment, @lifeExpectancy, @hairType);",
                new
                {
                    name = suggestion.Name,
                    size = suggestion.Size,
                    temperment = suggestion.Temperment,
                    lifeExpectancy = suggestion.Life_Expectancy,
                    hairType = suggestion.Hair_Type
                });
        }

        public IEnumerable<Suggestion> GetAllSuggestions()
        {
            return _conn.Query<Suggestion>("SELECT * FROM suggestions;");
        }

    }
}

using System;
using System.Data;
using Bark.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Bark
{
    public class BreedRepository : IBreedRepository
    {
        private readonly IDbConnection _conn;

        public BreedRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Breed> GetAllBreeds()
        {
            return _conn.Query<Breed>("SELECT * FROM breeds;");
        }
    }
}
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

        public Breed GetBreed(int id)
        {
            return (Breed)_conn.QuerySingle<Breed>("SELECT * FROM breeds WHERE ID =@id",
                new { id = id });
        }

        public void InsertBreed(Breed breedToInsert)
        {
            _conn.Execute("INSERT INTO breeds (Name, Size, Temperment, Life_Expectancy, Hair_Type) " +
                "VALUES (@name, @size, @temperment, @lifeExpectancy, @hairType);",
                new
                {
                    name = breedToInsert.Name,
                    size = breedToInsert.Size,
                    temperment = breedToInsert.Temperment,
                    lifeExpectancy = breedToInsert.Life_Expectancy,
                    hairType = breedToInsert.Hair_Type
                });
        }

        public void UpdateBreed(Breed breed)
        {
            _conn.Execute("UPDATE breeds SET Name = @name, Size = @size, Temperment = @temperment, Life_Expectancy = @lifeExpectancy, Hair_Type = @hairType WHERE ID = @id",
                new { name = breed.Name, size = breed.Size, temperment = breed.Temperment, lifeExpectancy = breed.Life_Expectancy, hairType = breed.Hair_Type, id = breed.ID });
        }

        public void DeleteBreed(Breed breed)
        {
            _conn.Execute("DELETE FROM breeds WHERE ID = @id",
                new { id = @breed.ID });
        }
    }
}
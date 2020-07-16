using System;
using Bark.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Bark
{
        public interface IBreedRepository
        {
            public IEnumerable<Breed> GetAllBreeds();
            public Breed GetBreed(int id);
            public void UpdateBreed(Breed breed);
            public void InsertBreed(Breed breedToInsert);
            public void DeleteBreed(Breed breed);
            
    }

}

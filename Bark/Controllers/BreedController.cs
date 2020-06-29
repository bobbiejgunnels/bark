using System;
using Microsoft.AspNetCore.Mvc;
using Bark.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bark.Controllers
{
    public class BreedController : Controller
    {
        private readonly IBreedRepository repo;

        public BreedController(IBreedRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var breeds = repo.GetAllBreeds();

            return View(breeds);
        }

        public IActionResult ViewBreed(int id)
        {
            var breed = repo.GetBreed(id);
            return View(breed);
        }

        public IActionResult UpdateBreed(int id)
        {
            Breed breed = repo.GetBreed(id);
            repo.UpdateBreed(breed);

            if(breed == null)
            {
                return View("BreedNotFound");
            }
            return View(breed);
        }

        public IActionResult UpdateBreedToDatabase(Breed breed)
        {
            repo.UpdateBreed(breed);
            return RedirectToAction("ViewBreed", new { id = breed.ID });
        }


        public IActionResult InsertBreed(Breed breed)
        {
            
            return View(breed);
        }
        public IActionResult InsertBreedToDatabase(Breed breedToInsert)
        {
            repo.InsertBreed(breedToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBreed(Breed breed)
        {
            repo.DeleteBreed(breed);
            return RedirectToAction("Index");
        }
    }
}

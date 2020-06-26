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
    }
}

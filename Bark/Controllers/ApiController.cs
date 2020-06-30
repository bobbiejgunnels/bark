using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Dapper;

using Bark.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bark.Controllers
{
    public class ApiController : Controller
    {
       private readonly IBreedRepository repo;

        public ApiController(IBreedRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var breeds = repo.GetAllBreeds();

            return Json(new { success = true, breeds = breeds });
        }
    }
}

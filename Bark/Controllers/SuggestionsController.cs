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
    public class SuggestionsController : Controller
    {
        private readonly ISuggestionRepository repo;

        public SuggestionsController(ISuggestionRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var suggestions = repo.GetAllSuggestions();

            return View(suggestions);
        }

        // POST: /<controller>/create
        [HttpPost]
        public IActionResult InsertSuggestion([FromBody] Suggestion suggestion)
        {
            repo.InsertSuggestion(suggestion);

            return Json(new { success = true });
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Young.Models;

namespace Mission06_Young.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _context;

        public HomeController(MoviesContext movies)
        {
            _context = movies;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Form response)
        {
            _context.Movies.Add(response); //Add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

    }
}

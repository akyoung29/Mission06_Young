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
            var movies = _context.Movies
                .ToList();
            return View(movies);
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("Movie Form", new Form());
        }

        [HttpPost]
        public IActionResult MovieForm(Form response)
        {
            if (ModelState.IsValid)
            {
                 _context.Movies.Add(response); //Add record to the database
                            _context.SaveChanges();

                return View("Confirmation", response);
            }
            else //If it has invalid data
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

                return View(response);
            }
        }

        public IActionResult Edit(int id)
        {
            var movieToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("MovieForm", movieToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Form form)
        {
            _context.Update(form);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movieToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View("Delete", movieToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Form form)
        {
            _context.Movies.Remove(form);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

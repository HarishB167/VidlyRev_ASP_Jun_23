using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRev.Models;
using VidlyRev.ViewModels;

namespace VidlyRev.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new IndexMoviesViewModel()
            {
                Movies = getMovies()
            };
            return View(movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }


        public List<Movie> getMovies()
        {
            var movies = new List<Movie>
            {
                new Movie() { Id = 1, Name = "Wall-E" },
                new Movie() { Id = 2, Name = "Shrek" }
            };
            return movies;
        }
    }
}
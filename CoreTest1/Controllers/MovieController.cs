//manually made:D

using CoreTest1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreTest1.Controllers
{
    public class MovieController: Controller
    {
        private static List<MovieViewModel> _movies = new List<MovieViewModel>();


        public IActionResult Index(){

       //     MovieViewModel movie = new MovieViewModel()
         //   {
         //       MovieTitle = "The Godfater", Director = "Francis Ford Coppola", Year = 1972
        //    };
            return View(_movies);
        }



        public IActionResult Create()
        {
            var movieVm = new MovieViewModel();
            return View(movieVm);
        }

        public IActionResult CreateMovie(MovieViewModel movieViewModel)
        {
            _movies.Add(movieViewModel);
            return RedirectToAction(nameof(Index));
        }


    }
}
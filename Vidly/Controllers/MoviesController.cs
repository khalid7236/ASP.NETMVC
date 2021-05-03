using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie { Name = "sherk!" };
            var Customers = new List<Customer> {
                                new Customer {Name = "khalid"},
                                new Customer {Name = "Rama"}
                            };

            var ViewModel = new RandomMovieViewModels
            {
                Movie = movie,
                Customers = Customers
            };
            return View(ViewModel);
        }

        public ActionResult ByReleaseDate(int year , int month)
        {
            return Content(year + "/" + month);
        }
    }
}
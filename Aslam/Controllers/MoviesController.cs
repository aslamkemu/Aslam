using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aslam.Models;
using Aslam.ViewModels;
using System.Data.Entity;

namespace Aslam.Controllers
{


    public class MoviesController : Controller
    {
        // GET: Movies

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ViewResult Index()
        {
            var movies = _context.Movies;

            return View(movies);
        }

       

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Game of Thrones!" };
           
            var customers = new List<Customer>
            {
                new Customer  { Name = "Customer 1" },
                new Customer  { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }        

    }
}
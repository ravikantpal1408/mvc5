using Foothill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foothill.ViewModels;
using System.Data.Entity;

namespace Foothill.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult MovieList()
        {
            var movies = _context.Cinemas.Include(x=>x.Genre).ToList();
            
            return View(movies);
        }


        // GET: Movies
        public ActionResult Random()
        {
            var movie = _context.Cinemas.ToList();

            var customers =_context.Customers.ToList();


            var viewModel = new RandomMovieViewModels()
            {
                //Movies = { Id=},
                Customers = customers
            };

            ViewData["Movie"] = movie;
            return View(viewModel);
            //return Content("Hello World !!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }


        public ActionResult Edit(int id)
        {
            return Content("Id =" + id.ToString());
        }


        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }

        [Route("movies/released/{year}/{month}")]//:regex(\\d{4}):range(2014,2015)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("Movies/MovieInfo/{Id:range(1,3)}")]
        public ActionResult MovieInfo(int Id)
        {

            var moviesInfo = _context.Cinemas.Include(m=>m.Genre)
                .SingleOrDefault(m=>m.Id==Id);



            return View(moviesInfo);
        }
    }
}
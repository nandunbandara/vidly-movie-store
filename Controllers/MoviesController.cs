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
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek"};

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMoviesViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(String.Format("Year:{0} Month: {1}", year, month));
        }

        public ActionResult Update()
        {
            return RedirectToAction("Index", "Home", new { id = 1, name = "Nandun" });
        }

        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return Content("id is not passed");
            }

            return Content(String.Format("ID: {0}", id));

        }
    }
}
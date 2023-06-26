using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyRev.Dtos;
using VidlyRev.Models;

namespace VidlyRev.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            
            foreach (var movieId in newRental.MovieIds)
            {
                var movie = _context.Movies.Single(m => m.Id == movieId);
                movie.NumberAvailable--;
                var rental = new Rental { Customer = customer, DateRented = DateTime.Now, Movie = movie };
                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}

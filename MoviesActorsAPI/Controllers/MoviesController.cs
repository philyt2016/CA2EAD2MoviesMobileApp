using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesActorsAPI;

//testing to see git working

namespace MoviesActorsAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesContext _context;

        public MoviesController(MoviesContext context)
        {
            _context = context;
        }

        // GET api/movies/all
        [HttpGet("all")]        
        public IEnumerable<Movie> GetAllEntries()
        {
            var entries = _context.Movie.OrderBy(e => e.Name);
            return entries;
        }

        

        //GET: api/movies/genre/eg. action
        [HttpGet("genre/{Genre}")]
        public IActionResult GetMovieByGenre(String Genre)
        {
            // LINQ query, find matching entries for genre
            var entries = _context.Movie.Where(r => r.Genre.ToUpper() == Genre.ToUpper());

            if (entries == null)
            {
                return NotFound();
            }
            return Ok(entries);
        }

        [HttpGet("stars/{Stars:int}")]
        public IActionResult GetMovieByStars(int Stars)
        {
            // LINQ query, find matching entries for num of stars
            var entries = _context.Movie.Where(r => r.Stars == Stars);

            if (entries == null)
            {
                return NotFound();
            }
            return Ok(entries);
        }

        [HttpGet("year_released/{ReleaseYear:int}")]
        public IActionResult GetMovieByReleaseYear(int ReleaseYear)
        {
            // LINQ query, find matching entries for num of stars
            var entries = _context.Movie.Where(r => r.ReleaseYear == ReleaseYear);

            if (entries == null)
            {
                return NotFound();
            }
            return Ok(entries);
        }


        //test
        private bool MovieExists(string id)
        {
            return _context.Movie.Any(e => e.Name == id);
        }
    }
}
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

        // GET api/movies/name/
        [HttpGet("name/{name}", Name = "GetMovieByName")]        
        public IActionResult GetMovieByName(string name)
        {
            // LINQ query, find matching entry for number
            var entry = _context.Movie.FirstOrDefault(m => m.Name.ToUpper() == name.ToUpper());
            if (entry == null)
            {
                return NotFound();
            }
            return Ok(entry);
        }



        //GET: api/movies/genre/eg. action
        [HttpGet("genre/{genre}")]
        public IActionResult GetMovieByGenre(String genre)
        {
            // LINQ query, find matching entries for genre
            var entries = _context.Movie.Where(r => r.Genre.ToUpper() == genre.ToUpper());

            if (entries == null)
            {
                return NotFound();
            }
            return Ok(entries);
        }


        [HttpGet("stars/{stars:int}")]
        public IActionResult GetMovieByStars(int stars)
        {
            // LINQ query, find matching entries for num of stars
            var entries = _context.Movie.Where(r => r.Stars == stars);

            if (entries == null)
            {
                return NotFound();
            }
            return Ok(entries);
        }


        [HttpGet("year_released/{release_year:int}")]
        public IActionResult GetMovieByReleaseYear(int release_year)
        {
            // LINQ query, find matching entries for num of stars
            var entries = _context.Movie.Where(r => r.ReleaseYear == release_year);

            if (entries == null)
            {
                return NotFound();
            }
            return Ok(entries);
        }


        // DELETE: api/movies/name
        [HttpDelete("{name}")]
        public async Task<IActionResult> DeleteMovie([FromRoute] string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var movie = await _context.Movie.FindAsync(name);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();

            return Ok(movie);
        }


        // POST: api/movies
        // add an entry
        [HttpPost]
        [ProducesResponseType(201)]             // created
        [ProducesResponseType(400)]             // bad request
        public IActionResult PostAddEntry([FromBody] Movie movie)
        {
            if (ModelState.IsValid)                                            
            {
                // check for duplicate
                // LINQ query - get record
                var record = _context.Movie.SingleOrDefault(e => e.Name.ToUpper() == movie.Name.ToUpper());
                if (record == null)
                {
                    _context.Movie.Add(movie);
                    _context.SaveChanges();                                           

                    // create http response with Created status code and listing serialised as content and Location header set to URI for new resource
                    return CreatedAtRoute("GetMovieByName", new { name = movie.Name }, movie);
                }
                else
                {
                    return BadRequest("resource already exists");      // 400, already exists
                }
            }
            else
            {
                return BadRequest(ModelState);        // 400
            }
        }


        //test
        private bool MovieExists(string id)
        {
            return _context.Movie.Any(e => e.Name == id);
        }
    }
}
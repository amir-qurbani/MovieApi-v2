using Microsoft.AspNetCore.Mvc;
using MovieApi.Data;
using MovieApi.Models;
namespace MovieApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MovieController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Movie>> GetMovies()
        {
            return _context.Movies.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovieById(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }
        [HttpPost]
        public ActionResult<Movie> CreateMovie(Movie movie)
        {
            if (movie == null)
            {
                return BadRequest();
            }
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpPut("{id}")]
        public ActionResult<Movie> UpdateMovie(int id, [FromBody] Movie updateMovie)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            movie.Title = updateMovie.Title;
            movie.Genre = updateMovie.Genre;
            movie.Year = updateMovie.Year;
            _context.SaveChanges();
            return movie;

        }

    }
}


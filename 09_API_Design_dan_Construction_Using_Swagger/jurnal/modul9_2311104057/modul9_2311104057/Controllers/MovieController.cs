using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using modul9_2311104057.Models;

namespace modul9_2311104057.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty transfers control to his reluctant son."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "When the menace known as the Joker wreaks havoc, Batman must accept one of the greatest tests."
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            if (movies == null || !movies.Any())
            {
                return NotFound("No movies found.");
            }
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMoviebyID(int id)
        {
            if (id < 0 || id >= movies.Count)
            {
                return NotFound("Movie not found.");
            }
            return Ok(movies[id]);
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie([FromBody] Movie movie)
        {
            if (movie == null || string.IsNullOrWhiteSpace(movie.Title) || string.IsNullOrWhiteSpace(movie.Director))
            {
                return BadRequest("Invalid movie data.");
            }
            movies.Add(movie);
            return CreatedAtAction(nameof(GetMoviebyID), new { id = movies.Count - 1 }, movie);
        }

        [HttpPut("{id}")]
        public ActionResult<Movie> PutMovie(int id, [FromBody] Movie movie)
        {
            if (id < 0 || id >= movies.Count)
            {
                return NotFound("Movie not found.");
            }
            if (movie == null || string.IsNullOrWhiteSpace(movie.Title) || string.IsNullOrWhiteSpace(movie.Director))
            {
                return BadRequest("Invalid movie data.");
            }
            movies[id] = movie;
            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= movies.Count)
            {
                return NotFound("Movie not found.");
            }
            movies.RemoveAt(id);
            return NoContent();
        }
    }
}

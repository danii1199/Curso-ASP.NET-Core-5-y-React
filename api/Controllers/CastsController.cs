using System.Linq;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/movies/{movieId}/casts")]
    public class CastsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCasts(int movieId)
        {
            var movie = MoviesDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie.Casts);
        }
        [HttpGet("{castId}", Name = "GetCast")]
        public IActionResult GetCast(int movieId, int castId)
        {
            var movie = MoviesDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);

            if (movie == null)
            {
                return NotFound();
            }

            var cast = movie.Casts.FirstOrDefault(x => x.Id == castId);
            if (cast == null)
            {
                return NotFound();
            }
            return Ok(cast);
        }

        [HttpPost]
        public IActionResult CreateCast(int movieId, [FromBody] CastForCreationDto castForCreationDto)
        {
            var movie = MoviesDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
            {
                return NotFound();
            }

            var maxCastId = MoviesDataStore.Current.Movies.SelectMany(x => x.Casts).Max(p => p.Id);

            var newCast = new CastDto
            {
                Id = ++maxCastId,
                Name = castForCreationDto.Name,
                Character = castForCreationDto.Character
            };

            movie.Casts.Add(newCast);

            return CreatedAtRoute(
                nameof(GetCast),
                new { movieId, castId = newCast.Id },
                castForCreationDto
            );

        }

        [HttpPut("{castId}")]
        public ActionResult UpdateCast(int movieId, int castId, [FromBody] CastForupdateDto castForupdate)
        {
            var movie = MoviesDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
            {
                return NotFound();
            }

            var cast = movie.Casts.FirstOrDefault(x => x.Id == castId);

            if (cast == null)
            {
                return NotFound();
            }

            cast.Name = castForupdate.Name;
            cast.Character = castForupdate.Character;

            return NoContent();


        }

        [HttpPatch]
        public IActionResult PartialUpdateCast(int movieId, int castId, [FromBody] JsonPathDocument<>)
        {

        }

        /*[HttpDelete("{castId")]
        public IActionResult DeleteCast(int moviedId, int castId)
        {
            var movie = MoviesDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
            {
                return NotFound();
            }

            var cast = movie.Casts.FirstOrDefault(x => x.Id == castId);

            if (cast == null)
            {
                return NotFound();
            }

        }*/
    }
}
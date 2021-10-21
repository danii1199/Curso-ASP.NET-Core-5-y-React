using System;
using System.Collections.Generic;
using System.Linq;
using api.Models;
using apiApp.Entities;
using apiApp.Services;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("api/movies/{movieId}/casts")]
    public class CastsController : ControllerBase
    {
        private ILogger<CastsController> _logger;
        private IMailService _localMailService;
        private IMovieInfoRepository _repository;
        private IMapper _mapper;

        public CastsController(ILogger<CastsController> logger, IMailService localMailService, IMovieInfoRepository repository, IMapper mapper)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _localMailService = localMailService ?? throw new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public IActionResult GetCasts(int movieId)
        {
            //var movie = MoviesDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);
            if (!_repository.MovieExists(movieId))
            {
                return NotFound();
            }

            var casts = _repository.GetCastsByMovies(movieId);

            return Ok(_mapper.Map<IEnumerable<CastDto>>(casts));
        }
        [HttpGet("{castId}", Name = "GetCast")]
        public IActionResult GetCast(int movieId, int castId)
        {
            try
            {
                //throw new InvalidOperationException();

                if (!_repository.MovieExists(movieId))
                {
                    return NotFound();
                }

                var cast = _repository.GetCast(movieId, castId);
                if (cast == null)
                {
                    _logger.LogInformation($"El cast con el id {castId} no fue encontrado");
                    return NotFound();
                }

                return Ok(_mapper.Map<CastDto>(cast));
            }
            catch (System.Exception ex)
            {
                _logger.LogCritical($"Un error ocurrio al buscar el cast con id {castId}", ex);
                return StatusCode(500, "Un problema ocurrio al realizar la solicitud al recurso");
            }
        }

        [HttpPost]
        public IActionResult CreateCast(int movieId, [FromBody] CastForCreationDto castForCreationDto)
        {
            if (!_repository.MovieExists(movieId))
            {
                return NotFound();
            }

            var finalCast = _mapper.Map<Cast>(castForCreationDto);
            _repository.AddCastForMovie(movieId, finalCast);
            _repository.Save();

            var createdCastToReturn = _mapper.Map<CastForCreationDto>(finalCast);

            return CreatedAtRoute(nameof(GetCast),
            new { movieId, Id = finalCast.Id },
            createdCastToReturn
            );

        }

        [HttpPut("{castId}")]
        public ActionResult UpdateCast(int movieId, int castId, [FromBody] CastForupdateDto castForupdate)
        {
            if (!_repository.MovieExists(movieId))
            {
                return NotFound();
            }

            var cast = _repository.GetCast(movieId, castId);

            if (cast == null)
            {
                return NotFound();
            }

            _mapper.Map(castForupdate, cast);
            _repository.UpdateCastForMovie(movieId, cast);
            _repository.Save();

            return NoContent();


        }

        [HttpPatch("{castId}")]
        public IActionResult PartialUpdateCast(int movieId, int castId, [FromBody] JsonPatchDocument<CastForupdateDto> patchDocument)
        {
            if (!_repository.MovieExists(movieId))
            {
                return NotFound();
            }

            var cast = _repository.GetCast(movieId, castId);

            if (cast == null)
            {
                return NotFound();
            }

            var castToCatch = _mapper.Map<CastForupdateDto>(cast);

            patchDocument.ApplyTo(castToCatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(castToCatch))
            {
                return BadRequest();
            }

            _mapper.Map(castToCatch, cast);
            _repository.UpdateCastForMovie(movieId, cast);
            _repository.Save();

            return NoContent();
        }

        [HttpDelete("{castId}")]
        public IActionResult DeleteCast(int movieId, int castId)
        {
            if (!_repository.MovieExists(movieId))
            {
                return NotFound();
            }

            var cast = _repository.GetCast(movieId, castId);

            if (cast == null)
            {
                return NotFound();
            }

            _localMailService.send("Recurso eliminado", $"El recurso con id{castId} ha sido eliminado");
            _repository.DeleteCastForMovie(cast);
            _repository.Save();

            return NoContent();

        }
    }
}
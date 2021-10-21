using System;
using System.Collections.Generic;
using System.Linq;
using apiApp.Context;
using apiApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace apiApp.Services
{
    public class MovieInfoRepository : IMovieInfoRepository
    {
        private MovieInfoContext _context;

        public MovieInfoRepository(MovieInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Cast GetCast(int movieId, int castId)
        {
            return _context.Casts.Where(c => c.MovieId == movieId && c.Id == castId).FirstOrDefault();
        }

        public IEnumerable<Cast> GetCastsByMovies(int movieId)
        {
            return _context.Casts.Where(c => c.MovieId == movieId).ToList();
        }

        public Movie GetMovie(int movieId, bool includeCast)
        {
            if (includeCast == true)
            {
                return _context.Movies.Include(c => c.Casts)
                .Where(x => x.Id == movieId).FirstOrDefault();
            }
            return _context.Movies.Where(x => x.Id == movieId).FirstOrDefault();

        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.OrderBy(m => m.Name).ToList();
        }


        public bool MovieExists(int movieId) => _context.Movies.Any(x => x.Id == movieId);
        public void AddCastForMovie(int movieId, Cast cast)
        {
            var movie = GetMovie(movieId, false);
            movie.Casts.Add(cast);
        }
        public bool Save() => _context.SaveChanges() > 0;

        public void UpdateCastForMovie(int moviId, Cast cast)
        {

        }

        public void DeleteCastForMovie(Cast cast)
        {
            _context.Casts.Remove(cast);
        }
    }
}
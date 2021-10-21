using System.Collections.Generic;
using System.Linq;
using apiApp.Entities;

namespace apiApp.Services
{
    public interface IMovieInfoRepository
    {
        IEnumerable<Movie> GetMovies();

        Movie GetMovie(int movieId, bool includeCast);

        IEnumerable<Cast> GetCastsByMovies(int movieId);

        Cast GetCast(int movieId, int castId);

        bool MovieExists(int movieId);

        void AddCastForMovie(int movieId, Cast cast);

        bool Save();

        void UpdateCastForMovie(int moviId, Cast cast);

        void DeleteCastForMovie(Cast cast);
    }
}
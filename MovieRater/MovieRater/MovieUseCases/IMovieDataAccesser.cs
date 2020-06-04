using MovieRater.Entities;
using System.Collections.Generic;

namespace MovieRater.MovieUseCases
{
    public interface IMovieDataAccesser
    {
        public List<Movie> GetMovies();
    }
}
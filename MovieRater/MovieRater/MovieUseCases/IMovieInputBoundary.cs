using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRater.MovieUseCases
{
    public interface IMovieInputBoundary
    {

        public void AddMovie(MovieInput movie);

        public void RemoveMovie(MovieInput movie);

        public void UpdateMovie(MovieInput movie);
    }
}

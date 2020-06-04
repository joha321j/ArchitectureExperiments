using MovieRater.Entities;
using MovieRater.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRater.MovieUseCases
{
    public class MovieRepository : IMovieInputBoundary
    {
        private List<Movie> _movies;
        private readonly IMovieOutputBoundary _outputBoundary;

        public MovieRepository(IMovieDataAccesser dataAccesser, IMovieOutputBoundary outputBoundary)
        {
            _movies = dataAccesser.GetMovies();
            _outputBoundary = outputBoundary;
        }
        public void AddMovie(MovieInput movie)
        {
            Movie temp = ConvertToMovie(movie);
            _movies.Add(temp);

            NotifyOutputBoundary();
        }

        private Movie ConvertToMovie(MovieInput movie)
        {
            throw new NotImplementedException();
        }

        private void NotifyOutputBoundary()
        {
            throw new NotImplementedException();
        }

        public void RemoveMovie(MovieInput movie)
        {
            try
            {
                RemoveMovieHelper(movie);
            }
            catch (ArgumentNullException e)
            {
                throw new UnableToRemoveMovieException(e);
            }
        }

        private void RemoveMovieHelper(MovieInput movie)
        {
            _movies.RemoveAll(m => m.Equals(movie));
            NotifyOutputBoundary();
        }

        public void UpdateMovie(MovieInput movie)
        {
            try
            {
                UpdateMovieHelper(movie);

            }
            catch (ArgumentNullException e)
            {
                throw new UnableToUpdateMovieException(e);
            }
        }

        private void UpdateMovieHelper(MovieInput movie)
        {
            Movie movieToUpdate = FindMovie(movie.Id);
            Movie updatedMovie = ConvertToMovie(movie);

            movieToUpdate.UpdateProperties(updatedMovie);
            NotifyOutputBoundary();
        }

        private Movie FindMovie(int id)
        {
            return _movies.Find(m => m.Id == id);
        }
    }
}

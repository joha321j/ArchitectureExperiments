using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRater.MovieUseCases
{
    public interface IMovieOutputBoundary
    {
        public T OutputData<T>();
    }
}

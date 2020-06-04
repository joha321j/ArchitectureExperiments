using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRater.Exceptions
{
    public class UnableToRemoveMovieException : Exception
    {
        public UnableToRemoveMovieException(Exception e) : base(e.Message)
        {

        }
    }
}

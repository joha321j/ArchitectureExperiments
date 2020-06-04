using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRater.Exceptions
{
    public class UnableToUpdateMovieException : Exception
    {
        public UnableToUpdateMovieException(Exception e) : base(e.Message)
        {

        }
    }
}

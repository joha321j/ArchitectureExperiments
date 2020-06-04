using MovieRater.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRater.MovieUseCases
{
    public class MovieOutput
    {
        public int Id { get; }
        public string Title { get; }
        public DateTime ReleaseDate { get; }
        public string Description { get; }
        public Review Review { get; }
    }
}

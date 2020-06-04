using System;

namespace MovieRater.Entities
{
    public class Movie
    {
        private string _title;
        private DateTime _releaseDate;
        private string _description;

        public Movie(int id, string title, DateTime releaseDate, string description)
        {
            Id = id;
            _title = title;
            _releaseDate = releaseDate;
            _description = description;
        }

        public int Id { get; }
        public string Title { get => _title; }
        public DateTime ReleaseDate { get => _releaseDate; }
        public string Description { get => _description;}

        public Review Review { get; set; }

        internal void UpdateProperties(Movie movie)
        {
            _title = movie.Title;
            _releaseDate = movie.ReleaseDate;
            _description = movie.Description;
        }
    }
}

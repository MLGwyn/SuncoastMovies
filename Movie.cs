using System;
using System.Collections.Generic;

namespace SuncoastMovies
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PrimaryDirector { get; set; }
        public int YearReleased { get; set; }
        public string Genre { get; set; }
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
        public List<Role> Roles { get; set; }
    }


}
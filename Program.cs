using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SuncoastMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SuncoastMoviesContext();

            var movieCount = context.Movies.Count();
            Console.WriteLine($"There are {movieCount} movies! ");

            var moviesWithRatingsRolesAndActors = context.Movies.
            Include(movie => movie.Rating).
            Include(movie => movie.Roles).
            ThenInclude(role => role.Actor);
            foreach (var movie in moviesWithRatingsRolesAndActors)
            {
                if (movie.Rating == null)
                {
                    Console.WriteLine($"There is a movie named {movie.Title} and has not been rated yet");
                }
                else
                {
                    Console.WriteLine($"There is a movie named {movie.Title} with a rating of {movie.Rating.Description}");
                }

                foreach (var role in movie.Roles)
                {
                    Console.WriteLine($"- Has a character named {role.CharacterName} played by {role.Actor.FullName}");
                }
            }
        }
    }
}

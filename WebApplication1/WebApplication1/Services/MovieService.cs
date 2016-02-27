using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    class MovieService
    {
        private static List<Movie> MovieList { get; set; }

        public MovieService()
        {
            if (MovieList == null)
            {
                MovieList = new List<Movie>()
                {
                    new Movie {Title = "The Matrix" , Genre = "SciFi", ReleaseYear = "1997"},
                    new Movie {Title = "The Matrix2" , Genre = "SciFi", ReleaseYear = "2001"}
                };


            }
        }

        public virtual IEnumerable<Movie> GetMovies()
        {
            return MovieList;
        }

        public virtual void AddMovie(Movie movie)
        {
            MovieList.Add(movie);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Home Teachers",
                        ReleaseDate = DateTime.Parse("2004-2-12"),
                        Genre = "1",
                        Rating = "G",
                        Price = 7.99M                    },
                   new Movie
                   {
                       Title = "The RM",
                       ReleaseDate = DateTime.Parse("2003-2-12"),
                       Genre = "2",
                       Rating = "G",
                       Price = 6.99M,
                 

                   },

                    new Movie
                    {
                        Title = "The Other Side of Heaven ",
                        ReleaseDate = DateTime.Parse("2002-3-13"),
                        Genre = "2",
                        Rating = "G",
                        Price = 8.99M,
                    },

           
                    new Movie
                    {
                        Title = "The Other Side of Heaven: 2 Fire of Faith",
                        ReleaseDate = DateTime.Parse("2018-9-11"),
                        Genre = "2",
                        Rating = "PG-13",
                        Price = 3.99M,
                  
                    }
                );
                context.SaveChanges();
            }
            using (var contextGenres = new MvcMovieContext(
              serviceProvider.GetRequiredService<
                  DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (contextGenres.Genre.Any())
                {
                    return;   // DB has been seeded
                }

                contextGenres.Genre.AddRange(
                    new Genre
                    {
                        GenreName = "Comedy",
                     
                    },

                    new Genre
                    {
                        GenreName = "Drama",

                    },
                     new Genre
                     {
                         GenreName = "Romantic",

                     },
                      new Genre
                      {
                          GenreName = "Documental",

                      }
                    
                );
                contextGenres.SaveChanges();
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ModelViewControllerMovie.Data;
using System;
using System.Linq;

namespace ModelViewControllerMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ModelViewControllerMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ModelViewControllerMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Home Teachers",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "1",
                        Rating = "G",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven ",
                        ReleaseDate = DateTime.Parse("2002-3-13"),
                        Genre = "2",
                        Rating = "G",
                        Price = 8.99M
                    },

                    new Movie
                    
                    {
                       Title = "The Other Side of Heaven: II ",
                       ReleaseDate = DateTime.Parse("2018-3-13"),
                       Genre = "2",
                       Rating = "G",
                       Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "The Restoration",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "3",
                        Rating = "G",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "3",
                        Rating = "PG",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
            using (var contextGenres = new ModelViewControllerMovieContext(
              serviceProvider.GetRequiredService<
                  DbContextOptions<ModelViewControllerMovieContext>>()))
            {
                // Look for any movies.
                if (contextGenres.Genre.Any())
                {
                    return;   // DB has been seeded
                }

                contextGenres.Genre.AddRange(
                    new Genre
                    {
                        GenreName = "Documentary"
                    },

                    new Genre
                    {
                        GenreName = "Comedy"
                    },
                    new Genre
                    {
                        GenreName = "Adventure",

                    },
                    new Genre
                    {
                        GenreName = "Drama",

                    }
                );
                contextGenres.SaveChanges();
            }
        }
    }
}

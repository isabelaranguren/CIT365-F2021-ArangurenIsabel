using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelViewControllerMovie.Models;

namespace ModelViewControllerMovie.Data
{
    public class ModelViewControllerMovieContext : DbContext
    {
        public ModelViewControllerMovieContext (DbContextOptions<ModelViewControllerMovieContext> options)
            : base(options)
        {
        }

        public DbSet<ModelViewControllerMovie.Models.Movie> Movies { get; set; }
        public DbSet<ModelViewControllerMovie.Models.Genre> Genre { get; set; }

    }
}

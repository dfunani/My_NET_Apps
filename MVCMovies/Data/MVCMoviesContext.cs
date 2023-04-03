using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovies.Models;

namespace MVCMovies.Data
{
    public class MVCMoviesContext : DbContext
    {
        public MVCMoviesContext (DbContextOptions<MVCMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMovies.Models.Movie> Movie { get; set; } = default!;
    }
}

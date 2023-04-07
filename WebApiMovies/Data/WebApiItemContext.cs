using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiMovies.Models;

namespace WebApiMovies.Data
{
    public class WebApiItemContext : DbContext
    {
        public WebApiItemContext (DbContextOptions<WebApiItemContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiMovies.Models.Item> Item { get; set; } = default!;
    }
}

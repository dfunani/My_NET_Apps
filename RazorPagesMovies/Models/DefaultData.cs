using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Data;

namespace RazorPagesMovies.Models
{
    public class DefaultData
    {
        public static void Init(IServiceProvider serviceProvider)
        {
                using(RazorPagesMoviesContext context = new RazorPagesMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMoviesContext>>())) 
                { 
                    if (context == null || context.Movie == null) 
                    {
                        throw new ArgumentNullException("Null RazorPagesMovieContext");
                    }

                    if (context.Movie.Any())
                    {
                        return;
                    }

                    context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                    );
                    context.SaveChanges();
                }
        }
    }
}

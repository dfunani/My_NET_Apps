using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RazorPagesMovies.Data;
using RazorPagesMovies.Models;

namespace RazorPagesMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovies.Data.RazorPagesMoviesContext _context;
        public IndexModel(RazorPagesMovies.Data.RazorPagesMoviesContext context)
        {
            _context = context;
        }

        public RazorPagesMovies.Data.RazorPagesMoviesContext? test;
        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SelectGenres { get; set; }

        public SelectList? Genres { get; set; }

        public IQueryable<string> genres { get; set; } = default!;


        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                genres = from movie in _context.Movie orderby movie.Genre select movie.Genre;
                Genres = new SelectList(await genres.Distinct().ToListAsync());

                IQueryable<Movie> movies = from movie in _context.Movie select movie;
                if(!string.IsNullOrEmpty(SearchString))
                {
                    movies = movies.Where(s => s.Title.Contains(SearchString));   
                }
                if (!string.IsNullOrEmpty(SelectGenres))
                {
                    movies = movies.Where(x => x.Genre == SelectGenres);
                }
                Movie = await movies.ToListAsync();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Movie
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Data.WebApplication1Context _context;
        private string searchString;
        private SelectList genres;
        private string movieGenre;

        public IndexModel(WebApplication1.Data.WebApplication1Context context)
        {
            _context = context;
        }

        public IList<WebApplication1.Models.Movie> Movie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get => searchString; set => searchString = value; }
        public SelectList Genres { get => genres; set => genres = value; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get => movieGenre; set => movieGenre = value; }


        public async Task OnGetNewAsync()
        {
            var movies = from m in _context.Movie
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            Movie = await movies.ToListAsync();
        }


        public async Task OnGetAsync()
        {
            IList<WebApplication1.Models.Movie> data = new List<WebApplication1.Models.Movie>()
            {
                new WebApplication1.Models.Movie(){ID = 1, Genre = "Male", Price = 1000, ReleaseDate = DateTime.Now, Title = "Hello"},
                new WebApplication1.Models.Movie(){ID = 1, Genre = "Male", Price = 1000, ReleaseDate = DateTime.Now, Title = "Hello"},
                new WebApplication1.Models.Movie(){ID = 1, Genre = "Male", Price = 1000, ReleaseDate = DateTime.Now, Title = "Hello"},
            };

            if (_context != null)
            {
                Movie = await _context.Movie.ToListAsync();
                //Movie = data;
            }

        }
    }
}

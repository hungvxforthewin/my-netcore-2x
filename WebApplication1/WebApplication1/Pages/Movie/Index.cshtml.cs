using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Movie
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Data.WebApplication1Context _context;

        public IndexModel(WebApplication1.Data.WebApplication1Context context)
        {
            _context = context;
        }

        public IList<WebApplication1.Models.Movie> Movie { get; set; }

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

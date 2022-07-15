﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Movie
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication1.Data.WebApplication1Context _context;

        public CreateModel(WebApplication1.Data.WebApplication1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["xxx"] = "From controller";
            return Page();
        }

        [BindProperty]
        public WebApplication1.Models.Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
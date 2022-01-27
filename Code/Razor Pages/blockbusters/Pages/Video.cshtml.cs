using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blockbusters.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace blockbusters.Pages
{
    [Authorize]
    public class VideoModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public VideoModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies.FirstOrDefaultAsync(m => m.MovieID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

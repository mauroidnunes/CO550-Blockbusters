using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using blockbusters.Data;
using blockbusters.Models;

namespace blockbusters.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public IndexModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }
    }
}

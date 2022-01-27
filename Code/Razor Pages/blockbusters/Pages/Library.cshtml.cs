using blockbusters.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blockbusters.Pages
{
    [Authorize]
    public class LibraryModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public LibraryModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }

    }
}

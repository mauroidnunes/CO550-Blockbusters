using blockbusters.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blockbusters.Pages
{
    public class ExploreModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public ExploreModel(blockbusters.Data.ApplicationDbContext context)
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

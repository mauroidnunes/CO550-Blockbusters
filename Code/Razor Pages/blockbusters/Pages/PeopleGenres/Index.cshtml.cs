using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using blockbusters.Data;
using blockbusters.Models;

namespace blockbusters.Pages.PeopleGenres
{
    public class IndexModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public IndexModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PersonGenre> PersonGenre { get;set; }

        public async Task OnGetAsync()
        {
            PersonGenre = await _context.PeopleGenres
                .Include(p => p.Person).ToListAsync();
        }
    }
}

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
    public class DetailsModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public DetailsModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public PersonGenre PersonGenre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PersonGenre = await _context.PeopleGenres
                .Include(p => p.Person).FirstOrDefaultAsync(m => m.PersonGenreID == id);

            if (PersonGenre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

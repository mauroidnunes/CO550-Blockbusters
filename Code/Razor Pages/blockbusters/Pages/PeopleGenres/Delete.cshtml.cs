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
    public class DeleteModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public DeleteModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PersonGenre = await _context.PeopleGenres.FindAsync(id);

            if (PersonGenre != null)
            {
                _context.PeopleGenres.Remove(PersonGenre);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using blockbusters.Data;
using blockbusters.Models;

namespace blockbusters.Pages.PeopleGenres
{
    public class EditModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public EditModel(blockbusters.Data.ApplicationDbContext context)
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
           ViewData["PersonID"] = new SelectList(_context.People, "PersonID", "Email");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PersonGenre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonGenreExists(PersonGenre.PersonGenreID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PersonGenreExists(int id)
        {
            return _context.PeopleGenres.Any(e => e.PersonGenreID == id);
        }
    }
}

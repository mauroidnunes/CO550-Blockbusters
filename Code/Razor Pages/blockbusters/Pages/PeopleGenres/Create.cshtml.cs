using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using blockbusters.Data;
using blockbusters.Models;

namespace blockbusters.Pages.PeopleGenres
{
    public class CreateModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public CreateModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PersonID"] = new SelectList(_context.People, "PersonID", "Email");
            return Page();
        }

        [BindProperty]
        public PersonGenre PersonGenre { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PeopleGenres.Add(PersonGenre);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

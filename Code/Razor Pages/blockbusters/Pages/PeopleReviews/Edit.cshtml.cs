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

namespace blockbusters.Pages.PeopleReviews
{
    public class EditModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public EditModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PersonReview PersonReview { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PersonReview = await _context.PeopleReviews
                .Include(p => p.Movie)
                .Include(p => p.Person).FirstOrDefaultAsync(m => m.PersonReviewID == id);

            if (PersonReview == null)
            {
                return NotFound();
            }
           ViewData["MovieID"] = new SelectList(_context.Movies, "MovieID", "Description");
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

            _context.Attach(PersonReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonReviewExists(PersonReview.PersonReviewID))
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

        private bool PersonReviewExists(int id)
        {
            return _context.PeopleReviews.Any(e => e.PersonReviewID == id);
        }
    }
}

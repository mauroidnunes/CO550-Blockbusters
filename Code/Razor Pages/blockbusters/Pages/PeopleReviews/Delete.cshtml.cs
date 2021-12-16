using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using blockbusters.Data;
using blockbusters.Models;

namespace blockbusters.Pages.PeopleReviews
{
    public class DeleteModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public DeleteModel(blockbusters.Data.ApplicationDbContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PersonReview = await _context.PeopleReviews.FindAsync(id);

            if (PersonReview != null)
            {
                _context.PeopleReviews.Remove(PersonReview);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

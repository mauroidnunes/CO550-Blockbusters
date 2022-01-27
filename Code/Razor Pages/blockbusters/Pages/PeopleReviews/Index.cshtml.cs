using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using blockbusters.Data;
using blockbusters.Models;
using Microsoft.AspNetCore.Authorization;

namespace blockbusters.Pages.PeopleReviews
{
    [Authorize(Roles = "staff")]
    public class IndexModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public IndexModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<PersonReview> PersonReview { get;set; }

        public async Task OnGetAsync(string searchString)
        {

            IQueryable<PersonReview> studentsIQ = from s in _context.PeopleReviews select s;
            CurrentFilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                studentsIQ = studentsIQ.Where(s => s.ReviewText.Contains(searchString));
            }

            PersonReview = await studentsIQ.AsNoTracking()
                .Include(p => p.Movie)
                .Include(p => p.Person).ToListAsync();
        }
    }
}

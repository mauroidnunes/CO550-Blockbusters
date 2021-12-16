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
    public class IndexModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public IndexModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PersonReview> PersonReview { get;set; }

        public async Task OnGetAsync()
        {
            PersonReview = await _context.PeopleReviews
                .Include(p => p.Movie)
                .Include(p => p.Person).ToListAsync();
        }
    }
}

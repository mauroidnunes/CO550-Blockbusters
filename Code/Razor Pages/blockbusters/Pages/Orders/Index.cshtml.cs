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

namespace blockbusters.Pages.Orders
{
    [Authorize(Roles = "staff")]
    public class IndexModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public IndexModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            DateSort = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";
            CurrentFilter = searchString;

            IQueryable<Order> studentsIQ = from s in _context.Orders select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                studentsIQ = studentsIQ.Where(s => s.Person.Email.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "date_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.OrderDate);
                    break;
                default:
                    studentsIQ = studentsIQ.OrderBy(s => s.OrderDate);
                    break;
            }

            Order = await studentsIQ.AsNoTracking()
                .Include(o => o.Person).ToListAsync();
        }
    }
}

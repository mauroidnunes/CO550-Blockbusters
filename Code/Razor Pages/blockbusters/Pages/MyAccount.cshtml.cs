using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using blockbusters.Data;
using blockbusters.Models;

namespace blockbusters.Pages
{
    public class MyAccountModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public MyAccountModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            string user = User.Identity.Name;

            Person = await _context.People
                .Include(p => p.Payment).FirstOrDefaultAsync(m => m.Email==user);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
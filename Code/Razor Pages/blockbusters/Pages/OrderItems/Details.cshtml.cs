using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using blockbusters.Data;
using blockbusters.Models;

namespace blockbusters.Pages.OrderItems
{
    public class DetailsModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public DetailsModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public OrderItem OrderItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderItem = await _context.OrderItems
                .Include(o => o.Movie)
                .Include(o => o.Order).FirstOrDefaultAsync(m => m.OrderItemID == id);

            if (OrderItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

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
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace blockbusters.Pages
{
    [Authorize]
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
            string name = User.Identity.Name;

            Person = await _context.People
                .Include(p => p.Payment).FirstOrDefaultAsync(m => m.Email == name);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;
//using blockbusters.Data;
//using blockbusters.Models;

//namespace blockbusters.Pages
//{
//    public class MyAccountModel : PageModel
//    {
//        private readonly blockbusters.Data.ApplicationDbContext _context;

//        public MyAccountModel(blockbusters.Data.ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        public Person Person { get; set; }

//        public async Task<IActionResult> OnGetAsync(int? id)
//        {
//            string user = User.Identity.Name;
//            if (id == null)
//            {
//                return NotFound();
//            }

//            Person = await _context.People
//                .Include(p => p.Payment).FirstOrDefaultAsync(m => m.PersonID == id);

//            if (Person == null)
//            {
//                return NotFound();
//            }
//            return Page();
//        }
//    }
//}

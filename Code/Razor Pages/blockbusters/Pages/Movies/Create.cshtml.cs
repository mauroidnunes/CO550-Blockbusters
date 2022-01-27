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
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace blockbusters.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        private readonly IHostEnvironment _environment;

        [BindProperty]
        public IFormFile UploadedFile { get; set; }

        public CreateModel(blockbusters.Data.ApplicationDbContext context, ILogger<IndexModel> logger, IHostEnvironment environment)
        {
            _context = context;
            _logger = logger;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


                if (UploadedFile != null && UploadedFile.Length != 0)
                {
                    Movie.ContentLocation = UploadedFile.FileName;
                    _logger.LogInformation($"Uploading {UploadedFile.FileName}.");
                    string targetFileName = $"{_environment.ContentRootPath}/wwwroot/images/{UploadedFile.FileName}";
                    using (var stream = new FileStream(targetFileName, FileMode.Create))
                    {
                        await UploadedFile.CopyToAsync(stream);
                    }
                }




            _context.Movies.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

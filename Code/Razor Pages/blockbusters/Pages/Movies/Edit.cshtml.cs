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
    public class EditModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        private readonly IHostEnvironment _environment;
        [BindProperty]
        public IFormFile UploadedFile { get; set; }

        public EditModel(blockbusters.Data.ApplicationDbContext context, ILogger<IndexModel> logger, IHostEnvironment environment)
        {
            _context = context;
            _logger = logger;
            _environment = environment;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies.FirstOrDefaultAsync(m => m.MovieID == id);

            if (Movie == null)
            {
                return NotFound();
            }
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

            _context.Attach(Movie).State = EntityState.Modified;

            //if (UploadedFile == null || UploadedFile.Length == 0)
            //{
            //    return Page();
            //}

            Movie.ContentLocation = Movie.ContentLocation;

            try
            {
                if(UploadedFile != null && UploadedFile.Length != 0)
                {
                    Movie.ContentLocation = UploadedFile.FileName;
                    _logger.LogInformation($"Uploading {UploadedFile.FileName}.");
                    string targetFileName = $"{_environment.ContentRootPath}/wwwroot/images/{UploadedFile.FileName}";
                    using (var stream = new FileStream(targetFileName, FileMode.Create))
                    {
                        await UploadedFile.CopyToAsync(stream);
                    }
                }

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(Movie.MovieID))
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

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.MovieID == id);
        }

    }
}

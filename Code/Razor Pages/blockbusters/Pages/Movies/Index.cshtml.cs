using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using blockbusters.Data;
using blockbusters.Models;

namespace blockbusters.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly blockbusters.Data.ApplicationDbContext _context;

        public IndexModel(blockbusters.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string PriceSort { get; set; }
        public string RatingSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString, Genre? genreType)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            DateSort = sortOrder == "date" ? "date_desc" : "date";
            PriceSort = sortOrder == "price" ? "price_desc" : "price";
            RatingSort = sortOrder == "rating" ? "rating_desc" : "rating";

            CurrentFilter = searchString;

            IQueryable<Movie> studentsIQ = from s in _context.Movies select s;

            if (genreType != null)
            {
                studentsIQ = studentsIQ.Where(s => s.Genre == genreType);
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                studentsIQ = studentsIQ.Where(s => s.Title.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "title_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.Title);
                    break;
                case "price":
                    studentsIQ = studentsIQ.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.Price);
                    break;
                case "date":
                    studentsIQ = studentsIQ.OrderBy(s => s.ReleaseDate);
                    break;
                case "date_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.ReleaseDate);
                    break;
                case "rating":
                    studentsIQ = studentsIQ.OrderBy(s => s.Rating);
                    break;
                case "rating_desc":
                    studentsIQ = studentsIQ.OrderByDescending(s => s.Rating);
                    break;
                default:
                    studentsIQ = studentsIQ.OrderBy(s => s.Title);
                    break;
            }
            Movie = await studentsIQ.AsNoTracking().ToListAsync();
        }
    }
}

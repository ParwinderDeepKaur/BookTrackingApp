using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTest.Data;
using BookTest.Models;

namespace BookTest.Pages.Admin.Books
{
    public class DetailsModel : PageModel
    {
        private readonly BookTest.Data.BookTestDBContext _context;

        public DetailsModel(BookTest.Data.BookTestDBContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
                .Include(b => b.Categories).FirstOrDefaultAsync(m => m.ISBNNumber == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

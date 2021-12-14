using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookTest.Data;
using BookTest.Models;

namespace BookTest.Pages.Admin.Books
{
    public class CreateModel : PageModel
    {
        private readonly BookTest.Data.BookTestDBContext _context;

        public CreateModel(BookTest.Data.BookTestDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryId"] = new SelectList(_context.Categories, "NameToken", "NameToken");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (BookExists(Book.ISBNNumber))
            {
                ModelState.AddModelError(string.Empty, "ISBN Number Already Exists.");
                ViewData["CategoryId"] = new SelectList(_context.Categories, "NameToken", "NameToken");
                return Page();
            }
            else {

                _context.Book.Add(Book);
                await _context.SaveChangesAsync();
            }

          

            return RedirectToPage("./Index");
        }

        private bool BookExists(string id)
        {
            return _context.Book.Any(e => e.ISBNNumber == id);
        }
    }
}

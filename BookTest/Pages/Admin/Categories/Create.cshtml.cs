using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookTest.Data;
using BookTest.Models;

namespace BookTest.Pages.Admin.Categories
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
        ViewData["TypeId"] = new SelectList(_context.CategType, "Type", "Type");
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (CategoryExists(Category.NameToken))
            {
                ModelState.AddModelError(string.Empty, "Name Token Already Exists.");
                ViewData["TypeId"] = new SelectList(_context.CategType, "Type", "Type");
                return Page();
            }
            else
            {

                _context.Categories.Add(Category);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }

        private bool CategoryExists(string id)
        {
            return _context.Categories.Any(e => e.NameToken == id);
        }
    }
}

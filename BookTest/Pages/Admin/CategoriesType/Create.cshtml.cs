using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookTest.Data;
using BookTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTest.Pages.Admin.CategoriesType
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
            return Page();
        }

        [BindProperty]
        public CategoryType CategoryType { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (CategoryTypeExists(CategoryType.Type))
            {
                ModelState.AddModelError(string.Empty, "Type Already Exists.");
                return Page();
            }
            else {
                _context.CategType.Add(CategoryType);
                await _context.SaveChangesAsync();
            }
          
 
            return RedirectToPage("./Index");
        }


        private bool CategoryTypeExists(string id)
        {
            return _context.CategType.Any(e => e.Type == id);
        }
    }
}

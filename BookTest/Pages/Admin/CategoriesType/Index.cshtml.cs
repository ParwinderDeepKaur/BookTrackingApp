using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTest.Data;
using BookTest.Models;

namespace BookTest.Pages.Admin.CategoriesType
{
    public class IndexModel : PageModel
    {
        private readonly BookTestDBContext _context;

        public IndexModel(BookTestDBContext context)
        {
            _context = context;
        }

        public IList<CategoryType> CategoryType { get;set; }

        public async Task OnGetAsync()
        {
            CategoryType = await _context.CategType.ToListAsync();
        }
    }
}

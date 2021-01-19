using System.Threading.Tasks;

using BookStore.Data;
using BookStore.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Pages.BookCategories
{
    public class CreateModel : PageModel
    {
        private readonly BookStoreContext _context;

        public CreateModel(BookStoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookCategory BookCategory { get; set; }

        public IActionResult OnGet()
        {
            ViewData["BookID"] = new SelectList(_context.Book, "Id", "Title");
            ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "Id", "CategoryName");
            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.BookCategory.Add(BookCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
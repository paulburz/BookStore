﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BookStore.Data.BookStoreContext _context;

        public CreateModel(BookStore.Data.BookStoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PublisherID"] = new SelectList(_context.Publisher, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

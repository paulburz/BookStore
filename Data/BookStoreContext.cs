﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;

namespace BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext (DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<BookStore.Models.Book> Book { get; set; }

        public DbSet<BookStore.Models.Publisher> Publisher { get; set; }

        public DbSet<BookStore.Models.BookCategory> BookCategory { get; set; }

        public DbSet<BookStore.Models.Category> Category { get; set; }
    }
}

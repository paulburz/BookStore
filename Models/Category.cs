﻿using System.Collections.Generic;

namespace BookStore.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
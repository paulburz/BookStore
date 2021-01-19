using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
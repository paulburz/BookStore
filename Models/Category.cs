using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        [Required, StringLength(150, MinimumLength = 3)]
        public string CategoryName { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
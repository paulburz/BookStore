using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Book Title")]
        [Required, StringLength(150, MinimumLength = 3)]
        public string Title { get; set; }

        [Required, StringLength(100, MinimumLength = 3)]
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(1, 300)]
        public decimal Price { get; set; }

        [Display(Name = "Publishing Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }

        [Required]
        public Publisher Publisher { get; set; } //navigation property

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
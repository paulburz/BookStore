using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [Display(Name = "Publisher Name")]
        [Required, StringLength(150, MinimumLength = 3)]
        public string PublisherName { get; set; }

        public ICollection<Book> Books { get; set; } //navigation property
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstRelationshipsApplication.Models
{
    public class Book
    {
        // Scalar Properties
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(100, 2000)]
        public float Price { get; set; }
        public int AuthorId { get; set; }
        // Navigation Properties
        public Author Author { get; set; }
    }
}

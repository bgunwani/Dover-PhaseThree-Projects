using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstRelationshipsApplication.Models
{
    public class Author
    {
        // Scalar Properties
        public int AuthorId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        // Navigation Properties
        public AuthorBiography AuthorBiography { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

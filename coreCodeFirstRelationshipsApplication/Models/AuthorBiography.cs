using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstRelationshipsApplication.Models
{
    public class AuthorBiography
    {
        // Scalary Properties
        public int AuthorBiographyId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string PlaceOfBirth { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string Country { get; set; }
        public int AuthorId { get; set; }
        // Navigation Properties
        public Author Author { get; set; }
    }
}

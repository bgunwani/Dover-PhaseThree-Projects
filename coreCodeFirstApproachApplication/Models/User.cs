using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstApproachApplication.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "City is mandatory field.")]
        public string City { get; set; }
        [Required]
        [Range(100, 20000)]
        public double Amount { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        [StringLength(50, ErrorMessage = "Message cannot be longer than 50 character.")]
        public string Message { get; set; }

    }
}

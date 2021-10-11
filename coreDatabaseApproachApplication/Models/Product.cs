using System;
using System.Collections.Generic;

#nullable disable

namespace coreDatabaseApproachApplication.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public double? ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public DateTime? ProductAddedDate { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public int? ProductQuantity { get; set; }
        public string ProductColor { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}

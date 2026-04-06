using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        public required string Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}

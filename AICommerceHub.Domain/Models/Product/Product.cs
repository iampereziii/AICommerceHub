using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Domain.Models
{
    public class Product : IProduct
    {

        public Product()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;

        }
        public Product(string name, string description, short stock, decimal price, string category, string imageUrl, DateTime createdDate, DateTime modifiedDate)
        {
            Name = name;
            Description = description;
            Stock = stock;
            Price = price;
            Category = category;
            ImageUrl = imageUrl;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, 100)]
        public short Stock { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Domain.Models
{

    // Ideally, product model should be very generic and could support almost all kind of products
    public interface IProduct
    {
        public int Id { get; set; }  // Unique identifier for the product
        public string Name { get; set; }    // Name of the product
        public string Description { get; set; } // Description of the product
        public decimal Price { get; set; }  // Price of the product
        public short Stock { get; set; }      // Number of items in stock
        public string Category { get; set; } // Category to which the product belongs
        public string ImageUrl { get; set; } // URL of the product's image
        public DateTime CreatedDate { get; set; } // Date when the product was created
        public DateTime ModifiedDate { get; set; } // Date when the product was last modified

    }
}

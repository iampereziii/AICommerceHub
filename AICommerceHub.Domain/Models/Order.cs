using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Domain.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Client { get; set; }

        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }

        public int Product_Id { get; set; }

        [Required]
        [ForeignKey(nameof(Product_Id))]
        public Product Product { get; set; }
    }
}

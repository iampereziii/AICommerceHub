using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Domain.Models.NewFolder
{
    public class Product : IProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public string? Description { get; set; }


        [Required]
        [Range(0, 100)]
        public short Stock { get; set; }

    }
}

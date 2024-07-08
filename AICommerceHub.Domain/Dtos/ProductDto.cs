
using System.ComponentModel.DataAnnotations;
using System;
using AICommerceHub.Domain.Models;


namespace AICommerceHub.Domain.DTOs
{
    public class ProductDTO
    {
     

        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, 100)]
        public short Stock { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }
    }
}
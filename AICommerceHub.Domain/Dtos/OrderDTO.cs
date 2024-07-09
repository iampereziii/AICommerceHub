using System;
using System.ComponentModel.DataAnnotations;

namespace AICommerceHub.Domain.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public string? CustomerEmail { get; set; }

        [Required]
        public DateTime? OrderDate { get; set; }

        public DateTime? PotentialShipDate { get; set; }

        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }

        public int Product_Id { get; set; }

        public double TotalAmount { get; set; }
    }
}
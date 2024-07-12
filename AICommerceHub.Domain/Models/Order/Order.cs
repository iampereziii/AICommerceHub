using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Domain.Models
{
    public class Order : IOrder
    {
        public Order(string customerName, string customerEmail, DateTime? orderDate, DateTime? potentialShipDate, int quantity, int product_Id, double totalAmount)
        {
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            OrderDate = orderDate;
            PotentialShipDate = potentialShipDate;
            Quantity = quantity;
            Product_Id = product_Id;
            TotalAmount = totalAmount;
        }

        public Order()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public string? CustomerEmail { get; set; }

        [Required]
        public DateTime? OrderDate { get; set; }


        public DateTime? PotentialShipDate { get; set; }

        public enum OrderStatus { Pack = 0, Ship = 1, Deliveered = 2 }

        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }

        public int Product_Id { get; set; }

        [Required]
        [ForeignKey(nameof(Product_Id))]
        public Product Product { get; set; }


        public double TotalAmount { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Order order &&
                   CustomerEmail == order.CustomerEmail;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CustomerEmail);
        }
    }
}

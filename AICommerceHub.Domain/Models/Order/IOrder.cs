
namespace AICommerceHub.Domain.Models
{
    public interface IOrder
    {
        string? CustomerEmail { get; set; }
        string CustomerName { get; set; }
        int Id { get; set; }
        DateTime? OrderDate { get; set; }
        DateTime? PotentialShipDate { get; set; }
        Product Product { get; set; }
        int Product_Id { get; set; }
        int Quantity { get; set; }
        double TotalAmount { get; set; }

        bool Equals(object? obj);
        int GetHashCode();
    }
}
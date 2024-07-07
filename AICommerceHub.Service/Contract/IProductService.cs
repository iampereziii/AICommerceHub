using AICommerceHub.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Service.Contract
{
    public interface IProductService
    {

        List<String> GetProducts();

        String GetProductName();

        bool AddProduct(Product product);

        bool DeleteProduct(int productId);

        bool UpdateProduct(Product product);

    }
}

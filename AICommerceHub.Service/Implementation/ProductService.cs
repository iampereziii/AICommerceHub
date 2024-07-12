using AICommerceHub.Data.Context;
using AICommerceHub.Domain.Models;
using AICommerceHub.Service.Contract;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICommerceHub.Service.Implementation
{
    public class ProductService : IProductService
    {

        private AICommerceHubContext _context;

        private Product _product;

        public ProductService(AICommerceHubContext context)
        {
            this._context = context;
        }

        //TEMP

        public bool AddProduct(Product product)
        {
            try
            {
                _context.Add<Product>(product);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }

        public bool DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public string GetProductName()
        {
            throw new NotImplementedException();
        }

        public List<string> GetProducts()
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

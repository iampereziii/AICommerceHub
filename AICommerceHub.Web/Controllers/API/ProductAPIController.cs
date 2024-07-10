using AICommerceHub.Domain.DTOs;
using AICommerceHub.Domain.Models;
using AICommerceHub.Service;
using AICommerceHub.Service.Contract;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AICommerceHub.Web.Controllers.API
{
    [Route("api/product")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {

        IMapper mapper;
        IProductService productService;

        public ProductAPIController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }


        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] ProductDTO value)
        {
            try
            {
                Product product = mapper.Map<ProductDTO, Product>(value);
                this.productService.AddProduct(product);

            }
            catch (Exception)
            {
                throw;
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

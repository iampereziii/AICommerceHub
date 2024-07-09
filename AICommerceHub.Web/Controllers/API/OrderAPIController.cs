using AICommerceHub.Data.Context;
using AICommerceHub.Domain.Models;
using AICommerceHub.Service.Contract;
using AICommerceHub.Service.Implementation;

//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AICommerceHub.Web.Controllers.API
{
    [Route("api/order")]
    [ApiController]
    public class OrderAPIController : ControllerBase
    {

        AICommerceHubContext context;

        public OrderAPIController(AICommerceHubContext context) {
            this.context = context;
        
        }




        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post(int productId)
        {
            Order order = new Order("","",DateTime.Now,null,1,productId,35);

            context.Add<Order>(order);
            context.SaveChanges();

        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

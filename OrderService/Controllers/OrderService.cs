using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderServiceController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetOrders(int id)
        {
            // Placeholder for fetching the order by ID
            var order = new { Id = id, Product = "Sample Product", Quantity = 1 };

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }
    }
}
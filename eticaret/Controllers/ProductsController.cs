using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eticaret.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetProducts(int id)
        {
            return Ok();
        }
    }
}

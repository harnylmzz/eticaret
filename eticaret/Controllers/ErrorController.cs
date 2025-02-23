using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eticaret.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {

        [HttpGet("not-found")]
        public IActionResult NotFoundError()
        {
            return NotFound();
        }

        [HttpGet("bad-request")]
        public IActionResult BadRequestError()
        {
            return BadRequest();
        }

        [HttpGet("unautharized")]
        public IActionResult UnAuthorizedError()
        {
            return Unauthorized();
        }

        [HttpGet("validation-found")]
        public IActionResult ValidationError()
        {
            ModelState.AddModelError("Name", "This field is required");
            return ValidationProblem();
        }

        [HttpGet("server-error")]
        public IActionResult ServerError()
        {
            throw new Exception("This is a server error");
        }
    }
}

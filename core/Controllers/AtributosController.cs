using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtributosController : Controller
    {
        public AtributosController()
        {
            
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
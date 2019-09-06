using core.Data;
using Microsoft.AspNetCore.Mvc;

namespace core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtributosController : Controller
    {
        public readonly DataContext _context;
        public AtributosController(DataContext context) 
        {
            _context = context ;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
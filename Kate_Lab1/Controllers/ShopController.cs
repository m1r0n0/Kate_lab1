using Microsoft.AspNetCore.Mvc;
using SP.Identity.DataAccessLayer.Data;

namespace Kate_Lab1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly ShopContext _context;

        public ShopController(ShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public void Foo()
        {
            var r = _context.Staff.Any();
        }
    }
}
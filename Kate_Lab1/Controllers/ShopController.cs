using Kate_Lab1.Data.Models;
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

        [HttpPost]
        public void Foo(List<Staff> list)
        {
            _context.Staff.AddRange(list);
            _context.SaveChanges();
        }
    }
}
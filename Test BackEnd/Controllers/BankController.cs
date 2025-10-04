using Microsoft.AspNetCore.Mvc;
using Test_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace Test_BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankController : ControllerBase
    {
        private readonly BankDbContext _context;

        public BankController(BankDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = new
            {
                data = await _context.Banks.ToListAsync(),
                status = await _context.Statuses.ToListAsync()
            };

            return Ok(response);
        }
    }
}

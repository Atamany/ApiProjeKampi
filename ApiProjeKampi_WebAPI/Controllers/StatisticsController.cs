using ApiProjeKampi_WebAPI.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly ApiContext _context;

        public StatisticsController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            var value = _context.Products.Count();
            return Ok(value);
        }
        [HttpGet("ReservationCount")]
        public IActionResult ReservationCount()
        {
            var value = _context.Reservations.Count();
            return Ok(value);
        }
        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            var value = _context.Categories.Count();
            return Ok(value);
        }
        [HttpGet("YummyEventCount")]
        public IActionResult YummyEventCount()
        {
            var value = _context.YummyEvents.Count();
            return Ok(value);
        }
    }
}

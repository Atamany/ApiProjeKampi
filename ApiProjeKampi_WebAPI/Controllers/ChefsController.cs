using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ChefsController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ChefList()
        {
            var values = _context.Chefs.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateChef(Chef chef)
        {
            _context.Chefs.Add(chef);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateChef(Chef chef)
        {
            _context.Chefs.Update(chef);
            _context.SaveChanges();
            return Ok("Şef güncelleme işlemi başarılı!");
        }
        [HttpDelete]
        public IActionResult DeleteChef(int id)
        {
            var value = _context.Chefs.Find(id);
            _context.Chefs.Remove(value);
            _context.SaveChanges();
            return Ok("Şef silme işlemi başarılı!");
        }
        [HttpGet("GetChef")]
        public IActionResult GetChef(int id)
        {
            return Ok(_context.Chefs.Find(id));
        }
    }
}

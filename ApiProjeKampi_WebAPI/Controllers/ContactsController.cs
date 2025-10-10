using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.DTOs.ContactDTOs;
using ApiProjeKampi_WebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _context;
        public ContactsController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _context.Contacts.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDTO createContactDTO)
        {
            Contact contact = new Contact();
            contact.Email = createContactDTO.Email;
            contact.Address = createContactDTO.Address;
            contact.MapLocation = createContactDTO.MapLocation;
            contact.OpenHours = createContactDTO.OpenHours;
            contact.Phone = createContactDTO.Phone;
            _context.Add(contact);
            _context.SaveChanges();
            return Ok("Ekleme işlemi başarılı!");
        }
    }
}

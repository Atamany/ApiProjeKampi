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
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarılı!");
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _context.Contacts.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDTO updateContactDTO)
        {
            var contact = _context.Contacts.Find(updateContactDTO.ContactId);
            contact.Email = updateContactDTO.Email;
            contact.Address = updateContactDTO.Address;
            contact.MapLocation = updateContactDTO.MapLocation;
            contact.OpenHours = updateContactDTO.OpenHours;
            contact.Phone = updateContactDTO.Phone;
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı!");
        }
    }
}

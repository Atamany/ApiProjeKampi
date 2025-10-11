using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.DTOs.EventDTOs;
using ApiProjeKampi_WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YummyEventsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;
        public YummyEventsController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public IActionResult EventList()
        {
            var values = _context.YummyEvents.OrderByDescending(x => x.YummyEventId).ToList();
            return Ok(_mapper.Map<List<ResultEventDTO>>(values));
        }
        [HttpPost]
        public IActionResult CreateEvent(CreateEventDTO createEventDTO)
        {
            var value = _mapper.Map<YummyEvent>(createEventDTO);
            _context.YummyEvents.Add(value);
            _context.SaveChanges();
            return Ok("Ekleme işlemi başarılı!");
        }
        [HttpDelete]
        public IActionResult DeleteEvent(int id)
        {
            var value = _context.YummyEvents.Find(id);
            _context.YummyEvents.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarılı!");
        }
        [HttpPut]
        public IActionResult UpdateEvent(UpdateEventDTO updateEventDTO)
        {
            var value = _mapper.Map<YummyEvent>(updateEventDTO);
            _context.YummyEvents.Update(value);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı!");
        }
        [HttpGet("GetEvent")]
        public IActionResult GetEvent(int id)
        {
            var value = _context.YummyEvents.Find(id);
            return Ok(_mapper.Map<GetByIdEventDTO>(value));
        }

    }
}

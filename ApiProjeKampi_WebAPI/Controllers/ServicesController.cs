using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.DTOs.ServiceDTOs;
using ApiProjeKampi_WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public ServicesController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _context.Services.ToList();
            return Ok(_mapper.Map<List<ResultServiceDTO>>(values));
        }
        [HttpPost]
        public IActionResult CreateService(CreateServiceDTO createServiceDTO)
        {
            var service = _mapper.Map<Service>(createServiceDTO);
            _context.Services.Add(service);
            _context.SaveChanges();
            return Ok(service);
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return Ok("Kategori silme işlemi başarılı!");
        }
        [HttpGet("GetService")]
        public IActionResult GetService(int id)
        {
            var value = _context.Services.Find(id);
            return Ok(_mapper.Map<GetByIdServiceDTO>(value));
        }
        [HttpPut]
        public IActionResult UpdateService(UpdateServiceDTO updateServiceDTO)
        {
            var service = _mapper.Map<Service>(updateServiceDTO);
            _context.Services.Update(service);
            _context.SaveChanges();
            return Ok("Kategori güncelleme işlemi başarılı!");
        }
    }
}

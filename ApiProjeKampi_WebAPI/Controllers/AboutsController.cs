using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.DTOs.AboutDTOs;
using ApiProjeKampi_WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;
        public AboutsController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _context.Abouts.ToList();
            return Ok(_mapper.Map<List<ResultAboutDTO>>(values));
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDTO createAboutDTO)
        {
            var value = _mapper.Map<About>(createAboutDTO);
            _context.Abouts.Add(value);
            _context.SaveChanges();
            return Ok("Ekleme işlemi başarılı!");
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarılı!");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDTO updateAboutDTO)
        {
            var value = _mapper.Map<About>(updateAboutDTO);
            _context.Abouts.Update(value);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı!");
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            return Ok(_mapper.Map<GetByIdAboutDTO>(value));
        }

    }
}

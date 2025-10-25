using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.DTOs.ImageDTOs;
using ApiProjeKampi_WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public ImagesController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ImageList()
        {
            var values = _context.Images.ToList();
            return Ok(_mapper.Map<List<ResultImageDTO>>(values));
        }
        [HttpPost]
        public IActionResult CreateImage(CreateImageDTO createImageDTO)
        {
            var image = _mapper.Map<Image>(createImageDTO);
            _context.Images.Add(image);
            _context.SaveChanges();
            return Ok(image);
        }
        [HttpDelete]
        public IActionResult DeleteImage(int id)
        {
            var value = _context.Images.Find(id);
            _context.Images.Remove(value);
            _context.SaveChanges();
            return Ok("Görsel silme işlemi başarılı!");
        }
        [HttpGet("GetImage")]
        public IActionResult GetImage(int id)
        {
            var value = _context.Images.Find(id);
            return Ok(_mapper.Map<GetByIdImageDTO>(value));
        }
        [HttpPut]
        public IActionResult UpdateImage(UpdateImageDTO updateImageDTO)
        {
            var image = _mapper.Map<Image>(updateImageDTO);
            _context.Images.Update(image);
            _context.SaveChanges();
            return Ok("Görsel güncelleme işlemi başarılı!");
        }
    }
}

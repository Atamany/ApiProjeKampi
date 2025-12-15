using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.DTOs.GroupReservationDTOs;
using ApiProjeKampi_WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupReservationController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public GroupReservationController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GroupReservationList()
        {
            var values = _context.GroupReservations.ToList();
            return Ok(_mapper.Map<List<ResultGroupReservationDTO>>(values));
        }
        [HttpPost]
        public IActionResult CreateGroupReservation(CreateGroupReservationDTO createGroupReservationDTO)
        {
            var groupReservation = _mapper.Map<GroupReservation>(createGroupReservationDTO);
            _context.GroupReservations.Add(groupReservation);
            _context.SaveChanges();
            return Ok(groupReservation);
        }
        [HttpDelete]
        public IActionResult DeleteGroupReservation(int id)
        {
            var value = _context.GroupReservations.Find(id);
            _context.GroupReservations.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarılı!");
        }
        [HttpGet("GetGroupReservation")]
        public IActionResult GetGroupReservation(int id)
        {
            var value = _context.GroupReservations.Find(id);
            return Ok(_mapper.Map<GetByIdGroupReservationDTO>(value));
        }
        [HttpPut]
        public IActionResult UpdateGroupReservation(UpdateGroupReservationDTO updateGroupReservationDTO)
        {
            var groupReservation = _mapper.Map<GroupReservation>(updateGroupReservationDTO);
            _context.GroupReservations.Update(groupReservation);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı!");
        }
    }
}

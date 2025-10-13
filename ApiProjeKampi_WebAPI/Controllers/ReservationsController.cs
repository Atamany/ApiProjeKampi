using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.DTOs.ReservationDTOs;
using ApiProjeKampi_WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;
        public ReservationsController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public IActionResult ReservationList()
        {
            var values = _context.Reservations.ToList();
            return Ok(_mapper.Map<List<ResultReservationDTO>>(values));
        }
        [HttpPost]
        public IActionResult CreateReservation(CreateReservationDTO createReservationDTO)
        {
            var value = _mapper.Map<Reservation>(createReservationDTO);
            _context.Reservations.Add(value);
            _context.SaveChanges();
            return Ok("Ekleme işlemi başarılı!");
        }
        [HttpDelete]
        public IActionResult DeleteReservation(int id)
        {
            var value = _context.Reservations.Find(id);
            _context.Reservations.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarılı!");
        }
        [HttpPut]
        public IActionResult UpdateReservation(UpdateReservationDTO updateReservationDTO)
        {
            var value = _mapper.Map<Reservation>(updateReservationDTO);
            _context.Reservations.Update(value);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı!");
        }
        [HttpGet("GetReservation")]
        public IActionResult GetReservation(int id)
        {
            var value = _context.Reservations.Find(id);
            return Ok(_mapper.Map<GetByIdReservationDTO>(value));
        }
    }
}

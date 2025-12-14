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
        [HttpGet("GetTotalReservationCount")]
        public IActionResult GetTotalReservationCount()
        {
            var values = _context.Reservations.Count();
            return Ok(values);
        }
        [HttpGet("GetTotalCustomerCount")]
        public IActionResult GetTotalCustomerCount()
        {
            var values = _context.Reservations.Sum(x=>x.CountOfPeople);
            return Ok(values);
        }
        [HttpGet("GetPendingReservations")]
        public IActionResult GetPendingReservations()
        {
            var values = _context.Reservations.Where(x=>x.ReservationStatus=="Beklemede").Count();
            return Ok(values);
        }
        [HttpGet("GetApprovedReservations")]
        public IActionResult GetApprovedReservations()
        {
            var values = _context.Reservations.Where(x => x.ReservationStatus == "Onaylandı").Count();
            return Ok(values);
        }
        [HttpGet("GetReservationStats")]
        public IActionResult GetReservationStats()
        {
            DateTime today = DateTime.Today;
            DateTime fourMonthsAgo = today.AddMonths(-3);

            // 1. SQL tarafında sadece gruplama ve veri çekme
            var rawData = _context.Reservations
                .Where(r => r.ReservationDate >= fourMonthsAgo)
                .GroupBy(r => new { r.ReservationDate.Year, r.ReservationDate.Month })
                .Select(g => new
                {
                    g.Key.Year,
                    g.Key.Month,
                    Approved = g.Count(x => x.ReservationStatus == "Onaylandı"),
                    Pending = g.Count(x => x.ReservationStatus == "Beklemede"),
                    Canceled = g.Count(x => x.ReservationStatus == "İptal Edildi")
                })
                .OrderBy(x => x.Year).ThenBy(x => x.Month)
                .ToList(); // Burada SQL biter, veriler RAM’e alınır

            // 2. Bellekte DTO'ya mapleme + tarih formatlama
            var result = rawData.Select(x => new ReservationChartDTO
            {
                Month = new DateTime(x.Year, x.Month, 1).ToString("MMM yyyy"),
                Approved = x.Approved,
                Pending = x.Pending,
                Canceled = x.Canceled
            }).ToList();

            return Ok(result);
        }
    }
}

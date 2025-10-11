using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.DTOs.NotificationDTOs;
using ApiProjeKampi_WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public NotificationsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult NotificationList()
        {
            var values = _context.Notifications.OrderByDescending(x=>x.NotificationID).ToList();
            return Ok(_mapper.Map<List<ResultNotificationDTO>>(values));
        }
        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDTO createNotificationDTO)
        {
            var notification = _mapper.Map<Notification>(createNotificationDTO);
            _context.Notifications.Add(notification);
            _context.SaveChanges();
            return Ok(notification);
        }
        [HttpDelete]
        public IActionResult DeleteNotification(int id)
        {
            var value = _context.Notifications.Find(id);
            _context.Notifications.Remove(value);
            _context.SaveChanges();
            return Ok("Kategori silme işlemi başarılı!");
        }
        [HttpGet("GetNotification")]
        public IActionResult GetNotification(int id)
        {
            var value = _context.Notifications.Find(id);
            return Ok(_mapper.Map<GetByIdNotificationDTO>(value));
        }
        [HttpPut]
        public IActionResult UpdateNotification(UpdateNotificationDTO updateNotificationDTO)
        {
            var notification = _mapper.Map<Notification>(updateNotificationDTO);
            _context.Notifications.Update(notification);
            _context.SaveChanges();
            return Ok("Kategori güncelleme işlemi başarılı!");
        }
        [HttpGet("NotificationListByIsReadFalse")]
        public IActionResult NotificationListByIsReadFalse()
        {
            var values = _context.Notifications.Where(x => x.IsRead == false).OrderByDescending(x => x.NotificationID).ToList();
            return Ok(_mapper.Map<List<ResultNotificationDTO>>(values));
        }
    }
}

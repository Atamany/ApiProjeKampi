using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.DTOs.MessageDTOs;
using ApiProjeKampi_WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;

        public MessagesController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _context.Messages.OrderByDescending(x=>x.MessageId).ToList();
            return Ok(_mapper.Map<List<ResultMessageDTO>>(values));
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDTO createMessageDTO)
        {
            var value = _mapper.Map<Message>(createMessageDTO);
            _context.Messages.Add(value);
            _context.SaveChanges();
            return Ok("Ekleme işlemi başarılı!");
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarılı!");
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDTO updateMessageDTO)
        {
            var value = _mapper.Map<Message>(updateMessageDTO);
            _context.Messages.Update(value);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı!");
        }
        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var value = _context.Messages.Find(id);
            return Ok(_mapper.Map<GetByIdMessageDTO>(value));
        }
        [HttpGet("MessageListByIsReadFalse")]
        public IActionResult MessageListByIsReadFalse()
        {
            var values = _context.Messages.Where(x=>x.IsRead==false).OrderByDescending(x=>x.MessageId).ToList();
            return Ok(_mapper.Map<List<ResultMessageDTO>>(values));
        }
    }
}

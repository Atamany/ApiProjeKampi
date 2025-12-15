using ApiProjeKampi_WebAPI.Context;
using ApiProjeKampi_WebAPI.DTOs.EmployeeTaskDTOs;
using ApiProjeKampi_WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTasksController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;
        public EmployeeTasksController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public IActionResult EmployeeTaskList()
        {
            var values = _context.EmployeeTasks.OrderByDescending(x => x.EmployeeTaskId).ToList();
            return Ok(_mapper.Map<List<ResultEmployeeTaskDTO>>(values));
        }
        [HttpPost]
        public IActionResult CreateEmployeeTask(CreateEmployeeTaskDTO createEmployeeTaskDTO)
        {
            var value = _mapper.Map<EmployeeTask>(createEmployeeTaskDTO);
            _context.EmployeeTasks.Add(value);
            _context.SaveChanges();
            return Ok("Ekleme işlemi başarılı!");
        }
        [HttpDelete]
        public IActionResult DeleteEmployeeTask(int id)
        {
            var value = _context.EmployeeTasks.Find(id);
            _context.EmployeeTasks.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarılı!");
        }
        [HttpPut]
        public IActionResult UpdateEmployeeTask(UpdateEmployeeTaskDTO updateEmployeeTaskDTO)
        {
            var value = _mapper.Map<EmployeeTask>(updateEmployeeTaskDTO);
            _context.EmployeeTasks.Update(value);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı!");
        }
        [HttpGet("GetEmployeeTask")]
        public IActionResult GetEmployeeTask(int id)
        {
            var value = _context.EmployeeTasks.Find(id);
            return Ok(_mapper.Map<GetByIdEmployeeTaskDTO>(value));
        }

    }
}

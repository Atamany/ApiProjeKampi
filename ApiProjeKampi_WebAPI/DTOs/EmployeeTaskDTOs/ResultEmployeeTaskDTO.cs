using ApiProjeKampi_WebAPI.Entities;

namespace ApiProjeKampi_WebAPI.DTOs.EmployeeTaskDTOs
{
    public class ResultEmployeeTaskDTO
    {
        public int EmployeeTaskId { get; set; }
        public string TaskName { get; set; }
        public byte TaskStatusValue { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string TaskStatus { get; set; }
        public int ChefId { get; set; }
        public Chef Chef { get; set; }
    }
}

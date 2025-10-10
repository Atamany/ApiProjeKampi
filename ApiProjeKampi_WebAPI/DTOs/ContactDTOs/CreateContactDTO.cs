namespace ApiProjeKampi_WebAPI.DTOs.ContactDTOs
{
    public class CreateContactDTO
    {
        public string MapLocation { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OpenHours { get; set; }
    }
}

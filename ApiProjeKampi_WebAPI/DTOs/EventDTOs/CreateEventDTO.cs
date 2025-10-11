namespace ApiProjeKampi_WebAPI.DTOs.EventDTOs
{
    public class CreateEventDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
    }
}

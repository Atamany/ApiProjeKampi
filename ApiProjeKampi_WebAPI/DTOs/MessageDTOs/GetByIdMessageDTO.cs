namespace ApiProjeKampi_WebAPI.DTOs.MessageDTOs
{
    public class GetByIdMessageDTO
    {
        public int MessageId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}

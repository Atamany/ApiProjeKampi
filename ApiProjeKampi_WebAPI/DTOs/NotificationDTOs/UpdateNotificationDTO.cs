namespace ApiProjeKampi_WebAPI.DTOs.NotificationDTOs
{
    public class UpdateNotificationDTO
    {
        public int NotificationID { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsRead { get; set; }
    }
}

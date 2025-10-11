namespace ApiProjeKampi_WebAPI.Entities
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsRead { get; set; }
    }
}

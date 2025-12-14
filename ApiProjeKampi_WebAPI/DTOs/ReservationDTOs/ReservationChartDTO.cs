namespace ApiProjeKampi_WebAPI.DTOs.ReservationDTOs
{
    public class ReservationChartDTO
    {
        public string Month { get; set; }
        public int Approved { get; set; }
        public int Pending { get; set; }
        public int Canceled { get; set; }
    }
}

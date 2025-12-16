namespace ApiProjeKampi_WebUI.DTOs.AISuggestionDTOs
{
    public class MenuSuggestionDTO
    {
        public string Cuisine { get; set; }
        public string MenuTitle { get; set; }
        public string CountryCode { get; set; }
        public List<MenuItemDTO> Items { get; set; }
    }
}

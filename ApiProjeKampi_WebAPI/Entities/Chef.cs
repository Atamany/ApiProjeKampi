namespace ApiProjeKampi_WebAPI.Entities
{
    public class Chef
    {
        public int ChefId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<EmployeeTask> EmployeeTasks { get; set; }
    }
}

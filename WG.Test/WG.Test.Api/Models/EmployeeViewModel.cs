namespace WG.Test.Api.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        public int? ManagerId { get; set; }
        public ManagerViewModel Manager { get; set; }
    }
}

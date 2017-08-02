namespace WG.Test.BLL.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        public int ManagerId { get; set; }
        public ManagerModel Manager { get; set; }
    }
}

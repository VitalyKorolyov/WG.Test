namespace WG.Test.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
    }
}

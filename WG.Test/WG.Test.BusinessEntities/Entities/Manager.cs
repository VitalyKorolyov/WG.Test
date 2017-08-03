using System.Collections.Generic;

namespace WG.Test.BusinessEntities.Entities
{
    public class Manager
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}

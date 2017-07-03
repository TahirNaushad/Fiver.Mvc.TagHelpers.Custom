using System.Collections.Generic;

namespace Fiver.Mvc.TagHelpers.Custom.Models.Home
{
    public class EmployeesViewModel
    {
        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Profile { get; set; }
        public List<Friend> Friends { get; set; }
    }

    public class Friend
    {
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiver.Mvc.TagHelpers.Custom.Models.Home
{
    public class IndexViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
    }

    public class EmployeeViewModel
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Profile { get; set; }
        public List<FriendViewModel> Friends { get; set; }
    }

    public class FriendViewModel
    {
        public string Name { get; set; }
    }
}

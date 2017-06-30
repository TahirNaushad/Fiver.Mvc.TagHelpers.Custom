using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.TagHelpers.Custom.Models.Home;

namespace Fiver.Mvc.TagHelpers.Custom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                Employees = new List<EmployeeViewModel>
                {
                    new EmployeeViewModel {
                        Name = "Tahir Naushad",
                        JobTitle = "Software Developer",
                        Profile = "C#/ASP.NET Developer",
                        Friends = new List<FriendViewModel>
                        {
                            new FriendViewModel { Name = "Tom" },
                            new FriendViewModel { Name = "Dick" },
                            new FriendViewModel { Name = "Harry" },
                        }
                    },
                    new EmployeeViewModel {
                        Name = "James Bond",
                        JobTitle = "MI6 Agent",
                        Profile = "Has licence to kill",
                        Friends = new List<FriendViewModel>
                        {
                            new FriendViewModel { Name = "James Gordon" },
                            new FriendViewModel { Name = "Robin Hood" },
                        }
                    },
                }
            };
            return View(model);
        }
    }
}

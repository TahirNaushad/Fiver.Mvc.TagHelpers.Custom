using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.TagHelpers.Custom.Models.Home;

namespace Fiver.Mvc.TagHelpers.Custom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            var model = new EmployeesViewModel
            {
                Employees = new List<Employee>
                {
                    new Employee {
                        Name = "Tahir Naushad",
                        JobTitle = "Software Developer",
                        Profile = "C#/ASP.NET Developer",
                        Friends = new List<Friend>
                        {
                            new Friend { Name = "Tom" },
                            new Friend { Name = "Dick" },
                            new Friend { Name = "Harry" },
                        }
                    },
                    new Employee {
                        Name = "James Bond",
                        JobTitle = "MI6 Agent",
                        Profile = "Has licence to kill",
                        Friends = new List<Friend>
                        {
                            new Friend { Name = "James Gordon" },
                            new Friend { Name = "Robin Hood" },
                        }
                    },
                }
            };
            return View(model);
        }

        public IActionResult Movie()
        {
            var model = new MovieViewModel
            {
                Title = "Diamonds Are Forever",
                ReleaseYear = "1971",
                Director = "Guy Hamilton",
                Summary = "A diamond smuggling investigation leads James Bond to Las Vegas, where he uncovers an evil plot involving a rich business tycoon.",
                Stars = new List<string> { "Sean Connery", "Jill St. John", "Charles Gray" }
            };
            return View(model);
        }

        public IActionResult Context()
        {
            ViewBag.Greeting = "Hello Context Tag Helper";
            return View();
        }

        public IActionResult Greet()
        {
            return View();
        }
    }
}

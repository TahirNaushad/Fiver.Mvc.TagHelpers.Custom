using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiver.Mvc.TagHelpers.Custom.Models.Home
{
    public interface IGreetingService
    {
        string Greet(string name);
    }

    public class GreetingService : IGreetingService
    {
        public string Greet(string name)
        {
            return $"Hello {name}";
        }
    }
}

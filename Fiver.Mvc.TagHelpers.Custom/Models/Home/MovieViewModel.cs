using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiver.Mvc.TagHelpers.Custom.Models.Home
{
    public class MovieViewModel
    {
        public string Title { get; set; }
        public string ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Summary { get; set; }
        public List<string> Stars { get; set; }
    }
}

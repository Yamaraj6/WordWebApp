using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WordWebApp.Models
{
    public class WebsiteModel
    {
        public string Address { get; set; }
        public Dictionary<string, int> WordsStats { get; set; }
        public string ErrorMessage { get; set; }
    }
}
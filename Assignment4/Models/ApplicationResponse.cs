using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class ApplicationResponse
    {
        public string ClientName { get; set; }
        public string SuggestedRestaurant { get; set; }
        public string SuggestedDish { get; set; }
        public string SuggRestPhone { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    //Model for suggested restaurants
    public class ApplicationResponse
    {
        public string ClientName { get; set; }
        public string SuggestedRestaurant { get; set; }
        public string SuggestedDish { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "This is not a valid phone number")]
        public string SuggRestPhone { get; set; }
    }
}

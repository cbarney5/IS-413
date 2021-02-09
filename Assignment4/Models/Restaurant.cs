using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            RestaurantRank = rank;
        }
        [Required]
        public int RestaurantRank { get; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; }
        [Required]
        public string RestaurantAddress { get; set; }
        public string? RestaurantPhone { get; set; }
        public string? RestaurantWebsite { get; set; } = "Coming Soon";
       




        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Costa Vida",
                FavoriteDish = null,
                RestaurantAddress = "1200 N University Ave, Provo, UT 84606",
                RestaurantPhone = null,
                RestaurantWebsite = "costavida.com"
            };
            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "PF Changs",
                FavoriteDish = "Kung Pao Chicken",
                RestaurantAddress = "575 E University Pkwy Ste A-20, Orem, UT 84097",
                RestaurantPhone = "(801) 426-0900",
                RestaurantWebsite = "pfchangs.com"

            };
            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Chick Fil A",
                FavoriteDish = "Chicken Sandwich with Fries",
                RestaurantAddress = "484 Bulldog Ln, Provo, UT 84604",
                RestaurantPhone = "(801) 374-2697",
                RestaurantWebsite = "chick-fil-a.com"
            };
            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Texas Roadhouse",
                FavoriteDish = "Top Sirloin",
                RestaurantAddress = "1265 State St, Orem, UT 84097",
                RestaurantPhone = "(801) 226-2742",
                RestaurantWebsite = "texasroadhouse.com"
            };
            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Blaze Pizza",
                FavoriteDish = "DIY Pizza (i.e. white sauce, mozzarella cheese, chicken, bacon)",
                RestaurantAddress = "1350 S State St, Orem, UT 84097",
                RestaurantPhone = "(801) 528-9501",
                RestaurantWebsite = " blazepizza.com"
            };
            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
  
}

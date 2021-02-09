using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment4.Models;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
   
        //Creates string for the recommended restaurants on index page
        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string? FavDish = r.FavoriteDish ?? "It's all tasty!";
                restaurantList.Add($"#{r.RestaurantRank}: {r.RestaurantName} Best Dish: {FavDish} Address: {r.RestaurantAddress} Phone Number: {r.RestaurantPhone} Website: {r.RestaurantWebsite}");
            }

            return View(restaurantList);
        }
        //Get for restaurant input
        [HttpGet]
        public IActionResult RestaurantInput()
        {
            return View();
        }
        //Post for restaurant input
        [HttpPost]

        public IActionResult RestaurantInput(ApplicationResponse appResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(appResponse);
            }
            return View();
        }
        //View of restaurant suggestions in a table
        public IActionResult RestaurantSuggestions()
        {
            return View(TempStorage.Applications);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

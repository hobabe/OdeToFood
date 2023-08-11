using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;
using System.Collections.Generic;

namespace OdeToFood.Pages.Restaurents
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        public string Message { get; set; }
        public string MessageFromAppsettings { get; set; }

        public IEnumerable<Restaurant> Restaurants;

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet(string searchTerm)
        {
            Message = "Hello, world!";
            MessageFromAppsettings = config["Message"];

            Restaurants = restaurantData.GetRestaurantsByName(searchTerm);
        }
    }
}

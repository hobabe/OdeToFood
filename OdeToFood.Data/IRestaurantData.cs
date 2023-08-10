using System.Linq;
using OdeToFood.Core;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestauranData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestauranData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant(){ Id = 1, Name = "Scott's Pizza ", Location = "Maryland", Cuisine = CuisineType.Italian },
                new Restaurant(){ Id = 1, Name = "Riaan's Mega ", Location = "Maryland", Cuisine = CuisineType.Mexican },
                new Restaurant(){ Id = 1, Name = "Rajtha's Gold ", Location = "Maryland", Cuisine = CuisineType.Indian }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}

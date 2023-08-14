using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class OdeToFoodDBContext :DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

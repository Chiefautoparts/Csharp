using Microsoft.EntityFrameworkCore;

namespace restauranter.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options){ }
    }
}
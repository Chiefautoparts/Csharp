using Microsoft.EntityFrameworkCore;

namespace Form.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options){}
    }
}
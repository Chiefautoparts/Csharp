using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Models
{
    public class WeddingConext : DbContext
    {
        public WeddingConext(DbContextOptions<WeddingConext> options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Wedding> Wedding { get; set; }
        public DbSet<Invites> Invites { get; set; }
    }
}
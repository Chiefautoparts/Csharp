using Microsoft.EntityFrameworkCore;
namespace quotesPRAC.Models
{
    public class QuotesContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public QuotesContext(DbContextOptions<QuotesContext> options) : base(options) {}
        public DbSet<Quotes> Quotes { get; set; }
    }
}
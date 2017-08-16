using Microsoft.EntityFrameworkCore;

namespace BankofDojo.Models
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options) {}
        public DbSet<User> Account { get; set; }
    }
}
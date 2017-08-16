using Microsoft.EntityFrameworkCore;

namespace BankAccount.Models
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options): base(options) {}

        public DbSet<User> user { get; set; }
        }
    }
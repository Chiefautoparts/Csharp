using Microsoft.EntityFrameworkCore;

namespace loginReg.Models
{
    public class LoginContext :  DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options) { }
    }
}
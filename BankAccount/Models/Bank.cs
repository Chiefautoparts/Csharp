using System;

namespace BankAccount.Models
{
    public class User : BaseEntity
    {
        public int iduser { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }

    }
}
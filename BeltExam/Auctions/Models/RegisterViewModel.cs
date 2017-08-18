using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Auctions.Models
{
    public class RegisterViewModel : BaseEntity
    {
        
        public RegisterViewModel(string firstName, string lastName, string username, string password, string confirm)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
            this.Confirm = confirm;

        }
        [Required]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string LastName { get; set; }

        [Required]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Username { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [Display(Name = "Confirm")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }
    }
}
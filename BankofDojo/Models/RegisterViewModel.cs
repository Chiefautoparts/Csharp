using System.ComponentModel.DataAnnotations;

namespace BankofDojo.Models
{
    public class RegisterViewModel : BaseEntity
    {
        [Required]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Minlength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string PasswordConfirmation { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]

        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType("")]
        public string Password { get; set; }
    }
}
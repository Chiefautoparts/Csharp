using System.ComponentModel.DataAnnotations;

namespace users.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set: }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    
        public IActionResult Method()
        {
            User NewUser = new User
            {
                Name = "name",
                Email = "email@email.com",
                Password = "password"
            };
            TryValidateModel(NewUser);
        }
    }
}
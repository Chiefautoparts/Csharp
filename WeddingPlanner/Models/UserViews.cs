using System.ComponentModel.DataAnnotations;


namespace WeddingPlanner.Models
{
    public class UserViews
    {
        [Required]
        [MinLength(2, ErrorMessage="2 Character minimum")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2, ErrorMessage="2 Character minimum")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress (ErrorMessage="Not valid format")]
        public string Email {get; set; }
        [Required]
        [MinLength(8, ErrorMessage="8 character minimu")] 
        public string Password { get; set; }
        [Required]
        [MinLength(8)]
        [Compare("Password", ErrorMessage="Passwords must match")]
        public string ConfirmPassword { get; set; }       
    }
}
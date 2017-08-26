using System.ComponentModel.DataAnnotations;

namespace eCom.Models
{
    public class UserView
    {
        [Required (ErrorMessage="Please enter name")]
        public string Name { get; set; }
    }
}
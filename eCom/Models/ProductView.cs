using System.ComponentModel.DataAnnotations;

namespace eCom.Models
{
    public class ProductView
    {
        [Required (ErrorMessage="Name Cannot Be Blank")]
        public string Name { get; set; }

        [Required (ErrorMessage="Please Include Image of Product")]
        public string Image { get; set; }

        [Required (ErrorMessage="Include Brief Description")]
        public string Description { get; set; }
        
        [Required (ErrorMessage="Quantity Must Be Greater Than 0")]
        public int Quantity { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace eCom.Models
{
    public class OrdersView
    {
        public int UserID { get; set; }
        public int ProdId { get; set; }
        [Required (ErrorMessage="Please select amount to order")]
        public int Quantity { get; set; }
    }
}
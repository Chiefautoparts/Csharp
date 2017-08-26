using System;
using System.Collections.Generic;

namespace eCom.Models
{
    public class Orders : BaseEntity
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProdId { get; set; }
        public Product Product { get; set; }
        
    }
}
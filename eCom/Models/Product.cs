using System;
using System.Collections.Generic;

namespace eCom.Models
{
    public class Product : BaseEntity
    {
        public int ProdId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Quantitiy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Order> Orders { get; set; }

        public Products() {
            Orders =new List<Orders>();
        }
    }
}
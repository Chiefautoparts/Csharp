using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Auctions.Models
{
    public class Item : BaseEntity
    {
        public int ItemId { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime Expires { get; set; }
        public int UserId { get; set; }
        public User PostedItem { get; set; }
    }
}
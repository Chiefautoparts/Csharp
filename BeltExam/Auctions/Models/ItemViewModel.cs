using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Auctions.Models
{
    public class ItemViewModels : BaseEntity
    {
        // public ItemViewModel(string name, string description, int price)
        // {
        //     this.Name = name;
        //     this.Description = description;
        //     this.Price = price;
        // }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
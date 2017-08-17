using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankofDojo.Models
{
    public class Transaction : BaseEntity
    {
        public int TransactionID { get; set; }
        [Required]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public int Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int userID { get; set; }
        public User accountUser { get; set; }
    }
}
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Extensions;

namespace eCom.Models
{
    public class User : BaseEntity
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
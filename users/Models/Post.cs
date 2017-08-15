using System;
namespace users.Models
{
    public class Post : BaseEntity
    {
        public int PostId { get; set; }
        public string PostText { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
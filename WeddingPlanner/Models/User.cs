using System;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class User : BaseEntity
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatdAt { get; set; }   

        public List<Invites> Invites { get; set; }
        public User()
        {
            Invites = new List<Invites>();
        }
    }
}
using System;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Invites
    {
        public int InvitesId { get; set; }
        public int GuestId { get; set; }
        public User Guests { get; set; }
        public int WeddingId { get; set; }
        public Wedding Wedding { get; set; }
    }
}
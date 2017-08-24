using System;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        public int WeddingId { get; set; }
        public string WedderOne { get; set; }
        public string WedderTwo { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }

        public List<Invites> Invites { get; set; }

        public Wedding()
        {
            Invites = new List<Invites> ();
        }
    }
}
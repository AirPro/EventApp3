using System;
using System.Collections.Generic;

#nullable disable

namespace EventApp3.Models.DomainModels
{
    public partial class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventCity { get; set; }
        public string EventDate { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public string PromoterName { get; set; }
    }
}

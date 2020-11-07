
namespace FIT5032_Week08A.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int BookingId { get; set; }
        public string UserId { get; set; }
        public int FlightId { get; set; }
        public System.DateTime BookingDate { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfKids { get; set; }
        public decimal BookingAmount { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual Rating Rating { get; set; }
    }
}

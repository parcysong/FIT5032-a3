
namespace FIT5032_Week08A.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public int BookingId { get; set; }
        public int Value { get; set; }
        public string Feedback { get; set; }
    
        public virtual Booking Booking { get; set; }
    }
}

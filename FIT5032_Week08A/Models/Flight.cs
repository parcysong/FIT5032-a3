
namespace FIT5032_Week08A.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int FlightId { get; set; }
        public string FlightCode { get; set; }
        public string FlightName { get; set; }
        public int AvailableSeats { get; set; }
        public decimal BasePrice { get; set; }
        public string DeparturePlace { get; set; }
        public string ArrivalPlace { get; set; }
        public System.DateTime departureDateTime { get; set; }
        public System.DateTime arrivalDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}

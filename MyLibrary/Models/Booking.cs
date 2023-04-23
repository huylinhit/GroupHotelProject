using System;
using System.Collections.Generic;

namespace MyLibrary.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int? UserId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public string Status { get; set; }

        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MyLibrary.Models
{
    public partial class Room
    {
        public Room()
        {
            Bookings = new HashSet<Booking>();
        }

        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public int? RoomTypeId { get; set; }
        public string Status { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}

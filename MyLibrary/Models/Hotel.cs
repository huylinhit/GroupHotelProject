using System;
using System.Collections.Generic;

namespace MyLibrary.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            RoomTypes = new HashSet<RoomType>();
        }

        public int HotelId { get; set; }
        public int? ManagerId { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonPhone { get; set; }
        public string ContactPersonEmail { get; set; }
        public string CancellationPolicy { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }

        public virtual User Manager { get; set; }
        public virtual ICollection<RoomType> RoomTypes { get; set; }
    }
}

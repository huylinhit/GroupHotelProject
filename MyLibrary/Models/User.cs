using System;
using System.Collections.Generic;

namespace MyLibrary.Models
{
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
            Hotels = new HashSet<Hotel>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}

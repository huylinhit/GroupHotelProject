using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Repositories
{
    internal interface IBookingRepository
    {
        public IEnumerable<Booking> GetBookings();
        public IEnumerable<Booking> GetBookingsByHotelID(int hotelID);
        public IEnumerable<Booking> GetBookingsByManagerID(int managerID);
        public Booking? GetBookingByID(int id);
        public int GetNewBookingID();
        public IEnumerable<Booking> GetBookingsByUserID(int userID);
        public IEnumerable<Booking> GetBookingsByRoomID(int roomID);
        public void AddBooking(Booking item);
        public void RemoveBooking(Booking item);
        public void RemoveBookingByID(int id);
        public void UpdateBooking(Booking item);
        public void UpdateBookingStatusByBookingID(int id, string status);

    }
}
